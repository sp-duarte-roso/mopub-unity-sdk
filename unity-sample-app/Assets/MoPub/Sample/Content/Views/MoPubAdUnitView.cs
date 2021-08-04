#region Using Statements

using System.Linq;
using UnityEngine;

#endregion

namespace Delight
{
    public partial class MoPubAdUnitView
    {
        #region Properties

        private const bool TestLayout = false;
        private const string DefaultKeywordsInputText = "Keywords";
        private const string DefaultUserDataKeywordsInputText = "User Data Keywords";
        private const string RefreshButtonText = "Refresh";
        private readonly Color _preEventColor = new Color(0.8f, 0.8f, 0.8f);
        private readonly Color _postEventColor = Color.black;

        #endregion

        #region State

        private bool _bannerLoaded;

        #endregion

        #region MoPubEventHandlers

        private void AdLoadedEvent(string adUnitId, float height)
        {
            UpdateExpander(OnAdLoadedExpander, true, adUnitId, MoPubUtils.InvariantCultureToString(height));
            LoadAdButton.Text = RefreshButtonText;
            _bannerLoaded = true;
        }

        private void AdClickedEvent(string adUnitId)
        {
            UpdateExpander(OnAdClickedExpander, true, adUnitId);
        }

        private void AdFailedEvent(string adUnitId, string error)
        {
            UpdateExpander(OnAdFailedExpander, true, adUnitId, error:error);
            LoadAdButton.IsDisabled = false;
        }

        private void InterstitialLoadedEvent(string adUnitId)
        {
            UpdateExpander(OnInterstitialLoadedExpander, true, adUnitId);
            ShowAdButton.IsDisabled = false;
        }

        private void InterstitialShownEvent(string adUnitId)
        {
            UpdateExpander(OnInterstitialShownExpander, true, adUnitId);
        }

        private void InterstitialClickedEvent(string adUnitId)
        {
            UpdateExpander(OnInterstitialClickedExpander, true, adUnitId);
        }

        private void InterstitialDismissedEvent(string adUnitId)
        {
            UpdateExpander(OnInterstitialDismissedExpander, true, adUnitId);
            LoadAdButton.IsDisabled = false;
            ShowAdButton.IsDisabled = true;
        }

        private void InterstitialFailedEvent(string adUnitId, string error)
        {
            UpdateExpander(OnInterstitialFailedExpander, true, adUnitId, error:error);
            LoadAdButton.IsDisabled = false;
        }

        private void RewardedVideoLoadedEvent(string adUnitId)
        {
            UpdateExpander(OnRewardedVideoLoadedExpander, true, adUnitId);
            ShowAdButton.IsDisabled = false;
        }

        private void RewardedVideoShownEvent(string adUnitId)
        {
            UpdateExpander(OnRewardedVideoShownExpander, true, adUnitId);
        }

        private void RewardedVideoClickedEvent(string adUnitId)
        {
            UpdateExpander(OnRewardedVideoClickedExpander, true, adUnitId);
        }

        private void RewardedVideoClosedEvent(string adUnitId)
        {
            UpdateExpander(OnRewardedVideoClosedExpander, true, adUnitId);
            LoadAdButton.IsDisabled = false;
            ShowAdButton.IsDisabled = true;
        }

        private void RewardedVideoReceivedRewardEvent(string adUnitId, string label, float amount)
        {
            UpdateExpander(OnRewardedVideoReceivedRewardExpander, true, adUnitId, label:label, amount:MoPubUtils.InvariantCultureToString(amount));
        }

        private void RewardedVideoFailedToPlayEvent(string adUnitId, string error)
        {
            UpdateExpander(OnRewardedVideoFailedToPlayExpander, true, adUnitId, error:error);
            LoadAdButton.IsDisabled = false;
            ShowAdButton.IsDisabled = true;
        }

        private void RewardedVideoFailedEvent(string adUnitId, string error)
        {
            UpdateExpander(OnRewardedVideoFailedEventExpander, true, adUnitId, error:error);
            LoadAdButton.IsDisabled = false;
        }

        private void ImpressionTrackedEventBg(string adUnitId, MoPub.ImpressionData impressionData)
        {
            Debug.Log("[Background] Impression tracked for " + adUnitId + " with impression data: "
                      + impressionData.JsonRepresentation);
            UpdateExpander(OnImpressionTrackedBgExpander, true, adUnitId,
                impressionDataJson:impressionData.JsonRepresentation);
        }

        private void ImpressionTrackedEvent(string adUnitId, MoPub.ImpressionData impressionData)
        {
            Debug.Log("Impression tracked for " + adUnitId + " with impression data: "
                      + impressionData.JsonRepresentation);
            UpdateExpander(OnImpressionTrackedExpander, true, adUnitId,
                impressionDataJson:impressionData.JsonRepresentation);
        }

