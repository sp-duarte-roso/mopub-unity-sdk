#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
#endregion

namespace Delight
{

    public partial class MoPubSampleView
    {
        public override void Start()
        {
            base.Start();
            // The SdkInitialize() call is handled by the MoPubManager prefab now. Please see:
            // https://developers.mopub.com/publishers/unity/initialize/#option-1-initialize-using-the-mopub-manager-recommended

            var bannerAdUnits = Models.BannerAdUnits.ToList().Select(adUnit => adUnit.AdUnitId).ToArray();
            var interstitialAdUnits = Models.InterstitialAdUnits.ToList().Select(adUnit => adUnit.AdUnitId).ToArray();
            var rewardedAdUnits = Models.RewardedAdUnits.ToList().Select(adUnit => adUnit.AdUnitId).ToArray();

            MoPub.LoadBannerPluginsForAdUnits(bannerAdUnits);
            MoPub.LoadInterstitialPluginsForAdUnits(interstitialAdUnits);
            MoPub.LoadRewardedVideoPluginsForAdUnits(rewardedAdUnits);

            PluginNameLabel.Text = "MoPub Unity Plugin v" + MoPub.MoPubSdkVersion;
            SdkNameLabel.Text = MoPub.SdkName;
            ResetScrollPosition();
        }

        public void NavigateBack()
        {
            MoPubAdUnitSwitcher.SwitchTo(MoPubAdUnitList);
            RestoreScrollPosition();
        }

        public void ShowAdUnit(MoPubAdUnit adUnit)
        {
            SaveScrollPosition();
            ResetScrollPosition();
            MoPubAdUnit.Unload(); // clear view state
            MoPubAdUnit.Load();
            MoPubAdUnit.AdType = adUnit.Type;
            MoPubAdUnit.IsBanner = adUnit.Type == "banner";
            MoPubAdUnit.IsInterstitial = adUnit.Type == "interstitial";
            MoPubAdUnit.IsRewardedAd = adUnit.Type == "rewarded";
            MoPubAdUnit.AdUnitName.Text = adUnit.Name;
            MoPubAdUnit.AdUnitId.Text = adUnit.AdUnitId;
            MoPubAdUnitSwitcher.SwitchTo(MoPubAdUnit);
        }

        private float _adUnitListScrollPosition;

        private void SetScrollPosition(float position)
        {
            MPScrollable.SetScrollPosition(0,position);
        }

        private void ResetScrollPosition()
        {
            SetScrollPosition(0);
        }

        private void SaveScrollPosition()
        {
            _adUnitListScrollPosition = MPScrollable.NormalizedPosition.y;
        }

        private void RestoreScrollPosition()
        {
            SetScrollPosition(_adUnitListScrollPosition);
        }
    }
}
