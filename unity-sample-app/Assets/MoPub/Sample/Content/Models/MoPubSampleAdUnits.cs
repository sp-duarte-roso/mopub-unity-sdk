#region Using Statements

using System.Collections.Generic;
using System.Linq;

#endregion

namespace Delight
{
    public static partial class Models
    {
        private static readonly IEnumerable<MoPubAdUnit> PlatformAdUnits =
            MoPubAdUnits.Where(adUnit => adUnit.Platform ==
#if UNITY_IOS
                                         "ios"
#elif UNITY_ANDROID || UNITY_EDITOR
                                         "android"
#endif
            );
        public static readonly BindableCollection<MoPubAdUnit> BannerAdUnits = new BindableCollection<MoPubAdUnit>(
            PlatformAdUnits.Where(adUnit => adUnit.Type == "banner"));
        public static readonly BindableCollection<MoPubAdUnit> InterstitialAdUnits = new BindableCollection<MoPubAdUnit>(
            PlatformAdUnits.Where(adUnit => adUnit.Type == "interstitial"));
        public static readonly BindableCollection<MoPubAdUnit> RewardedAdUnits = new BindableCollection<MoPubAdUnit>(
            PlatformAdUnits.Where(adUnit => adUnit.Type == "rewarded"));
    }
}