        public override void OnEnable()
        {
            MoPubManager.OnAdLoadedEvent += AdLoadedEvent;
            MoPubManager.OnAdClickedEvent += AdClickedEvent;
            MoPubManager.OnAdFailedEvent += AdFailedEvent;

            MoPubManager.OnInterstitialLoadedEvent += InterstitialLoadedEvent;
            MoPubManager.OnInterstitialShownEvent += InterstitialShownEvent;
            MoPubManager.OnInterstitialClickedEvent += InterstitialClickedEvent;
            MoPubManager.OnInterstitialDismissedEvent += InterstitialDismissedEvent;
            MoPubManager.OnInterstitialFailedEvent += InterstitialFailedEvent;

            MoPubManager.OnRewardedVideoLoadedEvent += RewardedVideoLoadedEvent;
            MoPubManager.OnRewardedVideoShownEvent += RewardedVideoShownEvent;
            MoPubManager.OnRewardedVideoClickedEvent += RewardedVideoClickedEvent;
            MoPubManager.OnRewardedVideoClosedEvent += RewardedVideoClosedEvent;
            MoPubManager.OnRewardedVideoReceivedRewardEvent += RewardedVideoReceivedRewardEvent;
            MoPubManager.OnRewardedVideoFailedToPlayEvent += RewardedVideoFailedToPlayEvent;
            MoPubManager.OnRewardedVideoFailedEvent += RewardedVideoFailedEvent;

            MoPubManager.OnImpressionTrackedEventBg += ImpressionTrackedEventBg;
            MoPubManager.OnImpressionTrackedEvent += ImpressionTrackedEvent;
        }

        #endregion

        #region ButtonHandlers

        public void LoadAdHandler()
        {
            LoadAdButton.IsDisabled = true;
            ResetEventLabelsAndChecks();

            var keywords = Keywords.Text != DefaultKeywordsInputText ? Keywords.Text : "";
            var userDataKeywords = UserDataKeywords.Text != DefaultUserDataKeywordsInputText ? UserDataKeywords.Text : "";

            switch (AdType) {
                case "banner":
                    if (LoadAdButton.Text != RefreshButtonText)
                        MoPub.RequestBanner(AdUnitIdText, MoPub.AdPosition.BottomCenter,
                            MoPub.MaxAdSize.Width336Height280);
                    else
                        MoPub.RefreshBanner(AdUnitIdText, keywords, userDataKeywords);
                    LoadAdButton.IsDisabled = false;
                    break;
                case "interstitial":
                    MoPub.RequestInterstitialAd(AdUnitIdText, keywords, userDataKeywords);
                    break;
                case "rewarded":
                    MoPub.RequestRewardedVideo(AdUnitIdText, keywords:keywords, userDataKeywords:userDataKeywords);
                    break;
                default:
                    Debug.LogError($"Invalid AdType received: {AdType}");
                    break;
            }
        }

        public void ShowAdHandler()
        {
            if (AdType == "interstitial")
                MoPub.ShowInterstitialAd(AdUnitIdText);
            else if (AdType == "rewarded")
                MoPub.ShowRewardedVideo(AdUnitIdText);
        }

        public void BackClickHandler()
        {
            if (_bannerLoaded)
                MoPub.DestroyBanner(AdUnitIdText);

            NavigateBack?.Invoke(this, null);
        }

        #endregion

        #region LifecycleEvents

        public override void Update()
        {
            base.Update();
            if (Application.platform == RuntimePlatform.Android) {
                if (Input.GetKey(KeyCode.Escape)) {
                    BackClickHandler();
                }
            }
        }

        protected override void AfterLoad()
        {
            base.AfterLoad();
            ResetInputFields();
            ResetEventLabelsAndChecks();
        }

        #endregion

        #region Helpers

        private void ResetInputFields()
        {
            Keywords.Text = DefaultKeywordsInputText;
            UserDataKeywords.Text = DefaultUserDataKeywordsInputText;
        }

        private void UpdateImageVisibility(string imageId, bool makeVisible, Expander parent)
        {
            var image = parent.Find<Image>(imageId);
            if (image != null)
                image.IsVisible = makeVisible;
        }

        private void UpdateLabelFontColor(string labelId, Color color, Expander parent)
        {
            var label = parent.Find<Label>(labelId);
            if (label != null)
                label.FontColor = color;
        }

        private void UpdateLabelText(string labelId, string text, Expander parent)
        {
            var label = parent.Find<Label>(labelId);
            if (label != null)
                label.Text = text;
        }

        private void UpdateFieldText(string fieldId, string text, Expander parent)
        {
            var input = parent.Find<InputField>(fieldId);
            if (input == null) return;

            input.Text = text;
            var expanderContent = parent.Find<ExpanderContent>();
            var group = parent.Find<Group>();
            var newHeight = string.IsNullOrEmpty(text) ? 60 : 480;
            if (expanderContent != null) expanderContent.Height = newHeight;
            if (group != null) group.Height = newHeight;
            input.Height = newHeight - 60;
        }

