// Internal view logic generated from "MoPubAdUnitView.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MoPubAdUnitView : UIView
    {
        #region Constructors

        public MoPubAdUnitView(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MoPubAdUnitViewTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing Group (Group1)
            Group1 = new Group(this, this, "Group1", Group1Template);
            Group2 = new Group(this, Group1.Content, "Group2", Group2Template);
            Image1 = new Image(this, Group2.Content, "Image1", Image1Template);
            Button1 = new Button(this, Group2.Content, "Button1", Button1Template);
            Button1.Click.RegisterHandler(this, "BackClickHandler");
            Region1 = new Region(this, Group1.Content, "Region1", Region1Template);
            AdUnitName = new Label(this, Region1.Content, "AdUnitName", AdUnitNameTemplate);
            Label1 = new Label(this, Group1.Content, "Label1", Label1Template);
            AdUnitId = new Label(this, Group1.Content, "AdUnitId", AdUnitIdTemplate);
            Region2 = new Region(this, Group1.Content, "Region2", Region2Template);
            Keywords = new InputField(this, Group1.Content, "Keywords", KeywordsTemplate);
            KeywordsDelimiter = new Region(this, Group1.Content, "KeywordsDelimiter", KeywordsDelimiterTemplate);
            UserDataKeywords = new InputField(this, Group1.Content, "UserDataKeywords", UserDataKeywordsTemplate);
            UserDataKeywordsDelimiter = new Region(this, Group1.Content, "UserDataKeywordsDelimiter", UserDataKeywordsDelimiterTemplate);
            Region3 = new Region(this, Group1.Content, "Region3", Region3Template);
            LoadAdButton = new Button(this, Group1.Content, "LoadAdButton", LoadAdButtonTemplate);
            LoadAdButton.Click.RegisterHandler(this, "LoadAdHandler");
            ShowAdButton = new Button(this, Group1.Content, "ShowAdButton", ShowAdButtonTemplate);
            ShowAdButton.Click.RegisterHandler(this, "ShowAdHandler");

            // binding <Button IsVisible="{!IsBanner}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsBanner" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "ShowAdButton", "IsVisible" }, new List<Func<object>> { () => this, () => ShowAdButton }), () => ShowAdButton.IsVisible = !IsBanner, () => { }, false));
            Region4 = new Region(this, Group1.Content, "Region4", Region4Template);
            OnAdLoadedExpander = new Expander(this, Group1.Content, "OnAdLoadedExpander", OnAdLoadedExpanderTemplate);
            OnAdLoadedExpander.Click.RegisterHandler(() => OnAdLoadedExpander.IsExpanded = !OnAdLoadedExpander.IsExpanded);

            // binding <Expander IsActive="{IsBanner}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsBanner" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnAdLoadedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnAdLoadedExpander }), () => OnAdLoadedExpander.IsActive = IsBanner, () => { }, false));

            // templates for OnAdLoadedExpander
            OnAdLoadedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader1 = new ExpanderHeader(this, OnAdLoadedExpander.Content, "ExpanderHeader1", ExpanderHeader1Template);
                var region5 = new Region(this, expanderHeader1.Content, "Region5", Region5Template);
                var onAdLoadedExpanderMPEventChevron = new Image(this, region5.Content, "OnAdLoadedExpanderMPEventChevron", OnAdLoadedExpanderMPEventChevronTemplate);
                expanderHeader1.SetExpanderState.SetValue(onAdLoadedExpanderMPEventChevron, true);
                var onAdLoadedExpanderCheckImage = new Image(this, region5.Content, "OnAdLoadedExpanderCheckImage", OnAdLoadedExpanderCheckImageTemplate);
                var onAdLoadedExpanderEventLabel = new Label(this, region5.Content, "OnAdLoadedExpanderEventLabel", OnAdLoadedExpanderEventLabelTemplate);
                expanderHeader1.IsDynamic = true;
                expanderHeader1.SetContentTemplateData(x0);
                return expanderHeader1;
            }, typeof(ExpanderHeader), "ExpanderHeader1"));

            // templates for OnAdLoadedExpander
            OnAdLoadedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent1 = new ExpanderContent(this, OnAdLoadedExpander.Content, "ExpanderContent1", ExpanderContent1Template);
                var group3 = new Group(this, expanderContent1.Content, "Group3", Group3Template);
                var onAdLoadedExpanderAdUnitIdLabel = new Label(this, group3.Content, "OnAdLoadedExpanderAdUnitIdLabel", OnAdLoadedExpanderAdUnitIdLabelTemplate);
                var onAdLoadedExpanderHeightLabel = new Label(this, group3.Content, "OnAdLoadedExpanderHeightLabel", OnAdLoadedExpanderHeightLabelTemplate);
                expanderContent1.IsDynamic = true;
                expanderContent1.SetContentTemplateData(x0);
                return expanderContent1;
            }, typeof(ExpanderContent), "ExpanderContent1"));
            Region6 = new Region(this, Group1.Content, "Region6", Region6Template);

            // binding <Region IsActive="{IsBanner}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsBanner" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region6", "IsActive" }, new List<Func<object>> { () => this, () => Region6 }), () => Region6.IsActive = IsBanner, () => { }, false));
            OnAdClickedExpander = new Expander(this, Group1.Content, "OnAdClickedExpander", OnAdClickedExpanderTemplate);
            OnAdClickedExpander.Click.RegisterHandler(() => OnAdClickedExpander.IsExpanded = !OnAdClickedExpander.IsExpanded);

            // binding <Expander IsActive="{IsBanner}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsBanner" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnAdClickedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnAdClickedExpander }), () => OnAdClickedExpander.IsActive = IsBanner, () => { }, false));

            // templates for OnAdClickedExpander
            OnAdClickedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader2 = new ExpanderHeader(this, OnAdClickedExpander.Content, "ExpanderHeader2", ExpanderHeader2Template);
                var region7 = new Region(this, expanderHeader2.Content, "Region7", Region7Template);
                var onAdClickedExpanderMPEventChevron = new Image(this, region7.Content, "OnAdClickedExpanderMPEventChevron", OnAdClickedExpanderMPEventChevronTemplate);
                expanderHeader2.SetExpanderState.SetValue(onAdClickedExpanderMPEventChevron, true);
                var onAdClickedExpanderCheckImage = new Image(this, region7.Content, "OnAdClickedExpanderCheckImage", OnAdClickedExpanderCheckImageTemplate);
                var onAdClickedExpanderEventLabel = new Label(this, region7.Content, "OnAdClickedExpanderEventLabel", OnAdClickedExpanderEventLabelTemplate);
                expanderHeader2.IsDynamic = true;
                expanderHeader2.SetContentTemplateData(x0);
                return expanderHeader2;
            }, typeof(ExpanderHeader), "ExpanderHeader2"));

            // templates for OnAdClickedExpander
            OnAdClickedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent2 = new ExpanderContent(this, OnAdClickedExpander.Content, "ExpanderContent2", ExpanderContent2Template);
                var onAdClickedExpanderAdUnitIdLabel = new Label(this, expanderContent2.Content, "OnAdClickedExpanderAdUnitIdLabel", OnAdClickedExpanderAdUnitIdLabelTemplate);
                expanderContent2.IsDynamic = true;
                expanderContent2.SetContentTemplateData(x0);
                return expanderContent2;
            }, typeof(ExpanderContent), "ExpanderContent2"));
            Region8 = new Region(this, Group1.Content, "Region8", Region8Template);

            // binding <Region IsActive="{IsBanner}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsBanner" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region8", "IsActive" }, new List<Func<object>> { () => this, () => Region8 }), () => Region8.IsActive = IsBanner, () => { }, false));
            OnAdFailedExpander = new Expander(this, Group1.Content, "OnAdFailedExpander", OnAdFailedExpanderTemplate);
            OnAdFailedExpander.Click.RegisterHandler(() => OnAdFailedExpander.IsExpanded = !OnAdFailedExpander.IsExpanded);

            // binding <Expander IsActive="{IsBanner}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsBanner" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnAdFailedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnAdFailedExpander }), () => OnAdFailedExpander.IsActive = IsBanner, () => { }, false));

            // templates for OnAdFailedExpander
            OnAdFailedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader3 = new ExpanderHeader(this, OnAdFailedExpander.Content, "ExpanderHeader3", ExpanderHeader3Template);
                var region9 = new Region(this, expanderHeader3.Content, "Region9", Region9Template);
                var onAdFailedExpanderMPEventChevron = new Image(this, region9.Content, "OnAdFailedExpanderMPEventChevron", OnAdFailedExpanderMPEventChevronTemplate);
                expanderHeader3.SetExpanderState.SetValue(onAdFailedExpanderMPEventChevron, true);
                var onAdFailedExpanderCheckImage = new Image(this, region9.Content, "OnAdFailedExpanderCheckImage", OnAdFailedExpanderCheckImageTemplate);
                var onAdFailedExpanderEventLabel = new Label(this, region9.Content, "OnAdFailedExpanderEventLabel", OnAdFailedExpanderEventLabelTemplate);
                expanderHeader3.IsDynamic = true;
                expanderHeader3.SetContentTemplateData(x0);
                return expanderHeader3;
            }, typeof(ExpanderHeader), "ExpanderHeader3"));

            // templates for OnAdFailedExpander
            OnAdFailedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent3 = new ExpanderContent(this, OnAdFailedExpander.Content, "ExpanderContent3", ExpanderContent3Template);
                var group4 = new Group(this, expanderContent3.Content, "Group4", Group4Template);
                var onAdFailedExpanderAdUnitIdLabel = new Label(this, group4.Content, "OnAdFailedExpanderAdUnitIdLabel", OnAdFailedExpanderAdUnitIdLabelTemplate);
                var onAdFailedExpanderErrorLabel = new Label(this, group4.Content, "OnAdFailedExpanderErrorLabel", OnAdFailedExpanderErrorLabelTemplate);
                expanderContent3.IsDynamic = true;
                expanderContent3.SetContentTemplateData(x0);
                return expanderContent3;
            }, typeof(ExpanderContent), "ExpanderContent3"));
            Region10 = new Region(this, Group1.Content, "Region10", Region10Template);

            // binding <Region IsActive="{IsBanner}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsBanner" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region10", "IsActive" }, new List<Func<object>> { () => this, () => Region10 }), () => Region10.IsActive = IsBanner, () => { }, false));
            OnInterstitialLoadedExpander = new Expander(this, Group1.Content, "OnInterstitialLoadedExpander", OnInterstitialLoadedExpanderTemplate);
            OnInterstitialLoadedExpander.Click.RegisterHandler(() => OnInterstitialLoadedExpander.IsExpanded = !OnInterstitialLoadedExpander.IsExpanded);

            // binding <Expander IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnInterstitialLoadedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnInterstitialLoadedExpander }), () => OnInterstitialLoadedExpander.IsActive = IsInterstitial, () => { }, false));

            // templates for OnInterstitialLoadedExpander
            OnInterstitialLoadedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader4 = new ExpanderHeader(this, OnInterstitialLoadedExpander.Content, "ExpanderHeader4", ExpanderHeader4Template);
                var region11 = new Region(this, expanderHeader4.Content, "Region11", Region11Template);
                var onInterstitialLoadedExpanderMPEventChevron = new Image(this, region11.Content, "OnInterstitialLoadedExpanderMPEventChevron", OnInterstitialLoadedExpanderMPEventChevronTemplate);
                expanderHeader4.SetExpanderState.SetValue(onInterstitialLoadedExpanderMPEventChevron, true);
                var onInterstitialLoadedExpanderCheckImage = new Image(this, region11.Content, "OnInterstitialLoadedExpanderCheckImage", OnInterstitialLoadedExpanderCheckImageTemplate);
                var onInterstitialLoadedExpanderEventLabel = new Label(this, region11.Content, "OnInterstitialLoadedExpanderEventLabel", OnInterstitialLoadedExpanderEventLabelTemplate);
                expanderHeader4.IsDynamic = true;
                expanderHeader4.SetContentTemplateData(x0);
                return expanderHeader4;
            }, typeof(ExpanderHeader), "ExpanderHeader4"));

            // templates for OnInterstitialLoadedExpander
            OnInterstitialLoadedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent4 = new ExpanderContent(this, OnInterstitialLoadedExpander.Content, "ExpanderContent4", ExpanderContent4Template);
                var onInterstitialLoadedExpanderAdUnitIdLabel = new Label(this, expanderContent4.Content, "OnInterstitialLoadedExpanderAdUnitIdLabel", OnInterstitialLoadedExpanderAdUnitIdLabelTemplate);
                expanderContent4.IsDynamic = true;
                expanderContent4.SetContentTemplateData(x0);
                return expanderContent4;
            }, typeof(ExpanderContent), "ExpanderContent4"));
            Region12 = new Region(this, Group1.Content, "Region12", Region12Template);

            // binding <Region IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region12", "IsActive" }, new List<Func<object>> { () => this, () => Region12 }), () => Region12.IsActive = IsInterstitial, () => { }, false));
            OnInterstitialShownExpander = new Expander(this, Group1.Content, "OnInterstitialShownExpander", OnInterstitialShownExpanderTemplate);
            OnInterstitialShownExpander.Click.RegisterHandler(() => OnInterstitialShownExpander.IsExpanded = !OnInterstitialShownExpander.IsExpanded);

            // binding <Expander IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnInterstitialShownExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnInterstitialShownExpander }), () => OnInterstitialShownExpander.IsActive = IsInterstitial, () => { }, false));

            // templates for OnInterstitialShownExpander
            OnInterstitialShownExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader5 = new ExpanderHeader(this, OnInterstitialShownExpander.Content, "ExpanderHeader5", ExpanderHeader5Template);
                var region13 = new Region(this, expanderHeader5.Content, "Region13", Region13Template);
                var onInterstitialShownExpanderMPEventChevron = new Image(this, region13.Content, "OnInterstitialShownExpanderMPEventChevron", OnInterstitialShownExpanderMPEventChevronTemplate);
                expanderHeader5.SetExpanderState.SetValue(onInterstitialShownExpanderMPEventChevron, true);
                var onInterstitialShownExpanderCheckImage = new Image(this, region13.Content, "OnInterstitialShownExpanderCheckImage", OnInterstitialShownExpanderCheckImageTemplate);
                var onInterstitialShownExpanderEventLabel = new Label(this, region13.Content, "OnInterstitialShownExpanderEventLabel", OnInterstitialShownExpanderEventLabelTemplate);
                expanderHeader5.IsDynamic = true;
                expanderHeader5.SetContentTemplateData(x0);
                return expanderHeader5;
            }, typeof(ExpanderHeader), "ExpanderHeader5"));

            // templates for OnInterstitialShownExpander
            OnInterstitialShownExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent5 = new ExpanderContent(this, OnInterstitialShownExpander.Content, "ExpanderContent5", ExpanderContent5Template);
                var onInterstitialShownExpanderAdUnitIdLabel = new Label(this, expanderContent5.Content, "OnInterstitialShownExpanderAdUnitIdLabel", OnInterstitialShownExpanderAdUnitIdLabelTemplate);
                expanderContent5.IsDynamic = true;
                expanderContent5.SetContentTemplateData(x0);
                return expanderContent5;
            }, typeof(ExpanderContent), "ExpanderContent5"));
            Region14 = new Region(this, Group1.Content, "Region14", Region14Template);

            // binding <Region IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region14", "IsActive" }, new List<Func<object>> { () => this, () => Region14 }), () => Region14.IsActive = IsInterstitial, () => { }, false));
            OnInterstitialClickedExpander = new Expander(this, Group1.Content, "OnInterstitialClickedExpander", OnInterstitialClickedExpanderTemplate);
            OnInterstitialClickedExpander.Click.RegisterHandler(() => OnInterstitialClickedExpander.IsExpanded = !OnInterstitialClickedExpander.IsExpanded);

            // binding <Expander IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnInterstitialClickedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnInterstitialClickedExpander }), () => OnInterstitialClickedExpander.IsActive = IsInterstitial, () => { }, false));

            // templates for OnInterstitialClickedExpander
            OnInterstitialClickedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader6 = new ExpanderHeader(this, OnInterstitialClickedExpander.Content, "ExpanderHeader6", ExpanderHeader6Template);
                var region15 = new Region(this, expanderHeader6.Content, "Region15", Region15Template);
                var onInterstitialClickedExpanderMPEventChevron = new Image(this, region15.Content, "OnInterstitialClickedExpanderMPEventChevron", OnInterstitialClickedExpanderMPEventChevronTemplate);
                expanderHeader6.SetExpanderState.SetValue(onInterstitialClickedExpanderMPEventChevron, true);
                var onInterstitialClickedExpanderCheckImage = new Image(this, region15.Content, "OnInterstitialClickedExpanderCheckImage", OnInterstitialClickedExpanderCheckImageTemplate);
                var onInterstitialClickedExpanderEventLabel = new Label(this, region15.Content, "OnInterstitialClickedExpanderEventLabel", OnInterstitialClickedExpanderEventLabelTemplate);
                expanderHeader6.IsDynamic = true;
                expanderHeader6.SetContentTemplateData(x0);
                return expanderHeader6;
            }, typeof(ExpanderHeader), "ExpanderHeader6"));

            // templates for OnInterstitialClickedExpander
            OnInterstitialClickedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent6 = new ExpanderContent(this, OnInterstitialClickedExpander.Content, "ExpanderContent6", ExpanderContent6Template);
                var onInterstitialClickedExpanderAdUnitIdLabel = new Label(this, expanderContent6.Content, "OnInterstitialClickedExpanderAdUnitIdLabel", OnInterstitialClickedExpanderAdUnitIdLabelTemplate);
                expanderContent6.IsDynamic = true;
                expanderContent6.SetContentTemplateData(x0);
                return expanderContent6;
            }, typeof(ExpanderContent), "ExpanderContent6"));
            Region16 = new Region(this, Group1.Content, "Region16", Region16Template);

            // binding <Region IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region16", "IsActive" }, new List<Func<object>> { () => this, () => Region16 }), () => Region16.IsActive = IsInterstitial, () => { }, false));
            OnInterstitialDismissedExpander = new Expander(this, Group1.Content, "OnInterstitialDismissedExpander", OnInterstitialDismissedExpanderTemplate);
            OnInterstitialDismissedExpander.Click.RegisterHandler(() => OnInterstitialDismissedExpander.IsExpanded = !OnInterstitialDismissedExpander.IsExpanded);

            // binding <Expander IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnInterstitialDismissedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnInterstitialDismissedExpander }), () => OnInterstitialDismissedExpander.IsActive = IsInterstitial, () => { }, false));

            // templates for OnInterstitialDismissedExpander
            OnInterstitialDismissedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader7 = new ExpanderHeader(this, OnInterstitialDismissedExpander.Content, "ExpanderHeader7", ExpanderHeader7Template);
                var region17 = new Region(this, expanderHeader7.Content, "Region17", Region17Template);
                var onInterstitialDismissedExpanderMPEventChevron = new Image(this, region17.Content, "OnInterstitialDismissedExpanderMPEventChevron", OnInterstitialDismissedExpanderMPEventChevronTemplate);
                expanderHeader7.SetExpanderState.SetValue(onInterstitialDismissedExpanderMPEventChevron, true);
                var onInterstitialDismissedExpanderCheckImage = new Image(this, region17.Content, "OnInterstitialDismissedExpanderCheckImage", OnInterstitialDismissedExpanderCheckImageTemplate);
                var onInterstitialDismissedExpanderEventLabel = new Label(this, region17.Content, "OnInterstitialDismissedExpanderEventLabel", OnInterstitialDismissedExpanderEventLabelTemplate);
                expanderHeader7.IsDynamic = true;
                expanderHeader7.SetContentTemplateData(x0);
                return expanderHeader7;
            }, typeof(ExpanderHeader), "ExpanderHeader7"));

            // templates for OnInterstitialDismissedExpander
            OnInterstitialDismissedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent7 = new ExpanderContent(this, OnInterstitialDismissedExpander.Content, "ExpanderContent7", ExpanderContent7Template);
                var onInterstitialDismissedExpanderAdUnitIdLabel = new Label(this, expanderContent7.Content, "OnInterstitialDismissedExpanderAdUnitIdLabel", OnInterstitialDismissedExpanderAdUnitIdLabelTemplate);
                expanderContent7.IsDynamic = true;
                expanderContent7.SetContentTemplateData(x0);
                return expanderContent7;
            }, typeof(ExpanderContent), "ExpanderContent7"));
            Region18 = new Region(this, Group1.Content, "Region18", Region18Template);

            // binding <Region IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region18", "IsActive" }, new List<Func<object>> { () => this, () => Region18 }), () => Region18.IsActive = IsInterstitial, () => { }, false));
            OnInterstitialFailedExpander = new Expander(this, Group1.Content, "OnInterstitialFailedExpander", OnInterstitialFailedExpanderTemplate);
            OnInterstitialFailedExpander.Click.RegisterHandler(() => OnInterstitialFailedExpander.IsExpanded = !OnInterstitialFailedExpander.IsExpanded);

            // binding <Expander IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnInterstitialFailedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnInterstitialFailedExpander }), () => OnInterstitialFailedExpander.IsActive = IsInterstitial, () => { }, false));

            // templates for OnInterstitialFailedExpander
            OnInterstitialFailedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader8 = new ExpanderHeader(this, OnInterstitialFailedExpander.Content, "ExpanderHeader8", ExpanderHeader8Template);
                var region19 = new Region(this, expanderHeader8.Content, "Region19", Region19Template);
                var onInterstitialFailedExpanderMPEventChevron = new Image(this, region19.Content, "OnInterstitialFailedExpanderMPEventChevron", OnInterstitialFailedExpanderMPEventChevronTemplate);
                expanderHeader8.SetExpanderState.SetValue(onInterstitialFailedExpanderMPEventChevron, true);
                var onInterstitialFailedExpanderCheckImage = new Image(this, region19.Content, "OnInterstitialFailedExpanderCheckImage", OnInterstitialFailedExpanderCheckImageTemplate);
                var onInterstitialFailedExpanderEventLabel = new Label(this, region19.Content, "OnInterstitialFailedExpanderEventLabel", OnInterstitialFailedExpanderEventLabelTemplate);
                expanderHeader8.IsDynamic = true;
                expanderHeader8.SetContentTemplateData(x0);
                return expanderHeader8;
            }, typeof(ExpanderHeader), "ExpanderHeader8"));

            // templates for OnInterstitialFailedExpander
            OnInterstitialFailedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent8 = new ExpanderContent(this, OnInterstitialFailedExpander.Content, "ExpanderContent8", ExpanderContent8Template);
                var group5 = new Group(this, expanderContent8.Content, "Group5", Group5Template);
                var onInterstitialFailedExpanderAdUnitIdLabel = new Label(this, group5.Content, "OnInterstitialFailedExpanderAdUnitIdLabel", OnInterstitialFailedExpanderAdUnitIdLabelTemplate);
                var onInterstitialFailedExpanderErrorLabel = new Label(this, group5.Content, "OnInterstitialFailedExpanderErrorLabel", OnInterstitialFailedExpanderErrorLabelTemplate);
                expanderContent8.IsDynamic = true;
                expanderContent8.SetContentTemplateData(x0);
                return expanderContent8;
            }, typeof(ExpanderContent), "ExpanderContent8"));
            Region20 = new Region(this, Group1.Content, "Region20", Region20Template);

            // binding <Region IsActive="{IsInterstitial}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsInterstitial" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region20", "IsActive" }, new List<Func<object>> { () => this, () => Region20 }), () => Region20.IsActive = IsInterstitial, () => { }, false));
            OnRewardedVideoLoadedExpander = new Expander(this, Group1.Content, "OnRewardedVideoLoadedExpander", OnRewardedVideoLoadedExpanderTemplate);
            OnRewardedVideoLoadedExpander.Click.RegisterHandler(() => OnRewardedVideoLoadedExpander.IsExpanded = !OnRewardedVideoLoadedExpander.IsExpanded);

            // binding <Expander IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnRewardedVideoLoadedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnRewardedVideoLoadedExpander }), () => OnRewardedVideoLoadedExpander.IsActive = IsRewardedAd, () => { }, false));

            // templates for OnRewardedVideoLoadedExpander
            OnRewardedVideoLoadedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader9 = new ExpanderHeader(this, OnRewardedVideoLoadedExpander.Content, "ExpanderHeader9", ExpanderHeader9Template);
                var region21 = new Region(this, expanderHeader9.Content, "Region21", Region21Template);
                var onRewardedVideoLoadedExpanderMPEventChevron = new Image(this, region21.Content, "OnRewardedVideoLoadedExpanderMPEventChevron", OnRewardedVideoLoadedExpanderMPEventChevronTemplate);
                expanderHeader9.SetExpanderState.SetValue(onRewardedVideoLoadedExpanderMPEventChevron, true);
                var onRewardedVideoLoadedExpanderCheckImage = new Image(this, region21.Content, "OnRewardedVideoLoadedExpanderCheckImage", OnRewardedVideoLoadedExpanderCheckImageTemplate);
                var onRewardedVideoLoadedExpanderEventLabel = new Label(this, region21.Content, "OnRewardedVideoLoadedExpanderEventLabel", OnRewardedVideoLoadedExpanderEventLabelTemplate);
                expanderHeader9.IsDynamic = true;
                expanderHeader9.SetContentTemplateData(x0);
                return expanderHeader9;
            }, typeof(ExpanderHeader), "ExpanderHeader9"));

            // templates for OnRewardedVideoLoadedExpander
            OnRewardedVideoLoadedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent9 = new ExpanderContent(this, OnRewardedVideoLoadedExpander.Content, "ExpanderContent9", ExpanderContent9Template);
                var onRewardedVideoLoadedExpanderAdUnitIdLabel = new Label(this, expanderContent9.Content, "OnRewardedVideoLoadedExpanderAdUnitIdLabel", OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplate);
                expanderContent9.IsDynamic = true;
                expanderContent9.SetContentTemplateData(x0);
                return expanderContent9;
            }, typeof(ExpanderContent), "ExpanderContent9"));
            Region22 = new Region(this, Group1.Content, "Region22", Region22Template);

            // binding <Region IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region22", "IsActive" }, new List<Func<object>> { () => this, () => Region22 }), () => Region22.IsActive = IsRewardedAd, () => { }, false));
            OnRewardedVideoShownExpander = new Expander(this, Group1.Content, "OnRewardedVideoShownExpander", OnRewardedVideoShownExpanderTemplate);
            OnRewardedVideoShownExpander.Click.RegisterHandler(() => OnRewardedVideoShownExpander.IsExpanded = !OnRewardedVideoShownExpander.IsExpanded);

            // binding <Expander IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnRewardedVideoShownExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnRewardedVideoShownExpander }), () => OnRewardedVideoShownExpander.IsActive = IsRewardedAd, () => { }, false));

            // templates for OnRewardedVideoShownExpander
            OnRewardedVideoShownExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader10 = new ExpanderHeader(this, OnRewardedVideoShownExpander.Content, "ExpanderHeader10", ExpanderHeader10Template);
                var region23 = new Region(this, expanderHeader10.Content, "Region23", Region23Template);
                var onRewardedVideoShownExpanderMPEventChevron = new Image(this, region23.Content, "OnRewardedVideoShownExpanderMPEventChevron", OnRewardedVideoShownExpanderMPEventChevronTemplate);
                expanderHeader10.SetExpanderState.SetValue(onRewardedVideoShownExpanderMPEventChevron, true);
                var onRewardedVideoShownExpanderCheckImage = new Image(this, region23.Content, "OnRewardedVideoShownExpanderCheckImage", OnRewardedVideoShownExpanderCheckImageTemplate);
                var onRewardedVideoShownExpanderEventLabel = new Label(this, region23.Content, "OnRewardedVideoShownExpanderEventLabel", OnRewardedVideoShownExpanderEventLabelTemplate);
                expanderHeader10.IsDynamic = true;
                expanderHeader10.SetContentTemplateData(x0);
                return expanderHeader10;
            }, typeof(ExpanderHeader), "ExpanderHeader10"));

            // templates for OnRewardedVideoShownExpander
            OnRewardedVideoShownExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent10 = new ExpanderContent(this, OnRewardedVideoShownExpander.Content, "ExpanderContent10", ExpanderContent10Template);
                var onRewardedVideoShownExpanderAdUnitIdLabel = new Label(this, expanderContent10.Content, "OnRewardedVideoShownExpanderAdUnitIdLabel", OnRewardedVideoShownExpanderAdUnitIdLabelTemplate);
                expanderContent10.IsDynamic = true;
                expanderContent10.SetContentTemplateData(x0);
                return expanderContent10;
            }, typeof(ExpanderContent), "ExpanderContent10"));
            Region24 = new Region(this, Group1.Content, "Region24", Region24Template);

            // binding <Region IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region24", "IsActive" }, new List<Func<object>> { () => this, () => Region24 }), () => Region24.IsActive = IsRewardedAd, () => { }, false));
            OnRewardedVideoClickedExpander = new Expander(this, Group1.Content, "OnRewardedVideoClickedExpander", OnRewardedVideoClickedExpanderTemplate);
            OnRewardedVideoClickedExpander.Click.RegisterHandler(() => OnRewardedVideoClickedExpander.IsExpanded = !OnRewardedVideoClickedExpander.IsExpanded);

            // binding <Expander IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnRewardedVideoClickedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnRewardedVideoClickedExpander }), () => OnRewardedVideoClickedExpander.IsActive = IsRewardedAd, () => { }, false));

            // templates for OnRewardedVideoClickedExpander
            OnRewardedVideoClickedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader11 = new ExpanderHeader(this, OnRewardedVideoClickedExpander.Content, "ExpanderHeader11", ExpanderHeader11Template);
                var region25 = new Region(this, expanderHeader11.Content, "Region25", Region25Template);
                var onRewardedVideoClickedExpanderMPEventChevron = new Image(this, region25.Content, "OnRewardedVideoClickedExpanderMPEventChevron", OnRewardedVideoClickedExpanderMPEventChevronTemplate);
                expanderHeader11.SetExpanderState.SetValue(onRewardedVideoClickedExpanderMPEventChevron, true);
                var onRewardedVideoClickedExpanderCheckImage = new Image(this, region25.Content, "OnRewardedVideoClickedExpanderCheckImage", OnRewardedVideoClickedExpanderCheckImageTemplate);
                var onRewardedVideoClickedExpanderEventLabel = new Label(this, region25.Content, "OnRewardedVideoClickedExpanderEventLabel", OnRewardedVideoClickedExpanderEventLabelTemplate);
                expanderHeader11.IsDynamic = true;
                expanderHeader11.SetContentTemplateData(x0);
                return expanderHeader11;
            }, typeof(ExpanderHeader), "ExpanderHeader11"));

            // templates for OnRewardedVideoClickedExpander
            OnRewardedVideoClickedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent11 = new ExpanderContent(this, OnRewardedVideoClickedExpander.Content, "ExpanderContent11", ExpanderContent11Template);
                var onRewardedVideoClickedExpanderAdUnitIdLabel = new Label(this, expanderContent11.Content, "OnRewardedVideoClickedExpanderAdUnitIdLabel", OnRewardedVideoClickedExpanderAdUnitIdLabelTemplate);
                expanderContent11.IsDynamic = true;
                expanderContent11.SetContentTemplateData(x0);
                return expanderContent11;
            }, typeof(ExpanderContent), "ExpanderContent11"));
            Region26 = new Region(this, Group1.Content, "Region26", Region26Template);

            // binding <Region IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region26", "IsActive" }, new List<Func<object>> { () => this, () => Region26 }), () => Region26.IsActive = IsRewardedAd, () => { }, false));
            OnRewardedVideoClosedExpander = new Expander(this, Group1.Content, "OnRewardedVideoClosedExpander", OnRewardedVideoClosedExpanderTemplate);
            OnRewardedVideoClosedExpander.Click.RegisterHandler(() => OnRewardedVideoClosedExpander.IsExpanded = !OnRewardedVideoClosedExpander.IsExpanded);

            // binding <Expander IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnRewardedVideoClosedExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnRewardedVideoClosedExpander }), () => OnRewardedVideoClosedExpander.IsActive = IsRewardedAd, () => { }, false));

            // templates for OnRewardedVideoClosedExpander
            OnRewardedVideoClosedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader12 = new ExpanderHeader(this, OnRewardedVideoClosedExpander.Content, "ExpanderHeader12", ExpanderHeader12Template);
                var region27 = new Region(this, expanderHeader12.Content, "Region27", Region27Template);
                var onRewardedVideoClosedExpanderMPEventChevron = new Image(this, region27.Content, "OnRewardedVideoClosedExpanderMPEventChevron", OnRewardedVideoClosedExpanderMPEventChevronTemplate);
                expanderHeader12.SetExpanderState.SetValue(onRewardedVideoClosedExpanderMPEventChevron, true);
                var onRewardedVideoClosedExpanderCheckImage = new Image(this, region27.Content, "OnRewardedVideoClosedExpanderCheckImage", OnRewardedVideoClosedExpanderCheckImageTemplate);
                var onRewardedVideoClosedExpanderEventLabel = new Label(this, region27.Content, "OnRewardedVideoClosedExpanderEventLabel", OnRewardedVideoClosedExpanderEventLabelTemplate);
                expanderHeader12.IsDynamic = true;
                expanderHeader12.SetContentTemplateData(x0);
                return expanderHeader12;
            }, typeof(ExpanderHeader), "ExpanderHeader12"));

            // templates for OnRewardedVideoClosedExpander
            OnRewardedVideoClosedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent12 = new ExpanderContent(this, OnRewardedVideoClosedExpander.Content, "ExpanderContent12", ExpanderContent12Template);
                var onRewardedVideoClosedExpanderAdUnitIdLabel = new Label(this, expanderContent12.Content, "OnRewardedVideoClosedExpanderAdUnitIdLabel", OnRewardedVideoClosedExpanderAdUnitIdLabelTemplate);
                expanderContent12.IsDynamic = true;
                expanderContent12.SetContentTemplateData(x0);
                return expanderContent12;
            }, typeof(ExpanderContent), "ExpanderContent12"));
            Region28 = new Region(this, Group1.Content, "Region28", Region28Template);

            // binding <Region IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region28", "IsActive" }, new List<Func<object>> { () => this, () => Region28 }), () => Region28.IsActive = IsRewardedAd, () => { }, false));
            OnRewardedVideoReceivedRewardExpander = new Expander(this, Group1.Content, "OnRewardedVideoReceivedRewardExpander", OnRewardedVideoReceivedRewardExpanderTemplate);
            OnRewardedVideoReceivedRewardExpander.Click.RegisterHandler(() => OnRewardedVideoReceivedRewardExpander.IsExpanded = !OnRewardedVideoReceivedRewardExpander.IsExpanded);

            // binding <Expander IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnRewardedVideoReceivedRewardExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnRewardedVideoReceivedRewardExpander }), () => OnRewardedVideoReceivedRewardExpander.IsActive = IsRewardedAd, () => { }, false));

            // templates for OnRewardedVideoReceivedRewardExpander
            OnRewardedVideoReceivedRewardExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader13 = new ExpanderHeader(this, OnRewardedVideoReceivedRewardExpander.Content, "ExpanderHeader13", ExpanderHeader13Template);
                var region29 = new Region(this, expanderHeader13.Content, "Region29", Region29Template);
                var onRewardedVideoReceivedRewardExpanderMPEventChevron = new Image(this, region29.Content, "OnRewardedVideoReceivedRewardExpanderMPEventChevron", OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplate);
                expanderHeader13.SetExpanderState.SetValue(onRewardedVideoReceivedRewardExpanderMPEventChevron, true);
                var onRewardedVideoReceivedRewardExpanderCheckImage = new Image(this, region29.Content, "OnRewardedVideoReceivedRewardExpanderCheckImage", OnRewardedVideoReceivedRewardExpanderCheckImageTemplate);
                var onRewardedVideoReceivedRewardExpanderEventLabel = new Label(this, region29.Content, "OnRewardedVideoReceivedRewardExpanderEventLabel", OnRewardedVideoReceivedRewardExpanderEventLabelTemplate);
                expanderHeader13.IsDynamic = true;
                expanderHeader13.SetContentTemplateData(x0);
                return expanderHeader13;
            }, typeof(ExpanderHeader), "ExpanderHeader13"));

            // templates for OnRewardedVideoReceivedRewardExpander
            OnRewardedVideoReceivedRewardExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent13 = new ExpanderContent(this, OnRewardedVideoReceivedRewardExpander.Content, "ExpanderContent13", ExpanderContent13Template);
                var group6 = new Group(this, expanderContent13.Content, "Group6", Group6Template);
                var onRewardedVideoReceivedRewardExpanderAdUnitIdLabel = new Label(this, group6.Content, "OnRewardedVideoReceivedRewardExpanderAdUnitIdLabel", OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplate);
                var onRewardedVideoReceivedRewardExpanderLabelLabel = new Label(this, group6.Content, "OnRewardedVideoReceivedRewardExpanderLabelLabel", OnRewardedVideoReceivedRewardExpanderLabelLabelTemplate);
                var onRewardedVideoReceivedRewardExpanderAmountLabel = new Label(this, group6.Content, "OnRewardedVideoReceivedRewardExpanderAmountLabel", OnRewardedVideoReceivedRewardExpanderAmountLabelTemplate);
                expanderContent13.IsDynamic = true;
                expanderContent13.SetContentTemplateData(x0);
                return expanderContent13;
            }, typeof(ExpanderContent), "ExpanderContent13"));
            Region30 = new Region(this, Group1.Content, "Region30", Region30Template);

            // binding <Region IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region30", "IsActive" }, new List<Func<object>> { () => this, () => Region30 }), () => Region30.IsActive = IsRewardedAd, () => { }, false));
            OnRewardedVideoFailedToPlayExpander = new Expander(this, Group1.Content, "OnRewardedVideoFailedToPlayExpander", OnRewardedVideoFailedToPlayExpanderTemplate);
            OnRewardedVideoFailedToPlayExpander.Click.RegisterHandler(() => OnRewardedVideoFailedToPlayExpander.IsExpanded = !OnRewardedVideoFailedToPlayExpander.IsExpanded);

            // binding <Expander IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnRewardedVideoFailedToPlayExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnRewardedVideoFailedToPlayExpander }), () => OnRewardedVideoFailedToPlayExpander.IsActive = IsRewardedAd, () => { }, false));

            // templates for OnRewardedVideoFailedToPlayExpander
            OnRewardedVideoFailedToPlayExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader14 = new ExpanderHeader(this, OnRewardedVideoFailedToPlayExpander.Content, "ExpanderHeader14", ExpanderHeader14Template);
                var region31 = new Region(this, expanderHeader14.Content, "Region31", Region31Template);
                var onRewardedVideoFailedToPlayExpanderMPEventChevron = new Image(this, region31.Content, "OnRewardedVideoFailedToPlayExpanderMPEventChevron", OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplate);
                expanderHeader14.SetExpanderState.SetValue(onRewardedVideoFailedToPlayExpanderMPEventChevron, true);
                var onRewardedVideoFailedToPlayExpanderCheckImage = new Image(this, region31.Content, "OnRewardedVideoFailedToPlayExpanderCheckImage", OnRewardedVideoFailedToPlayExpanderCheckImageTemplate);
                var onRewardedVideoFailedToPlayExpanderEventLabel = new Label(this, region31.Content, "OnRewardedVideoFailedToPlayExpanderEventLabel", OnRewardedVideoFailedToPlayExpanderEventLabelTemplate);
                expanderHeader14.IsDynamic = true;
                expanderHeader14.SetContentTemplateData(x0);
                return expanderHeader14;
            }, typeof(ExpanderHeader), "ExpanderHeader14"));

            // templates for OnRewardedVideoFailedToPlayExpander
            OnRewardedVideoFailedToPlayExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent14 = new ExpanderContent(this, OnRewardedVideoFailedToPlayExpander.Content, "ExpanderContent14", ExpanderContent14Template);
                var group7 = new Group(this, expanderContent14.Content, "Group7", Group7Template);
                var onRewardedVideoFailedToPlayExpanderAdUnitIdLabel = new Label(this, group7.Content, "OnRewardedVideoFailedToPlayExpanderAdUnitIdLabel", OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplate);
                var onRewardedVideoFailedToPlayExpanderErrorLabel = new Label(this, group7.Content, "OnRewardedVideoFailedToPlayExpanderErrorLabel", OnRewardedVideoFailedToPlayExpanderErrorLabelTemplate);
                expanderContent14.IsDynamic = true;
                expanderContent14.SetContentTemplateData(x0);
                return expanderContent14;
            }, typeof(ExpanderContent), "ExpanderContent14"));
            Region32 = new Region(this, Group1.Content, "Region32", Region32Template);

            // binding <Region IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region32", "IsActive" }, new List<Func<object>> { () => this, () => Region32 }), () => Region32.IsActive = IsRewardedAd, () => { }, false));
            OnRewardedVideoFailedEventExpander = new Expander(this, Group1.Content, "OnRewardedVideoFailedEventExpander", OnRewardedVideoFailedEventExpanderTemplate);
            OnRewardedVideoFailedEventExpander.Click.RegisterHandler(() => OnRewardedVideoFailedEventExpander.IsExpanded = !OnRewardedVideoFailedEventExpander.IsExpanded);

            // binding <Expander IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "OnRewardedVideoFailedEventExpander", "IsActive" }, new List<Func<object>> { () => this, () => OnRewardedVideoFailedEventExpander }), () => OnRewardedVideoFailedEventExpander.IsActive = IsRewardedAd, () => { }, false));

            // templates for OnRewardedVideoFailedEventExpander
            OnRewardedVideoFailedEventExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader15 = new ExpanderHeader(this, OnRewardedVideoFailedEventExpander.Content, "ExpanderHeader15", ExpanderHeader15Template);
                var region33 = new Region(this, expanderHeader15.Content, "Region33", Region33Template);
                var onRewardedVideoFailedEventExpanderMPEventChevron = new Image(this, region33.Content, "OnRewardedVideoFailedEventExpanderMPEventChevron", OnRewardedVideoFailedEventExpanderMPEventChevronTemplate);
                expanderHeader15.SetExpanderState.SetValue(onRewardedVideoFailedEventExpanderMPEventChevron, true);
                var onRewardedVideoFailedEventExpanderCheckImage = new Image(this, region33.Content, "OnRewardedVideoFailedEventExpanderCheckImage", OnRewardedVideoFailedEventExpanderCheckImageTemplate);
                var onRewardedVideoFailedEventExpanderEventLabel = new Label(this, region33.Content, "OnRewardedVideoFailedEventExpanderEventLabel", OnRewardedVideoFailedEventExpanderEventLabelTemplate);
                expanderHeader15.IsDynamic = true;
                expanderHeader15.SetContentTemplateData(x0);
                return expanderHeader15;
            }, typeof(ExpanderHeader), "ExpanderHeader15"));

            // templates for OnRewardedVideoFailedEventExpander
            OnRewardedVideoFailedEventExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent15 = new ExpanderContent(this, OnRewardedVideoFailedEventExpander.Content, "ExpanderContent15", ExpanderContent15Template);
                var group8 = new Group(this, expanderContent15.Content, "Group8", Group8Template);
                var onRewardedVideoFailedEventExpanderAdUnitIdLabel = new Label(this, group8.Content, "OnRewardedVideoFailedEventExpanderAdUnitIdLabel", OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplate);
                var onRewardedVideoFailedEventExpanderErrorLabel = new Label(this, group8.Content, "OnRewardedVideoFailedEventExpanderErrorLabel", OnRewardedVideoFailedEventExpanderErrorLabelTemplate);
                expanderContent15.IsDynamic = true;
                expanderContent15.SetContentTemplateData(x0);
                return expanderContent15;
            }, typeof(ExpanderContent), "ExpanderContent15"));
            Region34 = new Region(this, Group1.Content, "Region34", Region34Template);

            // binding <Region IsActive="{IsRewardedAd}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "IsRewardedAd" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region34", "IsActive" }, new List<Func<object>> { () => this, () => Region34 }), () => Region34.IsActive = IsRewardedAd, () => { }, false));
            OnImpressionTrackedBgExpander = new Expander(this, Group1.Content, "OnImpressionTrackedBgExpander", OnImpressionTrackedBgExpanderTemplate);
            OnImpressionTrackedBgExpander.Click.RegisterHandler(() => OnImpressionTrackedBgExpander.IsExpanded = !OnImpressionTrackedBgExpander.IsExpanded);

            // templates for OnImpressionTrackedBgExpander
            OnImpressionTrackedBgExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader16 = new ExpanderHeader(this, OnImpressionTrackedBgExpander.Content, "ExpanderHeader16", ExpanderHeader16Template);
                var region35 = new Region(this, expanderHeader16.Content, "Region35", Region35Template);
                var onImpressionTrackedBgExpanderMPEventChevron = new Image(this, region35.Content, "OnImpressionTrackedBgExpanderMPEventChevron", OnImpressionTrackedBgExpanderMPEventChevronTemplate);
                expanderHeader16.SetExpanderState.SetValue(onImpressionTrackedBgExpanderMPEventChevron, true);
                var onImpressionTrackedBgExpanderCheckImage = new Image(this, region35.Content, "OnImpressionTrackedBgExpanderCheckImage", OnImpressionTrackedBgExpanderCheckImageTemplate);
                var onImpressionTrackedBgExpanderEventLabel = new Label(this, region35.Content, "OnImpressionTrackedBgExpanderEventLabel", OnImpressionTrackedBgExpanderEventLabelTemplate);
                expanderHeader16.IsDynamic = true;
                expanderHeader16.SetContentTemplateData(x0);
                return expanderHeader16;
            }, typeof(ExpanderHeader), "ExpanderHeader16"));

            // templates for OnImpressionTrackedBgExpander
            OnImpressionTrackedBgExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent16 = new ExpanderContent(this, OnImpressionTrackedBgExpander.Content, "ExpanderContent16", ExpanderContent16Template);
                var group9 = new Group(this, expanderContent16.Content, "Group9", Group9Template);
                var onImpressionTrackedBgExpanderAdUnitIdLabel = new Label(this, group9.Content, "OnImpressionTrackedBgExpanderAdUnitIdLabel", OnImpressionTrackedBgExpanderAdUnitIdLabelTemplate);
                var onImpressionTrackedBgExpanderImpressionDataField = new InputField(this, group9.Content, "OnImpressionTrackedBgExpanderImpressionDataField", OnImpressionTrackedBgExpanderImpressionDataFieldTemplate);
                expanderContent16.IsDynamic = true;
                expanderContent16.SetContentTemplateData(x0);
                return expanderContent16;
            }, typeof(ExpanderContent), "ExpanderContent16"));
            Region36 = new Region(this, Group1.Content, "Region36", Region36Template);
            OnImpressionTrackedExpander = new Expander(this, Group1.Content, "OnImpressionTrackedExpander", OnImpressionTrackedExpanderTemplate);
            OnImpressionTrackedExpander.Click.RegisterHandler(() => OnImpressionTrackedExpander.IsExpanded = !OnImpressionTrackedExpander.IsExpanded);

            // templates for OnImpressionTrackedExpander
            OnImpressionTrackedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderHeader17 = new ExpanderHeader(this, OnImpressionTrackedExpander.Content, "ExpanderHeader17", ExpanderHeader17Template);
                var region37 = new Region(this, expanderHeader17.Content, "Region37", Region37Template);
                var onImpressionTrackedExpanderMPEventChevron = new Image(this, region37.Content, "OnImpressionTrackedExpanderMPEventChevron", OnImpressionTrackedExpanderMPEventChevronTemplate);
                expanderHeader17.SetExpanderState.SetValue(onImpressionTrackedExpanderMPEventChevron, true);
                var onImpressionTrackedExpanderCheckImage = new Image(this, region37.Content, "OnImpressionTrackedExpanderCheckImage", OnImpressionTrackedExpanderCheckImageTemplate);
                var onImpressionTrackedExpanderEventLabel = new Label(this, region37.Content, "OnImpressionTrackedExpanderEventLabel", OnImpressionTrackedExpanderEventLabelTemplate);
                expanderHeader17.IsDynamic = true;
                expanderHeader17.SetContentTemplateData(x0);
                return expanderHeader17;
            }, typeof(ExpanderHeader), "ExpanderHeader17"));

            // templates for OnImpressionTrackedExpander
            OnImpressionTrackedExpander.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expanderContent17 = new ExpanderContent(this, OnImpressionTrackedExpander.Content, "ExpanderContent17", ExpanderContent17Template);
                var group10 = new Group(this, expanderContent17.Content, "Group10", Group10Template);
                var onImpressionTrackedExpanderAdUnitIdLabel = new Label(this, group10.Content, "OnImpressionTrackedExpanderAdUnitIdLabel", OnImpressionTrackedExpanderAdUnitIdLabelTemplate);
                var onImpressionTrackedExpanderImpressionDataField = new InputField(this, group10.Content, "OnImpressionTrackedExpanderImpressionDataField", OnImpressionTrackedExpanderImpressionDataFieldTemplate);
                expanderContent17.IsDynamic = true;
                expanderContent17.SetContentTemplateData(x0);
                return expanderContent17;
            }, typeof(ExpanderContent), "ExpanderContent17"));
            Region38 = new Region(this, Group1.Content, "Region38", Region38Template);
            this.AfterInitializeInternal();
        }

        public MoPubAdUnitView() : this(null)
        {
        }

        static MoPubAdUnitView()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MoPubAdUnitViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(NavigateBackProperty);
            dependencyProperties.Add(AdTypeProperty);
            dependencyProperties.Add(IsBannerProperty);
            dependencyProperties.Add(IsInterstitialProperty);
            dependencyProperties.Add(IsRewardedAdProperty);
            dependencyProperties.Add(Group1Property);
            dependencyProperties.Add(Group1TemplateProperty);
            dependencyProperties.Add(Group2Property);
            dependencyProperties.Add(Group2TemplateProperty);
            dependencyProperties.Add(Image1Property);
            dependencyProperties.Add(Image1TemplateProperty);
            dependencyProperties.Add(Button1Property);
            dependencyProperties.Add(Button1TemplateProperty);
            dependencyProperties.Add(Region1Property);
            dependencyProperties.Add(Region1TemplateProperty);
            dependencyProperties.Add(AdUnitNameProperty);
            dependencyProperties.Add(AdUnitNameTemplateProperty);
            dependencyProperties.Add(Label1Property);
            dependencyProperties.Add(Label1TemplateProperty);
            dependencyProperties.Add(AdUnitIdProperty);
            dependencyProperties.Add(AdUnitIdTemplateProperty);
            dependencyProperties.Add(Region2Property);
            dependencyProperties.Add(Region2TemplateProperty);
            dependencyProperties.Add(KeywordsProperty);
            dependencyProperties.Add(KeywordsTemplateProperty);
            dependencyProperties.Add(KeywordsDelimiterProperty);
            dependencyProperties.Add(KeywordsDelimiterTemplateProperty);
            dependencyProperties.Add(UserDataKeywordsProperty);
            dependencyProperties.Add(UserDataKeywordsTemplateProperty);
            dependencyProperties.Add(UserDataKeywordsDelimiterProperty);
            dependencyProperties.Add(UserDataKeywordsDelimiterTemplateProperty);
            dependencyProperties.Add(Region3Property);
            dependencyProperties.Add(Region3TemplateProperty);
            dependencyProperties.Add(LoadAdButtonProperty);
            dependencyProperties.Add(LoadAdButtonTemplateProperty);
            dependencyProperties.Add(ShowAdButtonProperty);
            dependencyProperties.Add(ShowAdButtonTemplateProperty);
            dependencyProperties.Add(Region4Property);
            dependencyProperties.Add(Region4TemplateProperty);
            dependencyProperties.Add(OnAdLoadedExpanderProperty);
            dependencyProperties.Add(OnAdLoadedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader1Property);
            dependencyProperties.Add(ExpanderHeader1TemplateProperty);
            dependencyProperties.Add(Region5Property);
            dependencyProperties.Add(Region5TemplateProperty);
            dependencyProperties.Add(OnAdLoadedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnAdLoadedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnAdLoadedExpanderCheckImageProperty);
            dependencyProperties.Add(OnAdLoadedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnAdLoadedExpanderEventLabelProperty);
            dependencyProperties.Add(OnAdLoadedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent1Property);
            dependencyProperties.Add(ExpanderContent1TemplateProperty);
            dependencyProperties.Add(Group3Property);
            dependencyProperties.Add(Group3TemplateProperty);
            dependencyProperties.Add(OnAdLoadedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnAdLoadedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(OnAdLoadedExpanderHeightLabelProperty);
            dependencyProperties.Add(OnAdLoadedExpanderHeightLabelTemplateProperty);
            dependencyProperties.Add(Region6Property);
            dependencyProperties.Add(Region6TemplateProperty);
            dependencyProperties.Add(OnAdClickedExpanderProperty);
            dependencyProperties.Add(OnAdClickedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader2Property);
            dependencyProperties.Add(ExpanderHeader2TemplateProperty);
            dependencyProperties.Add(Region7Property);
            dependencyProperties.Add(Region7TemplateProperty);
            dependencyProperties.Add(OnAdClickedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnAdClickedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnAdClickedExpanderCheckImageProperty);
            dependencyProperties.Add(OnAdClickedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnAdClickedExpanderEventLabelProperty);
            dependencyProperties.Add(OnAdClickedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent2Property);
            dependencyProperties.Add(ExpanderContent2TemplateProperty);
            dependencyProperties.Add(OnAdClickedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnAdClickedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region8Property);
            dependencyProperties.Add(Region8TemplateProperty);
            dependencyProperties.Add(OnAdFailedExpanderProperty);
            dependencyProperties.Add(OnAdFailedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader3Property);
            dependencyProperties.Add(ExpanderHeader3TemplateProperty);
            dependencyProperties.Add(Region9Property);
            dependencyProperties.Add(Region9TemplateProperty);
            dependencyProperties.Add(OnAdFailedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnAdFailedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnAdFailedExpanderCheckImageProperty);
            dependencyProperties.Add(OnAdFailedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnAdFailedExpanderEventLabelProperty);
            dependencyProperties.Add(OnAdFailedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent3Property);
            dependencyProperties.Add(ExpanderContent3TemplateProperty);
            dependencyProperties.Add(Group4Property);
            dependencyProperties.Add(Group4TemplateProperty);
            dependencyProperties.Add(OnAdFailedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnAdFailedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(OnAdFailedExpanderErrorLabelProperty);
            dependencyProperties.Add(OnAdFailedExpanderErrorLabelTemplateProperty);
            dependencyProperties.Add(Region10Property);
            dependencyProperties.Add(Region10TemplateProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader4Property);
            dependencyProperties.Add(ExpanderHeader4TemplateProperty);
            dependencyProperties.Add(Region11Property);
            dependencyProperties.Add(Region11TemplateProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderCheckImageProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderEventLabelProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent4Property);
            dependencyProperties.Add(ExpanderContent4TemplateProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnInterstitialLoadedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region12Property);
            dependencyProperties.Add(Region12TemplateProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader5Property);
            dependencyProperties.Add(ExpanderHeader5TemplateProperty);
            dependencyProperties.Add(Region13Property);
            dependencyProperties.Add(Region13TemplateProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderCheckImageProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderEventLabelProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent5Property);
            dependencyProperties.Add(ExpanderContent5TemplateProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnInterstitialShownExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region14Property);
            dependencyProperties.Add(Region14TemplateProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader6Property);
            dependencyProperties.Add(ExpanderHeader6TemplateProperty);
            dependencyProperties.Add(Region15Property);
            dependencyProperties.Add(Region15TemplateProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderCheckImageProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderEventLabelProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent6Property);
            dependencyProperties.Add(ExpanderContent6TemplateProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnInterstitialClickedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region16Property);
            dependencyProperties.Add(Region16TemplateProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader7Property);
            dependencyProperties.Add(ExpanderHeader7TemplateProperty);
            dependencyProperties.Add(Region17Property);
            dependencyProperties.Add(Region17TemplateProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderCheckImageProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderEventLabelProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent7Property);
            dependencyProperties.Add(ExpanderContent7TemplateProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnInterstitialDismissedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region18Property);
            dependencyProperties.Add(Region18TemplateProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader8Property);
            dependencyProperties.Add(ExpanderHeader8TemplateProperty);
            dependencyProperties.Add(Region19Property);
            dependencyProperties.Add(Region19TemplateProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderCheckImageProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderEventLabelProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent8Property);
            dependencyProperties.Add(ExpanderContent8TemplateProperty);
            dependencyProperties.Add(Group5Property);
            dependencyProperties.Add(Group5TemplateProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderErrorLabelProperty);
            dependencyProperties.Add(OnInterstitialFailedExpanderErrorLabelTemplateProperty);
            dependencyProperties.Add(Region20Property);
            dependencyProperties.Add(Region20TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader9Property);
            dependencyProperties.Add(ExpanderHeader9TemplateProperty);
            dependencyProperties.Add(Region21Property);
            dependencyProperties.Add(Region21TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderCheckImageProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderEventLabelProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent9Property);
            dependencyProperties.Add(ExpanderContent9TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region22Property);
            dependencyProperties.Add(Region22TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader10Property);
            dependencyProperties.Add(ExpanderHeader10TemplateProperty);
            dependencyProperties.Add(Region23Property);
            dependencyProperties.Add(Region23TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderCheckImageProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderEventLabelProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent10Property);
            dependencyProperties.Add(ExpanderContent10TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnRewardedVideoShownExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region24Property);
            dependencyProperties.Add(Region24TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader11Property);
            dependencyProperties.Add(ExpanderHeader11TemplateProperty);
            dependencyProperties.Add(Region25Property);
            dependencyProperties.Add(Region25TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderCheckImageProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderEventLabelProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent11Property);
            dependencyProperties.Add(ExpanderContent11TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnRewardedVideoClickedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region26Property);
            dependencyProperties.Add(Region26TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader12Property);
            dependencyProperties.Add(ExpanderHeader12TemplateProperty);
            dependencyProperties.Add(Region27Property);
            dependencyProperties.Add(Region27TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderCheckImageProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderEventLabelProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent12Property);
            dependencyProperties.Add(ExpanderContent12TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnRewardedVideoClosedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(Region28Property);
            dependencyProperties.Add(Region28TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader13Property);
            dependencyProperties.Add(ExpanderHeader13TemplateProperty);
            dependencyProperties.Add(Region29Property);
            dependencyProperties.Add(Region29TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderCheckImageProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderEventLabelProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent13Property);
            dependencyProperties.Add(ExpanderContent13TemplateProperty);
            dependencyProperties.Add(Group6Property);
            dependencyProperties.Add(Group6TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderLabelLabelProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderLabelLabelTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderAmountLabelProperty);
            dependencyProperties.Add(OnRewardedVideoReceivedRewardExpanderAmountLabelTemplateProperty);
            dependencyProperties.Add(Region30Property);
            dependencyProperties.Add(Region30TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader14Property);
            dependencyProperties.Add(ExpanderHeader14TemplateProperty);
            dependencyProperties.Add(Region31Property);
            dependencyProperties.Add(Region31TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderCheckImageProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderEventLabelProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent14Property);
            dependencyProperties.Add(ExpanderContent14TemplateProperty);
            dependencyProperties.Add(Group7Property);
            dependencyProperties.Add(Group7TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderErrorLabelProperty);
            dependencyProperties.Add(OnRewardedVideoFailedToPlayExpanderErrorLabelTemplateProperty);
            dependencyProperties.Add(Region32Property);
            dependencyProperties.Add(Region32TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader15Property);
            dependencyProperties.Add(ExpanderHeader15TemplateProperty);
            dependencyProperties.Add(Region33Property);
            dependencyProperties.Add(Region33TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderCheckImageProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderEventLabelProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent15Property);
            dependencyProperties.Add(ExpanderContent15TemplateProperty);
            dependencyProperties.Add(Group8Property);
            dependencyProperties.Add(Group8TemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderErrorLabelProperty);
            dependencyProperties.Add(OnRewardedVideoFailedEventExpanderErrorLabelTemplateProperty);
            dependencyProperties.Add(Region34Property);
            dependencyProperties.Add(Region34TemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader16Property);
            dependencyProperties.Add(ExpanderHeader16TemplateProperty);
            dependencyProperties.Add(Region35Property);
            dependencyProperties.Add(Region35TemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderCheckImageProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderEventLabelProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent16Property);
            dependencyProperties.Add(ExpanderContent16TemplateProperty);
            dependencyProperties.Add(Group9Property);
            dependencyProperties.Add(Group9TemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderImpressionDataFieldProperty);
            dependencyProperties.Add(OnImpressionTrackedBgExpanderImpressionDataFieldTemplateProperty);
            dependencyProperties.Add(Region36Property);
            dependencyProperties.Add(Region36TemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderTemplateProperty);
            dependencyProperties.Add(ExpanderHeader17Property);
            dependencyProperties.Add(ExpanderHeader17TemplateProperty);
            dependencyProperties.Add(Region37Property);
            dependencyProperties.Add(Region37TemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderMPEventChevronProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderMPEventChevronTemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderCheckImageProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderCheckImageTemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderEventLabelProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderEventLabelTemplateProperty);
            dependencyProperties.Add(ExpanderContent17Property);
            dependencyProperties.Add(ExpanderContent17TemplateProperty);
            dependencyProperties.Add(Group10Property);
            dependencyProperties.Add(Group10TemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderAdUnitIdLabelProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderAdUnitIdLabelTemplateProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderImpressionDataFieldProperty);
            dependencyProperties.Add(OnImpressionTrackedExpanderImpressionDataFieldTemplateProperty);
            dependencyProperties.Add(Region38Property);
            dependencyProperties.Add(Region38TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<ViewAction> NavigateBackProperty = new DependencyProperty<ViewAction>("NavigateBack", () => new ViewAction());
        public ViewAction NavigateBack
        {
            get { return NavigateBackProperty.GetValue(this); }
            set { NavigateBackProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.String> AdTypeProperty = new DependencyProperty<System.String>("AdType");
        public System.String AdType
        {
            get { return AdTypeProperty.GetValue(this); }
            set { AdTypeProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> IsBannerProperty = new DependencyProperty<System.Boolean>("IsBanner");
        public System.Boolean IsBanner
        {
            get { return IsBannerProperty.GetValue(this); }
            set { IsBannerProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> IsInterstitialProperty = new DependencyProperty<System.Boolean>("IsInterstitial");
        public System.Boolean IsInterstitial
        {
            get { return IsInterstitialProperty.GetValue(this); }
            set { IsInterstitialProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> IsRewardedAdProperty = new DependencyProperty<System.Boolean>("IsRewardedAd");
        public System.Boolean IsRewardedAd
        {
            get { return IsRewardedAdProperty.GetValue(this); }
            set { IsRewardedAdProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group1Property = new DependencyProperty<Group>("Group1");
        public Group Group1
        {
            get { return Group1Property.GetValue(this); }
            set { Group1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group1TemplateProperty = new DependencyProperty<Template>("Group1Template");
        public Template Group1Template
        {
            get { return Group1TemplateProperty.GetValue(this); }
            set { Group1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group2Property = new DependencyProperty<Group>("Group2");
        public Group Group2
        {
            get { return Group2Property.GetValue(this); }
            set { Group2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group2TemplateProperty = new DependencyProperty<Template>("Group2Template");
        public Template Group2Template
        {
            get { return Group2TemplateProperty.GetValue(this); }
            set { Group2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> Image1Property = new DependencyProperty<Image>("Image1");
        public Image Image1
        {
            get { return Image1Property.GetValue(this); }
            set { Image1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Image1TemplateProperty = new DependencyProperty<Template>("Image1Template");
        public Template Image1Template
        {
            get { return Image1TemplateProperty.GetValue(this); }
            set { Image1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button1Property = new DependencyProperty<Button>("Button1");
        public Button Button1
        {
            get { return Button1Property.GetValue(this); }
            set { Button1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button1TemplateProperty = new DependencyProperty<Template>("Button1Template");
        public Template Button1Template
        {
            get { return Button1TemplateProperty.GetValue(this); }
            set { Button1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region1Property = new DependencyProperty<Region>("Region1");
        public Region Region1
        {
            get { return Region1Property.GetValue(this); }
            set { Region1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region1TemplateProperty = new DependencyProperty<Template>("Region1Template");
        public Template Region1Template
        {
            get { return Region1TemplateProperty.GetValue(this); }
            set { Region1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> AdUnitNameProperty = new DependencyProperty<Label>("AdUnitName");
        public Label AdUnitName
        {
            get { return AdUnitNameProperty.GetValue(this); }
            set { AdUnitNameProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> AdUnitNameTemplateProperty = new DependencyProperty<Template>("AdUnitNameTemplate");
        public Template AdUnitNameTemplate
        {
            get { return AdUnitNameTemplateProperty.GetValue(this); }
            set { AdUnitNameTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label1Property = new DependencyProperty<Label>("Label1");
        public Label Label1
        {
            get { return Label1Property.GetValue(this); }
            set { Label1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label1TemplateProperty = new DependencyProperty<Template>("Label1Template");
        public Template Label1Template
        {
            get { return Label1TemplateProperty.GetValue(this); }
            set { Label1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> AdUnitIdProperty = new DependencyProperty<Label>("AdUnitId");
        public Label AdUnitId
        {
            get { return AdUnitIdProperty.GetValue(this); }
            set { AdUnitIdProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> AdUnitIdTemplateProperty = new DependencyProperty<Template>("AdUnitIdTemplate");
        public Template AdUnitIdTemplate
        {
            get { return AdUnitIdTemplateProperty.GetValue(this); }
            set { AdUnitIdTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region2Property = new DependencyProperty<Region>("Region2");
        public Region Region2
        {
            get { return Region2Property.GetValue(this); }
            set { Region2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region2TemplateProperty = new DependencyProperty<Template>("Region2Template");
        public Template Region2Template
        {
            get { return Region2TemplateProperty.GetValue(this); }
            set { Region2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<InputField> KeywordsProperty = new DependencyProperty<InputField>("Keywords");
        public InputField Keywords
        {
            get { return KeywordsProperty.GetValue(this); }
            set { KeywordsProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> KeywordsTemplateProperty = new DependencyProperty<Template>("KeywordsTemplate");
        public Template KeywordsTemplate
        {
            get { return KeywordsTemplateProperty.GetValue(this); }
            set { KeywordsTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> KeywordsDelimiterProperty = new DependencyProperty<Region>("KeywordsDelimiter");
        public Region KeywordsDelimiter
        {
            get { return KeywordsDelimiterProperty.GetValue(this); }
            set { KeywordsDelimiterProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> KeywordsDelimiterTemplateProperty = new DependencyProperty<Template>("KeywordsDelimiterTemplate");
        public Template KeywordsDelimiterTemplate
        {
            get { return KeywordsDelimiterTemplateProperty.GetValue(this); }
            set { KeywordsDelimiterTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<InputField> UserDataKeywordsProperty = new DependencyProperty<InputField>("UserDataKeywords");
        public InputField UserDataKeywords
        {
            get { return UserDataKeywordsProperty.GetValue(this); }
            set { UserDataKeywordsProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> UserDataKeywordsTemplateProperty = new DependencyProperty<Template>("UserDataKeywordsTemplate");
        public Template UserDataKeywordsTemplate
        {
            get { return UserDataKeywordsTemplateProperty.GetValue(this); }
            set { UserDataKeywordsTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> UserDataKeywordsDelimiterProperty = new DependencyProperty<Region>("UserDataKeywordsDelimiter");
        public Region UserDataKeywordsDelimiter
        {
            get { return UserDataKeywordsDelimiterProperty.GetValue(this); }
            set { UserDataKeywordsDelimiterProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> UserDataKeywordsDelimiterTemplateProperty = new DependencyProperty<Template>("UserDataKeywordsDelimiterTemplate");
        public Template UserDataKeywordsDelimiterTemplate
        {
            get { return UserDataKeywordsDelimiterTemplateProperty.GetValue(this); }
            set { UserDataKeywordsDelimiterTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region3Property = new DependencyProperty<Region>("Region3");
        public Region Region3
        {
            get { return Region3Property.GetValue(this); }
            set { Region3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region3TemplateProperty = new DependencyProperty<Template>("Region3Template");
        public Template Region3Template
        {
            get { return Region3TemplateProperty.GetValue(this); }
            set { Region3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> LoadAdButtonProperty = new DependencyProperty<Button>("LoadAdButton");
        public Button LoadAdButton
        {
            get { return LoadAdButtonProperty.GetValue(this); }
            set { LoadAdButtonProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> LoadAdButtonTemplateProperty = new DependencyProperty<Template>("LoadAdButtonTemplate");
        public Template LoadAdButtonTemplate
        {
            get { return LoadAdButtonTemplateProperty.GetValue(this); }
            set { LoadAdButtonTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> ShowAdButtonProperty = new DependencyProperty<Button>("ShowAdButton");
        public Button ShowAdButton
        {
            get { return ShowAdButtonProperty.GetValue(this); }
            set { ShowAdButtonProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ShowAdButtonTemplateProperty = new DependencyProperty<Template>("ShowAdButtonTemplate");
        public Template ShowAdButtonTemplate
        {
            get { return ShowAdButtonTemplateProperty.GetValue(this); }
            set { ShowAdButtonTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region4Property = new DependencyProperty<Region>("Region4");
        public Region Region4
        {
            get { return Region4Property.GetValue(this); }
            set { Region4Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region4TemplateProperty = new DependencyProperty<Template>("Region4Template");
        public Template Region4Template
        {
            get { return Region4TemplateProperty.GetValue(this); }
            set { Region4TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnAdLoadedExpanderProperty = new DependencyProperty<Expander>("OnAdLoadedExpander");
        public Expander OnAdLoadedExpander
        {
            get { return OnAdLoadedExpanderProperty.GetValue(this); }
            set { OnAdLoadedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdLoadedExpanderTemplateProperty = new DependencyProperty<Template>("OnAdLoadedExpanderTemplate");
        public Template OnAdLoadedExpanderTemplate
        {
            get { return OnAdLoadedExpanderTemplateProperty.GetValue(this); }
            set { OnAdLoadedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader1Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader1");
        public ExpanderHeader ExpanderHeader1
        {
            get { return ExpanderHeader1Property.GetValue(this); }
            set { ExpanderHeader1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader1TemplateProperty = new DependencyProperty<Template>("ExpanderHeader1Template");
        public Template ExpanderHeader1Template
        {
            get { return ExpanderHeader1TemplateProperty.GetValue(this); }
            set { ExpanderHeader1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region5Property = new DependencyProperty<Region>("Region5");
        public Region Region5
        {
            get { return Region5Property.GetValue(this); }
            set { Region5Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region5TemplateProperty = new DependencyProperty<Template>("Region5Template");
        public Template Region5Template
        {
            get { return Region5TemplateProperty.GetValue(this); }
            set { Region5TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnAdLoadedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnAdLoadedExpanderMPEventChevron");
        public Image OnAdLoadedExpanderMPEventChevron
        {
            get { return OnAdLoadedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnAdLoadedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdLoadedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnAdLoadedExpanderMPEventChevronTemplate");
        public Template OnAdLoadedExpanderMPEventChevronTemplate
        {
            get { return OnAdLoadedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnAdLoadedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnAdLoadedExpanderCheckImageProperty = new DependencyProperty<Image>("OnAdLoadedExpanderCheckImage");
        public Image OnAdLoadedExpanderCheckImage
        {
            get { return OnAdLoadedExpanderCheckImageProperty.GetValue(this); }
            set { OnAdLoadedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdLoadedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnAdLoadedExpanderCheckImageTemplate");
        public Template OnAdLoadedExpanderCheckImageTemplate
        {
            get { return OnAdLoadedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnAdLoadedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnAdLoadedExpanderEventLabelProperty = new DependencyProperty<Label>("OnAdLoadedExpanderEventLabel");
        public Label OnAdLoadedExpanderEventLabel
        {
            get { return OnAdLoadedExpanderEventLabelProperty.GetValue(this); }
            set { OnAdLoadedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdLoadedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnAdLoadedExpanderEventLabelTemplate");
        public Template OnAdLoadedExpanderEventLabelTemplate
        {
            get { return OnAdLoadedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnAdLoadedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent1Property = new DependencyProperty<ExpanderContent>("ExpanderContent1");
        public ExpanderContent ExpanderContent1
        {
            get { return ExpanderContent1Property.GetValue(this); }
            set { ExpanderContent1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent1TemplateProperty = new DependencyProperty<Template>("ExpanderContent1Template");
        public Template ExpanderContent1Template
        {
            get { return ExpanderContent1TemplateProperty.GetValue(this); }
            set { ExpanderContent1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group3Property = new DependencyProperty<Group>("Group3");
        public Group Group3
        {
            get { return Group3Property.GetValue(this); }
            set { Group3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group3TemplateProperty = new DependencyProperty<Template>("Group3Template");
        public Template Group3Template
        {
            get { return Group3TemplateProperty.GetValue(this); }
            set { Group3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnAdLoadedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnAdLoadedExpanderAdUnitIdLabel");
        public Label OnAdLoadedExpanderAdUnitIdLabel
        {
            get { return OnAdLoadedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnAdLoadedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdLoadedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnAdLoadedExpanderAdUnitIdLabelTemplate");
        public Template OnAdLoadedExpanderAdUnitIdLabelTemplate
        {
            get { return OnAdLoadedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnAdLoadedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnAdLoadedExpanderHeightLabelProperty = new DependencyProperty<Label>("OnAdLoadedExpanderHeightLabel");
        public Label OnAdLoadedExpanderHeightLabel
        {
            get { return OnAdLoadedExpanderHeightLabelProperty.GetValue(this); }
            set { OnAdLoadedExpanderHeightLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdLoadedExpanderHeightLabelTemplateProperty = new DependencyProperty<Template>("OnAdLoadedExpanderHeightLabelTemplate");
        public Template OnAdLoadedExpanderHeightLabelTemplate
        {
            get { return OnAdLoadedExpanderHeightLabelTemplateProperty.GetValue(this); }
            set { OnAdLoadedExpanderHeightLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region6Property = new DependencyProperty<Region>("Region6");
        public Region Region6
        {
            get { return Region6Property.GetValue(this); }
            set { Region6Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region6TemplateProperty = new DependencyProperty<Template>("Region6Template");
        public Template Region6Template
        {
            get { return Region6TemplateProperty.GetValue(this); }
            set { Region6TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnAdClickedExpanderProperty = new DependencyProperty<Expander>("OnAdClickedExpander");
        public Expander OnAdClickedExpander
        {
            get { return OnAdClickedExpanderProperty.GetValue(this); }
            set { OnAdClickedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdClickedExpanderTemplateProperty = new DependencyProperty<Template>("OnAdClickedExpanderTemplate");
        public Template OnAdClickedExpanderTemplate
        {
            get { return OnAdClickedExpanderTemplateProperty.GetValue(this); }
            set { OnAdClickedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader2Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader2");
        public ExpanderHeader ExpanderHeader2
        {
            get { return ExpanderHeader2Property.GetValue(this); }
            set { ExpanderHeader2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader2TemplateProperty = new DependencyProperty<Template>("ExpanderHeader2Template");
        public Template ExpanderHeader2Template
        {
            get { return ExpanderHeader2TemplateProperty.GetValue(this); }
            set { ExpanderHeader2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region7Property = new DependencyProperty<Region>("Region7");
        public Region Region7
        {
            get { return Region7Property.GetValue(this); }
            set { Region7Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region7TemplateProperty = new DependencyProperty<Template>("Region7Template");
        public Template Region7Template
        {
            get { return Region7TemplateProperty.GetValue(this); }
            set { Region7TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnAdClickedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnAdClickedExpanderMPEventChevron");
        public Image OnAdClickedExpanderMPEventChevron
        {
            get { return OnAdClickedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnAdClickedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdClickedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnAdClickedExpanderMPEventChevronTemplate");
        public Template OnAdClickedExpanderMPEventChevronTemplate
        {
            get { return OnAdClickedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnAdClickedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnAdClickedExpanderCheckImageProperty = new DependencyProperty<Image>("OnAdClickedExpanderCheckImage");
        public Image OnAdClickedExpanderCheckImage
        {
            get { return OnAdClickedExpanderCheckImageProperty.GetValue(this); }
            set { OnAdClickedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdClickedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnAdClickedExpanderCheckImageTemplate");
        public Template OnAdClickedExpanderCheckImageTemplate
        {
            get { return OnAdClickedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnAdClickedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnAdClickedExpanderEventLabelProperty = new DependencyProperty<Label>("OnAdClickedExpanderEventLabel");
        public Label OnAdClickedExpanderEventLabel
        {
            get { return OnAdClickedExpanderEventLabelProperty.GetValue(this); }
            set { OnAdClickedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdClickedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnAdClickedExpanderEventLabelTemplate");
        public Template OnAdClickedExpanderEventLabelTemplate
        {
            get { return OnAdClickedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnAdClickedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent2Property = new DependencyProperty<ExpanderContent>("ExpanderContent2");
        public ExpanderContent ExpanderContent2
        {
            get { return ExpanderContent2Property.GetValue(this); }
            set { ExpanderContent2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent2TemplateProperty = new DependencyProperty<Template>("ExpanderContent2Template");
        public Template ExpanderContent2Template
        {
            get { return ExpanderContent2TemplateProperty.GetValue(this); }
            set { ExpanderContent2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnAdClickedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnAdClickedExpanderAdUnitIdLabel");
        public Label OnAdClickedExpanderAdUnitIdLabel
        {
            get { return OnAdClickedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnAdClickedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdClickedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnAdClickedExpanderAdUnitIdLabelTemplate");
        public Template OnAdClickedExpanderAdUnitIdLabelTemplate
        {
            get { return OnAdClickedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnAdClickedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region8Property = new DependencyProperty<Region>("Region8");
        public Region Region8
        {
            get { return Region8Property.GetValue(this); }
            set { Region8Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region8TemplateProperty = new DependencyProperty<Template>("Region8Template");
        public Template Region8Template
        {
            get { return Region8TemplateProperty.GetValue(this); }
            set { Region8TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnAdFailedExpanderProperty = new DependencyProperty<Expander>("OnAdFailedExpander");
        public Expander OnAdFailedExpander
        {
            get { return OnAdFailedExpanderProperty.GetValue(this); }
            set { OnAdFailedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdFailedExpanderTemplateProperty = new DependencyProperty<Template>("OnAdFailedExpanderTemplate");
        public Template OnAdFailedExpanderTemplate
        {
            get { return OnAdFailedExpanderTemplateProperty.GetValue(this); }
            set { OnAdFailedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader3Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader3");
        public ExpanderHeader ExpanderHeader3
        {
            get { return ExpanderHeader3Property.GetValue(this); }
            set { ExpanderHeader3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader3TemplateProperty = new DependencyProperty<Template>("ExpanderHeader3Template");
        public Template ExpanderHeader3Template
        {
            get { return ExpanderHeader3TemplateProperty.GetValue(this); }
            set { ExpanderHeader3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region9Property = new DependencyProperty<Region>("Region9");
        public Region Region9
        {
            get { return Region9Property.GetValue(this); }
            set { Region9Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region9TemplateProperty = new DependencyProperty<Template>("Region9Template");
        public Template Region9Template
        {
            get { return Region9TemplateProperty.GetValue(this); }
            set { Region9TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnAdFailedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnAdFailedExpanderMPEventChevron");
        public Image OnAdFailedExpanderMPEventChevron
        {
            get { return OnAdFailedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnAdFailedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdFailedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnAdFailedExpanderMPEventChevronTemplate");
        public Template OnAdFailedExpanderMPEventChevronTemplate
        {
            get { return OnAdFailedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnAdFailedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnAdFailedExpanderCheckImageProperty = new DependencyProperty<Image>("OnAdFailedExpanderCheckImage");
        public Image OnAdFailedExpanderCheckImage
        {
            get { return OnAdFailedExpanderCheckImageProperty.GetValue(this); }
            set { OnAdFailedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdFailedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnAdFailedExpanderCheckImageTemplate");
        public Template OnAdFailedExpanderCheckImageTemplate
        {
            get { return OnAdFailedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnAdFailedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnAdFailedExpanderEventLabelProperty = new DependencyProperty<Label>("OnAdFailedExpanderEventLabel");
        public Label OnAdFailedExpanderEventLabel
        {
            get { return OnAdFailedExpanderEventLabelProperty.GetValue(this); }
            set { OnAdFailedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdFailedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnAdFailedExpanderEventLabelTemplate");
        public Template OnAdFailedExpanderEventLabelTemplate
        {
            get { return OnAdFailedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnAdFailedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent3Property = new DependencyProperty<ExpanderContent>("ExpanderContent3");
        public ExpanderContent ExpanderContent3
        {
            get { return ExpanderContent3Property.GetValue(this); }
            set { ExpanderContent3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent3TemplateProperty = new DependencyProperty<Template>("ExpanderContent3Template");
        public Template ExpanderContent3Template
        {
            get { return ExpanderContent3TemplateProperty.GetValue(this); }
            set { ExpanderContent3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group4Property = new DependencyProperty<Group>("Group4");
        public Group Group4
        {
            get { return Group4Property.GetValue(this); }
            set { Group4Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group4TemplateProperty = new DependencyProperty<Template>("Group4Template");
        public Template Group4Template
        {
            get { return Group4TemplateProperty.GetValue(this); }
            set { Group4TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnAdFailedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnAdFailedExpanderAdUnitIdLabel");
        public Label OnAdFailedExpanderAdUnitIdLabel
        {
            get { return OnAdFailedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnAdFailedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdFailedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnAdFailedExpanderAdUnitIdLabelTemplate");
        public Template OnAdFailedExpanderAdUnitIdLabelTemplate
        {
            get { return OnAdFailedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnAdFailedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnAdFailedExpanderErrorLabelProperty = new DependencyProperty<Label>("OnAdFailedExpanderErrorLabel");
        public Label OnAdFailedExpanderErrorLabel
        {
            get { return OnAdFailedExpanderErrorLabelProperty.GetValue(this); }
            set { OnAdFailedExpanderErrorLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnAdFailedExpanderErrorLabelTemplateProperty = new DependencyProperty<Template>("OnAdFailedExpanderErrorLabelTemplate");
        public Template OnAdFailedExpanderErrorLabelTemplate
        {
            get { return OnAdFailedExpanderErrorLabelTemplateProperty.GetValue(this); }
            set { OnAdFailedExpanderErrorLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region10Property = new DependencyProperty<Region>("Region10");
        public Region Region10
        {
            get { return Region10Property.GetValue(this); }
            set { Region10Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region10TemplateProperty = new DependencyProperty<Template>("Region10Template");
        public Template Region10Template
        {
            get { return Region10TemplateProperty.GetValue(this); }
            set { Region10TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnInterstitialLoadedExpanderProperty = new DependencyProperty<Expander>("OnInterstitialLoadedExpander");
        public Expander OnInterstitialLoadedExpander
        {
            get { return OnInterstitialLoadedExpanderProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialLoadedExpanderTemplateProperty = new DependencyProperty<Template>("OnInterstitialLoadedExpanderTemplate");
        public Template OnInterstitialLoadedExpanderTemplate
        {
            get { return OnInterstitialLoadedExpanderTemplateProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader4Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader4");
        public ExpanderHeader ExpanderHeader4
        {
            get { return ExpanderHeader4Property.GetValue(this); }
            set { ExpanderHeader4Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader4TemplateProperty = new DependencyProperty<Template>("ExpanderHeader4Template");
        public Template ExpanderHeader4Template
        {
            get { return ExpanderHeader4TemplateProperty.GetValue(this); }
            set { ExpanderHeader4TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region11Property = new DependencyProperty<Region>("Region11");
        public Region Region11
        {
            get { return Region11Property.GetValue(this); }
            set { Region11Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region11TemplateProperty = new DependencyProperty<Template>("Region11Template");
        public Template Region11Template
        {
            get { return Region11TemplateProperty.GetValue(this); }
            set { Region11TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialLoadedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnInterstitialLoadedExpanderMPEventChevron");
        public Image OnInterstitialLoadedExpanderMPEventChevron
        {
            get { return OnInterstitialLoadedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialLoadedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnInterstitialLoadedExpanderMPEventChevronTemplate");
        public Template OnInterstitialLoadedExpanderMPEventChevronTemplate
        {
            get { return OnInterstitialLoadedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialLoadedExpanderCheckImageProperty = new DependencyProperty<Image>("OnInterstitialLoadedExpanderCheckImage");
        public Image OnInterstitialLoadedExpanderCheckImage
        {
            get { return OnInterstitialLoadedExpanderCheckImageProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialLoadedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnInterstitialLoadedExpanderCheckImageTemplate");
        public Template OnInterstitialLoadedExpanderCheckImageTemplate
        {
            get { return OnInterstitialLoadedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialLoadedExpanderEventLabelProperty = new DependencyProperty<Label>("OnInterstitialLoadedExpanderEventLabel");
        public Label OnInterstitialLoadedExpanderEventLabel
        {
            get { return OnInterstitialLoadedExpanderEventLabelProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialLoadedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialLoadedExpanderEventLabelTemplate");
        public Template OnInterstitialLoadedExpanderEventLabelTemplate
        {
            get { return OnInterstitialLoadedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent4Property = new DependencyProperty<ExpanderContent>("ExpanderContent4");
        public ExpanderContent ExpanderContent4
        {
            get { return ExpanderContent4Property.GetValue(this); }
            set { ExpanderContent4Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent4TemplateProperty = new DependencyProperty<Template>("ExpanderContent4Template");
        public Template ExpanderContent4Template
        {
            get { return ExpanderContent4TemplateProperty.GetValue(this); }
            set { ExpanderContent4TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialLoadedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnInterstitialLoadedExpanderAdUnitIdLabel");
        public Label OnInterstitialLoadedExpanderAdUnitIdLabel
        {
            get { return OnInterstitialLoadedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialLoadedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialLoadedExpanderAdUnitIdLabelTemplate");
        public Template OnInterstitialLoadedExpanderAdUnitIdLabelTemplate
        {
            get { return OnInterstitialLoadedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialLoadedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region12Property = new DependencyProperty<Region>("Region12");
        public Region Region12
        {
            get { return Region12Property.GetValue(this); }
            set { Region12Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region12TemplateProperty = new DependencyProperty<Template>("Region12Template");
        public Template Region12Template
        {
            get { return Region12TemplateProperty.GetValue(this); }
            set { Region12TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnInterstitialShownExpanderProperty = new DependencyProperty<Expander>("OnInterstitialShownExpander");
        public Expander OnInterstitialShownExpander
        {
            get { return OnInterstitialShownExpanderProperty.GetValue(this); }
            set { OnInterstitialShownExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialShownExpanderTemplateProperty = new DependencyProperty<Template>("OnInterstitialShownExpanderTemplate");
        public Template OnInterstitialShownExpanderTemplate
        {
            get { return OnInterstitialShownExpanderTemplateProperty.GetValue(this); }
            set { OnInterstitialShownExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader5Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader5");
        public ExpanderHeader ExpanderHeader5
        {
            get { return ExpanderHeader5Property.GetValue(this); }
            set { ExpanderHeader5Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader5TemplateProperty = new DependencyProperty<Template>("ExpanderHeader5Template");
        public Template ExpanderHeader5Template
        {
            get { return ExpanderHeader5TemplateProperty.GetValue(this); }
            set { ExpanderHeader5TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region13Property = new DependencyProperty<Region>("Region13");
        public Region Region13
        {
            get { return Region13Property.GetValue(this); }
            set { Region13Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region13TemplateProperty = new DependencyProperty<Template>("Region13Template");
        public Template Region13Template
        {
            get { return Region13TemplateProperty.GetValue(this); }
            set { Region13TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialShownExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnInterstitialShownExpanderMPEventChevron");
        public Image OnInterstitialShownExpanderMPEventChevron
        {
            get { return OnInterstitialShownExpanderMPEventChevronProperty.GetValue(this); }
            set { OnInterstitialShownExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialShownExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnInterstitialShownExpanderMPEventChevronTemplate");
        public Template OnInterstitialShownExpanderMPEventChevronTemplate
        {
            get { return OnInterstitialShownExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnInterstitialShownExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialShownExpanderCheckImageProperty = new DependencyProperty<Image>("OnInterstitialShownExpanderCheckImage");
        public Image OnInterstitialShownExpanderCheckImage
        {
            get { return OnInterstitialShownExpanderCheckImageProperty.GetValue(this); }
            set { OnInterstitialShownExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialShownExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnInterstitialShownExpanderCheckImageTemplate");
        public Template OnInterstitialShownExpanderCheckImageTemplate
        {
            get { return OnInterstitialShownExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnInterstitialShownExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialShownExpanderEventLabelProperty = new DependencyProperty<Label>("OnInterstitialShownExpanderEventLabel");
        public Label OnInterstitialShownExpanderEventLabel
        {
            get { return OnInterstitialShownExpanderEventLabelProperty.GetValue(this); }
            set { OnInterstitialShownExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialShownExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialShownExpanderEventLabelTemplate");
        public Template OnInterstitialShownExpanderEventLabelTemplate
        {
            get { return OnInterstitialShownExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialShownExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent5Property = new DependencyProperty<ExpanderContent>("ExpanderContent5");
        public ExpanderContent ExpanderContent5
        {
            get { return ExpanderContent5Property.GetValue(this); }
            set { ExpanderContent5Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent5TemplateProperty = new DependencyProperty<Template>("ExpanderContent5Template");
        public Template ExpanderContent5Template
        {
            get { return ExpanderContent5TemplateProperty.GetValue(this); }
            set { ExpanderContent5TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialShownExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnInterstitialShownExpanderAdUnitIdLabel");
        public Label OnInterstitialShownExpanderAdUnitIdLabel
        {
            get { return OnInterstitialShownExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnInterstitialShownExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialShownExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialShownExpanderAdUnitIdLabelTemplate");
        public Template OnInterstitialShownExpanderAdUnitIdLabelTemplate
        {
            get { return OnInterstitialShownExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialShownExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region14Property = new DependencyProperty<Region>("Region14");
        public Region Region14
        {
            get { return Region14Property.GetValue(this); }
            set { Region14Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region14TemplateProperty = new DependencyProperty<Template>("Region14Template");
        public Template Region14Template
        {
            get { return Region14TemplateProperty.GetValue(this); }
            set { Region14TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnInterstitialClickedExpanderProperty = new DependencyProperty<Expander>("OnInterstitialClickedExpander");
        public Expander OnInterstitialClickedExpander
        {
            get { return OnInterstitialClickedExpanderProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialClickedExpanderTemplateProperty = new DependencyProperty<Template>("OnInterstitialClickedExpanderTemplate");
        public Template OnInterstitialClickedExpanderTemplate
        {
            get { return OnInterstitialClickedExpanderTemplateProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader6Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader6");
        public ExpanderHeader ExpanderHeader6
        {
            get { return ExpanderHeader6Property.GetValue(this); }
            set { ExpanderHeader6Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader6TemplateProperty = new DependencyProperty<Template>("ExpanderHeader6Template");
        public Template ExpanderHeader6Template
        {
            get { return ExpanderHeader6TemplateProperty.GetValue(this); }
            set { ExpanderHeader6TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region15Property = new DependencyProperty<Region>("Region15");
        public Region Region15
        {
            get { return Region15Property.GetValue(this); }
            set { Region15Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region15TemplateProperty = new DependencyProperty<Template>("Region15Template");
        public Template Region15Template
        {
            get { return Region15TemplateProperty.GetValue(this); }
            set { Region15TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialClickedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnInterstitialClickedExpanderMPEventChevron");
        public Image OnInterstitialClickedExpanderMPEventChevron
        {
            get { return OnInterstitialClickedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialClickedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnInterstitialClickedExpanderMPEventChevronTemplate");
        public Template OnInterstitialClickedExpanderMPEventChevronTemplate
        {
            get { return OnInterstitialClickedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialClickedExpanderCheckImageProperty = new DependencyProperty<Image>("OnInterstitialClickedExpanderCheckImage");
        public Image OnInterstitialClickedExpanderCheckImage
        {
            get { return OnInterstitialClickedExpanderCheckImageProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialClickedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnInterstitialClickedExpanderCheckImageTemplate");
        public Template OnInterstitialClickedExpanderCheckImageTemplate
        {
            get { return OnInterstitialClickedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialClickedExpanderEventLabelProperty = new DependencyProperty<Label>("OnInterstitialClickedExpanderEventLabel");
        public Label OnInterstitialClickedExpanderEventLabel
        {
            get { return OnInterstitialClickedExpanderEventLabelProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialClickedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialClickedExpanderEventLabelTemplate");
        public Template OnInterstitialClickedExpanderEventLabelTemplate
        {
            get { return OnInterstitialClickedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent6Property = new DependencyProperty<ExpanderContent>("ExpanderContent6");
        public ExpanderContent ExpanderContent6
        {
            get { return ExpanderContent6Property.GetValue(this); }
            set { ExpanderContent6Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent6TemplateProperty = new DependencyProperty<Template>("ExpanderContent6Template");
        public Template ExpanderContent6Template
        {
            get { return ExpanderContent6TemplateProperty.GetValue(this); }
            set { ExpanderContent6TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialClickedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnInterstitialClickedExpanderAdUnitIdLabel");
        public Label OnInterstitialClickedExpanderAdUnitIdLabel
        {
            get { return OnInterstitialClickedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialClickedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialClickedExpanderAdUnitIdLabelTemplate");
        public Template OnInterstitialClickedExpanderAdUnitIdLabelTemplate
        {
            get { return OnInterstitialClickedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialClickedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region16Property = new DependencyProperty<Region>("Region16");
        public Region Region16
        {
            get { return Region16Property.GetValue(this); }
            set { Region16Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region16TemplateProperty = new DependencyProperty<Template>("Region16Template");
        public Template Region16Template
        {
            get { return Region16TemplateProperty.GetValue(this); }
            set { Region16TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnInterstitialDismissedExpanderProperty = new DependencyProperty<Expander>("OnInterstitialDismissedExpander");
        public Expander OnInterstitialDismissedExpander
        {
            get { return OnInterstitialDismissedExpanderProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialDismissedExpanderTemplateProperty = new DependencyProperty<Template>("OnInterstitialDismissedExpanderTemplate");
        public Template OnInterstitialDismissedExpanderTemplate
        {
            get { return OnInterstitialDismissedExpanderTemplateProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader7Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader7");
        public ExpanderHeader ExpanderHeader7
        {
            get { return ExpanderHeader7Property.GetValue(this); }
            set { ExpanderHeader7Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader7TemplateProperty = new DependencyProperty<Template>("ExpanderHeader7Template");
        public Template ExpanderHeader7Template
        {
            get { return ExpanderHeader7TemplateProperty.GetValue(this); }
            set { ExpanderHeader7TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region17Property = new DependencyProperty<Region>("Region17");
        public Region Region17
        {
            get { return Region17Property.GetValue(this); }
            set { Region17Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region17TemplateProperty = new DependencyProperty<Template>("Region17Template");
        public Template Region17Template
        {
            get { return Region17TemplateProperty.GetValue(this); }
            set { Region17TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialDismissedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnInterstitialDismissedExpanderMPEventChevron");
        public Image OnInterstitialDismissedExpanderMPEventChevron
        {
            get { return OnInterstitialDismissedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialDismissedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnInterstitialDismissedExpanderMPEventChevronTemplate");
        public Template OnInterstitialDismissedExpanderMPEventChevronTemplate
        {
            get { return OnInterstitialDismissedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialDismissedExpanderCheckImageProperty = new DependencyProperty<Image>("OnInterstitialDismissedExpanderCheckImage");
        public Image OnInterstitialDismissedExpanderCheckImage
        {
            get { return OnInterstitialDismissedExpanderCheckImageProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialDismissedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnInterstitialDismissedExpanderCheckImageTemplate");
        public Template OnInterstitialDismissedExpanderCheckImageTemplate
        {
            get { return OnInterstitialDismissedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialDismissedExpanderEventLabelProperty = new DependencyProperty<Label>("OnInterstitialDismissedExpanderEventLabel");
        public Label OnInterstitialDismissedExpanderEventLabel
        {
            get { return OnInterstitialDismissedExpanderEventLabelProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialDismissedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialDismissedExpanderEventLabelTemplate");
        public Template OnInterstitialDismissedExpanderEventLabelTemplate
        {
            get { return OnInterstitialDismissedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent7Property = new DependencyProperty<ExpanderContent>("ExpanderContent7");
        public ExpanderContent ExpanderContent7
        {
            get { return ExpanderContent7Property.GetValue(this); }
            set { ExpanderContent7Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent7TemplateProperty = new DependencyProperty<Template>("ExpanderContent7Template");
        public Template ExpanderContent7Template
        {
            get { return ExpanderContent7TemplateProperty.GetValue(this); }
            set { ExpanderContent7TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialDismissedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnInterstitialDismissedExpanderAdUnitIdLabel");
        public Label OnInterstitialDismissedExpanderAdUnitIdLabel
        {
            get { return OnInterstitialDismissedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialDismissedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialDismissedExpanderAdUnitIdLabelTemplate");
        public Template OnInterstitialDismissedExpanderAdUnitIdLabelTemplate
        {
            get { return OnInterstitialDismissedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialDismissedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region18Property = new DependencyProperty<Region>("Region18");
        public Region Region18
        {
            get { return Region18Property.GetValue(this); }
            set { Region18Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region18TemplateProperty = new DependencyProperty<Template>("Region18Template");
        public Template Region18Template
        {
            get { return Region18TemplateProperty.GetValue(this); }
            set { Region18TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnInterstitialFailedExpanderProperty = new DependencyProperty<Expander>("OnInterstitialFailedExpander");
        public Expander OnInterstitialFailedExpander
        {
            get { return OnInterstitialFailedExpanderProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialFailedExpanderTemplateProperty = new DependencyProperty<Template>("OnInterstitialFailedExpanderTemplate");
        public Template OnInterstitialFailedExpanderTemplate
        {
            get { return OnInterstitialFailedExpanderTemplateProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader8Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader8");
        public ExpanderHeader ExpanderHeader8
        {
            get { return ExpanderHeader8Property.GetValue(this); }
            set { ExpanderHeader8Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader8TemplateProperty = new DependencyProperty<Template>("ExpanderHeader8Template");
        public Template ExpanderHeader8Template
        {
            get { return ExpanderHeader8TemplateProperty.GetValue(this); }
            set { ExpanderHeader8TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region19Property = new DependencyProperty<Region>("Region19");
        public Region Region19
        {
            get { return Region19Property.GetValue(this); }
            set { Region19Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region19TemplateProperty = new DependencyProperty<Template>("Region19Template");
        public Template Region19Template
        {
            get { return Region19TemplateProperty.GetValue(this); }
            set { Region19TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialFailedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnInterstitialFailedExpanderMPEventChevron");
        public Image OnInterstitialFailedExpanderMPEventChevron
        {
            get { return OnInterstitialFailedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialFailedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnInterstitialFailedExpanderMPEventChevronTemplate");
        public Template OnInterstitialFailedExpanderMPEventChevronTemplate
        {
            get { return OnInterstitialFailedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnInterstitialFailedExpanderCheckImageProperty = new DependencyProperty<Image>("OnInterstitialFailedExpanderCheckImage");
        public Image OnInterstitialFailedExpanderCheckImage
        {
            get { return OnInterstitialFailedExpanderCheckImageProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialFailedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnInterstitialFailedExpanderCheckImageTemplate");
        public Template OnInterstitialFailedExpanderCheckImageTemplate
        {
            get { return OnInterstitialFailedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialFailedExpanderEventLabelProperty = new DependencyProperty<Label>("OnInterstitialFailedExpanderEventLabel");
        public Label OnInterstitialFailedExpanderEventLabel
        {
            get { return OnInterstitialFailedExpanderEventLabelProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialFailedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialFailedExpanderEventLabelTemplate");
        public Template OnInterstitialFailedExpanderEventLabelTemplate
        {
            get { return OnInterstitialFailedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent8Property = new DependencyProperty<ExpanderContent>("ExpanderContent8");
        public ExpanderContent ExpanderContent8
        {
            get { return ExpanderContent8Property.GetValue(this); }
            set { ExpanderContent8Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent8TemplateProperty = new DependencyProperty<Template>("ExpanderContent8Template");
        public Template ExpanderContent8Template
        {
            get { return ExpanderContent8TemplateProperty.GetValue(this); }
            set { ExpanderContent8TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group5Property = new DependencyProperty<Group>("Group5");
        public Group Group5
        {
            get { return Group5Property.GetValue(this); }
            set { Group5Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group5TemplateProperty = new DependencyProperty<Template>("Group5Template");
        public Template Group5Template
        {
            get { return Group5TemplateProperty.GetValue(this); }
            set { Group5TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialFailedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnInterstitialFailedExpanderAdUnitIdLabel");
        public Label OnInterstitialFailedExpanderAdUnitIdLabel
        {
            get { return OnInterstitialFailedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialFailedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialFailedExpanderAdUnitIdLabelTemplate");
        public Template OnInterstitialFailedExpanderAdUnitIdLabelTemplate
        {
            get { return OnInterstitialFailedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnInterstitialFailedExpanderErrorLabelProperty = new DependencyProperty<Label>("OnInterstitialFailedExpanderErrorLabel");
        public Label OnInterstitialFailedExpanderErrorLabel
        {
            get { return OnInterstitialFailedExpanderErrorLabelProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderErrorLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnInterstitialFailedExpanderErrorLabelTemplateProperty = new DependencyProperty<Template>("OnInterstitialFailedExpanderErrorLabelTemplate");
        public Template OnInterstitialFailedExpanderErrorLabelTemplate
        {
            get { return OnInterstitialFailedExpanderErrorLabelTemplateProperty.GetValue(this); }
            set { OnInterstitialFailedExpanderErrorLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region20Property = new DependencyProperty<Region>("Region20");
        public Region Region20
        {
            get { return Region20Property.GetValue(this); }
            set { Region20Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region20TemplateProperty = new DependencyProperty<Template>("Region20Template");
        public Template Region20Template
        {
            get { return Region20TemplateProperty.GetValue(this); }
            set { Region20TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnRewardedVideoLoadedExpanderProperty = new DependencyProperty<Expander>("OnRewardedVideoLoadedExpander");
        public Expander OnRewardedVideoLoadedExpander
        {
            get { return OnRewardedVideoLoadedExpanderProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoLoadedExpanderTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoLoadedExpanderTemplate");
        public Template OnRewardedVideoLoadedExpanderTemplate
        {
            get { return OnRewardedVideoLoadedExpanderTemplateProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader9Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader9");
        public ExpanderHeader ExpanderHeader9
        {
            get { return ExpanderHeader9Property.GetValue(this); }
            set { ExpanderHeader9Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader9TemplateProperty = new DependencyProperty<Template>("ExpanderHeader9Template");
        public Template ExpanderHeader9Template
        {
            get { return ExpanderHeader9TemplateProperty.GetValue(this); }
            set { ExpanderHeader9TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region21Property = new DependencyProperty<Region>("Region21");
        public Region Region21
        {
            get { return Region21Property.GetValue(this); }
            set { Region21Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region21TemplateProperty = new DependencyProperty<Template>("Region21Template");
        public Template Region21Template
        {
            get { return Region21TemplateProperty.GetValue(this); }
            set { Region21TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoLoadedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnRewardedVideoLoadedExpanderMPEventChevron");
        public Image OnRewardedVideoLoadedExpanderMPEventChevron
        {
            get { return OnRewardedVideoLoadedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoLoadedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoLoadedExpanderMPEventChevronTemplate");
        public Template OnRewardedVideoLoadedExpanderMPEventChevronTemplate
        {
            get { return OnRewardedVideoLoadedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoLoadedExpanderCheckImageProperty = new DependencyProperty<Image>("OnRewardedVideoLoadedExpanderCheckImage");
        public Image OnRewardedVideoLoadedExpanderCheckImage
        {
            get { return OnRewardedVideoLoadedExpanderCheckImageProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoLoadedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoLoadedExpanderCheckImageTemplate");
        public Template OnRewardedVideoLoadedExpanderCheckImageTemplate
        {
            get { return OnRewardedVideoLoadedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoLoadedExpanderEventLabelProperty = new DependencyProperty<Label>("OnRewardedVideoLoadedExpanderEventLabel");
        public Label OnRewardedVideoLoadedExpanderEventLabel
        {
            get { return OnRewardedVideoLoadedExpanderEventLabelProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoLoadedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoLoadedExpanderEventLabelTemplate");
        public Template OnRewardedVideoLoadedExpanderEventLabelTemplate
        {
            get { return OnRewardedVideoLoadedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent9Property = new DependencyProperty<ExpanderContent>("ExpanderContent9");
        public ExpanderContent ExpanderContent9
        {
            get { return ExpanderContent9Property.GetValue(this); }
            set { ExpanderContent9Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent9TemplateProperty = new DependencyProperty<Template>("ExpanderContent9Template");
        public Template ExpanderContent9Template
        {
            get { return ExpanderContent9TemplateProperty.GetValue(this); }
            set { ExpanderContent9TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoLoadedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnRewardedVideoLoadedExpanderAdUnitIdLabel");
        public Label OnRewardedVideoLoadedExpanderAdUnitIdLabel
        {
            get { return OnRewardedVideoLoadedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplate");
        public Template OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplate
        {
            get { return OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region22Property = new DependencyProperty<Region>("Region22");
        public Region Region22
        {
            get { return Region22Property.GetValue(this); }
            set { Region22Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region22TemplateProperty = new DependencyProperty<Template>("Region22Template");
        public Template Region22Template
        {
            get { return Region22TemplateProperty.GetValue(this); }
            set { Region22TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnRewardedVideoShownExpanderProperty = new DependencyProperty<Expander>("OnRewardedVideoShownExpander");
        public Expander OnRewardedVideoShownExpander
        {
            get { return OnRewardedVideoShownExpanderProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoShownExpanderTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoShownExpanderTemplate");
        public Template OnRewardedVideoShownExpanderTemplate
        {
            get { return OnRewardedVideoShownExpanderTemplateProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader10Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader10");
        public ExpanderHeader ExpanderHeader10
        {
            get { return ExpanderHeader10Property.GetValue(this); }
            set { ExpanderHeader10Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader10TemplateProperty = new DependencyProperty<Template>("ExpanderHeader10Template");
        public Template ExpanderHeader10Template
        {
            get { return ExpanderHeader10TemplateProperty.GetValue(this); }
            set { ExpanderHeader10TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region23Property = new DependencyProperty<Region>("Region23");
        public Region Region23
        {
            get { return Region23Property.GetValue(this); }
            set { Region23Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region23TemplateProperty = new DependencyProperty<Template>("Region23Template");
        public Template Region23Template
        {
            get { return Region23TemplateProperty.GetValue(this); }
            set { Region23TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoShownExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnRewardedVideoShownExpanderMPEventChevron");
        public Image OnRewardedVideoShownExpanderMPEventChevron
        {
            get { return OnRewardedVideoShownExpanderMPEventChevronProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoShownExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoShownExpanderMPEventChevronTemplate");
        public Template OnRewardedVideoShownExpanderMPEventChevronTemplate
        {
            get { return OnRewardedVideoShownExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoShownExpanderCheckImageProperty = new DependencyProperty<Image>("OnRewardedVideoShownExpanderCheckImage");
        public Image OnRewardedVideoShownExpanderCheckImage
        {
            get { return OnRewardedVideoShownExpanderCheckImageProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoShownExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoShownExpanderCheckImageTemplate");
        public Template OnRewardedVideoShownExpanderCheckImageTemplate
        {
            get { return OnRewardedVideoShownExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoShownExpanderEventLabelProperty = new DependencyProperty<Label>("OnRewardedVideoShownExpanderEventLabel");
        public Label OnRewardedVideoShownExpanderEventLabel
        {
            get { return OnRewardedVideoShownExpanderEventLabelProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoShownExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoShownExpanderEventLabelTemplate");
        public Template OnRewardedVideoShownExpanderEventLabelTemplate
        {
            get { return OnRewardedVideoShownExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent10Property = new DependencyProperty<ExpanderContent>("ExpanderContent10");
        public ExpanderContent ExpanderContent10
        {
            get { return ExpanderContent10Property.GetValue(this); }
            set { ExpanderContent10Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent10TemplateProperty = new DependencyProperty<Template>("ExpanderContent10Template");
        public Template ExpanderContent10Template
        {
            get { return ExpanderContent10TemplateProperty.GetValue(this); }
            set { ExpanderContent10TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoShownExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnRewardedVideoShownExpanderAdUnitIdLabel");
        public Label OnRewardedVideoShownExpanderAdUnitIdLabel
        {
            get { return OnRewardedVideoShownExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoShownExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoShownExpanderAdUnitIdLabelTemplate");
        public Template OnRewardedVideoShownExpanderAdUnitIdLabelTemplate
        {
            get { return OnRewardedVideoShownExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoShownExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region24Property = new DependencyProperty<Region>("Region24");
        public Region Region24
        {
            get { return Region24Property.GetValue(this); }
            set { Region24Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region24TemplateProperty = new DependencyProperty<Template>("Region24Template");
        public Template Region24Template
        {
            get { return Region24TemplateProperty.GetValue(this); }
            set { Region24TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnRewardedVideoClickedExpanderProperty = new DependencyProperty<Expander>("OnRewardedVideoClickedExpander");
        public Expander OnRewardedVideoClickedExpander
        {
            get { return OnRewardedVideoClickedExpanderProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClickedExpanderTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClickedExpanderTemplate");
        public Template OnRewardedVideoClickedExpanderTemplate
        {
            get { return OnRewardedVideoClickedExpanderTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader11Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader11");
        public ExpanderHeader ExpanderHeader11
        {
            get { return ExpanderHeader11Property.GetValue(this); }
            set { ExpanderHeader11Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader11TemplateProperty = new DependencyProperty<Template>("ExpanderHeader11Template");
        public Template ExpanderHeader11Template
        {
            get { return ExpanderHeader11TemplateProperty.GetValue(this); }
            set { ExpanderHeader11TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region25Property = new DependencyProperty<Region>("Region25");
        public Region Region25
        {
            get { return Region25Property.GetValue(this); }
            set { Region25Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region25TemplateProperty = new DependencyProperty<Template>("Region25Template");
        public Template Region25Template
        {
            get { return Region25TemplateProperty.GetValue(this); }
            set { Region25TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoClickedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnRewardedVideoClickedExpanderMPEventChevron");
        public Image OnRewardedVideoClickedExpanderMPEventChevron
        {
            get { return OnRewardedVideoClickedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClickedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClickedExpanderMPEventChevronTemplate");
        public Template OnRewardedVideoClickedExpanderMPEventChevronTemplate
        {
            get { return OnRewardedVideoClickedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoClickedExpanderCheckImageProperty = new DependencyProperty<Image>("OnRewardedVideoClickedExpanderCheckImage");
        public Image OnRewardedVideoClickedExpanderCheckImage
        {
            get { return OnRewardedVideoClickedExpanderCheckImageProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClickedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClickedExpanderCheckImageTemplate");
        public Template OnRewardedVideoClickedExpanderCheckImageTemplate
        {
            get { return OnRewardedVideoClickedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoClickedExpanderEventLabelProperty = new DependencyProperty<Label>("OnRewardedVideoClickedExpanderEventLabel");
        public Label OnRewardedVideoClickedExpanderEventLabel
        {
            get { return OnRewardedVideoClickedExpanderEventLabelProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClickedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClickedExpanderEventLabelTemplate");
        public Template OnRewardedVideoClickedExpanderEventLabelTemplate
        {
            get { return OnRewardedVideoClickedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent11Property = new DependencyProperty<ExpanderContent>("ExpanderContent11");
        public ExpanderContent ExpanderContent11
        {
            get { return ExpanderContent11Property.GetValue(this); }
            set { ExpanderContent11Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent11TemplateProperty = new DependencyProperty<Template>("ExpanderContent11Template");
        public Template ExpanderContent11Template
        {
            get { return ExpanderContent11TemplateProperty.GetValue(this); }
            set { ExpanderContent11TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoClickedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnRewardedVideoClickedExpanderAdUnitIdLabel");
        public Label OnRewardedVideoClickedExpanderAdUnitIdLabel
        {
            get { return OnRewardedVideoClickedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClickedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClickedExpanderAdUnitIdLabelTemplate");
        public Template OnRewardedVideoClickedExpanderAdUnitIdLabelTemplate
        {
            get { return OnRewardedVideoClickedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClickedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region26Property = new DependencyProperty<Region>("Region26");
        public Region Region26
        {
            get { return Region26Property.GetValue(this); }
            set { Region26Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region26TemplateProperty = new DependencyProperty<Template>("Region26Template");
        public Template Region26Template
        {
            get { return Region26TemplateProperty.GetValue(this); }
            set { Region26TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnRewardedVideoClosedExpanderProperty = new DependencyProperty<Expander>("OnRewardedVideoClosedExpander");
        public Expander OnRewardedVideoClosedExpander
        {
            get { return OnRewardedVideoClosedExpanderProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClosedExpanderTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClosedExpanderTemplate");
        public Template OnRewardedVideoClosedExpanderTemplate
        {
            get { return OnRewardedVideoClosedExpanderTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader12Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader12");
        public ExpanderHeader ExpanderHeader12
        {
            get { return ExpanderHeader12Property.GetValue(this); }
            set { ExpanderHeader12Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader12TemplateProperty = new DependencyProperty<Template>("ExpanderHeader12Template");
        public Template ExpanderHeader12Template
        {
            get { return ExpanderHeader12TemplateProperty.GetValue(this); }
            set { ExpanderHeader12TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region27Property = new DependencyProperty<Region>("Region27");
        public Region Region27
        {
            get { return Region27Property.GetValue(this); }
            set { Region27Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region27TemplateProperty = new DependencyProperty<Template>("Region27Template");
        public Template Region27Template
        {
            get { return Region27TemplateProperty.GetValue(this); }
            set { Region27TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoClosedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnRewardedVideoClosedExpanderMPEventChevron");
        public Image OnRewardedVideoClosedExpanderMPEventChevron
        {
            get { return OnRewardedVideoClosedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClosedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClosedExpanderMPEventChevronTemplate");
        public Template OnRewardedVideoClosedExpanderMPEventChevronTemplate
        {
            get { return OnRewardedVideoClosedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoClosedExpanderCheckImageProperty = new DependencyProperty<Image>("OnRewardedVideoClosedExpanderCheckImage");
        public Image OnRewardedVideoClosedExpanderCheckImage
        {
            get { return OnRewardedVideoClosedExpanderCheckImageProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClosedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClosedExpanderCheckImageTemplate");
        public Template OnRewardedVideoClosedExpanderCheckImageTemplate
        {
            get { return OnRewardedVideoClosedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoClosedExpanderEventLabelProperty = new DependencyProperty<Label>("OnRewardedVideoClosedExpanderEventLabel");
        public Label OnRewardedVideoClosedExpanderEventLabel
        {
            get { return OnRewardedVideoClosedExpanderEventLabelProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClosedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClosedExpanderEventLabelTemplate");
        public Template OnRewardedVideoClosedExpanderEventLabelTemplate
        {
            get { return OnRewardedVideoClosedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent12Property = new DependencyProperty<ExpanderContent>("ExpanderContent12");
        public ExpanderContent ExpanderContent12
        {
            get { return ExpanderContent12Property.GetValue(this); }
            set { ExpanderContent12Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent12TemplateProperty = new DependencyProperty<Template>("ExpanderContent12Template");
        public Template ExpanderContent12Template
        {
            get { return ExpanderContent12TemplateProperty.GetValue(this); }
            set { ExpanderContent12TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoClosedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnRewardedVideoClosedExpanderAdUnitIdLabel");
        public Label OnRewardedVideoClosedExpanderAdUnitIdLabel
        {
            get { return OnRewardedVideoClosedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoClosedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoClosedExpanderAdUnitIdLabelTemplate");
        public Template OnRewardedVideoClosedExpanderAdUnitIdLabelTemplate
        {
            get { return OnRewardedVideoClosedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoClosedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region28Property = new DependencyProperty<Region>("Region28");
        public Region Region28
        {
            get { return Region28Property.GetValue(this); }
            set { Region28Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region28TemplateProperty = new DependencyProperty<Template>("Region28Template");
        public Template Region28Template
        {
            get { return Region28TemplateProperty.GetValue(this); }
            set { Region28TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnRewardedVideoReceivedRewardExpanderProperty = new DependencyProperty<Expander>("OnRewardedVideoReceivedRewardExpander");
        public Expander OnRewardedVideoReceivedRewardExpander
        {
            get { return OnRewardedVideoReceivedRewardExpanderProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoReceivedRewardExpanderTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoReceivedRewardExpanderTemplate");
        public Template OnRewardedVideoReceivedRewardExpanderTemplate
        {
            get { return OnRewardedVideoReceivedRewardExpanderTemplateProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader13Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader13");
        public ExpanderHeader ExpanderHeader13
        {
            get { return ExpanderHeader13Property.GetValue(this); }
            set { ExpanderHeader13Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader13TemplateProperty = new DependencyProperty<Template>("ExpanderHeader13Template");
        public Template ExpanderHeader13Template
        {
            get { return ExpanderHeader13TemplateProperty.GetValue(this); }
            set { ExpanderHeader13TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region29Property = new DependencyProperty<Region>("Region29");
        public Region Region29
        {
            get { return Region29Property.GetValue(this); }
            set { Region29Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region29TemplateProperty = new DependencyProperty<Template>("Region29Template");
        public Template Region29Template
        {
            get { return Region29TemplateProperty.GetValue(this); }
            set { Region29TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoReceivedRewardExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnRewardedVideoReceivedRewardExpanderMPEventChevron");
        public Image OnRewardedVideoReceivedRewardExpanderMPEventChevron
        {
            get { return OnRewardedVideoReceivedRewardExpanderMPEventChevronProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplate");
        public Template OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplate
        {
            get { return OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoReceivedRewardExpanderCheckImageProperty = new DependencyProperty<Image>("OnRewardedVideoReceivedRewardExpanderCheckImage");
        public Image OnRewardedVideoReceivedRewardExpanderCheckImage
        {
            get { return OnRewardedVideoReceivedRewardExpanderCheckImageProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoReceivedRewardExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoReceivedRewardExpanderCheckImageTemplate");
        public Template OnRewardedVideoReceivedRewardExpanderCheckImageTemplate
        {
            get { return OnRewardedVideoReceivedRewardExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoReceivedRewardExpanderEventLabelProperty = new DependencyProperty<Label>("OnRewardedVideoReceivedRewardExpanderEventLabel");
        public Label OnRewardedVideoReceivedRewardExpanderEventLabel
        {
            get { return OnRewardedVideoReceivedRewardExpanderEventLabelProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoReceivedRewardExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoReceivedRewardExpanderEventLabelTemplate");
        public Template OnRewardedVideoReceivedRewardExpanderEventLabelTemplate
        {
            get { return OnRewardedVideoReceivedRewardExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent13Property = new DependencyProperty<ExpanderContent>("ExpanderContent13");
        public ExpanderContent ExpanderContent13
        {
            get { return ExpanderContent13Property.GetValue(this); }
            set { ExpanderContent13Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent13TemplateProperty = new DependencyProperty<Template>("ExpanderContent13Template");
        public Template ExpanderContent13Template
        {
            get { return ExpanderContent13TemplateProperty.GetValue(this); }
            set { ExpanderContent13TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group6Property = new DependencyProperty<Group>("Group6");
        public Group Group6
        {
            get { return Group6Property.GetValue(this); }
            set { Group6Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group6TemplateProperty = new DependencyProperty<Template>("Group6Template");
        public Template Group6Template
        {
            get { return Group6TemplateProperty.GetValue(this); }
            set { Group6TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnRewardedVideoReceivedRewardExpanderAdUnitIdLabel");
        public Label OnRewardedVideoReceivedRewardExpanderAdUnitIdLabel
        {
            get { return OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplate");
        public Template OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplate
        {
            get { return OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoReceivedRewardExpanderLabelLabelProperty = new DependencyProperty<Label>("OnRewardedVideoReceivedRewardExpanderLabelLabel");
        public Label OnRewardedVideoReceivedRewardExpanderLabelLabel
        {
            get { return OnRewardedVideoReceivedRewardExpanderLabelLabelProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderLabelLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoReceivedRewardExpanderLabelLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoReceivedRewardExpanderLabelLabelTemplate");
        public Template OnRewardedVideoReceivedRewardExpanderLabelLabelTemplate
        {
            get { return OnRewardedVideoReceivedRewardExpanderLabelLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderLabelLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoReceivedRewardExpanderAmountLabelProperty = new DependencyProperty<Label>("OnRewardedVideoReceivedRewardExpanderAmountLabel");
        public Label OnRewardedVideoReceivedRewardExpanderAmountLabel
        {
            get { return OnRewardedVideoReceivedRewardExpanderAmountLabelProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderAmountLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoReceivedRewardExpanderAmountLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoReceivedRewardExpanderAmountLabelTemplate");
        public Template OnRewardedVideoReceivedRewardExpanderAmountLabelTemplate
        {
            get { return OnRewardedVideoReceivedRewardExpanderAmountLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoReceivedRewardExpanderAmountLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region30Property = new DependencyProperty<Region>("Region30");
        public Region Region30
        {
            get { return Region30Property.GetValue(this); }
            set { Region30Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region30TemplateProperty = new DependencyProperty<Template>("Region30Template");
        public Template Region30Template
        {
            get { return Region30TemplateProperty.GetValue(this); }
            set { Region30TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnRewardedVideoFailedToPlayExpanderProperty = new DependencyProperty<Expander>("OnRewardedVideoFailedToPlayExpander");
        public Expander OnRewardedVideoFailedToPlayExpander
        {
            get { return OnRewardedVideoFailedToPlayExpanderProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedToPlayExpanderTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedToPlayExpanderTemplate");
        public Template OnRewardedVideoFailedToPlayExpanderTemplate
        {
            get { return OnRewardedVideoFailedToPlayExpanderTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader14Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader14");
        public ExpanderHeader ExpanderHeader14
        {
            get { return ExpanderHeader14Property.GetValue(this); }
            set { ExpanderHeader14Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader14TemplateProperty = new DependencyProperty<Template>("ExpanderHeader14Template");
        public Template ExpanderHeader14Template
        {
            get { return ExpanderHeader14TemplateProperty.GetValue(this); }
            set { ExpanderHeader14TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region31Property = new DependencyProperty<Region>("Region31");
        public Region Region31
        {
            get { return Region31Property.GetValue(this); }
            set { Region31Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region31TemplateProperty = new DependencyProperty<Template>("Region31Template");
        public Template Region31Template
        {
            get { return Region31TemplateProperty.GetValue(this); }
            set { Region31TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoFailedToPlayExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnRewardedVideoFailedToPlayExpanderMPEventChevron");
        public Image OnRewardedVideoFailedToPlayExpanderMPEventChevron
        {
            get { return OnRewardedVideoFailedToPlayExpanderMPEventChevronProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplate");
        public Template OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplate
        {
            get { return OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoFailedToPlayExpanderCheckImageProperty = new DependencyProperty<Image>("OnRewardedVideoFailedToPlayExpanderCheckImage");
        public Image OnRewardedVideoFailedToPlayExpanderCheckImage
        {
            get { return OnRewardedVideoFailedToPlayExpanderCheckImageProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedToPlayExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedToPlayExpanderCheckImageTemplate");
        public Template OnRewardedVideoFailedToPlayExpanderCheckImageTemplate
        {
            get { return OnRewardedVideoFailedToPlayExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoFailedToPlayExpanderEventLabelProperty = new DependencyProperty<Label>("OnRewardedVideoFailedToPlayExpanderEventLabel");
        public Label OnRewardedVideoFailedToPlayExpanderEventLabel
        {
            get { return OnRewardedVideoFailedToPlayExpanderEventLabelProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedToPlayExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedToPlayExpanderEventLabelTemplate");
        public Template OnRewardedVideoFailedToPlayExpanderEventLabelTemplate
        {
            get { return OnRewardedVideoFailedToPlayExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent14Property = new DependencyProperty<ExpanderContent>("ExpanderContent14");
        public ExpanderContent ExpanderContent14
        {
            get { return ExpanderContent14Property.GetValue(this); }
            set { ExpanderContent14Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent14TemplateProperty = new DependencyProperty<Template>("ExpanderContent14Template");
        public Template ExpanderContent14Template
        {
            get { return ExpanderContent14TemplateProperty.GetValue(this); }
            set { ExpanderContent14TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group7Property = new DependencyProperty<Group>("Group7");
        public Group Group7
        {
            get { return Group7Property.GetValue(this); }
            set { Group7Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group7TemplateProperty = new DependencyProperty<Template>("Group7Template");
        public Template Group7Template
        {
            get { return Group7TemplateProperty.GetValue(this); }
            set { Group7TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnRewardedVideoFailedToPlayExpanderAdUnitIdLabel");
        public Label OnRewardedVideoFailedToPlayExpanderAdUnitIdLabel
        {
            get { return OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplate");
        public Template OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplate
        {
            get { return OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoFailedToPlayExpanderErrorLabelProperty = new DependencyProperty<Label>("OnRewardedVideoFailedToPlayExpanderErrorLabel");
        public Label OnRewardedVideoFailedToPlayExpanderErrorLabel
        {
            get { return OnRewardedVideoFailedToPlayExpanderErrorLabelProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderErrorLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedToPlayExpanderErrorLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedToPlayExpanderErrorLabelTemplate");
        public Template OnRewardedVideoFailedToPlayExpanderErrorLabelTemplate
        {
            get { return OnRewardedVideoFailedToPlayExpanderErrorLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedToPlayExpanderErrorLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region32Property = new DependencyProperty<Region>("Region32");
        public Region Region32
        {
            get { return Region32Property.GetValue(this); }
            set { Region32Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region32TemplateProperty = new DependencyProperty<Template>("Region32Template");
        public Template Region32Template
        {
            get { return Region32TemplateProperty.GetValue(this); }
            set { Region32TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnRewardedVideoFailedEventExpanderProperty = new DependencyProperty<Expander>("OnRewardedVideoFailedEventExpander");
        public Expander OnRewardedVideoFailedEventExpander
        {
            get { return OnRewardedVideoFailedEventExpanderProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedEventExpanderTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedEventExpanderTemplate");
        public Template OnRewardedVideoFailedEventExpanderTemplate
        {
            get { return OnRewardedVideoFailedEventExpanderTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader15Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader15");
        public ExpanderHeader ExpanderHeader15
        {
            get { return ExpanderHeader15Property.GetValue(this); }
            set { ExpanderHeader15Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader15TemplateProperty = new DependencyProperty<Template>("ExpanderHeader15Template");
        public Template ExpanderHeader15Template
        {
            get { return ExpanderHeader15TemplateProperty.GetValue(this); }
            set { ExpanderHeader15TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region33Property = new DependencyProperty<Region>("Region33");
        public Region Region33
        {
            get { return Region33Property.GetValue(this); }
            set { Region33Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region33TemplateProperty = new DependencyProperty<Template>("Region33Template");
        public Template Region33Template
        {
            get { return Region33TemplateProperty.GetValue(this); }
            set { Region33TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoFailedEventExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnRewardedVideoFailedEventExpanderMPEventChevron");
        public Image OnRewardedVideoFailedEventExpanderMPEventChevron
        {
            get { return OnRewardedVideoFailedEventExpanderMPEventChevronProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedEventExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedEventExpanderMPEventChevronTemplate");
        public Template OnRewardedVideoFailedEventExpanderMPEventChevronTemplate
        {
            get { return OnRewardedVideoFailedEventExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnRewardedVideoFailedEventExpanderCheckImageProperty = new DependencyProperty<Image>("OnRewardedVideoFailedEventExpanderCheckImage");
        public Image OnRewardedVideoFailedEventExpanderCheckImage
        {
            get { return OnRewardedVideoFailedEventExpanderCheckImageProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedEventExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedEventExpanderCheckImageTemplate");
        public Template OnRewardedVideoFailedEventExpanderCheckImageTemplate
        {
            get { return OnRewardedVideoFailedEventExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoFailedEventExpanderEventLabelProperty = new DependencyProperty<Label>("OnRewardedVideoFailedEventExpanderEventLabel");
        public Label OnRewardedVideoFailedEventExpanderEventLabel
        {
            get { return OnRewardedVideoFailedEventExpanderEventLabelProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedEventExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedEventExpanderEventLabelTemplate");
        public Template OnRewardedVideoFailedEventExpanderEventLabelTemplate
        {
            get { return OnRewardedVideoFailedEventExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent15Property = new DependencyProperty<ExpanderContent>("ExpanderContent15");
        public ExpanderContent ExpanderContent15
        {
            get { return ExpanderContent15Property.GetValue(this); }
            set { ExpanderContent15Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent15TemplateProperty = new DependencyProperty<Template>("ExpanderContent15Template");
        public Template ExpanderContent15Template
        {
            get { return ExpanderContent15TemplateProperty.GetValue(this); }
            set { ExpanderContent15TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group8Property = new DependencyProperty<Group>("Group8");
        public Group Group8
        {
            get { return Group8Property.GetValue(this); }
            set { Group8Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group8TemplateProperty = new DependencyProperty<Template>("Group8Template");
        public Template Group8Template
        {
            get { return Group8TemplateProperty.GetValue(this); }
            set { Group8TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoFailedEventExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnRewardedVideoFailedEventExpanderAdUnitIdLabel");
        public Label OnRewardedVideoFailedEventExpanderAdUnitIdLabel
        {
            get { return OnRewardedVideoFailedEventExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplate");
        public Template OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplate
        {
            get { return OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnRewardedVideoFailedEventExpanderErrorLabelProperty = new DependencyProperty<Label>("OnRewardedVideoFailedEventExpanderErrorLabel");
        public Label OnRewardedVideoFailedEventExpanderErrorLabel
        {
            get { return OnRewardedVideoFailedEventExpanderErrorLabelProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderErrorLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnRewardedVideoFailedEventExpanderErrorLabelTemplateProperty = new DependencyProperty<Template>("OnRewardedVideoFailedEventExpanderErrorLabelTemplate");
        public Template OnRewardedVideoFailedEventExpanderErrorLabelTemplate
        {
            get { return OnRewardedVideoFailedEventExpanderErrorLabelTemplateProperty.GetValue(this); }
            set { OnRewardedVideoFailedEventExpanderErrorLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region34Property = new DependencyProperty<Region>("Region34");
        public Region Region34
        {
            get { return Region34Property.GetValue(this); }
            set { Region34Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region34TemplateProperty = new DependencyProperty<Template>("Region34Template");
        public Template Region34Template
        {
            get { return Region34TemplateProperty.GetValue(this); }
            set { Region34TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnImpressionTrackedBgExpanderProperty = new DependencyProperty<Expander>("OnImpressionTrackedBgExpander");
        public Expander OnImpressionTrackedBgExpander
        {
            get { return OnImpressionTrackedBgExpanderProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedBgExpanderTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedBgExpanderTemplate");
        public Template OnImpressionTrackedBgExpanderTemplate
        {
            get { return OnImpressionTrackedBgExpanderTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader16Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader16");
        public ExpanderHeader ExpanderHeader16
        {
            get { return ExpanderHeader16Property.GetValue(this); }
            set { ExpanderHeader16Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader16TemplateProperty = new DependencyProperty<Template>("ExpanderHeader16Template");
        public Template ExpanderHeader16Template
        {
            get { return ExpanderHeader16TemplateProperty.GetValue(this); }
            set { ExpanderHeader16TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region35Property = new DependencyProperty<Region>("Region35");
        public Region Region35
        {
            get { return Region35Property.GetValue(this); }
            set { Region35Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region35TemplateProperty = new DependencyProperty<Template>("Region35Template");
        public Template Region35Template
        {
            get { return Region35TemplateProperty.GetValue(this); }
            set { Region35TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnImpressionTrackedBgExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnImpressionTrackedBgExpanderMPEventChevron");
        public Image OnImpressionTrackedBgExpanderMPEventChevron
        {
            get { return OnImpressionTrackedBgExpanderMPEventChevronProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedBgExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedBgExpanderMPEventChevronTemplate");
        public Template OnImpressionTrackedBgExpanderMPEventChevronTemplate
        {
            get { return OnImpressionTrackedBgExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnImpressionTrackedBgExpanderCheckImageProperty = new DependencyProperty<Image>("OnImpressionTrackedBgExpanderCheckImage");
        public Image OnImpressionTrackedBgExpanderCheckImage
        {
            get { return OnImpressionTrackedBgExpanderCheckImageProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedBgExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedBgExpanderCheckImageTemplate");
        public Template OnImpressionTrackedBgExpanderCheckImageTemplate
        {
            get { return OnImpressionTrackedBgExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnImpressionTrackedBgExpanderEventLabelProperty = new DependencyProperty<Label>("OnImpressionTrackedBgExpanderEventLabel");
        public Label OnImpressionTrackedBgExpanderEventLabel
        {
            get { return OnImpressionTrackedBgExpanderEventLabelProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedBgExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedBgExpanderEventLabelTemplate");
        public Template OnImpressionTrackedBgExpanderEventLabelTemplate
        {
            get { return OnImpressionTrackedBgExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent16Property = new DependencyProperty<ExpanderContent>("ExpanderContent16");
        public ExpanderContent ExpanderContent16
        {
            get { return ExpanderContent16Property.GetValue(this); }
            set { ExpanderContent16Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent16TemplateProperty = new DependencyProperty<Template>("ExpanderContent16Template");
        public Template ExpanderContent16Template
        {
            get { return ExpanderContent16TemplateProperty.GetValue(this); }
            set { ExpanderContent16TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group9Property = new DependencyProperty<Group>("Group9");
        public Group Group9
        {
            get { return Group9Property.GetValue(this); }
            set { Group9Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group9TemplateProperty = new DependencyProperty<Template>("Group9Template");
        public Template Group9Template
        {
            get { return Group9TemplateProperty.GetValue(this); }
            set { Group9TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnImpressionTrackedBgExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnImpressionTrackedBgExpanderAdUnitIdLabel");
        public Label OnImpressionTrackedBgExpanderAdUnitIdLabel
        {
            get { return OnImpressionTrackedBgExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedBgExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedBgExpanderAdUnitIdLabelTemplate");
        public Template OnImpressionTrackedBgExpanderAdUnitIdLabelTemplate
        {
            get { return OnImpressionTrackedBgExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<InputField> OnImpressionTrackedBgExpanderImpressionDataFieldProperty = new DependencyProperty<InputField>("OnImpressionTrackedBgExpanderImpressionDataField");
        public InputField OnImpressionTrackedBgExpanderImpressionDataField
        {
            get { return OnImpressionTrackedBgExpanderImpressionDataFieldProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderImpressionDataFieldProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedBgExpanderImpressionDataFieldTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedBgExpanderImpressionDataFieldTemplate");
        public Template OnImpressionTrackedBgExpanderImpressionDataFieldTemplate
        {
            get { return OnImpressionTrackedBgExpanderImpressionDataFieldTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedBgExpanderImpressionDataFieldTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region36Property = new DependencyProperty<Region>("Region36");
        public Region Region36
        {
            get { return Region36Property.GetValue(this); }
            set { Region36Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region36TemplateProperty = new DependencyProperty<Template>("Region36Template");
        public Template Region36Template
        {
            get { return Region36TemplateProperty.GetValue(this); }
            set { Region36TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> OnImpressionTrackedExpanderProperty = new DependencyProperty<Expander>("OnImpressionTrackedExpander");
        public Expander OnImpressionTrackedExpander
        {
            get { return OnImpressionTrackedExpanderProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedExpanderTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedExpanderTemplate");
        public Template OnImpressionTrackedExpanderTemplate
        {
            get { return OnImpressionTrackedExpanderTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderHeader> ExpanderHeader17Property = new DependencyProperty<ExpanderHeader>("ExpanderHeader17");
        public ExpanderHeader ExpanderHeader17
        {
            get { return ExpanderHeader17Property.GetValue(this); }
            set { ExpanderHeader17Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderHeader17TemplateProperty = new DependencyProperty<Template>("ExpanderHeader17Template");
        public Template ExpanderHeader17Template
        {
            get { return ExpanderHeader17TemplateProperty.GetValue(this); }
            set { ExpanderHeader17TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region37Property = new DependencyProperty<Region>("Region37");
        public Region Region37
        {
            get { return Region37Property.GetValue(this); }
            set { Region37Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region37TemplateProperty = new DependencyProperty<Template>("Region37Template");
        public Template Region37Template
        {
            get { return Region37TemplateProperty.GetValue(this); }
            set { Region37TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnImpressionTrackedExpanderMPEventChevronProperty = new DependencyProperty<Image>("OnImpressionTrackedExpanderMPEventChevron");
        public Image OnImpressionTrackedExpanderMPEventChevron
        {
            get { return OnImpressionTrackedExpanderMPEventChevronProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderMPEventChevronProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedExpanderMPEventChevronTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedExpanderMPEventChevronTemplate");
        public Template OnImpressionTrackedExpanderMPEventChevronTemplate
        {
            get { return OnImpressionTrackedExpanderMPEventChevronTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderMPEventChevronTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> OnImpressionTrackedExpanderCheckImageProperty = new DependencyProperty<Image>("OnImpressionTrackedExpanderCheckImage");
        public Image OnImpressionTrackedExpanderCheckImage
        {
            get { return OnImpressionTrackedExpanderCheckImageProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderCheckImageProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedExpanderCheckImageTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedExpanderCheckImageTemplate");
        public Template OnImpressionTrackedExpanderCheckImageTemplate
        {
            get { return OnImpressionTrackedExpanderCheckImageTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderCheckImageTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnImpressionTrackedExpanderEventLabelProperty = new DependencyProperty<Label>("OnImpressionTrackedExpanderEventLabel");
        public Label OnImpressionTrackedExpanderEventLabel
        {
            get { return OnImpressionTrackedExpanderEventLabelProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderEventLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedExpanderEventLabelTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedExpanderEventLabelTemplate");
        public Template OnImpressionTrackedExpanderEventLabelTemplate
        {
            get { return OnImpressionTrackedExpanderEventLabelTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderEventLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> ExpanderContent17Property = new DependencyProperty<ExpanderContent>("ExpanderContent17");
        public ExpanderContent ExpanderContent17
        {
            get { return ExpanderContent17Property.GetValue(this); }
            set { ExpanderContent17Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ExpanderContent17TemplateProperty = new DependencyProperty<Template>("ExpanderContent17Template");
        public Template ExpanderContent17Template
        {
            get { return ExpanderContent17TemplateProperty.GetValue(this); }
            set { ExpanderContent17TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group10Property = new DependencyProperty<Group>("Group10");
        public Group Group10
        {
            get { return Group10Property.GetValue(this); }
            set { Group10Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group10TemplateProperty = new DependencyProperty<Template>("Group10Template");
        public Template Group10Template
        {
            get { return Group10TemplateProperty.GetValue(this); }
            set { Group10TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> OnImpressionTrackedExpanderAdUnitIdLabelProperty = new DependencyProperty<Label>("OnImpressionTrackedExpanderAdUnitIdLabel");
        public Label OnImpressionTrackedExpanderAdUnitIdLabel
        {
            get { return OnImpressionTrackedExpanderAdUnitIdLabelProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderAdUnitIdLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedExpanderAdUnitIdLabelTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedExpanderAdUnitIdLabelTemplate");
        public Template OnImpressionTrackedExpanderAdUnitIdLabelTemplate
        {
            get { return OnImpressionTrackedExpanderAdUnitIdLabelTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderAdUnitIdLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<InputField> OnImpressionTrackedExpanderImpressionDataFieldProperty = new DependencyProperty<InputField>("OnImpressionTrackedExpanderImpressionDataField");
        public InputField OnImpressionTrackedExpanderImpressionDataField
        {
            get { return OnImpressionTrackedExpanderImpressionDataFieldProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderImpressionDataFieldProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OnImpressionTrackedExpanderImpressionDataFieldTemplateProperty = new DependencyProperty<Template>("OnImpressionTrackedExpanderImpressionDataFieldTemplate");
        public Template OnImpressionTrackedExpanderImpressionDataFieldTemplate
        {
            get { return OnImpressionTrackedExpanderImpressionDataFieldTemplateProperty.GetValue(this); }
            set { OnImpressionTrackedExpanderImpressionDataFieldTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region38Property = new DependencyProperty<Region>("Region38");
        public Region Region38
        {
            get { return Region38Property.GetValue(this); }
            set { Region38Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region38TemplateProperty = new DependencyProperty<Template>("Region38Template");
        public Template Region38Template
        {
            get { return Region38TemplateProperty.GetValue(this); }
            set { Region38TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty MaxWidthProperty = Label.MaxWidthProperty;
        public Delight.ElementSize MaxWidth
        {
            get { return AdUnitName.MaxWidth; }
            set { AdUnitName.MaxWidth = value; }
        }

        public readonly static DependencyProperty AutoSizeProperty = Label.AutoSizeProperty;
        public Delight.AutoSize AutoSize
        {
            get { return AdUnitName.AutoSize; }
            set { AdUnitName.AutoSize = value; }
        }

        public readonly static DependencyProperty AutoSizeTextContainerProperty = Label.AutoSizeTextContainerProperty;
        public System.Boolean AutoSizeTextContainer
        {
            get { return AdUnitName.AutoSizeTextContainer; }
            set { AdUnitName.AutoSizeTextContainer = value; }
        }

        public readonly static DependencyProperty MaskOffsetProperty = Label.MaskOffsetProperty;
        public UnityEngine.Vector4 MaskOffset
        {
            get { return AdUnitName.MaskOffset; }
            set { AdUnitName.MaskOffset = value; }
        }

        public readonly static DependencyProperty TextProperty = Label.TextProperty;
        public System.String Text
        {
            get { return AdUnitName.Text; }
            set { AdUnitName.Text = value; }
        }

        public readonly static DependencyProperty TextPreprocessorProperty = Label.TextPreprocessorProperty;
        public TMPro.ITextPreprocessor TextPreprocessor
        {
            get { return AdUnitName.TextPreprocessor; }
            set { AdUnitName.TextPreprocessor = value; }
        }

        public readonly static DependencyProperty IsRightToLeftTextProperty = Label.IsRightToLeftTextProperty;
        public System.Boolean IsRightToLeftText
        {
            get { return AdUnitName.IsRightToLeftText; }
            set { AdUnitName.IsRightToLeftText = value; }
        }

        public readonly static DependencyProperty FontProperty = Label.FontProperty;
        public TMP_FontAsset Font
        {
            get { return AdUnitName.Font; }
            set { AdUnitName.Font = value; }
        }

        public readonly static DependencyProperty FontSharedMaterialProperty = Label.FontSharedMaterialProperty;
        public MaterialAsset FontSharedMaterial
        {
            get { return AdUnitName.FontSharedMaterial; }
            set { AdUnitName.FontSharedMaterial = value; }
        }

        public readonly static DependencyProperty FontSharedMaterialsProperty = Label.FontSharedMaterialsProperty;
        public UnityEngine.Material[] FontSharedMaterials
        {
            get { return AdUnitName.FontSharedMaterials; }
            set { AdUnitName.FontSharedMaterials = value; }
        }

        public readonly static DependencyProperty FontMaterialProperty = Label.FontMaterialProperty;
        public MaterialAsset FontMaterial
        {
            get { return AdUnitName.FontMaterial; }
            set { AdUnitName.FontMaterial = value; }
        }

        public readonly static DependencyProperty FontMaterialsProperty = Label.FontMaterialsProperty;
        public UnityEngine.Material[] FontMaterials
        {
            get { return AdUnitName.FontMaterials; }
            set { AdUnitName.FontMaterials = value; }
        }

        public readonly static DependencyProperty FontColorProperty = Label.FontColorProperty;
        public UnityEngine.Color FontColor
        {
            get { return AdUnitName.FontColor; }
            set { AdUnitName.FontColor = value; }
        }

        public readonly static DependencyProperty TextMeshProUGUIAlphaProperty = Label.TextMeshProUGUIAlphaProperty;
        public System.Single TextMeshProUGUIAlpha
        {
            get { return AdUnitName.TextMeshProUGUIAlpha; }
            set { AdUnitName.TextMeshProUGUIAlpha = value; }
        }

        public readonly static DependencyProperty EnableVertexGradientProperty = Label.EnableVertexGradientProperty;
        public System.Boolean EnableVertexGradient
        {
            get { return AdUnitName.EnableVertexGradient; }
            set { AdUnitName.EnableVertexGradient = value; }
        }

        public readonly static DependencyProperty ColorGradientProperty = Label.ColorGradientProperty;
        public TMPro.VertexGradient ColorGradient
        {
            get { return AdUnitName.ColorGradient; }
            set { AdUnitName.ColorGradient = value; }
        }

        public readonly static DependencyProperty ColorGradientPresetProperty = Label.ColorGradientPresetProperty;
        public TMP_ColorGradientAsset ColorGradientPreset
        {
            get { return AdUnitName.ColorGradientPreset; }
            set { AdUnitName.ColorGradientPreset = value; }
        }

        public readonly static DependencyProperty SpriteAssetProperty = Label.SpriteAssetProperty;
        public TMP_SpriteAsset SpriteAsset
        {
            get { return AdUnitName.SpriteAsset; }
            set { AdUnitName.SpriteAsset = value; }
        }

        public readonly static DependencyProperty TintAllSpritesProperty = Label.TintAllSpritesProperty;
        public System.Boolean TintAllSprites
        {
            get { return AdUnitName.TintAllSprites; }
            set { AdUnitName.TintAllSprites = value; }
        }

        public readonly static DependencyProperty StyleSheetProperty = Label.StyleSheetProperty;
        public TMP_StyleSheetAsset StyleSheet
        {
            get { return AdUnitName.StyleSheet; }
            set { AdUnitName.StyleSheet = value; }
        }

        public readonly static DependencyProperty TextStyleProperty = Label.TextStyleProperty;
        public TMPro.TMP_Style TextStyle
        {
            get { return AdUnitName.TextStyle; }
            set { AdUnitName.TextStyle = value; }
        }

        public readonly static DependencyProperty OverrideColorTagsProperty = Label.OverrideColorTagsProperty;
        public System.Boolean OverrideColorTags
        {
            get { return AdUnitName.OverrideColorTags; }
            set { AdUnitName.OverrideColorTags = value; }
        }

        public readonly static DependencyProperty FaceColorProperty = Label.FaceColorProperty;
        public UnityEngine.Color32 FaceColor
        {
            get { return AdUnitName.FaceColor; }
            set { AdUnitName.FaceColor = value; }
        }

        public readonly static DependencyProperty OutlineColorProperty = Label.OutlineColorProperty;
        public UnityEngine.Color32 OutlineColor
        {
            get { return AdUnitName.OutlineColor; }
            set { AdUnitName.OutlineColor = value; }
        }

        public readonly static DependencyProperty OutlineWidthProperty = Label.OutlineWidthProperty;
        public System.Single OutlineWidth
        {
            get { return AdUnitName.OutlineWidth; }
            set { AdUnitName.OutlineWidth = value; }
        }

        public readonly static DependencyProperty FontSizeProperty = Label.FontSizeProperty;
        public System.Single FontSize
        {
            get { return AdUnitName.FontSize; }
            set { AdUnitName.FontSize = value; }
        }

        public readonly static DependencyProperty FontWeightProperty = Label.FontWeightProperty;
        public TMPro.FontWeight FontWeight
        {
            get { return AdUnitName.FontWeight; }
            set { AdUnitName.FontWeight = value; }
        }

        public readonly static DependencyProperty EnableAutoSizingProperty = Label.EnableAutoSizingProperty;
        public System.Boolean EnableAutoSizing
        {
            get { return AdUnitName.EnableAutoSizing; }
            set { AdUnitName.EnableAutoSizing = value; }
        }

        public readonly static DependencyProperty FontSizeMinProperty = Label.FontSizeMinProperty;
        public System.Single FontSizeMin
        {
            get { return AdUnitName.FontSizeMin; }
            set { AdUnitName.FontSizeMin = value; }
        }

        public readonly static DependencyProperty FontSizeMaxProperty = Label.FontSizeMaxProperty;
        public System.Single FontSizeMax
        {
            get { return AdUnitName.FontSizeMax; }
            set { AdUnitName.FontSizeMax = value; }
        }

        public readonly static DependencyProperty FontStyleProperty = Label.FontStyleProperty;
        public TMPro.FontStyles FontStyle
        {
            get { return AdUnitName.FontStyle; }
            set { AdUnitName.FontStyle = value; }
        }

        public readonly static DependencyProperty HorizontalAlignmentProperty = Label.HorizontalAlignmentProperty;
        public TMPro.HorizontalAlignmentOptions HorizontalAlignment
        {
            get { return AdUnitName.HorizontalAlignment; }
            set { AdUnitName.HorizontalAlignment = value; }
        }

        public readonly static DependencyProperty VerticalAlignmentProperty = Label.VerticalAlignmentProperty;
        public TMPro.VerticalAlignmentOptions VerticalAlignment
        {
            get { return AdUnitName.VerticalAlignment; }
            set { AdUnitName.VerticalAlignment = value; }
        }

        public readonly static DependencyProperty TextAlignmentProperty = Label.TextAlignmentProperty;
        public TMPro.TextAlignmentOptions TextAlignment
        {
            get { return AdUnitName.TextAlignment; }
            set { AdUnitName.TextAlignment = value; }
        }

        public readonly static DependencyProperty CharacterSpacingProperty = Label.CharacterSpacingProperty;
        public System.Single CharacterSpacing
        {
            get { return AdUnitName.CharacterSpacing; }
            set { AdUnitName.CharacterSpacing = value; }
        }

        public readonly static DependencyProperty WordSpacingProperty = Label.WordSpacingProperty;
        public System.Single WordSpacing
        {
            get { return AdUnitName.WordSpacing; }
            set { AdUnitName.WordSpacing = value; }
        }

        public readonly static DependencyProperty LineSpacingProperty = Label.LineSpacingProperty;
        public System.Single LineSpacing
        {
            get { return AdUnitName.LineSpacing; }
            set { AdUnitName.LineSpacing = value; }
        }

        public readonly static DependencyProperty LineSpacingAdjustmentProperty = Label.LineSpacingAdjustmentProperty;
        public System.Single LineSpacingAdjustment
        {
            get { return AdUnitName.LineSpacingAdjustment; }
            set { AdUnitName.LineSpacingAdjustment = value; }
        }

        public readonly static DependencyProperty ParagraphSpacingProperty = Label.ParagraphSpacingProperty;
        public System.Single ParagraphSpacing
        {
            get { return AdUnitName.ParagraphSpacing; }
            set { AdUnitName.ParagraphSpacing = value; }
        }

        public readonly static DependencyProperty CharacterWidthAdjustmentProperty = Label.CharacterWidthAdjustmentProperty;
        public System.Single CharacterWidthAdjustment
        {
            get { return AdUnitName.CharacterWidthAdjustment; }
            set { AdUnitName.CharacterWidthAdjustment = value; }
        }

        public readonly static DependencyProperty EnableWordWrappingProperty = Label.EnableWordWrappingProperty;
        public System.Boolean EnableWordWrapping
        {
            get { return AdUnitName.EnableWordWrapping; }
            set { AdUnitName.EnableWordWrapping = value; }
        }

        public readonly static DependencyProperty WordWrappingRatiosProperty = Label.WordWrappingRatiosProperty;
        public System.Single WordWrappingRatios
        {
            get { return AdUnitName.WordWrappingRatios; }
            set { AdUnitName.WordWrappingRatios = value; }
        }

        public readonly static DependencyProperty OverflowModeProperty = Label.OverflowModeProperty;
        public TMPro.TextOverflowModes OverflowMode
        {
            get { return AdUnitName.OverflowMode; }
            set { AdUnitName.OverflowMode = value; }
        }

        public readonly static DependencyProperty LinkedTextComponentProperty = Label.LinkedTextComponentProperty;
        public TMPro.TMP_Text LinkedTextComponent
        {
            get { return AdUnitName.LinkedTextComponent; }
            set { AdUnitName.LinkedTextComponent = value; }
        }

        public readonly static DependencyProperty EnableKerningProperty = Label.EnableKerningProperty;
        public System.Boolean EnableKerning
        {
            get { return AdUnitName.EnableKerning; }
            set { AdUnitName.EnableKerning = value; }
        }

        public readonly static DependencyProperty ExtraPaddingProperty = Label.ExtraPaddingProperty;
        public System.Boolean ExtraPadding
        {
            get { return AdUnitName.ExtraPadding; }
            set { AdUnitName.ExtraPadding = value; }
        }

        public readonly static DependencyProperty RichTextProperty = Label.RichTextProperty;
        public System.Boolean RichText
        {
            get { return AdUnitName.RichText; }
            set { AdUnitName.RichText = value; }
        }

        public readonly static DependencyProperty ParseCtrlCharactersProperty = Label.ParseCtrlCharactersProperty;
        public System.Boolean ParseCtrlCharacters
        {
            get { return AdUnitName.ParseCtrlCharacters; }
            set { AdUnitName.ParseCtrlCharacters = value; }
        }

        public readonly static DependencyProperty IsOverlayProperty = Label.IsOverlayProperty;
        public System.Boolean IsOverlay
        {
            get { return AdUnitName.IsOverlay; }
            set { AdUnitName.IsOverlay = value; }
        }

        public readonly static DependencyProperty IsOrthographicProperty = Label.IsOrthographicProperty;
        public System.Boolean IsOrthographic
        {
            get { return AdUnitName.IsOrthographic; }
            set { AdUnitName.IsOrthographic = value; }
        }

        public readonly static DependencyProperty EnableCullingProperty = Label.EnableCullingProperty;
        public System.Boolean EnableCulling
        {
            get { return AdUnitName.EnableCulling; }
            set { AdUnitName.EnableCulling = value; }
        }

        public readonly static DependencyProperty IgnoreVisibilityProperty = Label.IgnoreVisibilityProperty;
        public System.Boolean IgnoreVisibility
        {
            get { return AdUnitName.IgnoreVisibility; }
            set { AdUnitName.IgnoreVisibility = value; }
        }

        public readonly static DependencyProperty HorizontalMappingProperty = Label.HorizontalMappingProperty;
        public TMPro.TextureMappingOptions HorizontalMapping
        {
            get { return AdUnitName.HorizontalMapping; }
            set { AdUnitName.HorizontalMapping = value; }
        }

        public readonly static DependencyProperty VerticalMappingProperty = Label.VerticalMappingProperty;
        public TMPro.TextureMappingOptions VerticalMapping
        {
            get { return AdUnitName.VerticalMapping; }
            set { AdUnitName.VerticalMapping = value; }
        }

        public readonly static DependencyProperty MappingUvLineOffsetProperty = Label.MappingUvLineOffsetProperty;
        public System.Single MappingUvLineOffset
        {
            get { return AdUnitName.MappingUvLineOffset; }
            set { AdUnitName.MappingUvLineOffset = value; }
        }

        public readonly static DependencyProperty RenderModeProperty = Label.RenderModeProperty;
        public TMPro.TextRenderFlags RenderMode
        {
            get { return AdUnitName.RenderMode; }
            set { AdUnitName.RenderMode = value; }
        }

        public readonly static DependencyProperty GeometrySortingOrderProperty = Label.GeometrySortingOrderProperty;
        public TMPro.VertexSortingOrder GeometrySortingOrder
        {
            get { return AdUnitName.GeometrySortingOrder; }
            set { AdUnitName.GeometrySortingOrder = value; }
        }

        public readonly static DependencyProperty IsTextObjectScaleStaticProperty = Label.IsTextObjectScaleStaticProperty;
        public System.Boolean IsTextObjectScaleStatic
        {
            get { return AdUnitName.IsTextObjectScaleStatic; }
            set { AdUnitName.IsTextObjectScaleStatic = value; }
        }

        public readonly static DependencyProperty VertexBufferAutoSizeReductionProperty = Label.VertexBufferAutoSizeReductionProperty;
        public System.Boolean VertexBufferAutoSizeReduction
        {
            get { return AdUnitName.VertexBufferAutoSizeReduction; }
            set { AdUnitName.VertexBufferAutoSizeReduction = value; }
        }

        public readonly static DependencyProperty FirstVisibleCharacterProperty = Label.FirstVisibleCharacterProperty;
        public System.Int32 FirstVisibleCharacter
        {
            get { return AdUnitName.FirstVisibleCharacter; }
            set { AdUnitName.FirstVisibleCharacter = value; }
        }

        public readonly static DependencyProperty MaxVisibleCharactersProperty = Label.MaxVisibleCharactersProperty;
        public System.Int32 MaxVisibleCharacters
        {
            get { return AdUnitName.MaxVisibleCharacters; }
            set { AdUnitName.MaxVisibleCharacters = value; }
        }

        public readonly static DependencyProperty MaxVisibleWordsProperty = Label.MaxVisibleWordsProperty;
        public System.Int32 MaxVisibleWords
        {
            get { return AdUnitName.MaxVisibleWords; }
            set { AdUnitName.MaxVisibleWords = value; }
        }

        public readonly static DependencyProperty MaxVisibleLinesProperty = Label.MaxVisibleLinesProperty;
        public System.Int32 MaxVisibleLines
        {
            get { return AdUnitName.MaxVisibleLines; }
            set { AdUnitName.MaxVisibleLines = value; }
        }

        public readonly static DependencyProperty UseMaxVisibleDescenderProperty = Label.UseMaxVisibleDescenderProperty;
        public System.Boolean UseMaxVisibleDescender
        {
            get { return AdUnitName.UseMaxVisibleDescender; }
            set { AdUnitName.UseMaxVisibleDescender = value; }
        }

        public readonly static DependencyProperty PageToDisplayProperty = Label.PageToDisplayProperty;
        public System.Int32 PageToDisplay
        {
            get { return AdUnitName.PageToDisplay; }
            set { AdUnitName.PageToDisplay = value; }
        }

        public readonly static DependencyProperty TextMarginProperty = Label.TextMarginProperty;
        public UnityEngine.Vector4 TextMargin
        {
            get { return AdUnitName.TextMargin; }
            set { AdUnitName.TextMargin = value; }
        }

        public readonly static DependencyProperty HavePropertiesChangedProperty = Label.HavePropertiesChangedProperty;
        public System.Boolean HavePropertiesChanged
        {
            get { return AdUnitName.HavePropertiesChanged; }
            set { AdUnitName.HavePropertiesChanged = value; }
        }

        public readonly static DependencyProperty IsUsingLegacyAnimationComponentProperty = Label.IsUsingLegacyAnimationComponentProperty;
        public System.Boolean IsUsingLegacyAnimationComponent
        {
            get { return AdUnitName.IsUsingLegacyAnimationComponent; }
            set { AdUnitName.IsUsingLegacyAnimationComponent = value; }
        }

        public readonly static DependencyProperty IsVolumetricTextProperty = Label.IsVolumetricTextProperty;
        public System.Boolean IsVolumetricText
        {
            get { return AdUnitName.IsVolumetricText; }
            set { AdUnitName.IsVolumetricText = value; }
        }

        public readonly static DependencyProperty OnCullStateChangedProperty = Label.OnCullStateChangedProperty;
        public UnityEngine.UI.MaskableGraphic.CullStateChangedEvent OnCullStateChanged
        {
            get { return AdUnitName.OnCullStateChanged; }
            set { AdUnitName.OnCullStateChanged = value; }
        }

        public readonly static DependencyProperty MaskableProperty = Label.MaskableProperty;
        public System.Boolean Maskable
        {
            get { return AdUnitName.Maskable; }
            set { AdUnitName.Maskable = value; }
        }

        public readonly static DependencyProperty IsMaskingGraphicProperty = Label.IsMaskingGraphicProperty;
        public System.Boolean IsMaskingGraphic
        {
            get { return AdUnitName.IsMaskingGraphic; }
            set { AdUnitName.IsMaskingGraphic = value; }
        }

        public readonly static DependencyProperty RaycastTargetProperty = Label.RaycastTargetProperty;
        public System.Boolean RaycastTarget
        {
            get { return AdUnitName.RaycastTarget; }
            set { AdUnitName.RaycastTarget = value; }
        }

        public readonly static DependencyProperty MaterialProperty = Label.MaterialProperty;
        public MaterialAsset Material
        {
            get { return AdUnitName.Material; }
            set { AdUnitName.Material = value; }
        }

        public readonly static DependencyProperty AdUnitNameWidthProperty = Label.WidthProperty;
        public Delight.ElementSize AdUnitNameWidth
        {
            get { return AdUnitName.Width; }
            set { AdUnitName.Width = value; }
        }

        public readonly static DependencyProperty AdUnitNameHeightProperty = Label.HeightProperty;
        public Delight.ElementSize AdUnitNameHeight
        {
            get { return AdUnitName.Height; }
            set { AdUnitName.Height = value; }
        }

        public readonly static DependencyProperty AdUnitNameOverrideWidthProperty = Label.OverrideWidthProperty;
        public Delight.ElementSize AdUnitNameOverrideWidth
        {
            get { return AdUnitName.OverrideWidth; }
            set { AdUnitName.OverrideWidth = value; }
        }

        public readonly static DependencyProperty AdUnitNameOverrideHeightProperty = Label.OverrideHeightProperty;
        public Delight.ElementSize AdUnitNameOverrideHeight
        {
            get { return AdUnitName.OverrideHeight; }
            set { AdUnitName.OverrideHeight = value; }
        }

        public readonly static DependencyProperty AdUnitNameScaleProperty = Label.ScaleProperty;
        public UnityEngine.Vector3 AdUnitNameScale
        {
            get { return AdUnitName.Scale; }
            set { AdUnitName.Scale = value; }
        }

        public readonly static DependencyProperty AdUnitNameAlignmentProperty = Label.AlignmentProperty;
        public Delight.ElementAlignment AdUnitNameAlignment
        {
            get { return AdUnitName.Alignment; }
            set { AdUnitName.Alignment = value; }
        }

        public readonly static DependencyProperty AdUnitNameMarginProperty = Label.MarginProperty;
        public Delight.ElementMargin AdUnitNameMargin
        {
            get { return AdUnitName.Margin; }
            set { AdUnitName.Margin = value; }
        }

        public readonly static DependencyProperty AdUnitNameOffsetProperty = Label.OffsetProperty;
        public Delight.ElementMargin AdUnitNameOffset
        {
            get { return AdUnitName.Offset; }
            set { AdUnitName.Offset = value; }
        }

        public readonly static DependencyProperty AdUnitNameOffsetFromParentProperty = Label.OffsetFromParentProperty;
        public Delight.ElementMargin AdUnitNameOffsetFromParent
        {
            get { return AdUnitName.OffsetFromParent; }
            set { AdUnitName.OffsetFromParent = value; }
        }

        public readonly static DependencyProperty AdUnitNamePivotProperty = Label.PivotProperty;
        public UnityEngine.Vector2 AdUnitNamePivot
        {
            get { return AdUnitName.Pivot; }
            set { AdUnitName.Pivot = value; }
        }

        public readonly static DependencyProperty AdUnitNameDisableLayoutUpdateProperty = Label.DisableLayoutUpdateProperty;
        public System.Boolean AdUnitNameDisableLayoutUpdate
        {
            get { return AdUnitName.DisableLayoutUpdate; }
            set { AdUnitName.DisableLayoutUpdate = value; }
        }

        public readonly static DependencyProperty AdUnitNameAlphaProperty = Label.AlphaProperty;
        public System.Single AdUnitNameAlpha
        {
            get { return AdUnitName.Alpha; }
            set { AdUnitName.Alpha = value; }
        }

        public readonly static DependencyProperty AdUnitNameIsVisibleProperty = Label.IsVisibleProperty;
        public System.Boolean AdUnitNameIsVisible
        {
            get { return AdUnitName.IsVisible; }
            set { AdUnitName.IsVisible = value; }
        }

        public readonly static DependencyProperty AdUnitNameRaycastBlockModeProperty = Label.RaycastBlockModeProperty;
        public Delight.RaycastBlockMode AdUnitNameRaycastBlockMode
        {
            get { return AdUnitName.RaycastBlockMode; }
            set { AdUnitName.RaycastBlockMode = value; }
        }

        public readonly static DependencyProperty AdUnitNameIsInteractableProperty = Label.IsInteractableProperty;
        public System.Boolean AdUnitNameIsInteractable
        {
            get { return AdUnitName.IsInteractable; }
            set { AdUnitName.IsInteractable = value; }
        }

        public readonly static DependencyProperty AdUnitNameUseFastShaderProperty = Label.UseFastShaderProperty;
        public System.Boolean AdUnitNameUseFastShader
        {
            get { return AdUnitName.UseFastShader; }
            set { AdUnitName.UseFastShader = value; }
        }

        public readonly static DependencyProperty AdUnitNameBubbleNotifyChildLayoutChangedProperty = Label.BubbleNotifyChildLayoutChangedProperty;
        public System.Boolean AdUnitNameBubbleNotifyChildLayoutChanged
        {
            get { return AdUnitName.BubbleNotifyChildLayoutChanged; }
            set { AdUnitName.BubbleNotifyChildLayoutChanged = value; }
        }

        public readonly static DependencyProperty AdUnitNameIgnoreFlipProperty = Label.IgnoreFlipProperty;
        public System.Boolean AdUnitNameIgnoreFlip
        {
            get { return AdUnitName.IgnoreFlip; }
            set { AdUnitName.IgnoreFlip = value; }
        }

        public readonly static DependencyProperty AdUnitNameRotationProperty = Label.RotationProperty;
        public UnityEngine.Quaternion AdUnitNameRotation
        {
            get { return AdUnitName.Rotation; }
            set { AdUnitName.Rotation = value; }
        }

        public readonly static DependencyProperty AdUnitNamePositionProperty = Label.PositionProperty;
        public UnityEngine.Vector3 AdUnitNamePosition
        {
            get { return AdUnitName.Position; }
            set { AdUnitName.Position = value; }
        }

        public readonly static DependencyProperty AdUnitNameAdjustToParentProperty = Label.AdjustToParentProperty;
        public Delight.AdjustToParent AdUnitNameAdjustToParent
        {
            get { return AdUnitName.AdjustToParent; }
            set { AdUnitName.AdjustToParent = value; }
        }

        public readonly static DependencyProperty AdUnitNameGameObjectProperty = Label.GameObjectProperty;
        public UnityEngine.GameObject AdUnitNameGameObject
        {
            get { return AdUnitName.GameObject; }
            set { AdUnitName.GameObject = value; }
        }

        public readonly static DependencyProperty AdUnitNameEnableScriptEventsProperty = Label.EnableScriptEventsProperty;
        public System.Boolean AdUnitNameEnableScriptEvents
        {
            get { return AdUnitName.EnableScriptEvents; }
            set { AdUnitName.EnableScriptEvents = value; }
        }

        public readonly static DependencyProperty AdUnitNameIgnoreObjectProperty = Label.IgnoreObjectProperty;
        public System.Boolean AdUnitNameIgnoreObject
        {
            get { return AdUnitName.IgnoreObject; }
            set { AdUnitName.IgnoreObject = value; }
        }

        public readonly static DependencyProperty AdUnitNameIsActiveProperty = Label.IsActiveProperty;
        public System.Boolean AdUnitNameIsActive
        {
            get { return AdUnitName.IsActive; }
            set { AdUnitName.IsActive = value; }
        }

        public readonly static DependencyProperty AdUnitNameLoadModeProperty = Label.LoadModeProperty;
        public Delight.LoadMode AdUnitNameLoadMode
        {
            get { return AdUnitName.LoadMode; }
            set { AdUnitName.LoadMode = value; }
        }

        public readonly static DependencyProperty AdUnitIdMaxWidthProperty = Label.MaxWidthProperty;
        public Delight.ElementSize AdUnitIdMaxWidth
        {
            get { return AdUnitId.MaxWidth; }
            set { AdUnitId.MaxWidth = value; }
        }

        public readonly static DependencyProperty AdUnitIdAutoSizeProperty = Label.AutoSizeProperty;
        public Delight.AutoSize AdUnitIdAutoSize
        {
            get { return AdUnitId.AutoSize; }
            set { AdUnitId.AutoSize = value; }
        }

        public readonly static DependencyProperty AdUnitIdAutoSizeTextContainerProperty = Label.AutoSizeTextContainerProperty;
        public System.Boolean AdUnitIdAutoSizeTextContainer
        {
            get { return AdUnitId.AutoSizeTextContainer; }
            set { AdUnitId.AutoSizeTextContainer = value; }
        }

        public readonly static DependencyProperty AdUnitIdMaskOffsetProperty = Label.MaskOffsetProperty;
        public UnityEngine.Vector4 AdUnitIdMaskOffset
        {
            get { return AdUnitId.MaskOffset; }
            set { AdUnitId.MaskOffset = value; }
        }

        public readonly static DependencyProperty AdUnitIdTextProperty = Label.TextProperty;
        public System.String AdUnitIdText
        {
            get { return AdUnitId.Text; }
            set { AdUnitId.Text = value; }
        }

        public readonly static DependencyProperty AdUnitIdTextPreprocessorProperty = Label.TextPreprocessorProperty;
        public TMPro.ITextPreprocessor AdUnitIdTextPreprocessor
        {
            get { return AdUnitId.TextPreprocessor; }
            set { AdUnitId.TextPreprocessor = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsRightToLeftTextProperty = Label.IsRightToLeftTextProperty;
        public System.Boolean AdUnitIdIsRightToLeftText
        {
            get { return AdUnitId.IsRightToLeftText; }
            set { AdUnitId.IsRightToLeftText = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontProperty = Label.FontProperty;
        public TMP_FontAsset AdUnitIdFont
        {
            get { return AdUnitId.Font; }
            set { AdUnitId.Font = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontSharedMaterialProperty = Label.FontSharedMaterialProperty;
        public MaterialAsset AdUnitIdFontSharedMaterial
        {
            get { return AdUnitId.FontSharedMaterial; }
            set { AdUnitId.FontSharedMaterial = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontSharedMaterialsProperty = Label.FontSharedMaterialsProperty;
        public UnityEngine.Material[] AdUnitIdFontSharedMaterials
        {
            get { return AdUnitId.FontSharedMaterials; }
            set { AdUnitId.FontSharedMaterials = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontMaterialProperty = Label.FontMaterialProperty;
        public MaterialAsset AdUnitIdFontMaterial
        {
            get { return AdUnitId.FontMaterial; }
            set { AdUnitId.FontMaterial = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontMaterialsProperty = Label.FontMaterialsProperty;
        public UnityEngine.Material[] AdUnitIdFontMaterials
        {
            get { return AdUnitId.FontMaterials; }
            set { AdUnitId.FontMaterials = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontColorProperty = Label.FontColorProperty;
        public UnityEngine.Color AdUnitIdFontColor
        {
            get { return AdUnitId.FontColor; }
            set { AdUnitId.FontColor = value; }
        }

        public readonly static DependencyProperty AdUnitIdTextMeshProUGUIAlphaProperty = Label.TextMeshProUGUIAlphaProperty;
        public System.Single AdUnitIdTextMeshProUGUIAlpha
        {
            get { return AdUnitId.TextMeshProUGUIAlpha; }
            set { AdUnitId.TextMeshProUGUIAlpha = value; }
        }

        public readonly static DependencyProperty AdUnitIdEnableVertexGradientProperty = Label.EnableVertexGradientProperty;
        public System.Boolean AdUnitIdEnableVertexGradient
        {
            get { return AdUnitId.EnableVertexGradient; }
            set { AdUnitId.EnableVertexGradient = value; }
        }

        public readonly static DependencyProperty AdUnitIdColorGradientProperty = Label.ColorGradientProperty;
        public TMPro.VertexGradient AdUnitIdColorGradient
        {
            get { return AdUnitId.ColorGradient; }
            set { AdUnitId.ColorGradient = value; }
        }

        public readonly static DependencyProperty AdUnitIdColorGradientPresetProperty = Label.ColorGradientPresetProperty;
        public TMP_ColorGradientAsset AdUnitIdColorGradientPreset
        {
            get { return AdUnitId.ColorGradientPreset; }
            set { AdUnitId.ColorGradientPreset = value; }
        }

        public readonly static DependencyProperty AdUnitIdSpriteAssetProperty = Label.SpriteAssetProperty;
        public TMP_SpriteAsset AdUnitIdSpriteAsset
        {
            get { return AdUnitId.SpriteAsset; }
            set { AdUnitId.SpriteAsset = value; }
        }

        public readonly static DependencyProperty AdUnitIdTintAllSpritesProperty = Label.TintAllSpritesProperty;
        public System.Boolean AdUnitIdTintAllSprites
        {
            get { return AdUnitId.TintAllSprites; }
            set { AdUnitId.TintAllSprites = value; }
        }

        public readonly static DependencyProperty AdUnitIdStyleSheetProperty = Label.StyleSheetProperty;
        public TMP_StyleSheetAsset AdUnitIdStyleSheet
        {
            get { return AdUnitId.StyleSheet; }
            set { AdUnitId.StyleSheet = value; }
        }

        public readonly static DependencyProperty AdUnitIdTextStyleProperty = Label.TextStyleProperty;
        public TMPro.TMP_Style AdUnitIdTextStyle
        {
            get { return AdUnitId.TextStyle; }
            set { AdUnitId.TextStyle = value; }
        }

        public readonly static DependencyProperty AdUnitIdOverrideColorTagsProperty = Label.OverrideColorTagsProperty;
        public System.Boolean AdUnitIdOverrideColorTags
        {
            get { return AdUnitId.OverrideColorTags; }
            set { AdUnitId.OverrideColorTags = value; }
        }

        public readonly static DependencyProperty AdUnitIdFaceColorProperty = Label.FaceColorProperty;
        public UnityEngine.Color32 AdUnitIdFaceColor
        {
            get { return AdUnitId.FaceColor; }
            set { AdUnitId.FaceColor = value; }
        }

        public readonly static DependencyProperty AdUnitIdOutlineColorProperty = Label.OutlineColorProperty;
        public UnityEngine.Color32 AdUnitIdOutlineColor
        {
            get { return AdUnitId.OutlineColor; }
            set { AdUnitId.OutlineColor = value; }
        }

        public readonly static DependencyProperty AdUnitIdOutlineWidthProperty = Label.OutlineWidthProperty;
        public System.Single AdUnitIdOutlineWidth
        {
            get { return AdUnitId.OutlineWidth; }
            set { AdUnitId.OutlineWidth = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontSizeProperty = Label.FontSizeProperty;
        public System.Single AdUnitIdFontSize
        {
            get { return AdUnitId.FontSize; }
            set { AdUnitId.FontSize = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontWeightProperty = Label.FontWeightProperty;
        public TMPro.FontWeight AdUnitIdFontWeight
        {
            get { return AdUnitId.FontWeight; }
            set { AdUnitId.FontWeight = value; }
        }

        public readonly static DependencyProperty AdUnitIdEnableAutoSizingProperty = Label.EnableAutoSizingProperty;
        public System.Boolean AdUnitIdEnableAutoSizing
        {
            get { return AdUnitId.EnableAutoSizing; }
            set { AdUnitId.EnableAutoSizing = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontSizeMinProperty = Label.FontSizeMinProperty;
        public System.Single AdUnitIdFontSizeMin
        {
            get { return AdUnitId.FontSizeMin; }
            set { AdUnitId.FontSizeMin = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontSizeMaxProperty = Label.FontSizeMaxProperty;
        public System.Single AdUnitIdFontSizeMax
        {
            get { return AdUnitId.FontSizeMax; }
            set { AdUnitId.FontSizeMax = value; }
        }

        public readonly static DependencyProperty AdUnitIdFontStyleProperty = Label.FontStyleProperty;
        public TMPro.FontStyles AdUnitIdFontStyle
        {
            get { return AdUnitId.FontStyle; }
            set { AdUnitId.FontStyle = value; }
        }

        public readonly static DependencyProperty AdUnitIdHorizontalAlignmentProperty = Label.HorizontalAlignmentProperty;
        public TMPro.HorizontalAlignmentOptions AdUnitIdHorizontalAlignment
        {
            get { return AdUnitId.HorizontalAlignment; }
            set { AdUnitId.HorizontalAlignment = value; }
        }

        public readonly static DependencyProperty AdUnitIdVerticalAlignmentProperty = Label.VerticalAlignmentProperty;
        public TMPro.VerticalAlignmentOptions AdUnitIdVerticalAlignment
        {
            get { return AdUnitId.VerticalAlignment; }
            set { AdUnitId.VerticalAlignment = value; }
        }

        public readonly static DependencyProperty AdUnitIdTextAlignmentProperty = Label.TextAlignmentProperty;
        public TMPro.TextAlignmentOptions AdUnitIdTextAlignment
        {
            get { return AdUnitId.TextAlignment; }
            set { AdUnitId.TextAlignment = value; }
        }

        public readonly static DependencyProperty AdUnitIdCharacterSpacingProperty = Label.CharacterSpacingProperty;
        public System.Single AdUnitIdCharacterSpacing
        {
            get { return AdUnitId.CharacterSpacing; }
            set { AdUnitId.CharacterSpacing = value; }
        }

        public readonly static DependencyProperty AdUnitIdWordSpacingProperty = Label.WordSpacingProperty;
        public System.Single AdUnitIdWordSpacing
        {
            get { return AdUnitId.WordSpacing; }
            set { AdUnitId.WordSpacing = value; }
        }

        public readonly static DependencyProperty AdUnitIdLineSpacingProperty = Label.LineSpacingProperty;
        public System.Single AdUnitIdLineSpacing
        {
            get { return AdUnitId.LineSpacing; }
            set { AdUnitId.LineSpacing = value; }
        }

        public readonly static DependencyProperty AdUnitIdLineSpacingAdjustmentProperty = Label.LineSpacingAdjustmentProperty;
        public System.Single AdUnitIdLineSpacingAdjustment
        {
            get { return AdUnitId.LineSpacingAdjustment; }
            set { AdUnitId.LineSpacingAdjustment = value; }
        }

        public readonly static DependencyProperty AdUnitIdParagraphSpacingProperty = Label.ParagraphSpacingProperty;
        public System.Single AdUnitIdParagraphSpacing
        {
            get { return AdUnitId.ParagraphSpacing; }
            set { AdUnitId.ParagraphSpacing = value; }
        }

        public readonly static DependencyProperty AdUnitIdCharacterWidthAdjustmentProperty = Label.CharacterWidthAdjustmentProperty;
        public System.Single AdUnitIdCharacterWidthAdjustment
        {
            get { return AdUnitId.CharacterWidthAdjustment; }
            set { AdUnitId.CharacterWidthAdjustment = value; }
        }

        public readonly static DependencyProperty AdUnitIdEnableWordWrappingProperty = Label.EnableWordWrappingProperty;
        public System.Boolean AdUnitIdEnableWordWrapping
        {
            get { return AdUnitId.EnableWordWrapping; }
            set { AdUnitId.EnableWordWrapping = value; }
        }

        public readonly static DependencyProperty AdUnitIdWordWrappingRatiosProperty = Label.WordWrappingRatiosProperty;
        public System.Single AdUnitIdWordWrappingRatios
        {
            get { return AdUnitId.WordWrappingRatios; }
            set { AdUnitId.WordWrappingRatios = value; }
        }

        public readonly static DependencyProperty AdUnitIdOverflowModeProperty = Label.OverflowModeProperty;
        public TMPro.TextOverflowModes AdUnitIdOverflowMode
        {
            get { return AdUnitId.OverflowMode; }
            set { AdUnitId.OverflowMode = value; }
        }

        public readonly static DependencyProperty AdUnitIdLinkedTextComponentProperty = Label.LinkedTextComponentProperty;
        public TMPro.TMP_Text AdUnitIdLinkedTextComponent
        {
            get { return AdUnitId.LinkedTextComponent; }
            set { AdUnitId.LinkedTextComponent = value; }
        }

        public readonly static DependencyProperty AdUnitIdEnableKerningProperty = Label.EnableKerningProperty;
        public System.Boolean AdUnitIdEnableKerning
        {
            get { return AdUnitId.EnableKerning; }
            set { AdUnitId.EnableKerning = value; }
        }

        public readonly static DependencyProperty AdUnitIdExtraPaddingProperty = Label.ExtraPaddingProperty;
        public System.Boolean AdUnitIdExtraPadding
        {
            get { return AdUnitId.ExtraPadding; }
            set { AdUnitId.ExtraPadding = value; }
        }

        public readonly static DependencyProperty AdUnitIdRichTextProperty = Label.RichTextProperty;
        public System.Boolean AdUnitIdRichText
        {
            get { return AdUnitId.RichText; }
            set { AdUnitId.RichText = value; }
        }

        public readonly static DependencyProperty AdUnitIdParseCtrlCharactersProperty = Label.ParseCtrlCharactersProperty;
        public System.Boolean AdUnitIdParseCtrlCharacters
        {
            get { return AdUnitId.ParseCtrlCharacters; }
            set { AdUnitId.ParseCtrlCharacters = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsOverlayProperty = Label.IsOverlayProperty;
        public System.Boolean AdUnitIdIsOverlay
        {
            get { return AdUnitId.IsOverlay; }
            set { AdUnitId.IsOverlay = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsOrthographicProperty = Label.IsOrthographicProperty;
        public System.Boolean AdUnitIdIsOrthographic
        {
            get { return AdUnitId.IsOrthographic; }
            set { AdUnitId.IsOrthographic = value; }
        }

        public readonly static DependencyProperty AdUnitIdEnableCullingProperty = Label.EnableCullingProperty;
        public System.Boolean AdUnitIdEnableCulling
        {
            get { return AdUnitId.EnableCulling; }
            set { AdUnitId.EnableCulling = value; }
        }

        public readonly static DependencyProperty AdUnitIdIgnoreVisibilityProperty = Label.IgnoreVisibilityProperty;
        public System.Boolean AdUnitIdIgnoreVisibility
        {
            get { return AdUnitId.IgnoreVisibility; }
            set { AdUnitId.IgnoreVisibility = value; }
        }

        public readonly static DependencyProperty AdUnitIdHorizontalMappingProperty = Label.HorizontalMappingProperty;
        public TMPro.TextureMappingOptions AdUnitIdHorizontalMapping
        {
            get { return AdUnitId.HorizontalMapping; }
            set { AdUnitId.HorizontalMapping = value; }
        }

        public readonly static DependencyProperty AdUnitIdVerticalMappingProperty = Label.VerticalMappingProperty;
        public TMPro.TextureMappingOptions AdUnitIdVerticalMapping
        {
            get { return AdUnitId.VerticalMapping; }
            set { AdUnitId.VerticalMapping = value; }
        }

        public readonly static DependencyProperty AdUnitIdMappingUvLineOffsetProperty = Label.MappingUvLineOffsetProperty;
        public System.Single AdUnitIdMappingUvLineOffset
        {
            get { return AdUnitId.MappingUvLineOffset; }
            set { AdUnitId.MappingUvLineOffset = value; }
        }

        public readonly static DependencyProperty AdUnitIdRenderModeProperty = Label.RenderModeProperty;
        public TMPro.TextRenderFlags AdUnitIdRenderMode
        {
            get { return AdUnitId.RenderMode; }
            set { AdUnitId.RenderMode = value; }
        }

        public readonly static DependencyProperty AdUnitIdGeometrySortingOrderProperty = Label.GeometrySortingOrderProperty;
        public TMPro.VertexSortingOrder AdUnitIdGeometrySortingOrder
        {
            get { return AdUnitId.GeometrySortingOrder; }
            set { AdUnitId.GeometrySortingOrder = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsTextObjectScaleStaticProperty = Label.IsTextObjectScaleStaticProperty;
        public System.Boolean AdUnitIdIsTextObjectScaleStatic
        {
            get { return AdUnitId.IsTextObjectScaleStatic; }
            set { AdUnitId.IsTextObjectScaleStatic = value; }
        }

        public readonly static DependencyProperty AdUnitIdVertexBufferAutoSizeReductionProperty = Label.VertexBufferAutoSizeReductionProperty;
        public System.Boolean AdUnitIdVertexBufferAutoSizeReduction
        {
            get { return AdUnitId.VertexBufferAutoSizeReduction; }
            set { AdUnitId.VertexBufferAutoSizeReduction = value; }
        }

        public readonly static DependencyProperty AdUnitIdFirstVisibleCharacterProperty = Label.FirstVisibleCharacterProperty;
        public System.Int32 AdUnitIdFirstVisibleCharacter
        {
            get { return AdUnitId.FirstVisibleCharacter; }
            set { AdUnitId.FirstVisibleCharacter = value; }
        }

        public readonly static DependencyProperty AdUnitIdMaxVisibleCharactersProperty = Label.MaxVisibleCharactersProperty;
        public System.Int32 AdUnitIdMaxVisibleCharacters
        {
            get { return AdUnitId.MaxVisibleCharacters; }
            set { AdUnitId.MaxVisibleCharacters = value; }
        }

        public readonly static DependencyProperty AdUnitIdMaxVisibleWordsProperty = Label.MaxVisibleWordsProperty;
        public System.Int32 AdUnitIdMaxVisibleWords
        {
            get { return AdUnitId.MaxVisibleWords; }
            set { AdUnitId.MaxVisibleWords = value; }
        }

        public readonly static DependencyProperty AdUnitIdMaxVisibleLinesProperty = Label.MaxVisibleLinesProperty;
        public System.Int32 AdUnitIdMaxVisibleLines
        {
            get { return AdUnitId.MaxVisibleLines; }
            set { AdUnitId.MaxVisibleLines = value; }
        }

        public readonly static DependencyProperty AdUnitIdUseMaxVisibleDescenderProperty = Label.UseMaxVisibleDescenderProperty;
        public System.Boolean AdUnitIdUseMaxVisibleDescender
        {
            get { return AdUnitId.UseMaxVisibleDescender; }
            set { AdUnitId.UseMaxVisibleDescender = value; }
        }

        public readonly static DependencyProperty AdUnitIdPageToDisplayProperty = Label.PageToDisplayProperty;
        public System.Int32 AdUnitIdPageToDisplay
        {
            get { return AdUnitId.PageToDisplay; }
            set { AdUnitId.PageToDisplay = value; }
        }

        public readonly static DependencyProperty AdUnitIdTextMarginProperty = Label.TextMarginProperty;
        public UnityEngine.Vector4 AdUnitIdTextMargin
        {
            get { return AdUnitId.TextMargin; }
            set { AdUnitId.TextMargin = value; }
        }

        public readonly static DependencyProperty AdUnitIdHavePropertiesChangedProperty = Label.HavePropertiesChangedProperty;
        public System.Boolean AdUnitIdHavePropertiesChanged
        {
            get { return AdUnitId.HavePropertiesChanged; }
            set { AdUnitId.HavePropertiesChanged = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsUsingLegacyAnimationComponentProperty = Label.IsUsingLegacyAnimationComponentProperty;
        public System.Boolean AdUnitIdIsUsingLegacyAnimationComponent
        {
            get { return AdUnitId.IsUsingLegacyAnimationComponent; }
            set { AdUnitId.IsUsingLegacyAnimationComponent = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsVolumetricTextProperty = Label.IsVolumetricTextProperty;
        public System.Boolean AdUnitIdIsVolumetricText
        {
            get { return AdUnitId.IsVolumetricText; }
            set { AdUnitId.IsVolumetricText = value; }
        }

        public readonly static DependencyProperty AdUnitIdOnCullStateChangedProperty = Label.OnCullStateChangedProperty;
        public UnityEngine.UI.MaskableGraphic.CullStateChangedEvent AdUnitIdOnCullStateChanged
        {
            get { return AdUnitId.OnCullStateChanged; }
            set { AdUnitId.OnCullStateChanged = value; }
        }

        public readonly static DependencyProperty AdUnitIdMaskableProperty = Label.MaskableProperty;
        public System.Boolean AdUnitIdMaskable
        {
            get { return AdUnitId.Maskable; }
            set { AdUnitId.Maskable = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsMaskingGraphicProperty = Label.IsMaskingGraphicProperty;
        public System.Boolean AdUnitIdIsMaskingGraphic
        {
            get { return AdUnitId.IsMaskingGraphic; }
            set { AdUnitId.IsMaskingGraphic = value; }
        }

        public readonly static DependencyProperty AdUnitIdRaycastTargetProperty = Label.RaycastTargetProperty;
        public System.Boolean AdUnitIdRaycastTarget
        {
            get { return AdUnitId.RaycastTarget; }
            set { AdUnitId.RaycastTarget = value; }
        }

        public readonly static DependencyProperty AdUnitIdMaterialProperty = Label.MaterialProperty;
        public MaterialAsset AdUnitIdMaterial
        {
            get { return AdUnitId.Material; }
            set { AdUnitId.Material = value; }
        }

        public readonly static DependencyProperty AdUnitIdWidthProperty = Label.WidthProperty;
        public Delight.ElementSize AdUnitIdWidth
        {
            get { return AdUnitId.Width; }
            set { AdUnitId.Width = value; }
        }

        public readonly static DependencyProperty AdUnitIdHeightProperty = Label.HeightProperty;
        public Delight.ElementSize AdUnitIdHeight
        {
            get { return AdUnitId.Height; }
            set { AdUnitId.Height = value; }
        }

        public readonly static DependencyProperty AdUnitIdOverrideWidthProperty = Label.OverrideWidthProperty;
        public Delight.ElementSize AdUnitIdOverrideWidth
        {
            get { return AdUnitId.OverrideWidth; }
            set { AdUnitId.OverrideWidth = value; }
        }

        public readonly static DependencyProperty AdUnitIdOverrideHeightProperty = Label.OverrideHeightProperty;
        public Delight.ElementSize AdUnitIdOverrideHeight
        {
            get { return AdUnitId.OverrideHeight; }
            set { AdUnitId.OverrideHeight = value; }
        }

        public readonly static DependencyProperty AdUnitIdScaleProperty = Label.ScaleProperty;
        public UnityEngine.Vector3 AdUnitIdScale
        {
            get { return AdUnitId.Scale; }
            set { AdUnitId.Scale = value; }
        }

        public readonly static DependencyProperty AdUnitIdAlignmentProperty = Label.AlignmentProperty;
        public Delight.ElementAlignment AdUnitIdAlignment
        {
            get { return AdUnitId.Alignment; }
            set { AdUnitId.Alignment = value; }
        }

        public readonly static DependencyProperty AdUnitIdMarginProperty = Label.MarginProperty;
        public Delight.ElementMargin AdUnitIdMargin
        {
            get { return AdUnitId.Margin; }
            set { AdUnitId.Margin = value; }
        }

        public readonly static DependencyProperty AdUnitIdOffsetProperty = Label.OffsetProperty;
        public Delight.ElementMargin AdUnitIdOffset
        {
            get { return AdUnitId.Offset; }
            set { AdUnitId.Offset = value; }
        }

        public readonly static DependencyProperty AdUnitIdOffsetFromParentProperty = Label.OffsetFromParentProperty;
        public Delight.ElementMargin AdUnitIdOffsetFromParent
        {
            get { return AdUnitId.OffsetFromParent; }
            set { AdUnitId.OffsetFromParent = value; }
        }

        public readonly static DependencyProperty AdUnitIdPivotProperty = Label.PivotProperty;
        public UnityEngine.Vector2 AdUnitIdPivot
        {
            get { return AdUnitId.Pivot; }
            set { AdUnitId.Pivot = value; }
        }

        public readonly static DependencyProperty AdUnitIdDisableLayoutUpdateProperty = Label.DisableLayoutUpdateProperty;
        public System.Boolean AdUnitIdDisableLayoutUpdate
        {
            get { return AdUnitId.DisableLayoutUpdate; }
            set { AdUnitId.DisableLayoutUpdate = value; }
        }

        public readonly static DependencyProperty AdUnitIdAlphaProperty = Label.AlphaProperty;
        public System.Single AdUnitIdAlpha
        {
            get { return AdUnitId.Alpha; }
            set { AdUnitId.Alpha = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsVisibleProperty = Label.IsVisibleProperty;
        public System.Boolean AdUnitIdIsVisible
        {
            get { return AdUnitId.IsVisible; }
            set { AdUnitId.IsVisible = value; }
        }

        public readonly static DependencyProperty AdUnitIdRaycastBlockModeProperty = Label.RaycastBlockModeProperty;
        public Delight.RaycastBlockMode AdUnitIdRaycastBlockMode
        {
            get { return AdUnitId.RaycastBlockMode; }
            set { AdUnitId.RaycastBlockMode = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsInteractableProperty = Label.IsInteractableProperty;
        public System.Boolean AdUnitIdIsInteractable
        {
            get { return AdUnitId.IsInteractable; }
            set { AdUnitId.IsInteractable = value; }
        }

        public readonly static DependencyProperty AdUnitIdUseFastShaderProperty = Label.UseFastShaderProperty;
        public System.Boolean AdUnitIdUseFastShader
        {
            get { return AdUnitId.UseFastShader; }
            set { AdUnitId.UseFastShader = value; }
        }

        public readonly static DependencyProperty AdUnitIdBubbleNotifyChildLayoutChangedProperty = Label.BubbleNotifyChildLayoutChangedProperty;
        public System.Boolean AdUnitIdBubbleNotifyChildLayoutChanged
        {
            get { return AdUnitId.BubbleNotifyChildLayoutChanged; }
            set { AdUnitId.BubbleNotifyChildLayoutChanged = value; }
        }

        public readonly static DependencyProperty AdUnitIdIgnoreFlipProperty = Label.IgnoreFlipProperty;
        public System.Boolean AdUnitIdIgnoreFlip
        {
            get { return AdUnitId.IgnoreFlip; }
            set { AdUnitId.IgnoreFlip = value; }
        }

        public readonly static DependencyProperty AdUnitIdRotationProperty = Label.RotationProperty;
        public UnityEngine.Quaternion AdUnitIdRotation
        {
            get { return AdUnitId.Rotation; }
            set { AdUnitId.Rotation = value; }
        }

        public readonly static DependencyProperty AdUnitIdPositionProperty = Label.PositionProperty;
        public UnityEngine.Vector3 AdUnitIdPosition
        {
            get { return AdUnitId.Position; }
            set { AdUnitId.Position = value; }
        }

        public readonly static DependencyProperty AdUnitIdAdjustToParentProperty = Label.AdjustToParentProperty;
        public Delight.AdjustToParent AdUnitIdAdjustToParent
        {
            get { return AdUnitId.AdjustToParent; }
            set { AdUnitId.AdjustToParent = value; }
        }

        public readonly static DependencyProperty AdUnitIdGameObjectProperty = Label.GameObjectProperty;
        public UnityEngine.GameObject AdUnitIdGameObject
        {
            get { return AdUnitId.GameObject; }
            set { AdUnitId.GameObject = value; }
        }

        public readonly static DependencyProperty AdUnitIdEnableScriptEventsProperty = Label.EnableScriptEventsProperty;
        public System.Boolean AdUnitIdEnableScriptEvents
        {
            get { return AdUnitId.EnableScriptEvents; }
            set { AdUnitId.EnableScriptEvents = value; }
        }

        public readonly static DependencyProperty AdUnitIdIgnoreObjectProperty = Label.IgnoreObjectProperty;
        public System.Boolean AdUnitIdIgnoreObject
        {
            get { return AdUnitId.IgnoreObject; }
            set { AdUnitId.IgnoreObject = value; }
        }

        public readonly static DependencyProperty AdUnitIdIsActiveProperty = Label.IsActiveProperty;
        public System.Boolean AdUnitIdIsActive
        {
            get { return AdUnitId.IsActive; }
            set { AdUnitId.IsActive = value; }
        }

        public readonly static DependencyProperty AdUnitIdLoadModeProperty = Label.LoadModeProperty;
        public Delight.LoadMode AdUnitIdLoadMode
        {
            get { return AdUnitId.LoadMode; }
            set { AdUnitId.LoadMode = value; }
        }

        #endregion
    }

    #region Data Templates

    public static class MoPubAdUnitViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MoPubAdUnitView;
            }
        }

        private static Template _moPubAdUnitView;
        public static Template MoPubAdUnitView
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitView == null || _moPubAdUnitView.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitView == null)
#endif
                {
                    _moPubAdUnitView = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _moPubAdUnitView.Name = "MoPubAdUnitView";
                    _moPubAdUnitView.LineNumber = 0;
                    _moPubAdUnitView.LinePosition = 0;
#endif
                    Delight.MoPubAdUnitView.EnableScriptEventsProperty.SetDefault(_moPubAdUnitView, true);
                    Delight.MoPubAdUnitView.IsBannerProperty.SetDefault(_moPubAdUnitView, true);
                    Delight.MoPubAdUnitView.IsInterstitialProperty.SetDefault(_moPubAdUnitView, true);
                    Delight.MoPubAdUnitView.IsRewardedAdProperty.SetDefault(_moPubAdUnitView, true);
                    Delight.MoPubAdUnitView.Group1TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup1);
                    Delight.MoPubAdUnitView.Group2TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup2);
                    Delight.MoPubAdUnitView.Image1TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewImage1);
                    Delight.MoPubAdUnitView.Button1TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewButton1);
                    Delight.MoPubAdUnitView.Region1TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion1);
                    Delight.MoPubAdUnitView.AdUnitNameTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewAdUnitName);
                    Delight.MoPubAdUnitView.Label1TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewLabel1);
                    Delight.MoPubAdUnitView.AdUnitIdTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewAdUnitId);
                    Delight.MoPubAdUnitView.Region2TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion2);
                    Delight.MoPubAdUnitView.KeywordsTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewKeywords);
                    Delight.MoPubAdUnitView.KeywordsDelimiterTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewKeywordsDelimiter);
                    Delight.MoPubAdUnitView.UserDataKeywordsTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewUserDataKeywords);
                    Delight.MoPubAdUnitView.UserDataKeywordsDelimiterTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewUserDataKeywordsDelimiter);
                    Delight.MoPubAdUnitView.Region3TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion3);
                    Delight.MoPubAdUnitView.LoadAdButtonTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewLoadAdButton);
                    Delight.MoPubAdUnitView.ShowAdButtonTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewShowAdButton);
                    Delight.MoPubAdUnitView.Region4TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion4);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdLoadedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader1TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader1);
                    Delight.MoPubAdUnitView.Region5TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion5);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdLoadedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdLoadedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdLoadedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent1TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent1);
                    Delight.MoPubAdUnitView.Group3TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup3);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderHeightLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdLoadedExpanderHeightLabel);
                    Delight.MoPubAdUnitView.Region6TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion6);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdClickedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader2TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader2);
                    Delight.MoPubAdUnitView.Region7TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion7);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdClickedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdClickedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdClickedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent2TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent2);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region8TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion8);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdFailedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader3TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader3);
                    Delight.MoPubAdUnitView.Region9TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion9);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdFailedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdFailedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdFailedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent3TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent3);
                    Delight.MoPubAdUnitView.Group4TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup4);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderErrorLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnAdFailedExpanderErrorLabel);
                    Delight.MoPubAdUnitView.Region10TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion10);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialLoadedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader4TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader4);
                    Delight.MoPubAdUnitView.Region11TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion11);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialLoadedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialLoadedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent4TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent4);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region12TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion12);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialShownExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader5TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader5);
                    Delight.MoPubAdUnitView.Region13TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion13);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialShownExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialShownExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialShownExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent5TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent5);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region14TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion14);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialClickedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader6TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader6);
                    Delight.MoPubAdUnitView.Region15TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion15);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialClickedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialClickedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent6TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent6);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region16TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion16);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialDismissedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader7TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader7);
                    Delight.MoPubAdUnitView.Region17TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion17);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialDismissedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialDismissedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent7TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent7);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region18TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion18);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialFailedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader8TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader8);
                    Delight.MoPubAdUnitView.Region19TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion19);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialFailedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialFailedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent8TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent8);
                    Delight.MoPubAdUnitView.Group5TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup5);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderErrorLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnInterstitialFailedExpanderErrorLabel);
                    Delight.MoPubAdUnitView.Region20TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion20);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoLoadedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader9TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader9);
                    Delight.MoPubAdUnitView.Region21TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion21);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent9TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent9);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region22TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion22);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoShownExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader10TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader10);
                    Delight.MoPubAdUnitView.Region23TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion23);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoShownExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoShownExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent10TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent10);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region24TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion24);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClickedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader11TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader11);
                    Delight.MoPubAdUnitView.Region25TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion25);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent11TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent11);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region26TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion26);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClosedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader12TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader12);
                    Delight.MoPubAdUnitView.Region27TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion27);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent12TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent12);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region28TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion28);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoReceivedRewardExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader13TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader13);
                    Delight.MoPubAdUnitView.Region29TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion29);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent13TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent13);
                    Delight.MoPubAdUnitView.Group6TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup6);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderLabelLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderAmountLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel);
                    Delight.MoPubAdUnitView.Region30TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion30);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedToPlayExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader14TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader14);
                    Delight.MoPubAdUnitView.Region31TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion31);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent14TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent14);
                    Delight.MoPubAdUnitView.Group7TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup7);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderErrorLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel);
                    Delight.MoPubAdUnitView.Region32TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion32);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedEventExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader15TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader15);
                    Delight.MoPubAdUnitView.Region33TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion33);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent15TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent15);
                    Delight.MoPubAdUnitView.Group8TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup8);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderErrorLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel);
                    Delight.MoPubAdUnitView.Region34TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion34);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedBgExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader16TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader16);
                    Delight.MoPubAdUnitView.Region35TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion35);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent16TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent16);
                    Delight.MoPubAdUnitView.Group9TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup9);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderImpressionDataFieldTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField);
                    Delight.MoPubAdUnitView.Region36TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion36);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader17TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderHeader17);
                    Delight.MoPubAdUnitView.Region37TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion37);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderCheckImageTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderEventLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent17TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewExpanderContent17);
                    Delight.MoPubAdUnitView.Group10TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewGroup10);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderImpressionDataFieldTemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField);
                    Delight.MoPubAdUnitView.Region38TemplateProperty.SetDefault(_moPubAdUnitView, MoPubAdUnitViewRegion38);
                }
                return _moPubAdUnitView;
            }
        }

        private static Template _moPubAdUnitViewGroup1;
        public static Template MoPubAdUnitViewGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup1 == null || _moPubAdUnitViewGroup1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup1 == null)
#endif
                {
                    _moPubAdUnitViewGroup1 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup1.Name = "MoPubAdUnitViewGroup1";
                    _moPubAdUnitViewGroup1.LineNumber = 11;
                    _moPubAdUnitViewGroup1.LinePosition = 6;
#endif
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup1, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup1, Delight.ElementAlignment.Top);
                }
                return _moPubAdUnitViewGroup1;
            }
        }

        private static Template _moPubAdUnitViewGroup2;
        public static Template MoPubAdUnitViewGroup2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup2 == null || _moPubAdUnitViewGroup2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup2 == null)
#endif
                {
                    _moPubAdUnitViewGroup2 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup2.Name = "MoPubAdUnitViewGroup2";
                    _moPubAdUnitViewGroup2.LineNumber = 12;
                    _moPubAdUnitViewGroup2.LinePosition = 10;
#endif
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup2, Delight.ElementOrientation.Horizontal);
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup2, Delight.ElementAlignment.Left);
                }
                return _moPubAdUnitViewGroup2;
            }
        }

        private static Template _moPubAdUnitViewImage1;
        public static Template MoPubAdUnitViewImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewImage1 == null || _moPubAdUnitViewImage1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewImage1 == null)
#endif
                {
                    _moPubAdUnitViewImage1 = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewImage1.Name = "MoPubAdUnitViewImage1";
                    _moPubAdUnitViewImage1.LineNumber = 13;
                    _moPubAdUnitViewImage1.LinePosition = 14;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewImage1, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewImage1, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewImage1, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewImage1, Assets.Sprites["chevron-left"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewImage1, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewImage1, new ElementMargin(new ElementSize(15f, ElementSizeUnit.Pixels), new ElementSize(5f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewImage1;
            }
        }

        private static Template _moPubAdUnitViewButton1;
        public static Template MoPubAdUnitViewButton1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewButton1 == null || _moPubAdUnitViewButton1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewButton1 == null)
#endif
                {
                    _moPubAdUnitViewButton1 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _moPubAdUnitViewButton1.Name = "MoPubAdUnitViewButton1";
                    _moPubAdUnitViewButton1.LineNumber = 14;
                    _moPubAdUnitViewButton1.LinePosition = 14;
#endif
                    Delight.Button.HeightProperty.SetDefault(_moPubAdUnitViewButton1, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Button.WidthProperty.SetDefault(_moPubAdUnitViewButton1, new ElementSize(200f, ElementSizeUnit.Pixels));
                    Delight.Button.MarginProperty.SetDefault(_moPubAdUnitViewButton1, new ElementMargin(new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels)));
                    Delight.Button.AlignmentProperty.SetDefault(_moPubAdUnitViewButton1, Delight.ElementAlignment.Left);
                    Delight.Button.BackgroundColorProperty.SetDefault(_moPubAdUnitViewButton1, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _moPubAdUnitViewButton1, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _moPubAdUnitViewButton1, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Disabled", _moPubAdUnitViewButton1, new UnityEngine.Color(0.4901961f, 0.4901961f, 0.4901961f, 1f));
                    Delight.Button.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewButton1, Assets.Materials["UI-Fast-Default"]);
                    Delight.Button.OffsetProperty.SetDefault(_moPubAdUnitViewButton1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(50f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_moPubAdUnitViewButton1, MoPubAdUnitViewButton1Label);
                }
                return _moPubAdUnitViewButton1;
            }
        }

        private static Template _moPubAdUnitViewButton1Label;
        public static Template MoPubAdUnitViewButton1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewButton1Label == null || _moPubAdUnitViewButton1Label.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewButton1Label == null)
#endif
                {
                    _moPubAdUnitViewButton1Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _moPubAdUnitViewButton1Label.Name = "MoPubAdUnitViewButton1Label";
                    _moPubAdUnitViewButton1Label.LineNumber = 15;
                    _moPubAdUnitViewButton1Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewButton1Label, 50f);
                    Delight.Label.TextMarginProperty.SetDefault(_moPubAdUnitViewButton1Label, new Vector4(0f, 0f, 15f, 0f));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewButton1Label, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _moPubAdUnitViewButton1Label, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _moPubAdUnitViewButton1Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Disabled", _moPubAdUnitViewButton1Label, new UnityEngine.Color(0.8f, 0.8f, 0.8f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewButton1Label, "  Back");
                }
                return _moPubAdUnitViewButton1Label;
            }
        }

        private static Template _moPubAdUnitViewRegion1;
        public static Template MoPubAdUnitViewRegion1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion1 == null || _moPubAdUnitViewRegion1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion1 == null)
#endif
                {
                    _moPubAdUnitViewRegion1 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion1.Name = "MoPubAdUnitViewRegion1";
                    _moPubAdUnitViewRegion1.LineNumber = 17;
                    _moPubAdUnitViewRegion1.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion1, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion1, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 0.1568628f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion1, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewRegion1;
            }
        }

        private static Template _moPubAdUnitViewAdUnitName;
        public static Template MoPubAdUnitViewAdUnitName
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewAdUnitName == null || _moPubAdUnitViewAdUnitName.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewAdUnitName == null)
#endif
                {
                    _moPubAdUnitViewAdUnitName = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewAdUnitName.Name = "MoPubAdUnitViewAdUnitName";
                    _moPubAdUnitViewAdUnitName.LineNumber = 18;
                    _moPubAdUnitViewAdUnitName.LinePosition = 14;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewAdUnitName, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewAdUnitName, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewAdUnitName, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewAdUnitName, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewAdUnitName, 46f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewAdUnitName, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewAdUnitName, "AdUnitName_placeholder");
                }
                return _moPubAdUnitViewAdUnitName;
            }
        }

        private static Template _moPubAdUnitViewLabel1;
        public static Template MoPubAdUnitViewLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewLabel1 == null || _moPubAdUnitViewLabel1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewLabel1 == null)
#endif
                {
                    _moPubAdUnitViewLabel1 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewLabel1.Name = "MoPubAdUnitViewLabel1";
                    _moPubAdUnitViewLabel1.LineNumber = 21;
                    _moPubAdUnitViewLabel1.LinePosition = 10;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewLabel1, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewLabel1, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewLabel1, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewLabel1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewLabel1, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewLabel1, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewLabel1, 46f);
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewLabel1, "Ad Unit ID");
                }
                return _moPubAdUnitViewLabel1;
            }
        }

        private static Template _moPubAdUnitViewAdUnitId;
        public static Template MoPubAdUnitViewAdUnitId
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewAdUnitId == null || _moPubAdUnitViewAdUnitId.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewAdUnitId == null)
#endif
                {
                    _moPubAdUnitViewAdUnitId = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewAdUnitId.Name = "MoPubAdUnitViewAdUnitId";
                    _moPubAdUnitViewAdUnitId.LineNumber = 22;
                    _moPubAdUnitViewAdUnitId.LinePosition = 10;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewAdUnitId, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewAdUnitId, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewAdUnitId, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewAdUnitId, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewAdUnitId, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewAdUnitId, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewAdUnitId, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewAdUnitId, Delight.AutoSize.Default);
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewAdUnitId, "AdUnitId_placeholder");
                    Delight.Label.OffsetProperty.SetDefault(_moPubAdUnitViewAdUnitId, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-10f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewAdUnitId;
            }
        }

        private static Template _moPubAdUnitViewRegion2;
        public static Template MoPubAdUnitViewRegion2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion2 == null || _moPubAdUnitViewRegion2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion2 == null)
#endif
                {
                    _moPubAdUnitViewRegion2 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion2.Name = "MoPubAdUnitViewRegion2";
                    _moPubAdUnitViewRegion2.LineNumber = 23;
                    _moPubAdUnitViewRegion2.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion2, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion2, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion2, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion2, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewRegion2;
            }
        }

        private static Template _moPubAdUnitViewKeywords;
        public static Template MoPubAdUnitViewKeywords
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewKeywords == null || _moPubAdUnitViewKeywords.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewKeywords == null)
#endif
                {
                    _moPubAdUnitViewKeywords = new Template(InputFieldTemplates.InputField);
#if UNITY_EDITOR
                    _moPubAdUnitViewKeywords.Name = "MoPubAdUnitViewKeywords";
                    _moPubAdUnitViewKeywords.LineNumber = 25;
                    _moPubAdUnitViewKeywords.LinePosition = 10;
#endif
                    Delight.InputField.AlignmentProperty.SetDefault(_moPubAdUnitViewKeywords, Delight.ElementAlignment.Left);
                    Delight.InputField.HeightProperty.SetDefault(_moPubAdUnitViewKeywords, new ElementSize(100f, ElementSizeUnit.Pixels));
                    Delight.InputField.WidthProperty.SetDefault(_moPubAdUnitViewKeywords, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.InputField.SelectionColorProperty.SetDefault(_moPubAdUnitViewKeywords, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.InputField.MarginProperty.SetDefault(_moPubAdUnitViewKeywords, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.InputField.TextMarginProperty.SetDefault(_moPubAdUnitViewKeywords, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.InputField.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewKeywords, Assets.Materials["UI-Fast-Default"]);
                    Delight.InputField.InputFieldPlaceholderTemplateProperty.SetDefault(_moPubAdUnitViewKeywords, MoPubAdUnitViewKeywordsInputFieldPlaceholder);
                    Delight.InputField.TextAreaTemplateProperty.SetDefault(_moPubAdUnitViewKeywords, MoPubAdUnitViewKeywordsTextArea);
                    Delight.InputField.InputTextTemplateProperty.SetDefault(_moPubAdUnitViewKeywords, MoPubAdUnitViewKeywordsInputText);
                }
                return _moPubAdUnitViewKeywords;
            }
        }

        private static Template _moPubAdUnitViewKeywordsInputFieldPlaceholder;
        public static Template MoPubAdUnitViewKeywordsInputFieldPlaceholder
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewKeywordsInputFieldPlaceholder == null || _moPubAdUnitViewKeywordsInputFieldPlaceholder.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewKeywordsInputFieldPlaceholder == null)
#endif
                {
                    _moPubAdUnitViewKeywordsInputFieldPlaceholder = new Template(InputFieldTemplates.InputFieldInputFieldPlaceholder);
#if UNITY_EDITOR
                    _moPubAdUnitViewKeywordsInputFieldPlaceholder.Name = "MoPubAdUnitViewKeywordsInputFieldPlaceholder";
                    _moPubAdUnitViewKeywordsInputFieldPlaceholder.LineNumber = 12;
                    _moPubAdUnitViewKeywordsInputFieldPlaceholder.LinePosition = 4;
#endif
                }
                return _moPubAdUnitViewKeywordsInputFieldPlaceholder;
            }
        }

        private static Template _moPubAdUnitViewKeywordsTextArea;
        public static Template MoPubAdUnitViewKeywordsTextArea
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewKeywordsTextArea == null || _moPubAdUnitViewKeywordsTextArea.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewKeywordsTextArea == null)
#endif
                {
                    _moPubAdUnitViewKeywordsTextArea = new Template(InputFieldTemplates.InputFieldTextArea);
#if UNITY_EDITOR
                    _moPubAdUnitViewKeywordsTextArea.Name = "MoPubAdUnitViewKeywordsTextArea";
                    _moPubAdUnitViewKeywordsTextArea.LineNumber = 13;
                    _moPubAdUnitViewKeywordsTextArea.LinePosition = 4;
#endif
                }
                return _moPubAdUnitViewKeywordsTextArea;
            }
        }

        private static Template _moPubAdUnitViewKeywordsInputText;
        public static Template MoPubAdUnitViewKeywordsInputText
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewKeywordsInputText == null || _moPubAdUnitViewKeywordsInputText.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewKeywordsInputText == null)
#endif
                {
                    _moPubAdUnitViewKeywordsInputText = new Template(InputFieldTemplates.InputFieldInputText);
#if UNITY_EDITOR
                    _moPubAdUnitViewKeywordsInputText.Name = "MoPubAdUnitViewKeywordsInputText";
                    _moPubAdUnitViewKeywordsInputText.LineNumber = 14;
                    _moPubAdUnitViewKeywordsInputText.LinePosition = 6;
#endif
                    Delight.Label.TextAlignmentProperty.SetDefault(_moPubAdUnitViewKeywordsInputText, TMPro.TextAlignmentOptions.Left);
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewKeywordsInputText, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewKeywordsInputText, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                }
                return _moPubAdUnitViewKeywordsInputText;
            }
        }

        private static Template _moPubAdUnitViewKeywordsDelimiter;
        public static Template MoPubAdUnitViewKeywordsDelimiter
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewKeywordsDelimiter == null || _moPubAdUnitViewKeywordsDelimiter.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewKeywordsDelimiter == null)
#endif
                {
                    _moPubAdUnitViewKeywordsDelimiter = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewKeywordsDelimiter.Name = "MoPubAdUnitViewKeywordsDelimiter";
                    _moPubAdUnitViewKeywordsDelimiter.LineNumber = 26;
                    _moPubAdUnitViewKeywordsDelimiter.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewKeywordsDelimiter, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewKeywordsDelimiter, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewKeywordsDelimiter, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewKeywordsDelimiter, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewKeywordsDelimiter;
            }
        }

        private static Template _moPubAdUnitViewUserDataKeywords;
        public static Template MoPubAdUnitViewUserDataKeywords
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewUserDataKeywords == null || _moPubAdUnitViewUserDataKeywords.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewUserDataKeywords == null)
#endif
                {
                    _moPubAdUnitViewUserDataKeywords = new Template(InputFieldTemplates.InputField);
#if UNITY_EDITOR
                    _moPubAdUnitViewUserDataKeywords.Name = "MoPubAdUnitViewUserDataKeywords";
                    _moPubAdUnitViewUserDataKeywords.LineNumber = 28;
                    _moPubAdUnitViewUserDataKeywords.LinePosition = 10;
#endif
                    Delight.InputField.AlignmentProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, Delight.ElementAlignment.Left);
                    Delight.InputField.HeightProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, new ElementSize(100f, ElementSizeUnit.Pixels));
                    Delight.InputField.WidthProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.InputField.SelectionColorProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.InputField.MarginProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.InputField.TextMarginProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.InputField.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, Assets.Materials["UI-Fast-Default"]);
                    Delight.InputField.InputFieldPlaceholderTemplateProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, MoPubAdUnitViewUserDataKeywordsInputFieldPlaceholder);
                    Delight.InputField.TextAreaTemplateProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, MoPubAdUnitViewUserDataKeywordsTextArea);
                    Delight.InputField.InputTextTemplateProperty.SetDefault(_moPubAdUnitViewUserDataKeywords, MoPubAdUnitViewUserDataKeywordsInputText);
                }
                return _moPubAdUnitViewUserDataKeywords;
            }
        }

        private static Template _moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder;
        public static Template MoPubAdUnitViewUserDataKeywordsInputFieldPlaceholder
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder == null || _moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder == null)
#endif
                {
                    _moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder = new Template(InputFieldTemplates.InputFieldInputFieldPlaceholder);
#if UNITY_EDITOR
                    _moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder.Name = "MoPubAdUnitViewUserDataKeywordsInputFieldPlaceholder";
                    _moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder.LineNumber = 12;
                    _moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder.LinePosition = 4;
#endif
                }
                return _moPubAdUnitViewUserDataKeywordsInputFieldPlaceholder;
            }
        }

        private static Template _moPubAdUnitViewUserDataKeywordsTextArea;
        public static Template MoPubAdUnitViewUserDataKeywordsTextArea
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewUserDataKeywordsTextArea == null || _moPubAdUnitViewUserDataKeywordsTextArea.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewUserDataKeywordsTextArea == null)
#endif
                {
                    _moPubAdUnitViewUserDataKeywordsTextArea = new Template(InputFieldTemplates.InputFieldTextArea);
#if UNITY_EDITOR
                    _moPubAdUnitViewUserDataKeywordsTextArea.Name = "MoPubAdUnitViewUserDataKeywordsTextArea";
                    _moPubAdUnitViewUserDataKeywordsTextArea.LineNumber = 13;
                    _moPubAdUnitViewUserDataKeywordsTextArea.LinePosition = 4;
#endif
                }
                return _moPubAdUnitViewUserDataKeywordsTextArea;
            }
        }

        private static Template _moPubAdUnitViewUserDataKeywordsInputText;
        public static Template MoPubAdUnitViewUserDataKeywordsInputText
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewUserDataKeywordsInputText == null || _moPubAdUnitViewUserDataKeywordsInputText.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewUserDataKeywordsInputText == null)
#endif
                {
                    _moPubAdUnitViewUserDataKeywordsInputText = new Template(InputFieldTemplates.InputFieldInputText);
#if UNITY_EDITOR
                    _moPubAdUnitViewUserDataKeywordsInputText.Name = "MoPubAdUnitViewUserDataKeywordsInputText";
                    _moPubAdUnitViewUserDataKeywordsInputText.LineNumber = 14;
                    _moPubAdUnitViewUserDataKeywordsInputText.LinePosition = 6;
#endif
                    Delight.Label.TextAlignmentProperty.SetDefault(_moPubAdUnitViewUserDataKeywordsInputText, TMPro.TextAlignmentOptions.Left);
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewUserDataKeywordsInputText, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewUserDataKeywordsInputText, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                }
                return _moPubAdUnitViewUserDataKeywordsInputText;
            }
        }

        private static Template _moPubAdUnitViewUserDataKeywordsDelimiter;
        public static Template MoPubAdUnitViewUserDataKeywordsDelimiter
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewUserDataKeywordsDelimiter == null || _moPubAdUnitViewUserDataKeywordsDelimiter.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewUserDataKeywordsDelimiter == null)
#endif
                {
                    _moPubAdUnitViewUserDataKeywordsDelimiter = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewUserDataKeywordsDelimiter.Name = "MoPubAdUnitViewUserDataKeywordsDelimiter";
                    _moPubAdUnitViewUserDataKeywordsDelimiter.LineNumber = 29;
                    _moPubAdUnitViewUserDataKeywordsDelimiter.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewUserDataKeywordsDelimiter, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewUserDataKeywordsDelimiter, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewUserDataKeywordsDelimiter, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewUserDataKeywordsDelimiter, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewUserDataKeywordsDelimiter;
            }
        }

        private static Template _moPubAdUnitViewRegion3;
        public static Template MoPubAdUnitViewRegion3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion3 == null || _moPubAdUnitViewRegion3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion3 == null)
#endif
                {
                    _moPubAdUnitViewRegion3 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion3.Name = "MoPubAdUnitViewRegion3";
                    _moPubAdUnitViewRegion3.LineNumber = 31;
                    _moPubAdUnitViewRegion3.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion3, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.OffsetProperty.SetDefault(_moPubAdUnitViewRegion3, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(23f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion3, new UnityEngine.Color(0.8117647f, 0.8117647f, 0.8117647f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion3, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewRegion3;
            }
        }

        private static Template _moPubAdUnitViewLoadAdButton;
        public static Template MoPubAdUnitViewLoadAdButton
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewLoadAdButton == null || _moPubAdUnitViewLoadAdButton.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewLoadAdButton == null)
#endif
                {
                    _moPubAdUnitViewLoadAdButton = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _moPubAdUnitViewLoadAdButton.Name = "MoPubAdUnitViewLoadAdButton";
                    _moPubAdUnitViewLoadAdButton.LineNumber = 33;
                    _moPubAdUnitViewLoadAdButton.LinePosition = 10;
#endif
                    Delight.Button.HeightProperty.SetDefault(_moPubAdUnitViewLoadAdButton, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Button.WidthProperty.SetDefault(_moPubAdUnitViewLoadAdButton, new ElementSize(200f, ElementSizeUnit.Pixels));
                    Delight.Button.MarginProperty.SetDefault(_moPubAdUnitViewLoadAdButton, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Button.BackgroundColorProperty.SetDefault(_moPubAdUnitViewLoadAdButton, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _moPubAdUnitViewLoadAdButton, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _moPubAdUnitViewLoadAdButton, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 0.2666667f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Disabled", _moPubAdUnitViewLoadAdButton, new UnityEngine.Color(0.6117647f, 0.6117647f, 0.6117647f, 1f));
                    Delight.Button.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewLoadAdButton, Assets.Materials["UI-Fast-Default"]);
                    Delight.Button.OffsetProperty.SetDefault(_moPubAdUnitViewLoadAdButton, new ElementMargin(new ElementSize(-110f, ElementSizeUnit.Pixels), new ElementSize(56f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_moPubAdUnitViewLoadAdButton, MoPubAdUnitViewLoadAdButtonLabel);
                }
                return _moPubAdUnitViewLoadAdButton;
            }
        }

        private static Template _moPubAdUnitViewLoadAdButtonLabel;
        public static Template MoPubAdUnitViewLoadAdButtonLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewLoadAdButtonLabel == null || _moPubAdUnitViewLoadAdButtonLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewLoadAdButtonLabel == null)
#endif
                {
                    _moPubAdUnitViewLoadAdButtonLabel = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _moPubAdUnitViewLoadAdButtonLabel.Name = "MoPubAdUnitViewLoadAdButtonLabel";
                    _moPubAdUnitViewLoadAdButtonLabel.LineNumber = 15;
                    _moPubAdUnitViewLoadAdButtonLabel.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewLoadAdButtonLabel, 40f);
                    Delight.Label.TextMarginProperty.SetDefault(_moPubAdUnitViewLoadAdButtonLabel, new Vector4(-10f, 0f, 0f, 0f));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewLoadAdButtonLabel, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _moPubAdUnitViewLoadAdButtonLabel, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _moPubAdUnitViewLoadAdButtonLabel, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Disabled", _moPubAdUnitViewLoadAdButtonLabel, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontStyleProperty.SetStateDefault("Disabled", _moPubAdUnitViewLoadAdButtonLabel, TMPro.FontStyles.Normal);
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewLoadAdButtonLabel, "Load Ad");
                }
                return _moPubAdUnitViewLoadAdButtonLabel;
            }
        }

        private static Template _moPubAdUnitViewShowAdButton;
        public static Template MoPubAdUnitViewShowAdButton
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewShowAdButton == null || _moPubAdUnitViewShowAdButton.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewShowAdButton == null)
#endif
                {
                    _moPubAdUnitViewShowAdButton = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _moPubAdUnitViewShowAdButton.Name = "MoPubAdUnitViewShowAdButton";
                    _moPubAdUnitViewShowAdButton.LineNumber = 34;
                    _moPubAdUnitViewShowAdButton.LinePosition = 10;
#endif
                    Delight.Button.HeightProperty.SetDefault(_moPubAdUnitViewShowAdButton, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Button.WidthProperty.SetDefault(_moPubAdUnitViewShowAdButton, new ElementSize(200f, ElementSizeUnit.Pixels));
                    Delight.Button.MarginProperty.SetDefault(_moPubAdUnitViewShowAdButton, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Button.BackgroundColorProperty.SetDefault(_moPubAdUnitViewShowAdButton, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _moPubAdUnitViewShowAdButton, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _moPubAdUnitViewShowAdButton, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 0.2666667f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Disabled", _moPubAdUnitViewShowAdButton, new UnityEngine.Color(0.6117647f, 0.6117647f, 0.6117647f, 1f));
                    Delight.Button.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewShowAdButton, Assets.Materials["UI-Fast-Default"]);
                    Delight.Button.OffsetProperty.SetDefault(_moPubAdUnitViewShowAdButton, new ElementMargin(new ElementSize(110f, ElementSizeUnit.Pixels), new ElementSize(-34f, ElementSizeUnit.Pixels)));
                    Delight.Button.IsDisabledProperty.SetDefault(_moPubAdUnitViewShowAdButton, true);
                    Delight.Button.IsVisibleProperty.SetHasBinding(_moPubAdUnitViewShowAdButton);
                    Delight.Button.LabelTemplateProperty.SetDefault(_moPubAdUnitViewShowAdButton, MoPubAdUnitViewShowAdButtonLabel);
                }
                return _moPubAdUnitViewShowAdButton;
            }
        }

        private static Template _moPubAdUnitViewShowAdButtonLabel;
        public static Template MoPubAdUnitViewShowAdButtonLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewShowAdButtonLabel == null || _moPubAdUnitViewShowAdButtonLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewShowAdButtonLabel == null)
#endif
                {
                    _moPubAdUnitViewShowAdButtonLabel = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _moPubAdUnitViewShowAdButtonLabel.Name = "MoPubAdUnitViewShowAdButtonLabel";
                    _moPubAdUnitViewShowAdButtonLabel.LineNumber = 15;
                    _moPubAdUnitViewShowAdButtonLabel.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewShowAdButtonLabel, 40f);
                    Delight.Label.TextMarginProperty.SetDefault(_moPubAdUnitViewShowAdButtonLabel, new Vector4(-10f, 0f, 0f, 0f));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewShowAdButtonLabel, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _moPubAdUnitViewShowAdButtonLabel, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _moPubAdUnitViewShowAdButtonLabel, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Disabled", _moPubAdUnitViewShowAdButtonLabel, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontStyleProperty.SetStateDefault("Disabled", _moPubAdUnitViewShowAdButtonLabel, TMPro.FontStyles.Normal);
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewShowAdButtonLabel, "Show Ad");
                }
                return _moPubAdUnitViewShowAdButtonLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion4;
        public static Template MoPubAdUnitViewRegion4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion4 == null || _moPubAdUnitViewRegion4.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion4 == null)
#endif
                {
                    _moPubAdUnitViewRegion4 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion4.Name = "MoPubAdUnitViewRegion4";
                    _moPubAdUnitViewRegion4.LineNumber = 37;
                    _moPubAdUnitViewRegion4.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion4, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion4, new UnityEngine.Color(0.8117647f, 0.8117647f, 0.8117647f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion4, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewRegion4;
            }
        }

        private static Template _moPubAdUnitViewOnAdLoadedExpander;
        public static Template MoPubAdUnitViewOnAdLoadedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdLoadedExpander == null || _moPubAdUnitViewOnAdLoadedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdLoadedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnAdLoadedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdLoadedExpander.Name = "MoPubAdUnitViewOnAdLoadedExpander";
                    _moPubAdUnitViewOnAdLoadedExpander.LineNumber = 43;
                    _moPubAdUnitViewOnAdLoadedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnAdLoadedExpander);
                }
                return _moPubAdUnitViewOnAdLoadedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader1;
        public static Template MoPubAdUnitViewExpanderHeader1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader1 == null || _moPubAdUnitViewExpanderHeader1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader1 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader1 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader1.Name = "MoPubAdUnitViewExpanderHeader1";
                    _moPubAdUnitViewExpanderHeader1.LineNumber = 45;
                    _moPubAdUnitViewExpanderHeader1.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader1, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader1;
            }
        }

        private static Template _moPubAdUnitViewRegion5;
        public static Template MoPubAdUnitViewRegion5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion5 == null || _moPubAdUnitViewRegion5.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion5 == null)
#endif
                {
                    _moPubAdUnitViewRegion5 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion5.Name = "MoPubAdUnitViewRegion5";
                    _moPubAdUnitViewRegion5.LineNumber = 46;
                    _moPubAdUnitViewRegion5.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion5, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion5;
            }
        }

        private static Template _moPubAdUnitViewOnAdLoadedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnAdLoadedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdLoadedExpanderMPEventChevron == null || _moPubAdUnitViewOnAdLoadedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdLoadedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnAdLoadedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdLoadedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnAdLoadedExpanderMPEventChevron";
                    _moPubAdUnitViewOnAdLoadedExpanderMPEventChevron.LineNumber = 47;
                    _moPubAdUnitViewOnAdLoadedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnAdLoadedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnAdLoadedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnAdLoadedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnAdLoadedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdLoadedExpanderCheckImage == null || _moPubAdUnitViewOnAdLoadedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdLoadedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnAdLoadedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdLoadedExpanderCheckImage.Name = "MoPubAdUnitViewOnAdLoadedExpanderCheckImage";
                    _moPubAdUnitViewOnAdLoadedExpanderCheckImage.LineNumber = 49;
                    _moPubAdUnitViewOnAdLoadedExpanderCheckImage.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnAdLoadedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnAdLoadedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnAdLoadedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdLoadedExpanderEventLabel == null || _moPubAdUnitViewOnAdLoadedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdLoadedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnAdLoadedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdLoadedExpanderEventLabel.Name = "MoPubAdUnitViewOnAdLoadedExpanderEventLabel";
                    _moPubAdUnitViewOnAdLoadedExpanderEventLabel.LineNumber = 50;
                    _moPubAdUnitViewOnAdLoadedExpanderEventLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderEventLabel, "OnAdLoadedEvent");
                }
                return _moPubAdUnitViewOnAdLoadedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent1;
        public static Template MoPubAdUnitViewExpanderContent1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent1 == null || _moPubAdUnitViewExpanderContent1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent1 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent1 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent1.Name = "MoPubAdUnitViewExpanderContent1";
                    _moPubAdUnitViewExpanderContent1.LineNumber = 53;
                    _moPubAdUnitViewExpanderContent1.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent1, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent1, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent1, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent1, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent1, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent1, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent1;
            }
        }

        private static Template _moPubAdUnitViewGroup3;
        public static Template MoPubAdUnitViewGroup3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup3 == null || _moPubAdUnitViewGroup3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup3 == null)
#endif
                {
                    _moPubAdUnitViewGroup3 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup3.Name = "MoPubAdUnitViewGroup3";
                    _moPubAdUnitViewGroup3.LineNumber = 54;
                    _moPubAdUnitViewGroup3.LinePosition = 18;
#endif
                    Delight.Group.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewGroup3, Assets.Materials["UI-Fast-Default"]);
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup3, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup3, Delight.ElementAlignment.Top);
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup3, Delight.ElementOrientation.Vertical);
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup3, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup3, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup3, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.OffsetProperty.SetDefault(_moPubAdUnitViewGroup3, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-30f, ElementSizeUnit.Pixels)));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup3, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup3, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewGroup3;
            }
        }

        private static Template _moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel.LineNumber = 55;
                    _moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewOnAdLoadedExpanderHeightLabel;
        public static Template MoPubAdUnitViewOnAdLoadedExpanderHeightLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdLoadedExpanderHeightLabel == null || _moPubAdUnitViewOnAdLoadedExpanderHeightLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdLoadedExpanderHeightLabel == null)
#endif
                {
                    _moPubAdUnitViewOnAdLoadedExpanderHeightLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdLoadedExpanderHeightLabel.Name = "MoPubAdUnitViewOnAdLoadedExpanderHeightLabel";
                    _moPubAdUnitViewOnAdLoadedExpanderHeightLabel.LineNumber = 56;
                    _moPubAdUnitViewOnAdLoadedExpanderHeightLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, Delight.AutoSize.Default);
                    Delight.Label.OffsetProperty.SetDefault(_moPubAdUnitViewOnAdLoadedExpanderHeightLabel, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-50f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewOnAdLoadedExpanderHeightLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion6;
        public static Template MoPubAdUnitViewRegion6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion6 == null || _moPubAdUnitViewRegion6.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion6 == null)
#endif
                {
                    _moPubAdUnitViewRegion6 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion6.Name = "MoPubAdUnitViewRegion6";
                    _moPubAdUnitViewRegion6.LineNumber = 60;
                    _moPubAdUnitViewRegion6.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion6, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion6, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion6, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion6, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion6);
                }
                return _moPubAdUnitViewRegion6;
            }
        }

        private static Template _moPubAdUnitViewOnAdClickedExpander;
        public static Template MoPubAdUnitViewOnAdClickedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdClickedExpander == null || _moPubAdUnitViewOnAdClickedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdClickedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnAdClickedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdClickedExpander.Name = "MoPubAdUnitViewOnAdClickedExpander";
                    _moPubAdUnitViewOnAdClickedExpander.LineNumber = 62;
                    _moPubAdUnitViewOnAdClickedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnAdClickedExpander);
                }
                return _moPubAdUnitViewOnAdClickedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader2;
        public static Template MoPubAdUnitViewExpanderHeader2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader2 == null || _moPubAdUnitViewExpanderHeader2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader2 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader2 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader2.Name = "MoPubAdUnitViewExpanderHeader2";
                    _moPubAdUnitViewExpanderHeader2.LineNumber = 64;
                    _moPubAdUnitViewExpanderHeader2.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader2, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader2, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader2;
            }
        }

        private static Template _moPubAdUnitViewRegion7;
        public static Template MoPubAdUnitViewRegion7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion7 == null || _moPubAdUnitViewRegion7.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion7 == null)
#endif
                {
                    _moPubAdUnitViewRegion7 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion7.Name = "MoPubAdUnitViewRegion7";
                    _moPubAdUnitViewRegion7.LineNumber = 65;
                    _moPubAdUnitViewRegion7.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion7, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion7;
            }
        }

        private static Template _moPubAdUnitViewOnAdClickedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnAdClickedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdClickedExpanderMPEventChevron == null || _moPubAdUnitViewOnAdClickedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdClickedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnAdClickedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdClickedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnAdClickedExpanderMPEventChevron";
                    _moPubAdUnitViewOnAdClickedExpanderMPEventChevron.LineNumber = 66;
                    _moPubAdUnitViewOnAdClickedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnAdClickedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnAdClickedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnAdClickedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnAdClickedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdClickedExpanderCheckImage == null || _moPubAdUnitViewOnAdClickedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdClickedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnAdClickedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdClickedExpanderCheckImage.Name = "MoPubAdUnitViewOnAdClickedExpanderCheckImage";
                    _moPubAdUnitViewOnAdClickedExpanderCheckImage.LineNumber = 68;
                    _moPubAdUnitViewOnAdClickedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnAdClickedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnAdClickedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnAdClickedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdClickedExpanderEventLabel == null || _moPubAdUnitViewOnAdClickedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdClickedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnAdClickedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdClickedExpanderEventLabel.Name = "MoPubAdUnitViewOnAdClickedExpanderEventLabel";
                    _moPubAdUnitViewOnAdClickedExpanderEventLabel.LineNumber = 69;
                    _moPubAdUnitViewOnAdClickedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderEventLabel, "OnAdClickedEvent");
                }
                return _moPubAdUnitViewOnAdClickedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent2;
        public static Template MoPubAdUnitViewExpanderContent2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent2 == null || _moPubAdUnitViewExpanderContent2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent2 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent2 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent2.Name = "MoPubAdUnitViewExpanderContent2";
                    _moPubAdUnitViewExpanderContent2.LineNumber = 72;
                    _moPubAdUnitViewExpanderContent2.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent2, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent2, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent2, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent2, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent2, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent2, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent2, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent2;
            }
        }

        private static Template _moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel.LineNumber = 73;
                    _moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion8;
        public static Template MoPubAdUnitViewRegion8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion8 == null || _moPubAdUnitViewRegion8.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion8 == null)
#endif
                {
                    _moPubAdUnitViewRegion8 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion8.Name = "MoPubAdUnitViewRegion8";
                    _moPubAdUnitViewRegion8.LineNumber = 76;
                    _moPubAdUnitViewRegion8.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion8, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion8, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion8, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion8, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion8);
                }
                return _moPubAdUnitViewRegion8;
            }
        }

        private static Template _moPubAdUnitViewOnAdFailedExpander;
        public static Template MoPubAdUnitViewOnAdFailedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdFailedExpander == null || _moPubAdUnitViewOnAdFailedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdFailedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnAdFailedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdFailedExpander.Name = "MoPubAdUnitViewOnAdFailedExpander";
                    _moPubAdUnitViewOnAdFailedExpander.LineNumber = 78;
                    _moPubAdUnitViewOnAdFailedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnAdFailedExpander);
                }
                return _moPubAdUnitViewOnAdFailedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader3;
        public static Template MoPubAdUnitViewExpanderHeader3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader3 == null || _moPubAdUnitViewExpanderHeader3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader3 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader3 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader3.Name = "MoPubAdUnitViewExpanderHeader3";
                    _moPubAdUnitViewExpanderHeader3.LineNumber = 80;
                    _moPubAdUnitViewExpanderHeader3.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader3, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader3, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader3;
            }
        }

        private static Template _moPubAdUnitViewRegion9;
        public static Template MoPubAdUnitViewRegion9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion9 == null || _moPubAdUnitViewRegion9.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion9 == null)
#endif
                {
                    _moPubAdUnitViewRegion9 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion9.Name = "MoPubAdUnitViewRegion9";
                    _moPubAdUnitViewRegion9.LineNumber = 81;
                    _moPubAdUnitViewRegion9.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion9, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion9;
            }
        }

        private static Template _moPubAdUnitViewOnAdFailedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnAdFailedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdFailedExpanderMPEventChevron == null || _moPubAdUnitViewOnAdFailedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdFailedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnAdFailedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdFailedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnAdFailedExpanderMPEventChevron";
                    _moPubAdUnitViewOnAdFailedExpanderMPEventChevron.LineNumber = 82;
                    _moPubAdUnitViewOnAdFailedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnAdFailedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnAdFailedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnAdFailedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnAdFailedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdFailedExpanderCheckImage == null || _moPubAdUnitViewOnAdFailedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdFailedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnAdFailedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdFailedExpanderCheckImage.Name = "MoPubAdUnitViewOnAdFailedExpanderCheckImage";
                    _moPubAdUnitViewOnAdFailedExpanderCheckImage.LineNumber = 84;
                    _moPubAdUnitViewOnAdFailedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnAdFailedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnAdFailedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnAdFailedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdFailedExpanderEventLabel == null || _moPubAdUnitViewOnAdFailedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdFailedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnAdFailedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdFailedExpanderEventLabel.Name = "MoPubAdUnitViewOnAdFailedExpanderEventLabel";
                    _moPubAdUnitViewOnAdFailedExpanderEventLabel.LineNumber = 85;
                    _moPubAdUnitViewOnAdFailedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderEventLabel, "OnAdFailedEvent");
                }
                return _moPubAdUnitViewOnAdFailedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent3;
        public static Template MoPubAdUnitViewExpanderContent3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent3 == null || _moPubAdUnitViewExpanderContent3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent3 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent3 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent3.Name = "MoPubAdUnitViewExpanderContent3";
                    _moPubAdUnitViewExpanderContent3.LineNumber = 88;
                    _moPubAdUnitViewExpanderContent3.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent3, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent3, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent3, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent3, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent3, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent3, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent3, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent3;
            }
        }

        private static Template _moPubAdUnitViewGroup4;
        public static Template MoPubAdUnitViewGroup4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup4 == null || _moPubAdUnitViewGroup4.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup4 == null)
#endif
                {
                    _moPubAdUnitViewGroup4 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup4.Name = "MoPubAdUnitViewGroup4";
                    _moPubAdUnitViewGroup4.LineNumber = 89;
                    _moPubAdUnitViewGroup4.LinePosition = 18;
#endif
                    Delight.Group.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewGroup4, Assets.Materials["UI-Fast-Default"]);
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup4, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup4, Delight.ElementAlignment.Top);
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup4, Delight.ElementOrientation.Vertical);
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup4, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup4, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup4, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.OffsetProperty.SetDefault(_moPubAdUnitViewGroup4, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-30f, ElementSizeUnit.Pixels)));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup4, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup4, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewGroup4;
            }
        }

        private static Template _moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel.LineNumber = 90;
                    _moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewOnAdFailedExpanderErrorLabel;
        public static Template MoPubAdUnitViewOnAdFailedExpanderErrorLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnAdFailedExpanderErrorLabel == null || _moPubAdUnitViewOnAdFailedExpanderErrorLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnAdFailedExpanderErrorLabel == null)
#endif
                {
                    _moPubAdUnitViewOnAdFailedExpanderErrorLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnAdFailedExpanderErrorLabel.Name = "MoPubAdUnitViewOnAdFailedExpanderErrorLabel";
                    _moPubAdUnitViewOnAdFailedExpanderErrorLabel.LineNumber = 91;
                    _moPubAdUnitViewOnAdFailedExpanderErrorLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, Delight.AutoSize.Default);
                    Delight.Label.OffsetProperty.SetDefault(_moPubAdUnitViewOnAdFailedExpanderErrorLabel, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-50f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewOnAdFailedExpanderErrorLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion10;
        public static Template MoPubAdUnitViewRegion10
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion10 == null || _moPubAdUnitViewRegion10.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion10 == null)
#endif
                {
                    _moPubAdUnitViewRegion10 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion10.Name = "MoPubAdUnitViewRegion10";
                    _moPubAdUnitViewRegion10.LineNumber = 95;
                    _moPubAdUnitViewRegion10.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion10, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion10, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion10, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion10, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion10);
                }
                return _moPubAdUnitViewRegion10;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialLoadedExpander;
        public static Template MoPubAdUnitViewOnInterstitialLoadedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialLoadedExpander == null || _moPubAdUnitViewOnInterstitialLoadedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialLoadedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialLoadedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialLoadedExpander.Name = "MoPubAdUnitViewOnInterstitialLoadedExpander";
                    _moPubAdUnitViewOnInterstitialLoadedExpander.LineNumber = 101;
                    _moPubAdUnitViewOnInterstitialLoadedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnInterstitialLoadedExpander);
                }
                return _moPubAdUnitViewOnInterstitialLoadedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader4;
        public static Template MoPubAdUnitViewExpanderHeader4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader4 == null || _moPubAdUnitViewExpanderHeader4.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader4 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader4 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader4.Name = "MoPubAdUnitViewExpanderHeader4";
                    _moPubAdUnitViewExpanderHeader4.LineNumber = 103;
                    _moPubAdUnitViewExpanderHeader4.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader4, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader4, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader4;
            }
        }

        private static Template _moPubAdUnitViewRegion11;
        public static Template MoPubAdUnitViewRegion11
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion11 == null || _moPubAdUnitViewRegion11.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion11 == null)
#endif
                {
                    _moPubAdUnitViewRegion11 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion11.Name = "MoPubAdUnitViewRegion11";
                    _moPubAdUnitViewRegion11.LineNumber = 104;
                    _moPubAdUnitViewRegion11.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion11, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion11;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron == null || _moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron";
                    _moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron.LineNumber = 105;
                    _moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnInterstitialLoadedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage == null || _moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage.Name = "MoPubAdUnitViewOnInterstitialLoadedExpanderCheckImage";
                    _moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage.LineNumber = 107;
                    _moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnInterstitialLoadedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnInterstitialLoadedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel == null || _moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel.Name = "MoPubAdUnitViewOnInterstitialLoadedExpanderEventLabel";
                    _moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel.LineNumber = 108;
                    _moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel, "OnInterstitialLoadedEvent");
                }
                return _moPubAdUnitViewOnInterstitialLoadedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent4;
        public static Template MoPubAdUnitViewExpanderContent4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent4 == null || _moPubAdUnitViewExpanderContent4.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent4 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent4 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent4.Name = "MoPubAdUnitViewExpanderContent4";
                    _moPubAdUnitViewExpanderContent4.LineNumber = 111;
                    _moPubAdUnitViewExpanderContent4.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent4, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent4, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent4, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent4, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent4, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent4, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent4, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent4;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel.LineNumber = 112;
                    _moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion12;
        public static Template MoPubAdUnitViewRegion12
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion12 == null || _moPubAdUnitViewRegion12.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion12 == null)
#endif
                {
                    _moPubAdUnitViewRegion12 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion12.Name = "MoPubAdUnitViewRegion12";
                    _moPubAdUnitViewRegion12.LineNumber = 115;
                    _moPubAdUnitViewRegion12.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion12, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion12, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion12, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion12, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion12);
                }
                return _moPubAdUnitViewRegion12;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialShownExpander;
        public static Template MoPubAdUnitViewOnInterstitialShownExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialShownExpander == null || _moPubAdUnitViewOnInterstitialShownExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialShownExpander == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialShownExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialShownExpander.Name = "MoPubAdUnitViewOnInterstitialShownExpander";
                    _moPubAdUnitViewOnInterstitialShownExpander.LineNumber = 117;
                    _moPubAdUnitViewOnInterstitialShownExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnInterstitialShownExpander);
                }
                return _moPubAdUnitViewOnInterstitialShownExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader5;
        public static Template MoPubAdUnitViewExpanderHeader5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader5 == null || _moPubAdUnitViewExpanderHeader5.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader5 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader5 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader5.Name = "MoPubAdUnitViewExpanderHeader5";
                    _moPubAdUnitViewExpanderHeader5.LineNumber = 119;
                    _moPubAdUnitViewExpanderHeader5.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader5, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader5, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader5;
            }
        }

        private static Template _moPubAdUnitViewRegion13;
        public static Template MoPubAdUnitViewRegion13
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion13 == null || _moPubAdUnitViewRegion13.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion13 == null)
#endif
                {
                    _moPubAdUnitViewRegion13 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion13.Name = "MoPubAdUnitViewRegion13";
                    _moPubAdUnitViewRegion13.LineNumber = 120;
                    _moPubAdUnitViewRegion13.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion13, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion13;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnInterstitialShownExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron == null || _moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron.Name = "MoPubAdUnitViewOnInterstitialShownExpanderMPEventChevron";
                    _moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron.LineNumber = 121;
                    _moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnInterstitialShownExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialShownExpanderCheckImage;
        public static Template MoPubAdUnitViewOnInterstitialShownExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialShownExpanderCheckImage == null || _moPubAdUnitViewOnInterstitialShownExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialShownExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialShownExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialShownExpanderCheckImage.Name = "MoPubAdUnitViewOnInterstitialShownExpanderCheckImage";
                    _moPubAdUnitViewOnInterstitialShownExpanderCheckImage.LineNumber = 123;
                    _moPubAdUnitViewOnInterstitialShownExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnInterstitialShownExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialShownExpanderEventLabel;
        public static Template MoPubAdUnitViewOnInterstitialShownExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialShownExpanderEventLabel == null || _moPubAdUnitViewOnInterstitialShownExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialShownExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialShownExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialShownExpanderEventLabel.Name = "MoPubAdUnitViewOnInterstitialShownExpanderEventLabel";
                    _moPubAdUnitViewOnInterstitialShownExpanderEventLabel.LineNumber = 124;
                    _moPubAdUnitViewOnInterstitialShownExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderEventLabel, "OnInterstitialShownEvent");
                }
                return _moPubAdUnitViewOnInterstitialShownExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent5;
        public static Template MoPubAdUnitViewExpanderContent5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent5 == null || _moPubAdUnitViewExpanderContent5.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent5 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent5 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent5.Name = "MoPubAdUnitViewExpanderContent5";
                    _moPubAdUnitViewExpanderContent5.LineNumber = 127;
                    _moPubAdUnitViewExpanderContent5.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent5, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent5, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent5, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent5, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent5, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent5, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent5, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent5;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel.LineNumber = 128;
                    _moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion14;
        public static Template MoPubAdUnitViewRegion14
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion14 == null || _moPubAdUnitViewRegion14.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion14 == null)
#endif
                {
                    _moPubAdUnitViewRegion14 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion14.Name = "MoPubAdUnitViewRegion14";
                    _moPubAdUnitViewRegion14.LineNumber = 131;
                    _moPubAdUnitViewRegion14.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion14, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion14, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion14, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion14, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion14);
                }
                return _moPubAdUnitViewRegion14;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialClickedExpander;
        public static Template MoPubAdUnitViewOnInterstitialClickedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialClickedExpander == null || _moPubAdUnitViewOnInterstitialClickedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialClickedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialClickedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialClickedExpander.Name = "MoPubAdUnitViewOnInterstitialClickedExpander";
                    _moPubAdUnitViewOnInterstitialClickedExpander.LineNumber = 133;
                    _moPubAdUnitViewOnInterstitialClickedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnInterstitialClickedExpander);
                }
                return _moPubAdUnitViewOnInterstitialClickedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader6;
        public static Template MoPubAdUnitViewExpanderHeader6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader6 == null || _moPubAdUnitViewExpanderHeader6.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader6 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader6 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader6.Name = "MoPubAdUnitViewExpanderHeader6";
                    _moPubAdUnitViewExpanderHeader6.LineNumber = 135;
                    _moPubAdUnitViewExpanderHeader6.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader6, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader6, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader6;
            }
        }

        private static Template _moPubAdUnitViewRegion15;
        public static Template MoPubAdUnitViewRegion15
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion15 == null || _moPubAdUnitViewRegion15.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion15 == null)
#endif
                {
                    _moPubAdUnitViewRegion15 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion15.Name = "MoPubAdUnitViewRegion15";
                    _moPubAdUnitViewRegion15.LineNumber = 136;
                    _moPubAdUnitViewRegion15.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion15, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion15;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron == null || _moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron";
                    _moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron.LineNumber = 137;
                    _moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialClickedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnInterstitialClickedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialClickedExpanderCheckImage == null || _moPubAdUnitViewOnInterstitialClickedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialClickedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialClickedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialClickedExpanderCheckImage.Name = "MoPubAdUnitViewOnInterstitialClickedExpanderCheckImage";
                    _moPubAdUnitViewOnInterstitialClickedExpanderCheckImage.LineNumber = 139;
                    _moPubAdUnitViewOnInterstitialClickedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnInterstitialClickedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialClickedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnInterstitialClickedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel == null || _moPubAdUnitViewOnInterstitialClickedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialClickedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialClickedExpanderEventLabel.Name = "MoPubAdUnitViewOnInterstitialClickedExpanderEventLabel";
                    _moPubAdUnitViewOnInterstitialClickedExpanderEventLabel.LineNumber = 140;
                    _moPubAdUnitViewOnInterstitialClickedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderEventLabel, "OnInterstitialClickedEvent");
                }
                return _moPubAdUnitViewOnInterstitialClickedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent6;
        public static Template MoPubAdUnitViewExpanderContent6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent6 == null || _moPubAdUnitViewExpanderContent6.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent6 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent6 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent6.Name = "MoPubAdUnitViewExpanderContent6";
                    _moPubAdUnitViewExpanderContent6.LineNumber = 143;
                    _moPubAdUnitViewExpanderContent6.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent6, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent6, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent6, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent6, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent6, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent6, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent6, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent6;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel.LineNumber = 144;
                    _moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion16;
        public static Template MoPubAdUnitViewRegion16
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion16 == null || _moPubAdUnitViewRegion16.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion16 == null)
#endif
                {
                    _moPubAdUnitViewRegion16 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion16.Name = "MoPubAdUnitViewRegion16";
                    _moPubAdUnitViewRegion16.LineNumber = 147;
                    _moPubAdUnitViewRegion16.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion16, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion16, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion16, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion16, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion16);
                }
                return _moPubAdUnitViewRegion16;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialDismissedExpander;
        public static Template MoPubAdUnitViewOnInterstitialDismissedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialDismissedExpander == null || _moPubAdUnitViewOnInterstitialDismissedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialDismissedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialDismissedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialDismissedExpander.Name = "MoPubAdUnitViewOnInterstitialDismissedExpander";
                    _moPubAdUnitViewOnInterstitialDismissedExpander.LineNumber = 149;
                    _moPubAdUnitViewOnInterstitialDismissedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnInterstitialDismissedExpander);
                }
                return _moPubAdUnitViewOnInterstitialDismissedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader7;
        public static Template MoPubAdUnitViewExpanderHeader7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader7 == null || _moPubAdUnitViewExpanderHeader7.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader7 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader7 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader7.Name = "MoPubAdUnitViewExpanderHeader7";
                    _moPubAdUnitViewExpanderHeader7.LineNumber = 151;
                    _moPubAdUnitViewExpanderHeader7.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader7, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader7, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader7;
            }
        }

        private static Template _moPubAdUnitViewRegion17;
        public static Template MoPubAdUnitViewRegion17
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion17 == null || _moPubAdUnitViewRegion17.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion17 == null)
#endif
                {
                    _moPubAdUnitViewRegion17 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion17.Name = "MoPubAdUnitViewRegion17";
                    _moPubAdUnitViewRegion17.LineNumber = 152;
                    _moPubAdUnitViewRegion17.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion17, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion17;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron == null || _moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron";
                    _moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron.LineNumber = 153;
                    _moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnInterstitialDismissedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage == null || _moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage.Name = "MoPubAdUnitViewOnInterstitialDismissedExpanderCheckImage";
                    _moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage.LineNumber = 155;
                    _moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnInterstitialDismissedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnInterstitialDismissedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel == null || _moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel.Name = "MoPubAdUnitViewOnInterstitialDismissedExpanderEventLabel";
                    _moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel.LineNumber = 156;
                    _moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel, "OnInterstitialDismissedEvent");
                }
                return _moPubAdUnitViewOnInterstitialDismissedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent7;
        public static Template MoPubAdUnitViewExpanderContent7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent7 == null || _moPubAdUnitViewExpanderContent7.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent7 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent7 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent7.Name = "MoPubAdUnitViewExpanderContent7";
                    _moPubAdUnitViewExpanderContent7.LineNumber = 159;
                    _moPubAdUnitViewExpanderContent7.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent7, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent7, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent7, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent7, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent7, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent7, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent7, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent7;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel.LineNumber = 160;
                    _moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion18;
        public static Template MoPubAdUnitViewRegion18
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion18 == null || _moPubAdUnitViewRegion18.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion18 == null)
#endif
                {
                    _moPubAdUnitViewRegion18 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion18.Name = "MoPubAdUnitViewRegion18";
                    _moPubAdUnitViewRegion18.LineNumber = 163;
                    _moPubAdUnitViewRegion18.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion18, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion18, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion18, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion18, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion18);
                }
                return _moPubAdUnitViewRegion18;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialFailedExpander;
        public static Template MoPubAdUnitViewOnInterstitialFailedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialFailedExpander == null || _moPubAdUnitViewOnInterstitialFailedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialFailedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialFailedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialFailedExpander.Name = "MoPubAdUnitViewOnInterstitialFailedExpander";
                    _moPubAdUnitViewOnInterstitialFailedExpander.LineNumber = 165;
                    _moPubAdUnitViewOnInterstitialFailedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnInterstitialFailedExpander);
                }
                return _moPubAdUnitViewOnInterstitialFailedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader8;
        public static Template MoPubAdUnitViewExpanderHeader8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader8 == null || _moPubAdUnitViewExpanderHeader8.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader8 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader8 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader8.Name = "MoPubAdUnitViewExpanderHeader8";
                    _moPubAdUnitViewExpanderHeader8.LineNumber = 167;
                    _moPubAdUnitViewExpanderHeader8.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader8, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader8, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader8;
            }
        }

        private static Template _moPubAdUnitViewRegion19;
        public static Template MoPubAdUnitViewRegion19
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion19 == null || _moPubAdUnitViewRegion19.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion19 == null)
#endif
                {
                    _moPubAdUnitViewRegion19 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion19.Name = "MoPubAdUnitViewRegion19";
                    _moPubAdUnitViewRegion19.LineNumber = 168;
                    _moPubAdUnitViewRegion19.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion19, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion19;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron == null || _moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron";
                    _moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron.LineNumber = 169;
                    _moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialFailedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnInterstitialFailedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialFailedExpanderCheckImage == null || _moPubAdUnitViewOnInterstitialFailedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialFailedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialFailedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialFailedExpanderCheckImage.Name = "MoPubAdUnitViewOnInterstitialFailedExpanderCheckImage";
                    _moPubAdUnitViewOnInterstitialFailedExpanderCheckImage.LineNumber = 171;
                    _moPubAdUnitViewOnInterstitialFailedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnInterstitialFailedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialFailedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnInterstitialFailedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel == null || _moPubAdUnitViewOnInterstitialFailedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialFailedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialFailedExpanderEventLabel.Name = "MoPubAdUnitViewOnInterstitialFailedExpanderEventLabel";
                    _moPubAdUnitViewOnInterstitialFailedExpanderEventLabel.LineNumber = 172;
                    _moPubAdUnitViewOnInterstitialFailedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderEventLabel, "OnInterstitialFailedEvent");
                }
                return _moPubAdUnitViewOnInterstitialFailedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent8;
        public static Template MoPubAdUnitViewExpanderContent8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent8 == null || _moPubAdUnitViewExpanderContent8.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent8 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent8 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent8.Name = "MoPubAdUnitViewExpanderContent8";
                    _moPubAdUnitViewExpanderContent8.LineNumber = 175;
                    _moPubAdUnitViewExpanderContent8.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent8, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent8, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent8, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent8, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent8, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent8, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent8, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent8;
            }
        }

        private static Template _moPubAdUnitViewGroup5;
        public static Template MoPubAdUnitViewGroup5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup5 == null || _moPubAdUnitViewGroup5.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup5 == null)
#endif
                {
                    _moPubAdUnitViewGroup5 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup5.Name = "MoPubAdUnitViewGroup5";
                    _moPubAdUnitViewGroup5.LineNumber = 176;
                    _moPubAdUnitViewGroup5.LinePosition = 18;
#endif
                    Delight.Group.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewGroup5, Assets.Materials["UI-Fast-Default"]);
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup5, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup5, Delight.ElementAlignment.Top);
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup5, Delight.ElementOrientation.Vertical);
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup5, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup5, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup5, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.OffsetProperty.SetDefault(_moPubAdUnitViewGroup5, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-30f, ElementSizeUnit.Pixels)));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup5, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup5, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewGroup5;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel.LineNumber = 177;
                    _moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel;
        public static Template MoPubAdUnitViewOnInterstitialFailedExpanderErrorLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel == null || _moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel == null)
#endif
                {
                    _moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel.Name = "MoPubAdUnitViewOnInterstitialFailedExpanderErrorLabel";
                    _moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel.LineNumber = 178;
                    _moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, Delight.AutoSize.Default);
                    Delight.Label.OffsetProperty.SetDefault(_moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-50f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewOnInterstitialFailedExpanderErrorLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion20;
        public static Template MoPubAdUnitViewRegion20
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion20 == null || _moPubAdUnitViewRegion20.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion20 == null)
#endif
                {
                    _moPubAdUnitViewRegion20 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion20.Name = "MoPubAdUnitViewRegion20";
                    _moPubAdUnitViewRegion20.LineNumber = 182;
                    _moPubAdUnitViewRegion20.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion20, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion20, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion20, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion20, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion20);
                }
                return _moPubAdUnitViewRegion20;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoLoadedExpander;
        public static Template MoPubAdUnitViewOnRewardedVideoLoadedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpander == null || _moPubAdUnitViewOnRewardedVideoLoadedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoLoadedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoLoadedExpander.Name = "MoPubAdUnitViewOnRewardedVideoLoadedExpander";
                    _moPubAdUnitViewOnRewardedVideoLoadedExpander.LineNumber = 188;
                    _moPubAdUnitViewOnRewardedVideoLoadedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnRewardedVideoLoadedExpander);
                }
                return _moPubAdUnitViewOnRewardedVideoLoadedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader9;
        public static Template MoPubAdUnitViewExpanderHeader9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader9 == null || _moPubAdUnitViewExpanderHeader9.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader9 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader9 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader9.Name = "MoPubAdUnitViewExpanderHeader9";
                    _moPubAdUnitViewExpanderHeader9.LineNumber = 190;
                    _moPubAdUnitViewExpanderHeader9.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader9, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader9, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader9;
            }
        }

        private static Template _moPubAdUnitViewRegion21;
        public static Template MoPubAdUnitViewRegion21
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion21 == null || _moPubAdUnitViewRegion21.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion21 == null)
#endif
                {
                    _moPubAdUnitViewRegion21 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion21.Name = "MoPubAdUnitViewRegion21";
                    _moPubAdUnitViewRegion21.LineNumber = 191;
                    _moPubAdUnitViewRegion21.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion21, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion21;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron == null || _moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron";
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron.LineNumber = 192;
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage == null || _moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage.Name = "MoPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage";
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage.LineNumber = 194;
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel == null || _moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel.Name = "MoPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel";
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel.LineNumber = 195;
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel, "OnRewardedVideoLoadedEvent");
                }
                return _moPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent9;
        public static Template MoPubAdUnitViewExpanderContent9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent9 == null || _moPubAdUnitViewExpanderContent9.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent9 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent9 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent9.Name = "MoPubAdUnitViewExpanderContent9";
                    _moPubAdUnitViewExpanderContent9.LineNumber = 198;
                    _moPubAdUnitViewExpanderContent9.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent9, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent9, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent9, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent9, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent9, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent9, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent9, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent9;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel.LineNumber = 199;
                    _moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion22;
        public static Template MoPubAdUnitViewRegion22
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion22 == null || _moPubAdUnitViewRegion22.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion22 == null)
#endif
                {
                    _moPubAdUnitViewRegion22 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion22.Name = "MoPubAdUnitViewRegion22";
                    _moPubAdUnitViewRegion22.LineNumber = 202;
                    _moPubAdUnitViewRegion22.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion22, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion22, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion22, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion22, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion22);
                }
                return _moPubAdUnitViewRegion22;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoShownExpander;
        public static Template MoPubAdUnitViewOnRewardedVideoShownExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoShownExpander == null || _moPubAdUnitViewOnRewardedVideoShownExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoShownExpander == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoShownExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoShownExpander.Name = "MoPubAdUnitViewOnRewardedVideoShownExpander";
                    _moPubAdUnitViewOnRewardedVideoShownExpander.LineNumber = 204;
                    _moPubAdUnitViewOnRewardedVideoShownExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnRewardedVideoShownExpander);
                }
                return _moPubAdUnitViewOnRewardedVideoShownExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader10;
        public static Template MoPubAdUnitViewExpanderHeader10
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader10 == null || _moPubAdUnitViewExpanderHeader10.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader10 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader10 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader10.Name = "MoPubAdUnitViewExpanderHeader10";
                    _moPubAdUnitViewExpanderHeader10.LineNumber = 206;
                    _moPubAdUnitViewExpanderHeader10.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader10, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader10, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader10;
            }
        }

        private static Template _moPubAdUnitViewRegion23;
        public static Template MoPubAdUnitViewRegion23
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion23 == null || _moPubAdUnitViewRegion23.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion23 == null)
#endif
                {
                    _moPubAdUnitViewRegion23 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion23.Name = "MoPubAdUnitViewRegion23";
                    _moPubAdUnitViewRegion23.LineNumber = 207;
                    _moPubAdUnitViewRegion23.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion23, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion23;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron == null || _moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron.Name = "MoPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron";
                    _moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron.LineNumber = 208;
                    _moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage;
        public static Template MoPubAdUnitViewOnRewardedVideoShownExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage == null || _moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage.Name = "MoPubAdUnitViewOnRewardedVideoShownExpanderCheckImage";
                    _moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage.LineNumber = 210;
                    _moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnRewardedVideoShownExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoShownExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel == null || _moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel.Name = "MoPubAdUnitViewOnRewardedVideoShownExpanderEventLabel";
                    _moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel.LineNumber = 211;
                    _moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel, "OnRewardedVideoShownvent");
                }
                return _moPubAdUnitViewOnRewardedVideoShownExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent10;
        public static Template MoPubAdUnitViewExpanderContent10
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent10 == null || _moPubAdUnitViewExpanderContent10.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent10 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent10 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent10.Name = "MoPubAdUnitViewExpanderContent10";
                    _moPubAdUnitViewExpanderContent10.LineNumber = 214;
                    _moPubAdUnitViewExpanderContent10.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent10, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent10, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent10, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent10, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent10, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent10, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent10, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent10;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel.LineNumber = 215;
                    _moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion24;
        public static Template MoPubAdUnitViewRegion24
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion24 == null || _moPubAdUnitViewRegion24.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion24 == null)
#endif
                {
                    _moPubAdUnitViewRegion24 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion24.Name = "MoPubAdUnitViewRegion24";
                    _moPubAdUnitViewRegion24.LineNumber = 218;
                    _moPubAdUnitViewRegion24.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion24, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion24, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion24, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion24, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion24);
                }
                return _moPubAdUnitViewRegion24;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClickedExpander;
        public static Template MoPubAdUnitViewOnRewardedVideoClickedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClickedExpander == null || _moPubAdUnitViewOnRewardedVideoClickedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClickedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClickedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClickedExpander.Name = "MoPubAdUnitViewOnRewardedVideoClickedExpander";
                    _moPubAdUnitViewOnRewardedVideoClickedExpander.LineNumber = 220;
                    _moPubAdUnitViewOnRewardedVideoClickedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnRewardedVideoClickedExpander);
                }
                return _moPubAdUnitViewOnRewardedVideoClickedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader11;
        public static Template MoPubAdUnitViewExpanderHeader11
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader11 == null || _moPubAdUnitViewExpanderHeader11.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader11 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader11 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader11.Name = "MoPubAdUnitViewExpanderHeader11";
                    _moPubAdUnitViewExpanderHeader11.LineNumber = 222;
                    _moPubAdUnitViewExpanderHeader11.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader11, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader11, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader11;
            }
        }

        private static Template _moPubAdUnitViewRegion25;
        public static Template MoPubAdUnitViewRegion25
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion25 == null || _moPubAdUnitViewRegion25.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion25 == null)
#endif
                {
                    _moPubAdUnitViewRegion25 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion25.Name = "MoPubAdUnitViewRegion25";
                    _moPubAdUnitViewRegion25.LineNumber = 223;
                    _moPubAdUnitViewRegion25.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion25, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion25;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron == null || _moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron";
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron.LineNumber = 224;
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage == null || _moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage.Name = "MoPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage";
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage.LineNumber = 226;
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel == null || _moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel.Name = "MoPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel";
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel.LineNumber = 227;
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel, "OnRewardedVideoClickedEvent");
                }
                return _moPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent11;
        public static Template MoPubAdUnitViewExpanderContent11
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent11 == null || _moPubAdUnitViewExpanderContent11.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent11 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent11 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent11.Name = "MoPubAdUnitViewExpanderContent11";
                    _moPubAdUnitViewExpanderContent11.LineNumber = 230;
                    _moPubAdUnitViewExpanderContent11.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent11, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent11, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent11, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent11, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent11, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent11, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent11, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent11;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel.LineNumber = 231;
                    _moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion26;
        public static Template MoPubAdUnitViewRegion26
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion26 == null || _moPubAdUnitViewRegion26.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion26 == null)
#endif
                {
                    _moPubAdUnitViewRegion26 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion26.Name = "MoPubAdUnitViewRegion26";
                    _moPubAdUnitViewRegion26.LineNumber = 234;
                    _moPubAdUnitViewRegion26.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion26, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion26, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion26, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion26, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion26);
                }
                return _moPubAdUnitViewRegion26;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClosedExpander;
        public static Template MoPubAdUnitViewOnRewardedVideoClosedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClosedExpander == null || _moPubAdUnitViewOnRewardedVideoClosedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClosedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClosedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClosedExpander.Name = "MoPubAdUnitViewOnRewardedVideoClosedExpander";
                    _moPubAdUnitViewOnRewardedVideoClosedExpander.LineNumber = 236;
                    _moPubAdUnitViewOnRewardedVideoClosedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnRewardedVideoClosedExpander);
                }
                return _moPubAdUnitViewOnRewardedVideoClosedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader12;
        public static Template MoPubAdUnitViewExpanderHeader12
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader12 == null || _moPubAdUnitViewExpanderHeader12.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader12 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader12 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader12.Name = "MoPubAdUnitViewExpanderHeader12";
                    _moPubAdUnitViewExpanderHeader12.LineNumber = 238;
                    _moPubAdUnitViewExpanderHeader12.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader12, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader12, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader12;
            }
        }

        private static Template _moPubAdUnitViewRegion27;
        public static Template MoPubAdUnitViewRegion27
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion27 == null || _moPubAdUnitViewRegion27.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion27 == null)
#endif
                {
                    _moPubAdUnitViewRegion27 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion27.Name = "MoPubAdUnitViewRegion27";
                    _moPubAdUnitViewRegion27.LineNumber = 239;
                    _moPubAdUnitViewRegion27.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion27, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion27;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron == null || _moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron";
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron.LineNumber = 240;
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage == null || _moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage.Name = "MoPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage";
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage.LineNumber = 242;
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel == null || _moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel.Name = "MoPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel";
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel.LineNumber = 243;
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel, "OnRewardedVideoClosedEvent");
                }
                return _moPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent12;
        public static Template MoPubAdUnitViewExpanderContent12
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent12 == null || _moPubAdUnitViewExpanderContent12.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent12 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent12 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent12.Name = "MoPubAdUnitViewExpanderContent12";
                    _moPubAdUnitViewExpanderContent12.LineNumber = 246;
                    _moPubAdUnitViewExpanderContent12.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent12, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent12, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent12, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent12, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent12, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent12, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent12, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent12;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel.LineNumber = 247;
                    _moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion28;
        public static Template MoPubAdUnitViewRegion28
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion28 == null || _moPubAdUnitViewRegion28.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion28 == null)
#endif
                {
                    _moPubAdUnitViewRegion28 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion28.Name = "MoPubAdUnitViewRegion28";
                    _moPubAdUnitViewRegion28.LineNumber = 250;
                    _moPubAdUnitViewRegion28.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion28, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion28, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion28, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion28, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion28);
                }
                return _moPubAdUnitViewRegion28;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoReceivedRewardExpander;
        public static Template MoPubAdUnitViewOnRewardedVideoReceivedRewardExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander == null || _moPubAdUnitViewOnRewardedVideoReceivedRewardExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpander.Name = "MoPubAdUnitViewOnRewardedVideoReceivedRewardExpander";
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpander.LineNumber = 252;
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpander);
                }
                return _moPubAdUnitViewOnRewardedVideoReceivedRewardExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader13;
        public static Template MoPubAdUnitViewExpanderHeader13
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader13 == null || _moPubAdUnitViewExpanderHeader13.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader13 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader13 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader13.Name = "MoPubAdUnitViewExpanderHeader13";
                    _moPubAdUnitViewExpanderHeader13.LineNumber = 254;
                    _moPubAdUnitViewExpanderHeader13.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader13, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader13, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader13;
            }
        }

        private static Template _moPubAdUnitViewRegion29;
        public static Template MoPubAdUnitViewRegion29
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion29 == null || _moPubAdUnitViewRegion29.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion29 == null)
#endif
                {
                    _moPubAdUnitViewRegion29 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion29.Name = "MoPubAdUnitViewRegion29";
                    _moPubAdUnitViewRegion29.LineNumber = 255;
                    _moPubAdUnitViewRegion29.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion29, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion29;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron == null || _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron.Name = "MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron";
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron.LineNumber = 256;
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage;
        public static Template MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage == null || _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage.Name = "MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage";
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage.LineNumber = 258;
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel == null || _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel.Name = "MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel";
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel.LineNumber = 259;
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel, "OnRewardedVideoReceivedRewardEvent");
                }
                return _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent13;
        public static Template MoPubAdUnitViewExpanderContent13
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent13 == null || _moPubAdUnitViewExpanderContent13.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent13 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent13 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent13.Name = "MoPubAdUnitViewExpanderContent13";
                    _moPubAdUnitViewExpanderContent13.LineNumber = 263;
                    _moPubAdUnitViewExpanderContent13.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent13, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent13, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent13, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent13, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent13, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent13, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent13, new ElementSize(180f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent13;
            }
        }

        private static Template _moPubAdUnitViewGroup6;
        public static Template MoPubAdUnitViewGroup6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup6 == null || _moPubAdUnitViewGroup6.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup6 == null)
#endif
                {
                    _moPubAdUnitViewGroup6 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup6.Name = "MoPubAdUnitViewGroup6";
                    _moPubAdUnitViewGroup6.LineNumber = 264;
                    _moPubAdUnitViewGroup6.LinePosition = 18;
#endif
                    Delight.Group.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewGroup6, Assets.Materials["UI-Fast-Default"]);
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup6, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup6, Delight.ElementAlignment.Top);
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup6, Delight.ElementOrientation.Vertical);
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup6, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup6, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup6, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.OffsetProperty.SetDefault(_moPubAdUnitViewGroup6, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-30f, ElementSizeUnit.Pixels)));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup6, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup6, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewGroup6;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel.LineNumber = 265;
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel == null || _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel.Name = "MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel";
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel.LineNumber = 266;
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, Delight.AutoSize.Default);
                    Delight.Label.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-50f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel == null || _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel.Name = "MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel";
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel.LineNumber = 267;
                    _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, Delight.AutoSize.Default);
                    Delight.Label.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-100f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion30;
        public static Template MoPubAdUnitViewRegion30
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion30 == null || _moPubAdUnitViewRegion30.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion30 == null)
#endif
                {
                    _moPubAdUnitViewRegion30 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion30.Name = "MoPubAdUnitViewRegion30";
                    _moPubAdUnitViewRegion30.LineNumber = 271;
                    _moPubAdUnitViewRegion30.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion30, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion30, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion30, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion30, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion30);
                }
                return _moPubAdUnitViewRegion30;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedToPlayExpander;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedToPlayExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander == null || _moPubAdUnitViewOnRewardedVideoFailedToPlayExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpander.Name = "MoPubAdUnitViewOnRewardedVideoFailedToPlayExpander";
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpander.LineNumber = 273;
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpander);
                }
                return _moPubAdUnitViewOnRewardedVideoFailedToPlayExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader14;
        public static Template MoPubAdUnitViewExpanderHeader14
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader14 == null || _moPubAdUnitViewExpanderHeader14.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader14 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader14 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader14.Name = "MoPubAdUnitViewExpanderHeader14";
                    _moPubAdUnitViewExpanderHeader14.LineNumber = 275;
                    _moPubAdUnitViewExpanderHeader14.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader14, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader14, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader14;
            }
        }

        private static Template _moPubAdUnitViewRegion31;
        public static Template MoPubAdUnitViewRegion31
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion31 == null || _moPubAdUnitViewRegion31.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion31 == null)
#endif
                {
                    _moPubAdUnitViewRegion31 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion31.Name = "MoPubAdUnitViewRegion31";
                    _moPubAdUnitViewRegion31.LineNumber = 276;
                    _moPubAdUnitViewRegion31.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion31, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion31;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron == null || _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron.Name = "MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron";
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron.LineNumber = 277;
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage == null || _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage.Name = "MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage";
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage.LineNumber = 279;
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel == null || _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel.Name = "MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel";
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel.LineNumber = 280;
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel, "OnRewardedVideoFailedToPlayEvent");
                }
                return _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent14;
        public static Template MoPubAdUnitViewExpanderContent14
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent14 == null || _moPubAdUnitViewExpanderContent14.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent14 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent14 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent14.Name = "MoPubAdUnitViewExpanderContent14";
                    _moPubAdUnitViewExpanderContent14.LineNumber = 283;
                    _moPubAdUnitViewExpanderContent14.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent14, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent14, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent14, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent14, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent14, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent14, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent14, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent14;
            }
        }

        private static Template _moPubAdUnitViewGroup7;
        public static Template MoPubAdUnitViewGroup7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup7 == null || _moPubAdUnitViewGroup7.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup7 == null)
#endif
                {
                    _moPubAdUnitViewGroup7 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup7.Name = "MoPubAdUnitViewGroup7";
                    _moPubAdUnitViewGroup7.LineNumber = 284;
                    _moPubAdUnitViewGroup7.LinePosition = 18;
#endif
                    Delight.Group.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewGroup7, Assets.Materials["UI-Fast-Default"]);
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup7, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup7, Delight.ElementAlignment.Top);
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup7, Delight.ElementOrientation.Vertical);
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup7, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup7, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup7, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.OffsetProperty.SetDefault(_moPubAdUnitViewGroup7, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-30f, ElementSizeUnit.Pixels)));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup7, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup7, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewGroup7;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel.LineNumber = 285;
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel == null || _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel.Name = "MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel";
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel.LineNumber = 286;
                    _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, Delight.AutoSize.Default);
                    Delight.Label.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-50f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion32;
        public static Template MoPubAdUnitViewRegion32
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion32 == null || _moPubAdUnitViewRegion32.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion32 == null)
#endif
                {
                    _moPubAdUnitViewRegion32 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion32.Name = "MoPubAdUnitViewRegion32";
                    _moPubAdUnitViewRegion32.LineNumber = 290;
                    _moPubAdUnitViewRegion32.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion32, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion32, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion32, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion32, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion32);
                }
                return _moPubAdUnitViewRegion32;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedEventExpander;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedEventExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpander == null || _moPubAdUnitViewOnRewardedVideoFailedEventExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpander == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpander.Name = "MoPubAdUnitViewOnRewardedVideoFailedEventExpander";
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpander.LineNumber = 292;
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpander, Assets.Materials["UI-Fast-Default"]);
                    Delight.Expander.IsActiveProperty.SetHasBinding(_moPubAdUnitViewOnRewardedVideoFailedEventExpander);
                }
                return _moPubAdUnitViewOnRewardedVideoFailedEventExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader15;
        public static Template MoPubAdUnitViewExpanderHeader15
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader15 == null || _moPubAdUnitViewExpanderHeader15.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader15 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader15 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader15.Name = "MoPubAdUnitViewExpanderHeader15";
                    _moPubAdUnitViewExpanderHeader15.LineNumber = 294;
                    _moPubAdUnitViewExpanderHeader15.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader15, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader15, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader15;
            }
        }

        private static Template _moPubAdUnitViewRegion33;
        public static Template MoPubAdUnitViewRegion33
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion33 == null || _moPubAdUnitViewRegion33.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion33 == null)
#endif
                {
                    _moPubAdUnitViewRegion33 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion33.Name = "MoPubAdUnitViewRegion33";
                    _moPubAdUnitViewRegion33.LineNumber = 295;
                    _moPubAdUnitViewRegion33.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion33, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion33;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron == null || _moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron.Name = "MoPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron";
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron.LineNumber = 296;
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage == null || _moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage.Name = "MoPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage";
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage.LineNumber = 298;
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel == null || _moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel.Name = "MoPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel";
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel.LineNumber = 299;
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel, "OnRewardedVideoFailedEvent");
                }
                return _moPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent15;
        public static Template MoPubAdUnitViewExpanderContent15
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent15 == null || _moPubAdUnitViewExpanderContent15.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent15 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent15 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent15.Name = "MoPubAdUnitViewExpanderContent15";
                    _moPubAdUnitViewExpanderContent15.LineNumber = 302;
                    _moPubAdUnitViewExpanderContent15.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent15, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent15, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent15, true);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent15, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent15, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent15, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent15, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent15;
            }
        }

        private static Template _moPubAdUnitViewGroup8;
        public static Template MoPubAdUnitViewGroup8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup8 == null || _moPubAdUnitViewGroup8.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup8 == null)
#endif
                {
                    _moPubAdUnitViewGroup8 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup8.Name = "MoPubAdUnitViewGroup8";
                    _moPubAdUnitViewGroup8.LineNumber = 303;
                    _moPubAdUnitViewGroup8.LinePosition = 18;
#endif
                    Delight.Group.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewGroup8, Assets.Materials["UI-Fast-Default"]);
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup8, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup8, Delight.ElementAlignment.Top);
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup8, Delight.ElementOrientation.Vertical);
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup8, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup8, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup8, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.OffsetProperty.SetDefault(_moPubAdUnitViewGroup8, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-30f, ElementSizeUnit.Pixels)));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup8, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup8, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewGroup8;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel.LineNumber = 304;
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel;
        public static Template MoPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel == null || _moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel == null)
#endif
                {
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel.Name = "MoPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel";
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel.LineNumber = 305;
                    _moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, Delight.AutoSize.Default);
                    Delight.Label.OffsetProperty.SetDefault(_moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-50f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel;
            }
        }

        private static Template _moPubAdUnitViewRegion34;
        public static Template MoPubAdUnitViewRegion34
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion34 == null || _moPubAdUnitViewRegion34.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion34 == null)
#endif
                {
                    _moPubAdUnitViewRegion34 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion34.Name = "MoPubAdUnitViewRegion34";
                    _moPubAdUnitViewRegion34.LineNumber = 309;
                    _moPubAdUnitViewRegion34.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion34, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion34, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion34, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion34, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.IsActiveProperty.SetHasBinding(_moPubAdUnitViewRegion34);
                }
                return _moPubAdUnitViewRegion34;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpander;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpander == null || _moPubAdUnitViewOnImpressionTrackedBgExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpander == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpander.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpander";
                    _moPubAdUnitViewOnImpressionTrackedBgExpander.LineNumber = 315;
                    _moPubAdUnitViewOnImpressionTrackedBgExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpander, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader16;
        public static Template MoPubAdUnitViewExpanderHeader16
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader16 == null || _moPubAdUnitViewExpanderHeader16.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader16 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader16 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader16.Name = "MoPubAdUnitViewExpanderHeader16";
                    _moPubAdUnitViewExpanderHeader16.LineNumber = 317;
                    _moPubAdUnitViewExpanderHeader16.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader16, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader16, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader16;
            }
        }

        private static Template _moPubAdUnitViewRegion35;
        public static Template MoPubAdUnitViewRegion35
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion35 == null || _moPubAdUnitViewRegion35.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion35 == null)
#endif
                {
                    _moPubAdUnitViewRegion35 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion35.Name = "MoPubAdUnitViewRegion35";
                    _moPubAdUnitViewRegion35.LineNumber = 318;
                    _moPubAdUnitViewRegion35.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion35, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion35;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron == null || _moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron";
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron.LineNumber = 319;
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage == null || _moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage";
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage.LineNumber = 321;
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel == null || _moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel";
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel.LineNumber = 322;
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel, "OnImpressionTrackedBgEvent");
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent16;
        public static Template MoPubAdUnitViewExpanderContent16
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent16 == null || _moPubAdUnitViewExpanderContent16.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent16 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent16 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent16.Name = "MoPubAdUnitViewExpanderContent16";
                    _moPubAdUnitViewExpanderContent16.LineNumber = 325;
                    _moPubAdUnitViewExpanderContent16.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent16, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent16, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent16, false);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent16, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent16, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent16, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent16, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent16;
            }
        }

        private static Template _moPubAdUnitViewGroup9;
        public static Template MoPubAdUnitViewGroup9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup9 == null || _moPubAdUnitViewGroup9.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup9 == null)
#endif
                {
                    _moPubAdUnitViewGroup9 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup9.Name = "MoPubAdUnitViewGroup9";
                    _moPubAdUnitViewGroup9.LineNumber = 326;
                    _moPubAdUnitViewGroup9.LinePosition = 18;
#endif
                    Delight.Group.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewGroup9, Assets.Materials["UI-Fast-Default"]);
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup9, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup9, Delight.ElementAlignment.Top);
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup9, Delight.ElementOrientation.Vertical);
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup9, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup9, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup9, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.OffsetProperty.SetDefault(_moPubAdUnitViewGroup9, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-30f, ElementSizeUnit.Pixels)));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup9, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup9, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewGroup9;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel.LineNumber = 327;
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField == null || _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField = new Template(InputFieldTemplates.InputField);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField";
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField.LineNumber = 328;
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField.LinePosition = 22;
#endif
                    Delight.InputField.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, Assets.Materials["UI-Fast-Default"]);
                    Delight.InputField.TextMarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.InputField.MarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(80f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.InputField.SelectionColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.InputField.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.InputField.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.InputField.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, Delight.ElementAlignment.Left);
                    Delight.InputField.OffsetProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(-20f, ElementSizeUnit.Pixels)));
                    Delight.InputField.LineLimitProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, 0);
                    Delight.InputField.LineTypeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, TMPro.TMP_InputField.LineType.MultiLineNewline);
                    Delight.InputField.InputFieldPlaceholderTemplateProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder);
                    Delight.InputField.TextAreaTemplateProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea);
                    Delight.InputField.InputTextTemplateProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField, MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText);
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder == null || _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder = new Template(InputFieldTemplates.InputFieldInputFieldPlaceholder);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder";
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder.LineNumber = 12;
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder.LinePosition = 4;
#endif
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea == null || _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea = new Template(InputFieldTemplates.InputFieldTextArea);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea";
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea.LineNumber = 13;
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea.LinePosition = 4;
#endif
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText;
        public static Template MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText == null || _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText = new Template(InputFieldTemplates.InputFieldInputText);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText.Name = "MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText";
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText.LineNumber = 14;
                    _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText.LinePosition = 6;
#endif
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText, 32f);
                    Delight.Label.TextAlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText, TMPro.TextAlignmentOptions.Left);
                }
                return _moPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText;
            }
        }

        private static Template _moPubAdUnitViewRegion36;
        public static Template MoPubAdUnitViewRegion36
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion36 == null || _moPubAdUnitViewRegion36.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion36 == null)
#endif
                {
                    _moPubAdUnitViewRegion36 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion36.Name = "MoPubAdUnitViewRegion36";
                    _moPubAdUnitViewRegion36.LineNumber = 332;
                    _moPubAdUnitViewRegion36.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion36, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion36, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion36, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion36, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewRegion36;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpander;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpander == null || _moPubAdUnitViewOnImpressionTrackedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpander == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpander = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpander.Name = "MoPubAdUnitViewOnImpressionTrackedExpander";
                    _moPubAdUnitViewOnImpressionTrackedExpander.LineNumber = 334;
                    _moPubAdUnitViewOnImpressionTrackedExpander.LinePosition = 10;
#endif
                    Delight.Expander.ContentMarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpander, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Expander.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpander, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.IsExpandedProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpander, false);
                    Delight.Expander.HeaderAlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpander, Delight.ElementAlignment.Top);
                    Delight.Expander.BackgroundColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpander, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Expander.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpander, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnImpressionTrackedExpander;
            }
        }

        private static Template _moPubAdUnitViewExpanderHeader17;
        public static Template MoPubAdUnitViewExpanderHeader17
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderHeader17 == null || _moPubAdUnitViewExpanderHeader17.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderHeader17 == null)
#endif
                {
                    _moPubAdUnitViewExpanderHeader17 = new Template(ExpanderHeaderTemplates.ExpanderHeader);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderHeader17.Name = "MoPubAdUnitViewExpanderHeader17";
                    _moPubAdUnitViewExpanderHeader17.LineNumber = 336;
                    _moPubAdUnitViewExpanderHeader17.LinePosition = 14;
#endif
                    Delight.ExpanderHeader.WidthProperty.SetDefault(_moPubAdUnitViewExpanderHeader17, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderHeader.HeightProperty.SetDefault(_moPubAdUnitViewExpanderHeader17, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderHeader17;
            }
        }

        private static Template _moPubAdUnitViewRegion37;
        public static Template MoPubAdUnitViewRegion37
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion37 == null || _moPubAdUnitViewRegion37.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion37 == null)
#endif
                {
                    _moPubAdUnitViewRegion37 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion37.Name = "MoPubAdUnitViewRegion37";
                    _moPubAdUnitViewRegion37.LineNumber = 337;
                    _moPubAdUnitViewRegion37.LinePosition = 18;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion37, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitViewRegion37;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron == null || _moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron.Name = "MoPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron";
                    _moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron.LineNumber = 338;
                    _moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron.LinePosition = 22;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron, Delight.ElementAlignment.Left);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron, Assets.Materials["UI-Fast-Default"]);
                    Delight.Image.SpriteProperty.SetStateDefault("Expanded", _moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron, Assets.Sprites["chevron-down"]);
                }
                return _moPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpanderCheckImage;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpanderCheckImage == null || _moPubAdUnitViewOnImpressionTrackedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpanderCheckImage == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpanderCheckImage = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpanderCheckImage.Name = "MoPubAdUnitViewOnImpressionTrackedExpanderCheckImage";
                    _moPubAdUnitViewOnImpressionTrackedExpanderCheckImage.LineNumber = 340;
                    _moPubAdUnitViewOnImpressionTrackedExpanderCheckImage.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderCheckImage, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderCheckImage, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderCheckImage, Delight.ElementAlignment.Right);
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderCheckImage, Assets.Sprites["checkmark"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderCheckImage, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewOnImpressionTrackedExpanderCheckImage;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpanderEventLabel;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel == null || _moPubAdUnitViewOnImpressionTrackedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpanderEventLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpanderEventLabel.Name = "MoPubAdUnitViewOnImpressionTrackedExpanderEventLabel";
                    _moPubAdUnitViewOnImpressionTrackedExpanderEventLabel.LineNumber = 341;
                    _moPubAdUnitViewOnImpressionTrackedExpanderEventLabel.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderEventLabel, "OnImpressionTrackedEvent");
                }
                return _moPubAdUnitViewOnImpressionTrackedExpanderEventLabel;
            }
        }

        private static Template _moPubAdUnitViewExpanderContent17;
        public static Template MoPubAdUnitViewExpanderContent17
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewExpanderContent17 == null || _moPubAdUnitViewExpanderContent17.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewExpanderContent17 == null)
#endif
                {
                    _moPubAdUnitViewExpanderContent17 = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _moPubAdUnitViewExpanderContent17.Name = "MoPubAdUnitViewExpanderContent17";
                    _moPubAdUnitViewExpanderContent17.LineNumber = 344;
                    _moPubAdUnitViewExpanderContent17.LinePosition = 14;
#endif
                    Delight.ExpanderContent.OffsetProperty.SetDefault(_moPubAdUnitViewExpanderContent17, new ElementMargin(new ElementSize(60f, ElementSizeUnit.Pixels), new ElementSize(90f, ElementSizeUnit.Pixels)));
                    Delight.ExpanderContent.AlignmentProperty.SetDefault(_moPubAdUnitViewExpanderContent17, Delight.ElementAlignment.Top);
                    Delight.ExpanderContent.AutoSizeToContentProperty.SetDefault(_moPubAdUnitViewExpanderContent17, false);
                    Delight.ExpanderContent.BackgroundColorProperty.SetDefault(_moPubAdUnitViewExpanderContent17, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ExpanderContent.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewExpanderContent17, Assets.Materials["UI-Fast-Default"]);
                    Delight.ExpanderContent.WidthProperty.SetDefault(_moPubAdUnitViewExpanderContent17, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ExpanderContent.HeightProperty.SetDefault(_moPubAdUnitViewExpanderContent17, new ElementSize(60f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewExpanderContent17;
            }
        }

        private static Template _moPubAdUnitViewGroup10;
        public static Template MoPubAdUnitViewGroup10
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewGroup10 == null || _moPubAdUnitViewGroup10.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewGroup10 == null)
#endif
                {
                    _moPubAdUnitViewGroup10 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitViewGroup10.Name = "MoPubAdUnitViewGroup10";
                    _moPubAdUnitViewGroup10.LineNumber = 345;
                    _moPubAdUnitViewGroup10.LinePosition = 18;
#endif
                    Delight.Group.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewGroup10, Assets.Materials["UI-Fast-Default"]);
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitViewGroup10, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitViewGroup10, Delight.ElementAlignment.Top);
                    Delight.Group.OrientationProperty.SetDefault(_moPubAdUnitViewGroup10, Delight.ElementOrientation.Vertical);
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitViewGroup10, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup10, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup10, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.OffsetProperty.SetDefault(_moPubAdUnitViewGroup10, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-30f, ElementSizeUnit.Pixels)));
                    Delight.Group.WidthProperty.SetDefault(_moPubAdUnitViewGroup10, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Group.HeightProperty.SetDefault(_moPubAdUnitViewGroup10, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _moPubAdUnitViewGroup10;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel == null || _moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel.Name = "MoPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel";
                    _moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel.LineNumber = 346;
                    _moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel, 40f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel, Delight.AutoSize.Default);
                }
                return _moPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField == null || _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField = new Template(InputFieldTemplates.InputField);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField.Name = "MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField";
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField.LineNumber = 347;
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField.LinePosition = 22;
#endif
                    Delight.InputField.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, Assets.Materials["UI-Fast-Default"]);
                    Delight.InputField.TextMarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.InputField.MarginProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(80f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.InputField.SelectionColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 1f));
                    Delight.InputField.WidthProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.InputField.HeightProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.InputField.AlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, Delight.ElementAlignment.Left);
                    Delight.InputField.OffsetProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(-20f, ElementSizeUnit.Pixels)));
                    Delight.InputField.LineLimitProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, 0);
                    Delight.InputField.LineTypeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, TMPro.TMP_InputField.LineType.MultiLineNewline);
                    Delight.InputField.InputFieldPlaceholderTemplateProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder);
                    Delight.InputField.TextAreaTemplateProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea);
                    Delight.InputField.InputTextTemplateProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField, MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText);
                }
                return _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder == null || _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder = new Template(InputFieldTemplates.InputFieldInputFieldPlaceholder);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder.Name = "MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder";
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder.LineNumber = 12;
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder.LinePosition = 4;
#endif
                }
                return _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea == null || _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea = new Template(InputFieldTemplates.InputFieldTextArea);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea.Name = "MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea";
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea.LineNumber = 13;
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea.LinePosition = 4;
#endif
                }
                return _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea;
            }
        }

        private static Template _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText;
        public static Template MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText == null || _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText == null)
#endif
                {
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText = new Template(InputFieldTemplates.InputFieldInputText);
#if UNITY_EDITOR
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText.Name = "MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText";
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText.LineNumber = 14;
                    _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText.LinePosition = 6;
#endif
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText, 32f);
                    Delight.Label.TextAlignmentProperty.SetDefault(_moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText, TMPro.TextAlignmentOptions.Left);
                }
                return _moPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText;
            }
        }

        private static Template _moPubAdUnitViewRegion38;
        public static Template MoPubAdUnitViewRegion38
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitViewRegion38 == null || _moPubAdUnitViewRegion38.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitViewRegion38 == null)
#endif
                {
                    _moPubAdUnitViewRegion38 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitViewRegion38.Name = "MoPubAdUnitViewRegion38";
                    _moPubAdUnitViewRegion38.LineNumber = 351;
                    _moPubAdUnitViewRegion38.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitViewRegion38, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitViewRegion38, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitViewRegion38, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitViewRegion38, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitViewRegion38;
            }
        }

        #endregion
    }

    #endregion
}
