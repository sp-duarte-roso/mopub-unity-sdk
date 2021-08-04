## Version 5.17.0 (May 12, 2021)
- **Features**
  - The MoPub Unity Plugin now includes version `5.17.0` of the MoPub Android and iOS SDKs.
  - Completely new sample app (see below), rebuilt from the ground up, with a focus on usability, cross-platform consistency, and showcasing the MoPub API.
  - Cleaned up `MoPub.cs` to ensure it only includes Publisher API methods.

- **Bug Fixes**
  - Fixed issue with some banners on iOS extending beyond the desired size.

## Version 5.16.4 (March 31, 2021)
- **Features**
  - The MoPub Unity Plugin now includes version `5.16.4` of the MoPub Android SDK and version `5.16.2` of the iOS SDK.

- **Bug Fixes**
  - Fixed issue with App Store submissions.

## Version 5.16.3 (March 24, 2021)
- **Features**
  - The MoPub Unity Plugin now includes version `5.16.3` of the MoPub Android SDK and version `5.16.2` of the iOS SDK.
  - Updated External Dependency Manager from 1.2.160 to 1.2.164. (*carryover from `5.16.2`*)

- **Bug Fixes**
  - Fixed release issues from `5.16.2`.
  - Fixed issue with some banners extending beyond the desired size. (*carryover from `5.16.2`*)

## Version 5.16.2 (March 19, 2021) *Deprecated*
- **Features**
  - The MoPub Unity Plugin now includes version `5.16.2` of the MoPub Android and iOS SDKs.
  - Updated External Dependency Manager from 1.2.160 to 1.2.164.

- **Bug Fixes**
  - Fixed issue with some banners extending beyond the desired size.

## Version 5.16.1 (February 22, 2021)
- **Features**
  - The MoPub Unity Plugin now includes version `5.16.1` of the MoPub iOS SDK and version `5.16.0` of the Android SDK.

## Version 5.16.0 (February 16, 2021)
- **Features**
  - The MoPub Unity Plugin now includes version `5.16.0` of the MoPub Android and iOS SDKs.
  - Enabled multidex by default on Android sample app.

- **Bug Fixes**
  - Fixed issue when building for iOS on Unity 2019.3+ due to TargetGuidByName.

## Version 5.15.0 (November 18, 2020)
- **Features**
  - The MoPub Unity Plugin now includes version `5.15.0` of the MoPub Android and iOS SDKs.
  - Added support for Snap Audience Network.
  - Updated External Dependency Manager from 1.2.147 to 1.2.160.

- **Bug Fixes**
  - Cleaned up Android dependencies.