        private void UpdateExpander(Expander expander, bool enable,
            string adUnitId = "",
            string height = "",
            string label = "",
            string amount = "",
            string error = "",
            string impressionDataJson = "")
        {
            expander.IsDisabled = false; // enable Expander to update its properties...

            UpdateImageVisibility(expander.Id + "EventChevron", enable, expander);
            UpdateImageVisibility(expander.Id + "CheckImage", enable, expander);

            UpdateLabelFontColor(expander.Id + "EventLabel",
                enable ? _postEventColor : _preEventColor, expander);

            UpdateLabelText(expander.Id + "AdUnitIdLabel",
                enable ? "adUnitId: " + adUnitId : string.Empty, expander);
            UpdateLabelText(expander.Id + "HeightLabel",
                enable ? "height: " + height : string.Empty, expander);
            UpdateLabelText(expander.Id + "LabelLabel",
                enable ? "label: " + label : string.Empty, expander);
            UpdateLabelText(expander.Id + "AmountLabel",
                enable ? "amount: " + amount : string.Empty, expander);
            UpdateLabelText(expander.Id + "ErrorLabel",
                enable ? "error: " + error : string.Empty, expander);
            UpdateFieldText(expander.Id + "ImpressionDataField",
                enable && !string.IsNullOrEmpty(impressionDataJson)
                    ? "impressionDataJson: " + LineBreakJson(impressionDataJson)
                    : string.Empty, expander);

            expander.IsDisabled = !enable; // ... and now actually toggle it as desired.
        }

        private string LineBreakJson(string json)
        {
            if (string.IsNullOrEmpty(json)) return string.Empty;

            json = json.Replace("{", "{\n  ");
            json = json.Replace(",", ",\n  ");
            json = json.Replace("}", "\n}");
            return json;
        }

        private void ResetEventLabelsAndChecks()
        {
            new[] {
                OnAdLoadedExpander,
                OnAdClickedExpander,
                OnAdFailedExpander,

                OnInterstitialLoadedExpander,
                OnInterstitialShownExpander,
                OnInterstitialClickedExpander,
                OnInterstitialDismissedExpander,
                OnInterstitialFailedExpander,

                OnRewardedVideoLoadedExpander,
                OnRewardedVideoShownExpander,
                OnRewardedVideoClickedExpander,
                OnRewardedVideoClosedExpander,
                OnRewardedVideoReceivedRewardExpander,
                OnRewardedVideoFailedToPlayExpander,
                OnRewardedVideoFailedEventExpander,

                OnImpressionTrackedBgExpander,
                OnImpressionTrackedExpander
            }.ToList().ForEach(expander => UpdateExpander(expander, false));

            _bannerLoaded = false;

            if (TestLayout) {
                var testAdUnitId = "b195f8dd8ded45fe847ad89ed1d016da";
                var testHeight = "120";
                var testError = "this is just a placeholder error text";
                var testLabel = "MoBucks";
                var testAmount = "50";
                var testImpressionData =
                    "{\"id\":\"7570e6cceb9a4b10b8bf0e1a2bf2b08f_001b0d7500205531\",\"adunit_id\":\"b195f8dd8ded45fe847ad89ed1d016da\",\"adunit_name\":\"Android Sample App Banner\",\"adunit_format\":\"Banner\",\"adgroup_id\":\"365cd2475e074026b93da14103a36b97\",\"adgroup_name\":\"Non-Mrect Ads\",\"adgroup_type\":\"gtee\",\"currency\":\"USD\",\"country\":\"US\",\"app_version\":\"5.16.1\",\"adgroup_priority\":6,\"publisher_revenue\":5.0E-5,\"precision\":\"publisher_defined\"} ";

                UpdateExpander(OnAdLoadedExpander, true, testAdUnitId, height: testHeight);
                UpdateExpander(OnAdClickedExpander, true, testAdUnitId);
                UpdateExpander(OnAdFailedExpander, true, testAdUnitId, error: testError);

                UpdateExpander(OnInterstitialLoadedExpander, true, testAdUnitId);
                UpdateExpander(OnInterstitialShownExpander, true, testAdUnitId);
                UpdateExpander(OnInterstitialClickedExpander, true, testAdUnitId);
                UpdateExpander(OnInterstitialDismissedExpander, true, testAdUnitId);
                UpdateExpander(OnInterstitialFailedExpander, true, testAdUnitId, error: testError);

                UpdateExpander(OnRewardedVideoLoadedExpander, true, testAdUnitId);
                UpdateExpander(OnRewardedVideoShownExpander, true, testAdUnitId);
                UpdateExpander(OnRewardedVideoClickedExpander, true, testAdUnitId);
                UpdateExpander(OnRewardedVideoClosedExpander, true, testAdUnitId);
                UpdateExpander(OnRewardedVideoReceivedRewardExpander, true, testAdUnitId, label: testLabel,
                    amount: testAmount);
                UpdateExpander(OnRewardedVideoFailedToPlayExpander, true, testAdUnitId, error: testError);
                UpdateExpander(OnRewardedVideoFailedEventExpander, true, testAdUnitId, error: testError);

                UpdateExpander(OnImpressionTrackedBgExpander, true, testAdUnitId,
                    impressionDataJson: testImpressionData);
                UpdateExpander(OnImpressionTrackedExpander, true, testAdUnitId);
            }
        }

        #endregion
    }
}
