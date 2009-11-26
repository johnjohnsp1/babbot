﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BabBot.Wow
{
    [XmlRoot("wow_data")]
    public class WoWData
    {
        private Hashtable _versions;

        public WoWData() 
        {
            Init();
        }

        public WoWData(WoWVersion[] versions)
        {
            Init();
            Versions = versions;
        }

        private void Init()
        {
            _versions = new Hashtable();
        }

        [XmlElement("version")]
        public WoWVersion[] Versions
        {
            get {
                WoWVersion[] res = new WoWVersion[_versions.Count];
                _versions.Values.CopyTo(res,0);
                return res;
            }
            set
            {
                if (value == null) return;
                WoWVersion[] items = (WoWVersion[])value;
                _versions.Clear();
                foreach (WoWVersion item in items)
                    _versions.Add(item.Number, item);
            }
        }

        public WoWVersion FindVersion(string version)
        {
            return (WoWVersion) _versions[version];
        }
    }
    
    [Serializable]
    public class WoWVersion
    {
        private ArrayList _tlist;

        [XmlAttribute("max_lvl")]
        public int MaxLvl;

        [XmlAttribute("num")]
        public string Number;

        [XmlElement("lua")]
        public LuaProc LuaList;

        [XmlElement("talents")]
        public TalentConfig TalentConfig;

        [XmlElement("classes")]
        public CharClasses Classes;
        
        public WoWVersion()
        {
            Init();
        }

        private void Init()
        {
            _tlist = new ArrayList();
        }

        public string FindLuaFunction(string name)
        {
            return LuaList.FindLuaFunction(name);
        }

        public override string ToString()
        {
            return Number;
        }
    }

    public class LuaProc
    {
        private Hashtable _flist;

        public LuaProc() { 
            _flist = new Hashtable(); 
        }

        public LuaProc(LuaFunction[] flist)
        {
            FList = flist;
        }

        [XmlElement("function")]
        public LuaFunction[] FList
        {
            get
            {
                LuaFunction[] res = new LuaFunction[_flist.Count];
                _flist.Values.CopyTo(res, 0);
                return res;
            }

            set
            {
                if (value == null) return;
                LuaFunction[] items = (LuaFunction[])value;
                _flist.Clear();
                foreach (LuaFunction item in items)
                    _flist.Add(item.Name, item);
            }
        }

        public string FindLuaFunction(string name)
        {
            LuaFunction res = (LuaFunction)_flist[name];
            return (res != null) ? res.Code : null;
        }
    }

    public class LuaFunction
    {
        [XmlAttribute("name")] 
        public string Name;
        
        [XmlElement("text", typeof(XmlCDataSection))]
        public XmlCDataSection Text;

        // [XmlElement("text")] public string Text;

        public LuaFunction() {}

        public LuaFunction(string name, string text)
        {
            Name = name;
            XmlDocument doc = new XmlDocument();
            Text = doc.CreateCDataSection(text);
        }

        [XmlIgnore]
        public string Code
        {
            get { return ((Text != null) ? Text.InnerText : null); }
        }

    }

    public class CharClasses
    {
        private Hashtable _clist;
        
        [XmlElement("class")]
        public CharClass[] ClassList
        {
            get
            {
                CharClass[] res = new CharClass[_clist.Count];
                _clist.Values.CopyTo(res, 0);
                return res;
            }

            set
            {
                if (value == null) return;
                CharClass[] items = (CharClass[])value;
                _clist.Clear();
                foreach (CharClass item in items)
                    _clist.Add(item.ArmoryId, item);
            }
        }

        public CharClasses () 
        {
            _clist = new Hashtable();
        }
    }
    
    public class CharClass
    {
        [XmlAttribute("armory_id")]
        public byte ArmoryId;

        [XmlAttribute("long_name")]
        public string LongName;

        [XmlAttribute("short_name")]
        public string ShortName;

        [XmlAttribute("tab_1_max")]
        public byte TabMax1;

        [XmlAttribute("tab_2_max")]
        public byte TabMax2;

        [XmlAttribute("tab_3_max")]
        public byte TabMax3;

        [XmlIgnore]
        public byte[] Tabs
        {
            get { return new byte[] {TabMax1, TabMax2, TabMax3}; }
        }

        public CharClass () {}
    }
    
    public class TalentConfig
    {
        [XmlAttribute("lvl_start")]
        public byte StartLevel;

        [XmlAttribute("armory_pattern")]
        public string ArmoryPattern;

        public TalentConfig() { }
    }
}