## Version 5.14.1 (October 5, 2020)
- **Features**
  - The MoPub Unity Plugin now includes version `5.14.0` of the MoPub Android SDK and version `5.14.1` of the iOS SDK.
  - Added beta support for OMSDK version 1.3.4.
  - Added background event for real-time impression tracking: `OnImpressionTrackedEventBg`. Please see [our Publisher Docs](https://developers.mopub.com/publishers/unity/impression-data/#register-for-the-impression-event) for details.
  - Added ability to include `keywords` and `userDataKeywords` when requesting banners.
  - The Android SDK dependency is now managed by the External Dependency Manger. Please see [upgrade note below](https://github.com/mopub/mopub-unity-sdk#upgrading-to-sdk-514).
  - Added Pangle to `MoPub.SupportedNetwork` class.
  - Removed Mintegral from `MoPub.SupportedNetwork` class.

- **Bug Fixes**
  - Fixed an issue with interstitial loading causing crashes on Unity 2020. Please see [requirements note below](https://github.com/mopub/mopub-unity-sdk#additional-requirements-for-unity-2020) if you are using Unity 2020.
  - Fixed issue in SDK Manager when handling deprecated networks.

## Version 5.13.1 (July 09, 2020)
- **Features**
  - The MoPub Unity Plugin now includes version `5.13.1` of the MoPub Android and iOS SDKs.

- **Bug Fixes**
  - Fixed outdated version in sample app podspec.

## Version 5.13.0 (June 22, 2020)
- **Features**
  - The MoPub Unity Plugin now includes version `5.13.0` of the MoPub Android and iOS SDKs.
  - Handled newly deprecated Android SDK modules in SDK Manager migration.
  - Removed viewability exclusions in Android wrapper.
  - Cleaned up Android Manifest.

- **Bug Fixes**
  - Fixed missing `OnConsentDialogDismissed` event when consent dialog closes via X button.
  - Fixed incorrect logging when consent status changes.
  - Fixed incorrect return from `GetAvailableRewards` when there is a single Reward.
  - Removed redundant Unity resume after interstitial dismissal on iOS.

## Version 5.12.1 (April 16, 2020)
- **Features**
  - The MoPub Unity Plugin now includes version 5.12.1 of the MoPub iOS SDK (and version 5.12.0 of the MoPub Android SDK).

## Version 5.12.0 (April 09, 2020)
- **Features**
  - The MoPub Unity Plugin now includes version 5.12.0 of the MoPub Android SDK and version 5.12.0 of the MoPub iOS SDK.
  - Bumped minimum supported Unity version from 5.5 to 2017.1.
  - Added `app_version` to Impression-Level Revenue Data object.
  - Upgraded External Dependency Manager (f.k.a. Unity Jar Resolver) from version 1.2.122.0 to 1.2.147.0, enabling iOS building on Unity 2019.3+ and addressing several External Dependency Manager bugs.
  - Replaced "OneByAol" (aka "Millenial") with "Mintegral".
  - Removed deprecated `CreateBanner` API; please use `RequestBanner` instead.

- **Bug Fixes**
  - Fixed potential crash on Android due to missing dependencies.
  - Fix banners sometimes rendering bigger than requested.
  - Ensured MoPub iOS helper methods do not collide with publisher methods.
  - Fixed MoPubManagerTesting game object.
  - Fixed crash on Android when loading some ads due to missing new dependencies from Android SDK.
  - Removed double semicolons which caused some IDEs to report errors.

## Version 5.11.1 (February 19, 2020)
- **Features**
  - The MoPub Unity Plugin now includes version 5.11.1 of the MoPub Android SDK (and version 5.11.0 of the MoPub iOS SDK).

- **Bug Fixes**
  - Fixed crash on Android due to missing Kotlin dependency when parsing ads with video trackers.
  - Ensured ad events with invalid numerical values are handled gracefully.

## Version 5.11.0 (February 5, 2020)
- **Features**
  - The MoPub Unity Plugin now includes version 5.11.0 of the MoPub Android and iOS SDKs.
  - GDPR Consent Dialog is now automatically shown on application start (if needed) when "Auto Show Consent Dialog" is enabled (within the MoPubManager GameObject > MoPubConsent).
  - Added 3-layered validation ensuring any method in the MoPub API can be safely called regardless of SDK or Ad Unit state.
  - Added error message when SDK Manager fails to download files, suggesting manual integration.
  - Updated SDK Manager to use `UnityWebRequest` to download files.
  - Added 10-second timeout to SDK Manager downloads.
  - Added Flurry to MoPub.SupportedNetwork class.
  - Updated the following package names:
    - Plugin package renamed from `com.mopub.unityplugindemo` to `com.mopub.unity.plugin`.
    - Sample app package renamed from `com.mopub.sample` to `com.mopub.unity.sample`.
    - NOTE: Android wrapper package name remains as `com.mopub.unity`.

- **Bug Fixes**
  - Android binary updated with 5.10.0 bug fix: Guarded against premature calls to `IsInterstitialReady`.
  - Fixed Impression-Level Revenue Data parsing in cultures with comma decimals.
  - Namespaced our version of MiniJSON to avoid conflicts with publisher-included MiniJSON.
  - Removed duplicate Consent Dialog log entries.
  - Consent Dialog showing is now denied when GDPR does not apply.
  - Sample app now supports SSL Proxying.

## Version 5.10.0 (November 4, 2019)
- **Features**
  - The MoPub Unity Plugin now includes version 5.10.0 of the MoPub Android and iOS SDKs.
  - Upgraded Android Gradle plugin dependency to 3.5.1.
  - Rewarded Videos failing to show now trigger an `OnRewardedVideoFailedToPlayEvent` with error code `VIDEO_NOT_AVAILABLE`.
- **Bug Fixes**
  - Guarded against premature calls to `IsInterstitialReady`. NOTE: Android binary updated with this fix on 5.11.0.
  - Prevent polling `IsInterstitialReady` from spamming the Editor console.
  - Removed deprecated `Android only` comments.
  - Prevent destroying intersitials from causing exceptions.
  - Prevent MoPub Sample app icon from overriding publisher app icon.

## Version 5.9.0 (September 17, 2019)
- **Features**
  - The MoPub Unity Plugin now includes version 5.9.0 of the MoPub Android and iOS SDKs.
  - Refactored SDK to clarify between publisher and internal APIs, in short:
    - The entire Publisher API, along with its documentation, is now contained in the [MoPub class](https://github.com/mopub/mopub-unity-sdk/blob/master/unity-sample-app/Assets/MoPub/Scripts/MoPub.cs).
    - Internal APIs (such as the `MoPubPlatformApi` and `MoPubAdUnit` classes along with their derived types) now have all their methods marked `internal`.
    - *NOTE:* These changes are backwards-compatible, but if your integration contains calls to the internal class `MoPubBase`, simply replace those with calls to `MoPub`.
  - Removed Network-specific activity declarations in Android manifest (since they are now included in their corresponding adapters).
  - Migrated to Android X.
  - Sample app is now scrollable when needed.
  - Sample app on Android is now compatible with SSL Proxying.
- **Bug Fixes**
  - Fixed a bug in pixels to dips conversions.
  - Guarded against null values in Impression Data.
  - Logging from Android wrapper now uses `MoPubLog`.

## Version 5.8.0 (July 29, 2019)
- **Features**
  - The MoPub Unity Plugin now includes version 5.8.0 of the MoPub Android and iOS SDKs.
  - `CreateBanner` has been deprecated in favor of new `RequestBanner` which allows a maximum ad size to be specified.
  - The MoPubManager script has been expanded into a prefab you can add to the scene.
It can be used to configure the SDK initialization and consent dialog management from within the Unity editor.
  - Each mediation adapter comes with a NetworkConfig script which extends the MoPubManager prefab for adding network options to the initialization call.
  - The MoPubManager prefab includes two separate configurations, one for production builds and one for QA/testing builds.
  - Updated to the latest version of the Google Play Services Resolver to gain support for AndroidX and Jetifier.
  - Added an event for ConsentDialogDismissed.
- **Bug Fixes**
  - Failing to retrieve the SDK manifest in the SDK Manager dialog no longer causes an exception.
  - Fixed a bug that incorrectly deserialized JSON network options as the class names instead of the object values (Android only).
  - Use InvariantCulture in all calls to Parse/TryParse in order to not be affected by the user's locale when reading internal MoPub data.
  - Android SDK components are bundled in aar form instead of jar form because they contain some resources now.
  - Fixed concurrent loading of rewarded videos.
  - Fixed a bug causing an error message regarding Play Services Resolver when a new version is shipped. 

## Version 5.7.1 (June 4, 2019)
- **Features**
  - The MoPub Unity Plugin now includes versions 5.7.1 of the MoPub Android SDK and the MoPub iOS SDK.
- **Bug Fixes**
  - Upgraded the Unity Jar Resolver to version 1.2.110, which addresses an issue with local pods in the "Xcode project" mode of cocoapods integration (issue #51).

## Version 5.7.0 (May 22, 2019)
- **Features**
  - The MoPub Unity Plugin now includes versions 5.7.0 of the MoPub Android SDK and the MoPub iOS SDK.
  - Impression Level Revenue Data: a data object that includes revenue information associated with each impression.
  - Verizon Ads SDK now supported as a mediated network.
  - Added the `willLeaveApplicationFromAd` iOS callback to send the `AdClickedEvent` to Unity
- **Bug Fixes**
  - Fixed issue with location awareness toggling.
  - Fixed Unity event triggered from `didFailToLoadAdWithError` on iOS.
  - Use correct culture in `float.Parse()` calls to avoid potential parsing issues.

## Version 5.6.0 (March 21, 2019)
- The MoPub Unity Plugin now includes versions 5.6.0 of the MoPub Android SDK and the MoPub iOS SDK.
- The MoPub iOS SDK is now included via podspecs.
- Android application pause events are now properly handled.
- isSDKInitialized on Android now returns true only after SDK initalization has completed.

## Verison 5.5.0 (January 31, 2019)
- The MoPub Unity Plugin now includes versions 5.5.0 of the MoPub Android SDK and the MoPub iOS SDK.
- The SDK Manager can now also install and upgrade mediated network SDKs.
- Google's [Unity Jar Resolver|https://github.com/googlesamples/unity-jar-resolver] is included.
It is used to download the mediation adapters, network SDKs, and android support libraries.
- Improved logging throughout the SDK.
- Automatic Advanced Bidder initialization.
- Fixed a problem with the incorrect framework path in the Xcode project for Unity 2018.3+.

## Version 5.4.1 (November 28, 2018)
- The MoPub Unity Plugin now includes versions 5.4.1 of the MoPub Android SDK and the MoPub iOS SDK.
- Fixed Unity 5.3 sample app crash when attempting to show MRAID rich media ads on Android 9 devices.
- Fixed typo "Millenial" to "Millennial" in Rewarded Video.
- Fixed SDK Manager version comparisons.
- NOTE: The SDK Manager can not update to 5.4.1, so please update manually.

## Version 5.4.0 (October 9, 2018)
- The MoPub Unity Plugin now includes versions 5.4.0 of the MoPub Android SDK and the MoPub iOS SDK.
- The MoPub menu now has more features: About, Documentation, Report Issue, and SDK Manager
- The SDK Manager dialog allows checking for and updating to new versions of the SDK.
- The SDK directory structure has changed:  All files are now collected under Assets/MoPub.  See the README file for notes on migration.

## Version 5.3.0 (August 15, 2018)
- The MoPub Unity Plugin now includes versions 5.3.0 of the MoPub Android SDK and the MoPub iOS SDK.

## Version 5.2.0 (July 11, 2018)
- A new MoPub Preferences pane has been added to Unity Preferences, with optional Beta features.
- A Beta MoPub Menu has been added, including build commands for the MoPub wrappers. Please see the [developer support site](https://developers.mopub.com/docs/unity/getting-started/) for details.
- A Beta of the experimental MoPub Native Ad format has been included. Please see the [developer support site](https://developers.mopub.com/docs/unity/getting-started/) for details.
- Fixed an issue when building for Android with IL2CPP.
- The MoPub Unity Plugin now includes versions 5.2.0 of the MoPub Android SDK and the MoPub iOS SDK.

## Version 5.1.0 (June 6, 2018)
- Allow publishers to determine which users should be treated as GDPR-compliant users through the new API `ForceGdprApplicable`.
- Loading MoPub's consent dialog is only possible when GDPR rules applies to the app.
- Added support for AdMob's NPA mediation setting ([Issue #15](https://github.com/mopub/mopub-unity-sdk/issues/15)).
- Fixed event name for `RewardedVideoReceivedReward` on Android ([Issue #16](https://github.com/mopub/mopub-unity-sdk/issues/16)).
- Fixed Rewarded Video adapter class names for AdMob and UnityAds.
- Banners now only refresh after an impression is made.

## Version 5.0.1 (May 21, 2018)
- Fixes a bug that affected iOS builds on Unity versions below 2017.1.
- Note that a manual step in XCode is required for these cases to ensure that the `MoPubSDKFramework.framework` is included in the Embedded Binaries list. Please see the [Getting Started Guide](https://developers.mopub.com/docs/unity/getting-started/) for details.

## Version 5.0.0 (May 16, 2018)
- General Data Protection Regulation (GDPR) update to support a way for publishers to determine GDPR applicability and to obtain and manage consent from users in European Economic Area, the United Kingdom, or Switzerland to serve personalized ads.
- New SDK initialization method to initialize consent management and rewarded video ad networks. Required for receiving personalized ads. In future versions of the SDK, initialization will be required to receive ads.
- Sample app directory updated to `unity-sample-app/`

## Version 4.20.2 (March 16, 2018)
- Fixed an issue with banners being occluded by the notch in iPhone X; banners (regardless of platform or positioning) are now restricted to the device's safe area.
- We are formally separating network adapters from our MoPub SDK. This is to enable an independent release cadence resulting in faster updates and certification cycles. New mediation location is accessible [here](https://github.com/mopub/mopub-unity-mediation).
We have also added an additional tool, making it easy for publishers to get up and running with the mediation integration. Check out https://developers.mopub.com/docs/mediation/integrate/ and integration instructions at https://developers.mopub.com/docs/unity/getting-started/.

## Version 4.20.1 (March 13, 2018)
- The MoPub Unity Plugin now includes version 4.20.0 of the MoPub Android SDK and version 4.20.1 of the MoPub iOS SDK.
- We are formally separating network adapters from our MoPub SDK. This is to enable an independent release cadence resulting in faster updates and certification cycles. New mediation location is accessible [here](https://github.com/mopub/mopub-unity-mediation).
We have also added an additional tool, making it easy for publishers to get up and running with the mediation integration. Check out https://developers.mopub.com/docs/mediation/integrate/ and integration instructions at https://developers.mopub.com/docs/unity/getting-started/.

## Version 4.20.0 (February 20, 2018)
- The MoPub Unity Plugin now includes version 4.20.0 of the MoPub Android SDK and version 4.20.0 of the MoPub iOS SDK.
- We are formally separating network adapters from our MoPub SDK. This is to enable an independent release cadence resulting in faster updates and certification cycles. New mediation location is accessible [here](https://github.com/mopub/mopub-unity-mediation).
We have also added an additional tool, making it easy for publishers to get up and running with the mediation integration. Check out https://developers.mopub.com/docs/mediation/integrate/ and integration instructions at https://developers.mopub.com/docs/unity/getting-started/.

## Version 4.19.0 (December 15, 2017)
- Bug fixes.
- The MoPub Unity Plugin is now compatible with version 4.19.0 of the MoPub Android SDK and version 4.19.0 of the MoPub iOS SDK.

## Version 4.18.0 (November 3, 2017)
- Improved documentation for third-party SDKs.
- Added ability to change log level for iOS (Android already logs everything). See [`MoPubBinding.setSDKLogLevel(MoPubLogLevel)`](https://github.com/mopub/mopub-unity-sdk/blob/79e34235386b751054eeb70dfda2feda84f1762d/unity/MoPubUnityPlugin/Assets/MoPub/Internal/MoPubBinding.cs#L76)
- Several third-party networks were upgraded.
- Cleaned up errors for non-mobile platforms.
- The MoPub Unity Plugin is now compatible with version 4.18.0 of the MoPub Android SDK and version 4.18.0 of the MoPub iOS SDK.

## Version 4.17.0 (September 28, 2017)
- Rewarded Ads can now send up optional custom data through the server completion url. See [`MoPub.showRewardedVideo (string, string)`](https://github.com/mopub/mopub-unity-sdk/blob/e0697d2f03c972de70d94aac39d5990bb30389af/unity/MoPubUnityPlugin/Assets/MoPub/MoPub.cs#L348).
- Several improvements to the Sample Scene, including better layout, error cleanup, more details on failures, and showing the versions of the running Plugin and SDK.
- The MoPub Unity Plugin is now compatible with version 4.17.0 of the MoPub Android SDK and version 4.17.0 of the MoPub iOS SDK.

## Version 4.16.1 (September 8, 2017)
- The MoPub Unity Plugin is now fully open source! Please see the [readme](https://github.com/mopub/mopub-unity-sdk/blob/master/README.md) for details and building instructions.
- This release does not change the SDK compatibility; the Plugin is still compatible with version 4.16.1 of the MoPub Android SDK and version 4.16.0 of the MoPub iOS SDK.

## Version 4.16.0 (August 30, 2017)
- The MoPub Unity Plugin is now compatible with version 4.16.1 of the MoPub Android SDK and version 4.16.0 of the MoPub iOS SDK.
- Rewarded Videos have a new init method. See [`MoPub.initializeRewardedVideo(MoPubRewardedNetwork[])`](https://github.com/mopub/mopub-unity-sdk/blob/e0697d2f03c972de70d94aac39d5990bb30389af/unity/MoPubUnityPlugin/Assets/MoPub/MoPub.cs#L306). Pass in a list of networks to initialize, and MoPub will initialize those networks with the settings from the previous ad request, persisted across app close.

## Version 4.15.0 (June 29, 2017)
- The MoPub Unity Plugin is now compatible with version 4.15.0 of the MoPub SDK.
- The MoPub Unity Plugin is now available on GitHub.

## Version 4.14.0
- The MoPub Unity Plugin is now compatible with version 4.14.0 of the MoPub SDK.

## Version 4.13.0
- The MoPub Unity Plugin is now compatible with version 4.13.0 of the MoPub SDK.

## Version 4.12.0
- The MoPub Unity Plugin is now compatible with version 4.12.0 of the MoPub SDK.

## Version 4.11.0
- Minor bug fixes

## Version 4.10.0
#### The Mopub Unity Plugin 4.10.0 introduces Modularized SDK for Android
Starting in the 4.10.0 release, we want to bring the modular SDK support to Android, so you choose to include specific ad formats and decrease overall SDK footprint in your app. For instance, if a publisher only wishes to integrate with MoPub’s interstitials and rewarded videos, you no longer need to include the banner SDK module to your project. For taking advantage of the new modular features, download the Android Unity package 4.10.0 from the "Getting Started" section and choose the modules of your choice from [`Assets/Plugins/Android/mopub/libs/`](https://github.com/mopub/mopub-unity-sdk/tree/master/unity/MoPubUnityPlugin/Assets/Plugins/Android/mopub/libs) directory:

- mopub-unity-plugins.jar: Unity plugins supporting banner, interstitial, and/or rewarded video (required)
- mopub-sdk-base.jar: base module for MoPub Android SDK (required)
- mopub-sdk-banner.jar: banner SDK module (optional)
- mopub-sdk-interstitial.jar: interstitial SDK module (optional, but required for rewarded video)
- mopub-sdk-rewardedvideo.jar: rewarded video SDK module (optional)

Note: interstitials is a prerequisite for rewarded videos, so one cannot integrate with rewarded videos without the interstitials SDK module.

## Version 4.9.0
- Support of multiple plugins for multiple banners, interstitials, and rewarded videos: one plugin per adunit
- Compatibility with MoPub's SDK 4.9.0 (modular SDK)
- Please note that there is no backward compatibility with SDK versions earlier than 4.9.0. For earlier versions, please check our reference documentation.
