﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BabBot.Wow;
using BabBot.Common;
using BabBot.Manager;
using BabBot.Wow.Helpers;
using Pather.Graph;
// TODO add support for multiple NPC coordinates
namespace BabBot.States.Common
{
    /// <summary>
    /// Class used to set travel destination for GameObject or Endpoint
    /// Currently only supports single NPC coordinates
    /// Aggro ignored in this state
    /// </summary>
    class TravelState : State<WowPlayer>
    {
        /// <summary>
        /// Logging facility
        /// </summary>
        public string Lfs;

        /// <summary>
        /// Text shown in bot progress bar tooltip
        /// </summary>
        private string _tooltip;

        /// <summary>
        /// Endpoint or GameObject i.e Destination
        /// </summary>
        private object _dest;

        /// <summary>
        /// Base coordinates for destination target
        /// If dest has multiple coordinates see VList
        /// </summary>
        public Vector3D BaseCoord;

        /// <summary>
        /// List of coordinates if more than 1 (for NPC)
        /// </summary>
        public List<Vector3D> Vlist = null;

        /// <summary>
        /// Last destination vector that was submit to 
        /// NavigateTo state
        /// </summary>
        Vector3D _last_dest;

        /// <summary>
        /// Destination check class
        /// </summary>
        AbstractCheck _check;

        /// <summary>
        /// List of used routes
        /// </summary>
        protected List<Route> UsedRoutes = new List<Route>();

        /// <summary>
        /// List of found routes
        /// </summary>
        protected List<Route> FoundRoutes = new List<Route>();

        /// <summary>
        /// True when arrived to destination and False if not yet
        /// </summary>
        public bool AtDest = false;

