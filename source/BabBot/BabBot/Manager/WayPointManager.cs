﻿/*
    This file is part of BabBot.

    BabBot is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    BabBot is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with BabBot.  If not, see <http://www.gnu.org/licenses/>.
  
    Copyright 2009 BabBot Team
*/
using BabBot.Bot;

namespace BabBot.Manager
{
    public sealed class WayPointManager
    {
        private static readonly WayPointManager instance = new WayPointManager();

        public WayPointCollection BranchPath;
        public int CurrentBranchWayPointIndex;
        public int CurrentGhostWayPointIndex;
        public int CurrentNormalWayPointIndex;
        public int CurrentRepairWayPointIndex;
        public int CurrentVendorWayPointIndex;
        public WayPointCollection GhostPath;
        public WayPointCollection NormalPath;
        public WayPointCollection RepairPath;
        public WayPointCollection VendorPath;

        /// <summary>
        /// Base constructor
        /// </summary>
        private WayPointManager()
        {
        }

        public static WayPointManager Instance
        {
            get { return instance; }
        }

        public void Init()
        {
            NormalPath = new WayPointCollection();
            GhostPath = new WayPointCollection();
            VendorPath = new WayPointCollection();
            RepairPath = new WayPointCollection();
            BranchPath = new WayPointCollection();
        }

        public void AddWayPoint(WayPoint wp)
        {
            switch (wp.WPType)
            {
                case WayPointType.Vendor:
                    VendorPath.Add(wp);
                    break;
                case WayPointType.Repair:
                    RepairPath.Add(wp);
                    break;
                case WayPointType.Ghost:
                    GhostPath.Add(wp);
                    break;
                case WayPointType.Branch:
                    BranchPath.Add(wp);
                    break;
                case WayPointType.Normal:
                    NormalPath.Add(wp);
                    break;
            }
        }

        public void Reverse(WayPointType wpt)
        {
            switch (wpt)
            {
                case WayPointType.Vendor:
                    NormalPath.Reverse();
                    break;
                case WayPointType.Repair:
                    RepairPath.Reverse();
                    break;
                case WayPointType.Normal:
                    NormalPath.Reverse();
                    break;
                case WayPointType.Ghost:
                    GhostPath.Reverse();
                    break;
                case WayPointType.Branch:
                    BranchPath.Reverse();
                    break;
            }
        }

        public WayPoint GetNextWayPoint(WayPointType wpType)
        {
            switch (wpType)
            {
                case WayPointType.Vendor:
                    if (VendorNodeCount == 0)
                    {
                        return null;
                    }
                    CurrentVendorWayPointIndex++;
                    if (CurrentVendorWayPointIndex >= VendorNodeCount)
                    {
                        CurrentVendorWayPointIndex = 0;
                    }
                    return VendorPath[CurrentVendorWayPointIndex];

                case WayPointType.Repair:
                    if (RepairNodeCount == 0)
                    {
                        return null;
                    }
                    CurrentRepairWayPointIndex++;
                    if (CurrentRepairWayPointIndex >= RepairNodeCount)
                    {
                        CurrentRepairWayPointIndex = 0;
                    }
                    return RepairPath[CurrentRepairWayPointIndex];

                case WayPointType.Normal:
                    if (NormalNodeCount == 0)
                    {
                        return null;
                    }
                    CurrentNormalWayPointIndex++;
                    if (CurrentNormalWayPointIndex >= NormalNodeCount)
                    {
                        CurrentNormalWayPointIndex = 0;
                    }
                    return NormalPath[CurrentNormalWayPointIndex];

                case WayPointType.Ghost:
                    if (GhostNodeCount == 0)
                    {
                        return null;
                    }
                    CurrentGhostWayPointIndex++;
                    if (CurrentGhostWayPointIndex >= GhostNodeCount)
                    {
                        CurrentGhostWayPointIndex = 0;
                    }
                    return GhostPath[CurrentGhostWayPointIndex];

                default:
                    return null;
            }
        }

        public void ClearWaypoints(WayPointType wpType)
        {
            switch (wpType)
            {
                case WayPointType.Vendor:
                    VendorPath.Clear();
                    CurrentVendorWayPointIndex = 0;
                    break;
                case WayPointType.Repair:
                    RepairPath.Clear();
                    CurrentRepairWayPointIndex = 0;
                    break;
                case WayPointType.Normal:
                    NormalPath.Clear();
                    CurrentNormalWayPointIndex = 0;
                    break; 
                case WayPointType.Ghost:
                    GhostPath.Clear();
                    CurrentGhostWayPointIndex = 0;
                    break;
                default:
                    return;
            }
        }
        #region Properties

        public int NormalNodeCount
        {
            get { return NormalPath.Count; }
        }

        public int GhostNodeCount
        {
            get { return GhostPath.Count; }
        }

        public int VendorNodeCount
        {
            get { return VendorPath.Count; }
        }

        public int RepairNodeCount
        {
            get { return RepairPath.Count; }
        }

        public int BranchNodeCount
        {
            get { return BranchPath.Count; }
        }

        #endregion
    }
}