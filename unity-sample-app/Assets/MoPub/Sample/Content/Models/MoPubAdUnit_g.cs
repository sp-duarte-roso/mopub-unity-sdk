// Model generated from "Schema.txt"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    [Serializable]
    public partial class MoPubAdUnit : ModelObject
    {
        #region Properties

        [SerializeField]
        private string _platform;
        public string Platform
        {
            get { return _platform; }
            set { SetProperty(ref _platform, value); }
        }

        [SerializeField]
        private string _type;
        public string Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }

        [SerializeField]
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        [SerializeField]
        private string _adUnitId;
        public string AdUnitId
        {
            get { return _adUnitId; }
            set { SetProperty(ref _adUnitId, value); }
        }

        [SerializeField]
        private bool _custom;
        public bool Custom
        {
            get { return _custom; }
            set { SetProperty(ref _custom, value); }
        }

        #endregion
    }

    #region Data Provider

    public partial class MoPubAdUnitData : DataProvider<MoPubAdUnit>
    {
        #region Fields


        #endregion

        #region Constructor

        public MoPubAdUnitData()
        {
            Reset();
        }

        #endregion

        #region Methods

        public override void Reset()
        {
            Replace(new List<MoPubAdUnit> { new MoPubAdUnit { Platform = "android", Type = "banner", Name = "MoPub Sample Banner", AdUnitId = "b195f8dd8ded45fe847ad89ed1d016da", Custom = false }, new MoPubAdUnit { Platform = "android", Type = "interstitial", Name = "MoPub Sample Interstitial", AdUnitId = "24534e1901884e398f1253216226017e", Custom = false }, new MoPubAdUnit { Platform = "android", Type = "rewarded", Name = "MoPub Sample Rewarded Video", AdUnitId = "920b6145fb1546cf8b5cf2ac34638bb7", Custom = false }, new MoPubAdUnit { Platform = "android", Type = "rewarded", Name = "MoPub Sample Rewarded Rich Media", AdUnitId = "a96ae2ef41d44822af45c6328c4e1eb1", Custom = false }, new MoPubAdUnit { Platform = "ios", Type = "banner", Name = "MoPub Sample HTML Banner", AdUnitId = "0ac59b0996d947309c33f59d6676399f", Custom = false }, new MoPubAdUnit { Platform = "ios", Type = "banner", Name = "MoPub Sample MRAID Banner", AdUnitId = "ef078b27e11c49bbb87080617a69b970", Custom = false }, new MoPubAdUnit { Platform = "ios", Type = "banner", Name = "MoPub Sample HTML Medium Rectangle", AdUnitId = "2aae44d2ab91424d9850870af33e5af7", Custom = false }, new MoPubAdUnit { Platform = "ios", Type = "interstitial", Name = "MoPub Sample HTML Interstitial", AdUnitId = "4f117153f5c24fa6a3a92b818a5eb630", Custom = false }, new MoPubAdUnit { Platform = "ios", Type = "interstitial", Name = "MoPub Sample MRAID Interstitial", AdUnitId = "9f2859c6726447aa9eaaa43a35ae8682", Custom = false }, new MoPubAdUnit { Platform = "ios", Type = "rewarded", Name = "MoPub Sample Rewarded Video", AdUnitId = "8f000bd5e00246de9c789eed39ff6096", Custom = false }, new MoPubAdUnit { Platform = "ios", Type = "rewarded", Name = "MoPub Sample Rewarded Rich Media", AdUnitId = "98c29e015e7346bd9c380b1467b33850", Custom = false } });
        }

        #endregion
    }

    public static partial class Models
    {
        public static MoPubAdUnitData MoPubAdUnits = new MoPubAdUnitData();
    }

    #endregion
}