        /// <summary>
        /// Reference on current player
        /// </summary>
        public WowPlayer Player;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="obj">GameObject object</param>
        /// <param name="lfs">Logging facility</param>
        /// <param name="tooltip_text">Tooltip to show on BotStatus</param>
        public TravelState(GameObject obj, string lfs, string tooltip_text)
        {
            _check = new GameObjCheck(this,  obj);
            Init(obj, lfs, tooltip_text);
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="obj">QuestObjective object</param>
        /// <param name="lfs">Logging facility</param>
        /// <param name="tooltip_text">Tooltip to show on BotStatus</param>
        public TravelState(AbstractQuestObjective qobj, 
                            string lfs, string tooltip_text)
        {
            _check = new QuestObjectiveCheck(this, qobj);
            Init(qobj, lfs, tooltip_text);
        }

        /// <summary>
        /// Init Travel State
        /// </summary>
        /// <param name="dest">Destination object</param>
        /// <param name="lfs">Logging facility</param>
        /// <param name="tooltip_text">Tooltip to show on BotStatus</param>
        void Init(object dest, string lfs, string tooltip_text)
        {
            Lfs = lfs;
            _dest = dest;
            _tooltip = tooltip_text;
        }

        /// <summary>
        /// Enter state event handler
        /// Try locate route or locate destination waypoint and 
        ///     launch NavigationState
        /// </summary>
        /// <param name="player">Reference on current player</param>
        protected override void DoEnter(WowPlayer player)
        {
            Player = player;

            // Locate route in Endpoints table
            string name = _dest.ToString();
            Vector3D cur_loc = player.Location;

            try
            {
                if (!_check.DoBeforeRouteCheck())
                {
                    // We already at dest
                    Finish(player);
                    return;
                }
            }
            catch
            {
                // Something wrong with dest
                Finish(player);
                return;
            }

            // Check for exact or nearest route to dest name
            List<Route> lr = RouteListManager.Endpoints[name];
            if (lr != null)
            {
                // Best route with min total length
                Route min_route = null;
                float min_route_len = float.MaxValue;

                foreach (Route r in lr)
                {
                    // It's either A or B
                    Endpoint[] eps = r.GetEndpoints(name);
                    if (eps == null)
                        return;

                    // Only using atm based coord for game obj/quest item

                    if (eps[1].Waypoint.IsClose(Player.Location))
                    {
                        // Exact route found
                        try
                        {
                            ActivateMoveState(r, player);
                        }
                        catch (Exception e)
                        {
                            Output.Instance.Log(Lfs, e.Message);
                            Finish(player);
                        }
                        return;
                    }

                    // Exact route not found
                    // Check Direct Distance to both endpoint
                    float ddist_b = eps[1].Waypoint.GetDistanceTo(Player.Location);
                    float ddist_a = eps[0].Waypoint.GetDistanceTo(Player.Location) * 1.2F;

                    // Calc lenght and update best route
                    float cur_len = r.Length + ddist_b;
                    if (cur_len < min_route_len &&
                            cur_len <= ddist_a)
                    {
                        min_route = r;
                        min_route_len = cur_len;
                    }
                }

                if (min_route != null)
                {
                    // Found partial route and now look for the route connections
                    FoundRoutes.Add(min_route);
                    float calc_len = CheckRoute(min_route.PointB, 0);
                    if (calc_len > 0)
                    {
                        float direct_len = BaseCoord.GetDistanceTo(Player.Location) * 1.2F;
                        // Check if total calc length exceed much direct length
                        if (calc_len <= direct_len)
                        {
                            // Join Routes and activate moving state
                            Waypoints wp_list = new Waypoints();
                            foreach (Route r in FoundRoutes)
                            {
                                Waypoints wp;

                                try
                                {
                                    wp = GetWaypoints(r);
                                    if (wp == null)
                                        throw new WaypointsNotFoundException(r.WaypointFileName);

                                    int start_idx = 0;

                                    if (wp_list.Count > 0)
                                    {
                                        // skip first waypoint when joint wp list
                                        start_idx = 1;
                                    }

                                    for (int i = start_idx; i < wp.Count; i++)
                                        wp_list.Add(wp[i]);
                                }
                                catch (Exception e)
                                {
                                    Output.Instance.Log(Lfs, e.Message);
                                    Finish(player);
                                    return;
                                }
                            }

                            // Switch to navigation state
                            SwitchToNavigation(wp_list);
                            return;
                        }
                    }
                }

                // No routes
                // Transfer best coord to Nav state
                CallChangeStateEvent(player, new NavigationState(BaseCoord,
                                        Lfs, "Traveling to point " + BaseCoord));
            }
            
        }

        private void SwitchToNavigation(Waypoints wps)
        {
            _last_dest = wps[wps.Count - 1];
            CallChangeStateEvent(Player, new NavigationState(wps,
                                Lfs, "Traveling to " + _dest.ToString()));
        }

        private float CheckRoute(Endpoint ep, float total_len)
        {
            // Find all avail routes for dest
            List<Route> lr = RouteListManager.Waypoints[ep.Waypoint.Length];

            // Best route with min total length
            Route min_route = null;
            float min_route_len = float.MaxValue;

            foreach (Route r in lr)
            {
                // Quick check we not cycling
                if (FoundRoutes.IndexOf(r) >= 0)
                    continue;

                // It's either A or B
                Endpoint[] eps = r.GetEndpoints(ep.Waypoint);
                if (eps == null)
                    return 0;

                // At the moment only using based coord for game obj/quest item
                if (eps[1].Waypoint.IsClose(Player.Location))
                {
                    // Exact route found
                    FoundRoutes.Add(r);
                    return total_len + r.Length;
                }

                // Exact route not found
                // Check Direct Distance to both endpoint
                float ddist_b = eps[1].Waypoint.GetDistanceTo(Player.Location);
                float ddist_a = eps[0].Waypoint.GetDistanceTo(Player.Location);

                // Calc lenght and update best route
                float cur_len = r.Length + ddist_b;
                if (cur_len < min_route_len)
                {
                    min_route = r;
                    min_route_len = cur_len;
                }
            }

            if (min_route != null)
            {
                // Check if another route connected to given point
                // This check is recursive
                float len= CheckRoute(min_route.PointB, total_len + min_route_len);
                if (len > 0)
                {
                    FoundRoutes.Add(min_route);
                    return len;
                }
            }

            return 0;
        }
        
        private bool CheckEndpoint(Endpoint ep, Route r, 
                        WowPlayer player, Vector3D cur_loc)
        {
            if (ep.Waypoint.IsClose(cur_loc))
            {
                // Found exact route
                ActivateMoveState(r, player);
                return true;
            }

            return false;
        }

        protected override void DoExecute(WowPlayer player)
        {
            if ((_last_dest != null) && 
                    !_last_dest.IsClose(player.Location))
            {
                // Navigation state failed
                Finish(player);
                return;
            }
            else if (_dest.GetType().IsSubclassOf(typeof(GameObject)))
            {
                // Check if GameObject actually nearby
                // TODO
            }
            else
                Finish(player);

        }

        private Waypoints GetWaypoints(Route r)
        {
            Waypoints wp = RouteListManager.LoadWaypoints(r.WaypointFileName);
            if (wp != null)
            {
                if (r.NeedReverse)
                    wp.List.Reverse();

                UsedRoutes.Add(r);
            }
            return wp;
        }

        private void ActivateMoveState(Route r, WowPlayer player)
        {
            // Load waypoints and launch NavigationState
            Waypoints wp = GetWaypoints(r);
            if (wp != null)
                SwitchToNavigation(wp);
        }
       
    }

    abstract class AbstractCheck {
        protected TravelState Parent;
        protected string Lfs;

        protected AbstractCheck(TravelState parent)
        {
            Parent = parent;
        }

        public abstract bool DoBeforeRouteCheck();
    }

    class GameObjCheck : AbstractCheck
    {
        GameObject _obj;

        internal GameObjCheck(TravelState parent, GameObject obj)
            : base(parent)
        {
            _obj = obj;
        }

        /// <summary>
        /// Check if GameObject can be found around
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool LookForGameObjClose(GameObject obj)
        {
            WowObject wo = ProcessManager.ObjectManager.LookForGameObj(obj.Name);
            if (wo == null)
                return false;

            return wo.Location.IsClose(ProcessManager.Player.Location);
        }

        public override bool DoBeforeRouteCheck()
        {
            // Check if obj close
            if (LookForGameObjClose(_obj))
                // We already at destination
                return false;

            // Check if obj has coordinates
            Parent.BaseCoord = NpcHelper.GetGameObjCoord(_obj, Parent.Lfs);
            if (Parent.BaseCoord == null)
                throw new GameObjectCoordNotFound(_obj.Name);

            // Check for other coordinates
            if (_obj.GetType().IsSubclassOf(typeof(NPC)))
            {
                NPC npc = (NPC)_obj;

                // Use current zone as a key
                if (npc.Coordinates.Count > 0)
                {
                    ZoneWp zwp = npc.Coordinates[Parent.Player.ZoneText];
                    if (zwp != null)
                        Parent.Vlist = zwp.List;
                }
            }

            return true;
        }
    }

    class QuestObjectiveCheck : AbstractCheck
    {
        AbstractQuestObjective _qobj;

        internal QuestObjectiveCheck(TravelState parent, AbstractQuestObjective qobj)
            : base(parent)
        {
            _qobj = qobj;
        }

        public override bool DoBeforeRouteCheck()
        {
            if ((_qobj.Coordinates == null) || (_qobj.Coordinates.Count == 0))
                throw new QuestObjCoordNotFound(_qobj.Parent.Id, _qobj.Idx);

            // Use current zone as a key
            ZoneWp zwp = _qobj.Coordinates[Parent.Player.ZoneText];
            if (zwp != null)
            {
                Parent.BaseCoord = zwp[0];
                if (Parent.BaseCoord.IsClose(ProcessManager.Player.Location))
                    // We already at destination
                    return false;

                for (int i = 1; i < zwp.Count; i++)
                    Parent.Vlist.Add(zwp[i]);
            }
            else
                throw new QuestObjCoordNotFound(_qobj.Parent.Id, _qobj.Idx);

            return true;
        }
    }
}
