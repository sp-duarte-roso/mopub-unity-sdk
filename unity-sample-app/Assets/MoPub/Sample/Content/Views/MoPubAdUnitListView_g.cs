// Internal view logic generated from "MoPubAdUnitListView.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MoPubAdUnitListView : UIView
    {
        #region Constructors

        public MoPubAdUnitListView(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MoPubAdUnitListViewTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing Group (Group1)
            Group1 = new Group(this, this, "Group1", Group1Template);
            Region1 = new Region(this, Group1.Content, "Region1", Region1Template);
            Label1 = new Label(this, Region1.Content, "Label1", Label1Template);
            List1 = new List(this, Group1.Content, "List1", List1Template);

            // binding <List Items="{adUnit in @BannerAdUnits}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> {  }, new List<Func<object>> {  }) }, new BindingPath(new List<string> { "List1", "Items" }, new List<Func<object>> { () => this, () => List1 }), () => List1.Items = Models.BannerAdUnits, () => { }, false));

            // templates for List1
            List1.ContentTemplates.Add(new ContentTemplate(tiAdUnit => 
            {
                var listItem1 = new ListItem(this, List1.Content, "ListItem1", ListItem1Template);
                listItem1.Click.RegisterHandler(this, "AdUnitClickHandler", () => (tiAdUnit.Item as Delight.MoPubAdUnit));
                var label2 = new Label(this, listItem1.Content, "Label2", Label2Template);

                // binding <Label Text="{adUnit.Name}">
                listItem1.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Item", "Name" }, new List<Func<object>> { () => tiAdUnit, () => (tiAdUnit.Item as Delight.MoPubAdUnit) }) }, new BindingPath(new List<string> { "Text" }, new List<Func<object>> { () => label2 }), () => label2.Text = (tiAdUnit.Item as Delight.MoPubAdUnit).Name, () => { }, false));
                var label3 = new Label(this, listItem1.Content, "Label3", Label3Template);

                // binding <Label Text="{adUnit.AdUnitId}">
                listItem1.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Item", "AdUnitId" }, new List<Func<object>> { () => tiAdUnit, () => (tiAdUnit.Item as Delight.MoPubAdUnit) }) }, new BindingPath(new List<string> { "Text" }, new List<Func<object>> { () => label3 }), () => label3.Text = (tiAdUnit.Item as Delight.MoPubAdUnit).AdUnitId, () => { }, false));
                var image1 = new Image(this, listItem1.Content, "Image1", Image1Template);
                var region2 = new Region(this, listItem1.Content, "Region2", Region2Template);
                listItem1.IsDynamic = true;
                listItem1.SetContentTemplateData(tiAdUnit);
                return listItem1;
            }, typeof(ListItem), "ListItem1"));
            Region3 = new Region(this, Group1.Content, "Region3", Region3Template);
            Label4 = new Label(this, Region3.Content, "Label4", Label4Template);
            List2 = new List(this, Group1.Content, "List2", List2Template);

            // binding <List Items="{adUnit in @InterstitialAdUnits}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> {  }, new List<Func<object>> {  }) }, new BindingPath(new List<string> { "List2", "Items" }, new List<Func<object>> { () => this, () => List2 }), () => List2.Items = Models.InterstitialAdUnits, () => { }, false));

            // templates for List2
            List2.ContentTemplates.Add(new ContentTemplate(tiAdUnit => 
            {
                var listItem2 = new ListItem(this, List2.Content, "ListItem2", ListItem2Template);
                listItem2.Click.RegisterHandler(this, "AdUnitClickHandler", () => (tiAdUnit.Item as Delight.MoPubAdUnit));
                var label5 = new Label(this, listItem2.Content, "Label5", Label5Template);

                // binding <Label Text="{adUnit.Name}">
                listItem2.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Item", "Name" }, new List<Func<object>> { () => tiAdUnit, () => (tiAdUnit.Item as Delight.MoPubAdUnit) }) }, new BindingPath(new List<string> { "Text" }, new List<Func<object>> { () => label5 }), () => label5.Text = (tiAdUnit.Item as Delight.MoPubAdUnit).Name, () => { }, false));
                var label6 = new Label(this, listItem2.Content, "Label6", Label6Template);

                // binding <Label Text="{adUnit.AdUnitId}">
                listItem2.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Item", "AdUnitId" }, new List<Func<object>> { () => tiAdUnit, () => (tiAdUnit.Item as Delight.MoPubAdUnit) }) }, new BindingPath(new List<string> { "Text" }, new List<Func<object>> { () => label6 }), () => label6.Text = (tiAdUnit.Item as Delight.MoPubAdUnit).AdUnitId, () => { }, false));
                var image2 = new Image(this, listItem2.Content, "Image2", Image2Template);
                var region4 = new Region(this, listItem2.Content, "Region4", Region4Template);
                listItem2.IsDynamic = true;
                listItem2.SetContentTemplateData(tiAdUnit);
                return listItem2;
            }, typeof(ListItem), "ListItem2"));
            Region5 = new Region(this, Group1.Content, "Region5", Region5Template);
            Label7 = new Label(this, Region5.Content, "Label7", Label7Template);
            List3 = new List(this, Group1.Content, "List3", List3Template);

            // binding <List Items="{adUnit in @RewardedAdUnits}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> {  }, new List<Func<object>> {  }) }, new BindingPath(new List<string> { "List3", "Items" }, new List<Func<object>> { () => this, () => List3 }), () => List3.Items = Models.RewardedAdUnits, () => { }, false));

            // templates for List3
            List3.ContentTemplates.Add(new ContentTemplate(tiAdUnit => 
            {
                var listItem3 = new ListItem(this, List3.Content, "ListItem3", ListItem3Template);
                listItem3.Click.RegisterHandler(this, "AdUnitClickHandler", () => (tiAdUnit.Item as Delight.MoPubAdUnit));
                var label8 = new Label(this, listItem3.Content, "Label8", Label8Template);

                // binding <Label Text="{adUnit.Name}">
                listItem3.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Item", "Name" }, new List<Func<object>> { () => tiAdUnit, () => (tiAdUnit.Item as Delight.MoPubAdUnit) }) }, new BindingPath(new List<string> { "Text" }, new List<Func<object>> { () => label8 }), () => label8.Text = (tiAdUnit.Item as Delight.MoPubAdUnit).Name, () => { }, false));
                var label9 = new Label(this, listItem3.Content, "Label9", Label9Template);

                // binding <Label Text="{adUnit.AdUnitId}">
                listItem3.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Item", "AdUnitId" }, new List<Func<object>> { () => tiAdUnit, () => (tiAdUnit.Item as Delight.MoPubAdUnit) }) }, new BindingPath(new List<string> { "Text" }, new List<Func<object>> { () => label9 }), () => label9.Text = (tiAdUnit.Item as Delight.MoPubAdUnit).AdUnitId, () => { }, false));
                var image3 = new Image(this, listItem3.Content, "Image3", Image3Template);
                var region6 = new Region(this, listItem3.Content, "Region6", Region6Template);
                listItem3.IsDynamic = true;
                listItem3.SetContentTemplateData(tiAdUnit);
                return listItem3;
            }, typeof(ListItem), "ListItem3"));
            this.AfterInitializeInternal();
        }

        public MoPubAdUnitListView() : this(null)
        {
        }

        static MoPubAdUnitListView()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MoPubAdUnitListViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(ShowAdUnitProperty);
            dependencyProperties.Add(Group1Property);
            dependencyProperties.Add(Group1TemplateProperty);
            dependencyProperties.Add(Region1Property);
            dependencyProperties.Add(Region1TemplateProperty);
            dependencyProperties.Add(Label1Property);
            dependencyProperties.Add(Label1TemplateProperty);
            dependencyProperties.Add(List1Property);
            dependencyProperties.Add(List1TemplateProperty);
            dependencyProperties.Add(ListItem1Property);
            dependencyProperties.Add(ListItem1TemplateProperty);
            dependencyProperties.Add(Label2Property);
            dependencyProperties.Add(Label2TemplateProperty);
            dependencyProperties.Add(Label3Property);
            dependencyProperties.Add(Label3TemplateProperty);
            dependencyProperties.Add(Image1Property);
            dependencyProperties.Add(Image1TemplateProperty);
            dependencyProperties.Add(Region2Property);
            dependencyProperties.Add(Region2TemplateProperty);
            dependencyProperties.Add(Region3Property);
            dependencyProperties.Add(Region3TemplateProperty);
            dependencyProperties.Add(Label4Property);
            dependencyProperties.Add(Label4TemplateProperty);
            dependencyProperties.Add(List2Property);
            dependencyProperties.Add(List2TemplateProperty);
            dependencyProperties.Add(ListItem2Property);
            dependencyProperties.Add(ListItem2TemplateProperty);
            dependencyProperties.Add(Label5Property);
            dependencyProperties.Add(Label5TemplateProperty);
            dependencyProperties.Add(Label6Property);
            dependencyProperties.Add(Label6TemplateProperty);
            dependencyProperties.Add(Image2Property);
            dependencyProperties.Add(Image2TemplateProperty);
            dependencyProperties.Add(Region4Property);
            dependencyProperties.Add(Region4TemplateProperty);
            dependencyProperties.Add(Region5Property);
            dependencyProperties.Add(Region5TemplateProperty);
            dependencyProperties.Add(Label7Property);
            dependencyProperties.Add(Label7TemplateProperty);
            dependencyProperties.Add(List3Property);
            dependencyProperties.Add(List3TemplateProperty);
            dependencyProperties.Add(ListItem3Property);
            dependencyProperties.Add(ListItem3TemplateProperty);
            dependencyProperties.Add(Label8Property);
            dependencyProperties.Add(Label8TemplateProperty);
            dependencyProperties.Add(Label9Property);
            dependencyProperties.Add(Label9TemplateProperty);
            dependencyProperties.Add(Image3Property);
            dependencyProperties.Add(Image3TemplateProperty);
            dependencyProperties.Add(Region6Property);
            dependencyProperties.Add(Region6TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<ViewAction> ShowAdUnitProperty = new DependencyProperty<ViewAction>("ShowAdUnit", () => new ViewAction());
        public ViewAction ShowAdUnit
        {
            get { return ShowAdUnitProperty.GetValue(this); }
            set { ShowAdUnitProperty.SetValue(this, value); }
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

        public readonly static DependencyProperty<List> List1Property = new DependencyProperty<List>("List1");
        public List List1
        {
            get { return List1Property.GetValue(this); }
            set { List1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> List1TemplateProperty = new DependencyProperty<Template>("List1Template");
        public Template List1Template
        {
            get { return List1TemplateProperty.GetValue(this); }
            set { List1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ListItem> ListItem1Property = new DependencyProperty<ListItem>("ListItem1");
        public ListItem ListItem1
        {
            get { return ListItem1Property.GetValue(this); }
            set { ListItem1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ListItem1TemplateProperty = new DependencyProperty<Template>("ListItem1Template");
        public Template ListItem1Template
        {
            get { return ListItem1TemplateProperty.GetValue(this); }
            set { ListItem1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label2Property = new DependencyProperty<Label>("Label2");
        public Label Label2
        {
            get { return Label2Property.GetValue(this); }
            set { Label2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label2TemplateProperty = new DependencyProperty<Template>("Label2Template");
        public Template Label2Template
        {
            get { return Label2TemplateProperty.GetValue(this); }
            set { Label2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label3Property = new DependencyProperty<Label>("Label3");
        public Label Label3
        {
            get { return Label3Property.GetValue(this); }
            set { Label3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label3TemplateProperty = new DependencyProperty<Template>("Label3Template");
        public Template Label3Template
        {
            get { return Label3TemplateProperty.GetValue(this); }
            set { Label3TemplateProperty.SetValue(this, value); }
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

        public readonly static DependencyProperty<Label> Label4Property = new DependencyProperty<Label>("Label4");
        public Label Label4
        {
            get { return Label4Property.GetValue(this); }
            set { Label4Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label4TemplateProperty = new DependencyProperty<Template>("Label4Template");
        public Template Label4Template
        {
            get { return Label4TemplateProperty.GetValue(this); }
            set { Label4TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<List> List2Property = new DependencyProperty<List>("List2");
        public List List2
        {
            get { return List2Property.GetValue(this); }
            set { List2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> List2TemplateProperty = new DependencyProperty<Template>("List2Template");
        public Template List2Template
        {
            get { return List2TemplateProperty.GetValue(this); }
            set { List2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ListItem> ListItem2Property = new DependencyProperty<ListItem>("ListItem2");
        public ListItem ListItem2
        {
            get { return ListItem2Property.GetValue(this); }
            set { ListItem2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ListItem2TemplateProperty = new DependencyProperty<Template>("ListItem2Template");
        public Template ListItem2Template
        {
            get { return ListItem2TemplateProperty.GetValue(this); }
            set { ListItem2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label5Property = new DependencyProperty<Label>("Label5");
        public Label Label5
        {
            get { return Label5Property.GetValue(this); }
            set { Label5Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label5TemplateProperty = new DependencyProperty<Template>("Label5Template");
        public Template Label5Template
        {
            get { return Label5TemplateProperty.GetValue(this); }
            set { Label5TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label6Property = new DependencyProperty<Label>("Label6");
        public Label Label6
        {
            get { return Label6Property.GetValue(this); }
            set { Label6Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label6TemplateProperty = new DependencyProperty<Template>("Label6Template");
        public Template Label6Template
        {
            get { return Label6TemplateProperty.GetValue(this); }
            set { Label6TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> Image2Property = new DependencyProperty<Image>("Image2");
        public Image Image2
        {
            get { return Image2Property.GetValue(this); }
            set { Image2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Image2TemplateProperty = new DependencyProperty<Template>("Image2Template");
        public Template Image2Template
        {
            get { return Image2TemplateProperty.GetValue(this); }
            set { Image2TemplateProperty.SetValue(this, value); }
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

        public readonly static DependencyProperty<Label> Label7Property = new DependencyProperty<Label>("Label7");
        public Label Label7
        {
            get { return Label7Property.GetValue(this); }
            set { Label7Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label7TemplateProperty = new DependencyProperty<Template>("Label7Template");
        public Template Label7Template
        {
            get { return Label7TemplateProperty.GetValue(this); }
            set { Label7TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<List> List3Property = new DependencyProperty<List>("List3");
        public List List3
        {
            get { return List3Property.GetValue(this); }
            set { List3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> List3TemplateProperty = new DependencyProperty<Template>("List3Template");
        public Template List3Template
        {
            get { return List3TemplateProperty.GetValue(this); }
            set { List3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ListItem> ListItem3Property = new DependencyProperty<ListItem>("ListItem3");
        public ListItem ListItem3
        {
            get { return ListItem3Property.GetValue(this); }
            set { ListItem3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ListItem3TemplateProperty = new DependencyProperty<Template>("ListItem3Template");
        public Template ListItem3Template
        {
            get { return ListItem3TemplateProperty.GetValue(this); }
            set { ListItem3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label8Property = new DependencyProperty<Label>("Label8");
        public Label Label8
        {
            get { return Label8Property.GetValue(this); }
            set { Label8Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label8TemplateProperty = new DependencyProperty<Template>("Label8Template");
        public Template Label8Template
        {
            get { return Label8TemplateProperty.GetValue(this); }
            set { Label8TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label9Property = new DependencyProperty<Label>("Label9");
        public Label Label9
        {
            get { return Label9Property.GetValue(this); }
            set { Label9Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label9TemplateProperty = new DependencyProperty<Template>("Label9Template");
        public Template Label9Template
        {
            get { return Label9TemplateProperty.GetValue(this); }
            set { Label9TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> Image3Property = new DependencyProperty<Image>("Image3");
        public Image Image3
        {
            get { return Image3Property.GetValue(this); }
            set { Image3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Image3TemplateProperty = new DependencyProperty<Template>("Image3Template");
        public Template Image3Template
        {
            get { return Image3TemplateProperty.GetValue(this); }
            set { Image3TemplateProperty.SetValue(this, value); }
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

        #endregion
    }

    #region Data Templates

    public static class MoPubAdUnitListViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MoPubAdUnitListView;
            }
        }

        private static Template _moPubAdUnitListView;
        public static Template MoPubAdUnitListView
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListView == null || _moPubAdUnitListView.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListView == null)
#endif
                {
                    _moPubAdUnitListView = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _moPubAdUnitListView.Name = "MoPubAdUnitListView";
                    _moPubAdUnitListView.LineNumber = 0;
                    _moPubAdUnitListView.LinePosition = 0;
#endif
                    Delight.MoPubAdUnitListView.Group1TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewGroup1);
                    Delight.MoPubAdUnitListView.Region1TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewRegion1);
                    Delight.MoPubAdUnitListView.Label1TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel1);
                    Delight.MoPubAdUnitListView.List1TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewList1);
                    Delight.MoPubAdUnitListView.ListItem1TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewListItem1);
                    Delight.MoPubAdUnitListView.Label2TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel2);
                    Delight.MoPubAdUnitListView.Label3TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel3);
                    Delight.MoPubAdUnitListView.Image1TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewImage1);
                    Delight.MoPubAdUnitListView.Region2TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewRegion2);
                    Delight.MoPubAdUnitListView.Region3TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewRegion3);
                    Delight.MoPubAdUnitListView.Label4TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel4);
                    Delight.MoPubAdUnitListView.List2TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewList2);
                    Delight.MoPubAdUnitListView.ListItem2TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewListItem2);
                    Delight.MoPubAdUnitListView.Label5TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel5);
                    Delight.MoPubAdUnitListView.Label6TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel6);
                    Delight.MoPubAdUnitListView.Image2TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewImage2);
                    Delight.MoPubAdUnitListView.Region4TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewRegion4);
                    Delight.MoPubAdUnitListView.Region5TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewRegion5);
                    Delight.MoPubAdUnitListView.Label7TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel7);
                    Delight.MoPubAdUnitListView.List3TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewList3);
                    Delight.MoPubAdUnitListView.ListItem3TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewListItem3);
                    Delight.MoPubAdUnitListView.Label8TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel8);
                    Delight.MoPubAdUnitListView.Label9TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewLabel9);
                    Delight.MoPubAdUnitListView.Image3TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewImage3);
                    Delight.MoPubAdUnitListView.Region6TemplateProperty.SetDefault(_moPubAdUnitListView, MoPubAdUnitListViewRegion6);
                }
                return _moPubAdUnitListView;
            }
        }

        private static Template _moPubAdUnitListViewGroup1;
        public static Template MoPubAdUnitListViewGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewGroup1 == null || _moPubAdUnitListViewGroup1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewGroup1 == null)
#endif
                {
                    _moPubAdUnitListViewGroup1 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubAdUnitListViewGroup1.Name = "MoPubAdUnitListViewGroup1";
                    _moPubAdUnitListViewGroup1.LineNumber = 4;
                    _moPubAdUnitListViewGroup1.LinePosition = 6;
#endif
                    Delight.Group.BackgroundColorProperty.SetDefault(_moPubAdUnitListViewGroup1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Group.SpacingProperty.SetDefault(_moPubAdUnitListViewGroup1, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubAdUnitListViewGroup1, Delight.ElementAlignment.Top);
                }
                return _moPubAdUnitListViewGroup1;
            }
        }

        private static Template _moPubAdUnitListViewRegion1;
        public static Template MoPubAdUnitListViewRegion1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewRegion1 == null || _moPubAdUnitListViewRegion1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewRegion1 == null)
#endif
                {
                    _moPubAdUnitListViewRegion1 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitListViewRegion1.Name = "MoPubAdUnitListViewRegion1";
                    _moPubAdUnitListViewRegion1.LineNumber = 5;
                    _moPubAdUnitListViewRegion1.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitListViewRegion1, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitListViewRegion1, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 0.1568628f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewRegion1, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitListViewRegion1;
            }
        }

        private static Template _moPubAdUnitListViewLabel1;
        public static Template MoPubAdUnitListViewLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel1 == null || _moPubAdUnitListViewLabel1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel1 == null)
#endif
                {
                    _moPubAdUnitListViewLabel1 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel1.Name = "MoPubAdUnitListViewLabel1";
                    _moPubAdUnitListViewLabel1.LineNumber = 6;
                    _moPubAdUnitListViewLabel1.LinePosition = 14;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel1, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel1, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel1, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel1, 46f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel1, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitListViewLabel1, "Banners");
                }
                return _moPubAdUnitListViewLabel1;
            }
        }

        private static Template _moPubAdUnitListViewList1;
        public static Template MoPubAdUnitListViewList1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1 == null || _moPubAdUnitListViewList1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1 == null)
#endif
                {
                    _moPubAdUnitListViewList1 = new Template(ListTemplates.List);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1.Name = "MoPubAdUnitListViewList1";
                    _moPubAdUnitListViewList1.LineNumber = 8;
                    _moPubAdUnitListViewList1.LinePosition = 10;
#endif
                    Delight.List.CanSelectProperty.SetDefault(_moPubAdUnitListViewList1, false);
                    Delight.List.ItemsProperty.SetHasBinding(_moPubAdUnitListViewList1);
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_moPubAdUnitListViewList1, MoPubAdUnitListViewList1ScrollableRegion);
                }
                return _moPubAdUnitListViewList1;
            }
        }

        private static Template _moPubAdUnitListViewList1ScrollableRegion;
        public static Template MoPubAdUnitListViewList1ScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1ScrollableRegion == null || _moPubAdUnitListViewList1ScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1ScrollableRegion == null)
#endif
                {
                    _moPubAdUnitListViewList1ScrollableRegion = new Template(ListTemplates.ListScrollableRegion);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1ScrollableRegion.Name = "MoPubAdUnitListViewList1ScrollableRegion";
                    _moPubAdUnitListViewList1ScrollableRegion.LineNumber = 29;
                    _moPubAdUnitListViewList1ScrollableRegion.LinePosition = 4;
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_moPubAdUnitListViewList1ScrollableRegion, MoPubAdUnitListViewList1ScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_moPubAdUnitListViewList1ScrollableRegion, MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_moPubAdUnitListViewList1ScrollableRegion, MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbar);
                }
                return _moPubAdUnitListViewList1ScrollableRegion;
            }
        }

        private static Template _moPubAdUnitListViewList1ScrollableRegionContentRegion;
        public static Template MoPubAdUnitListViewList1ScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1ScrollableRegionContentRegion == null || _moPubAdUnitListViewList1ScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1ScrollableRegionContentRegion == null)
#endif
                {
                    _moPubAdUnitListViewList1ScrollableRegionContentRegion = new Template(ListTemplates.ListScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1ScrollableRegionContentRegion.Name = "MoPubAdUnitListViewList1ScrollableRegionContentRegion";
                    _moPubAdUnitListViewList1ScrollableRegionContentRegion.LineNumber = 24;
                    _moPubAdUnitListViewList1ScrollableRegionContentRegion.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList1ScrollableRegionContentRegion;
            }
        }

        private static Template _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar;
        public static Template MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar == null || _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar.Name = "MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar";
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar.LineNumber = 26;
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar, MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar, MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle);
                }
                return _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar;
        public static Template MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar == null || _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar.Name = "MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar";
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar.LineNumber = 7;
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle;
        public static Template MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle == null || _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle.Name = "MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle";
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle.LineNumber = 8;
                    _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar;
        public static Template MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar == null || _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar.Name = "MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbar";
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar.LineNumber = 27;
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar, MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar, MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle);
                }
                return _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar;
        public static Template MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar == null || _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar.Name = "MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar";
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar.LineNumber = 7;
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle;
        public static Template MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle == null || _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle.Name = "MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle";
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle.LineNumber = 8;
                    _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _moPubAdUnitListViewListItem1;
        public static Template MoPubAdUnitListViewListItem1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewListItem1 == null || _moPubAdUnitListViewListItem1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewListItem1 == null)
#endif
                {
                    _moPubAdUnitListViewListItem1 = new Template(ListItemTemplates.ListItem);
#if UNITY_EDITOR
                    _moPubAdUnitListViewListItem1.Name = "MoPubAdUnitListViewListItem1";
                    _moPubAdUnitListViewListItem1.LineNumber = 9;
                    _moPubAdUnitListViewListItem1.LinePosition = 14;
#endif
                    Delight.ListItem.HeightProperty.SetDefault(_moPubAdUnitListViewListItem1, new ElementSize(160f, ElementSizeUnit.Pixels));
                    Delight.ListItem.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewListItem1, Assets.Materials["UI-Fast-Default"]);
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Selected", _moPubAdUnitListViewListItem1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Highlighted", _moPubAdUnitListViewListItem1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Pressed", _moPubAdUnitListViewListItem1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitListViewListItem1;
            }
        }

        private static Template _moPubAdUnitListViewLabel2;
        public static Template MoPubAdUnitListViewLabel2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel2 == null || _moPubAdUnitListViewLabel2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel2 == null)
#endif
                {
                    _moPubAdUnitListViewLabel2 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel2.Name = "MoPubAdUnitListViewLabel2";
                    _moPubAdUnitListViewLabel2.LineNumber = 10;
                    _moPubAdUnitListViewLabel2.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel2, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel2, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel2, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(-60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel2, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel2, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitListViewLabel2, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel2, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetHasBinding(_moPubAdUnitListViewLabel2);
                }
                return _moPubAdUnitListViewLabel2;
            }
        }

        private static Template _moPubAdUnitListViewLabel3;
        public static Template MoPubAdUnitListViewLabel3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel3 == null || _moPubAdUnitListViewLabel3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel3 == null)
#endif
                {
                    _moPubAdUnitListViewLabel3 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel3.Name = "MoPubAdUnitListViewLabel3";
                    _moPubAdUnitListViewLabel3.LineNumber = 11;
                    _moPubAdUnitListViewLabel3.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel3, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel3, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel3, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel3, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitListViewLabel3, Delight.AutoSize.Default);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel3, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel3, 40f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitListViewLabel3, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.TextProperty.SetHasBinding(_moPubAdUnitListViewLabel3);
                }
                return _moPubAdUnitListViewLabel3;
            }
        }

        private static Template _moPubAdUnitListViewImage1;
        public static Template MoPubAdUnitListViewImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewImage1 == null || _moPubAdUnitListViewImage1.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewImage1 == null)
#endif
                {
                    _moPubAdUnitListViewImage1 = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitListViewImage1.Name = "MoPubAdUnitListViewImage1";
                    _moPubAdUnitListViewImage1.LineNumber = 12;
                    _moPubAdUnitListViewImage1.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitListViewImage1, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitListViewImage1, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitListViewImage1, Delight.ElementAlignment.Right);
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitListViewImage1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels)));
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitListViewImage1, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitListViewImage1, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitListViewImage1;
            }
        }

        private static Template _moPubAdUnitListViewRegion2;
        public static Template MoPubAdUnitListViewRegion2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewRegion2 == null || _moPubAdUnitListViewRegion2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewRegion2 == null)
#endif
                {
                    _moPubAdUnitListViewRegion2 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitListViewRegion2.Name = "MoPubAdUnitListViewRegion2";
                    _moPubAdUnitListViewRegion2.LineNumber = 13;
                    _moPubAdUnitListViewRegion2.LinePosition = 18;
#endif
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewRegion2, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitListViewRegion2, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitListViewRegion2, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitListViewRegion2, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.OffsetProperty.SetDefault(_moPubAdUnitListViewRegion2, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(80f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitListViewRegion2;
            }
        }

        private static Template _moPubAdUnitListViewRegion3;
        public static Template MoPubAdUnitListViewRegion3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewRegion3 == null || _moPubAdUnitListViewRegion3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewRegion3 == null)
#endif
                {
                    _moPubAdUnitListViewRegion3 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitListViewRegion3.Name = "MoPubAdUnitListViewRegion3";
                    _moPubAdUnitListViewRegion3.LineNumber = 17;
                    _moPubAdUnitListViewRegion3.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitListViewRegion3, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitListViewRegion3, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 0.1568628f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewRegion3, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitListViewRegion3;
            }
        }

        private static Template _moPubAdUnitListViewLabel4;
        public static Template MoPubAdUnitListViewLabel4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel4 == null || _moPubAdUnitListViewLabel4.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel4 == null)
#endif
                {
                    _moPubAdUnitListViewLabel4 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel4.Name = "MoPubAdUnitListViewLabel4";
                    _moPubAdUnitListViewLabel4.LineNumber = 18;
                    _moPubAdUnitListViewLabel4.LinePosition = 14;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel4, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel4, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel4, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel4, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel4, 46f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel4, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitListViewLabel4, "Interstitials");
                }
                return _moPubAdUnitListViewLabel4;
            }
        }

        private static Template _moPubAdUnitListViewList2;
        public static Template MoPubAdUnitListViewList2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2 == null || _moPubAdUnitListViewList2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2 == null)
#endif
                {
                    _moPubAdUnitListViewList2 = new Template(ListTemplates.List);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2.Name = "MoPubAdUnitListViewList2";
                    _moPubAdUnitListViewList2.LineNumber = 20;
                    _moPubAdUnitListViewList2.LinePosition = 10;
#endif
                    Delight.List.CanSelectProperty.SetDefault(_moPubAdUnitListViewList2, false);
                    Delight.List.ItemsProperty.SetHasBinding(_moPubAdUnitListViewList2);
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_moPubAdUnitListViewList2, MoPubAdUnitListViewList2ScrollableRegion);
                }
                return _moPubAdUnitListViewList2;
            }
        }

        private static Template _moPubAdUnitListViewList2ScrollableRegion;
        public static Template MoPubAdUnitListViewList2ScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2ScrollableRegion == null || _moPubAdUnitListViewList2ScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2ScrollableRegion == null)
#endif
                {
                    _moPubAdUnitListViewList2ScrollableRegion = new Template(ListTemplates.ListScrollableRegion);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2ScrollableRegion.Name = "MoPubAdUnitListViewList2ScrollableRegion";
                    _moPubAdUnitListViewList2ScrollableRegion.LineNumber = 29;
                    _moPubAdUnitListViewList2ScrollableRegion.LinePosition = 4;
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_moPubAdUnitListViewList2ScrollableRegion, MoPubAdUnitListViewList2ScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_moPubAdUnitListViewList2ScrollableRegion, MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_moPubAdUnitListViewList2ScrollableRegion, MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbar);
                }
                return _moPubAdUnitListViewList2ScrollableRegion;
            }
        }

        private static Template _moPubAdUnitListViewList2ScrollableRegionContentRegion;
        public static Template MoPubAdUnitListViewList2ScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2ScrollableRegionContentRegion == null || _moPubAdUnitListViewList2ScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2ScrollableRegionContentRegion == null)
#endif
                {
                    _moPubAdUnitListViewList2ScrollableRegionContentRegion = new Template(ListTemplates.ListScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2ScrollableRegionContentRegion.Name = "MoPubAdUnitListViewList2ScrollableRegionContentRegion";
                    _moPubAdUnitListViewList2ScrollableRegionContentRegion.LineNumber = 24;
                    _moPubAdUnitListViewList2ScrollableRegionContentRegion.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList2ScrollableRegionContentRegion;
            }
        }

        private static Template _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar;
        public static Template MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar == null || _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar.Name = "MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar";
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar.LineNumber = 26;
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar, MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar, MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle);
                }
                return _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar;
        public static Template MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar == null || _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar.Name = "MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar";
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar.LineNumber = 7;
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle;
        public static Template MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle == null || _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle.Name = "MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle";
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle.LineNumber = 8;
                    _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar;
        public static Template MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar == null || _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar.Name = "MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbar";
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar.LineNumber = 27;
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar, MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar, MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle);
                }
                return _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar;
        public static Template MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar == null || _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar.Name = "MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar";
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar.LineNumber = 7;
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle;
        public static Template MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle == null || _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle.Name = "MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle";
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle.LineNumber = 8;
                    _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _moPubAdUnitListViewListItem2;
        public static Template MoPubAdUnitListViewListItem2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewListItem2 == null || _moPubAdUnitListViewListItem2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewListItem2 == null)
#endif
                {
                    _moPubAdUnitListViewListItem2 = new Template(ListItemTemplates.ListItem);
#if UNITY_EDITOR
                    _moPubAdUnitListViewListItem2.Name = "MoPubAdUnitListViewListItem2";
                    _moPubAdUnitListViewListItem2.LineNumber = 21;
                    _moPubAdUnitListViewListItem2.LinePosition = 14;
#endif
                    Delight.ListItem.HeightProperty.SetDefault(_moPubAdUnitListViewListItem2, new ElementSize(160f, ElementSizeUnit.Pixels));
                    Delight.ListItem.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewListItem2, Assets.Materials["UI-Fast-Default"]);
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Selected", _moPubAdUnitListViewListItem2, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Highlighted", _moPubAdUnitListViewListItem2, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Pressed", _moPubAdUnitListViewListItem2, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitListViewListItem2;
            }
        }

        private static Template _moPubAdUnitListViewLabel5;
        public static Template MoPubAdUnitListViewLabel5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel5 == null || _moPubAdUnitListViewLabel5.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel5 == null)
#endif
                {
                    _moPubAdUnitListViewLabel5 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel5.Name = "MoPubAdUnitListViewLabel5";
                    _moPubAdUnitListViewLabel5.LineNumber = 22;
                    _moPubAdUnitListViewLabel5.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel5, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel5, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel5, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(-60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel5, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel5, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitListViewLabel5, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel5, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetHasBinding(_moPubAdUnitListViewLabel5);
                }
                return _moPubAdUnitListViewLabel5;
            }
        }

        private static Template _moPubAdUnitListViewLabel6;
        public static Template MoPubAdUnitListViewLabel6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel6 == null || _moPubAdUnitListViewLabel6.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel6 == null)
#endif
                {
                    _moPubAdUnitListViewLabel6 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel6.Name = "MoPubAdUnitListViewLabel6";
                    _moPubAdUnitListViewLabel6.LineNumber = 23;
                    _moPubAdUnitListViewLabel6.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel6, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel6, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel6, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel6, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitListViewLabel6, Delight.AutoSize.Default);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel6, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel6, 40f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitListViewLabel6, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.TextProperty.SetHasBinding(_moPubAdUnitListViewLabel6);
                }
                return _moPubAdUnitListViewLabel6;
            }
        }

        private static Template _moPubAdUnitListViewImage2;
        public static Template MoPubAdUnitListViewImage2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewImage2 == null || _moPubAdUnitListViewImage2.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewImage2 == null)
#endif
                {
                    _moPubAdUnitListViewImage2 = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitListViewImage2.Name = "MoPubAdUnitListViewImage2";
                    _moPubAdUnitListViewImage2.LineNumber = 24;
                    _moPubAdUnitListViewImage2.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitListViewImage2, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitListViewImage2, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitListViewImage2, Delight.ElementAlignment.Right);
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitListViewImage2, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels)));
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitListViewImage2, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitListViewImage2, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitListViewImage2;
            }
        }

        private static Template _moPubAdUnitListViewRegion4;
        public static Template MoPubAdUnitListViewRegion4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewRegion4 == null || _moPubAdUnitListViewRegion4.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewRegion4 == null)
#endif
                {
                    _moPubAdUnitListViewRegion4 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitListViewRegion4.Name = "MoPubAdUnitListViewRegion4";
                    _moPubAdUnitListViewRegion4.LineNumber = 25;
                    _moPubAdUnitListViewRegion4.LinePosition = 18;
#endif
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewRegion4, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitListViewRegion4, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitListViewRegion4, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitListViewRegion4, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.OffsetProperty.SetDefault(_moPubAdUnitListViewRegion4, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(80f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitListViewRegion4;
            }
        }

        private static Template _moPubAdUnitListViewRegion5;
        public static Template MoPubAdUnitListViewRegion5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewRegion5 == null || _moPubAdUnitListViewRegion5.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewRegion5 == null)
#endif
                {
                    _moPubAdUnitListViewRegion5 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitListViewRegion5.Name = "MoPubAdUnitListViewRegion5";
                    _moPubAdUnitListViewRegion5.LineNumber = 29;
                    _moPubAdUnitListViewRegion5.LinePosition = 10;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitListViewRegion5, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitListViewRegion5, new UnityEngine.Color(0.3843137f, 0.5843138f, 0.9372549f, 0.1568628f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewRegion5, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitListViewRegion5;
            }
        }

        private static Template _moPubAdUnitListViewLabel7;
        public static Template MoPubAdUnitListViewLabel7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel7 == null || _moPubAdUnitListViewLabel7.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel7 == null)
#endif
                {
                    _moPubAdUnitListViewLabel7 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel7.Name = "MoPubAdUnitListViewLabel7";
                    _moPubAdUnitListViewLabel7.LineNumber = 30;
                    _moPubAdUnitListViewLabel7.LinePosition = 14;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel7, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel7, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel7, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel7, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel7, 46f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel7, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetDefault(_moPubAdUnitListViewLabel7, "Rewarded Ads");
                }
                return _moPubAdUnitListViewLabel7;
            }
        }

        private static Template _moPubAdUnitListViewList3;
        public static Template MoPubAdUnitListViewList3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3 == null || _moPubAdUnitListViewList3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3 == null)
#endif
                {
                    _moPubAdUnitListViewList3 = new Template(ListTemplates.List);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3.Name = "MoPubAdUnitListViewList3";
                    _moPubAdUnitListViewList3.LineNumber = 32;
                    _moPubAdUnitListViewList3.LinePosition = 10;
#endif
                    Delight.List.CanSelectProperty.SetDefault(_moPubAdUnitListViewList3, false);
                    Delight.List.ItemsProperty.SetHasBinding(_moPubAdUnitListViewList3);
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_moPubAdUnitListViewList3, MoPubAdUnitListViewList3ScrollableRegion);
                }
                return _moPubAdUnitListViewList3;
            }
        }

        private static Template _moPubAdUnitListViewList3ScrollableRegion;
        public static Template MoPubAdUnitListViewList3ScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3ScrollableRegion == null || _moPubAdUnitListViewList3ScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3ScrollableRegion == null)
#endif
                {
                    _moPubAdUnitListViewList3ScrollableRegion = new Template(ListTemplates.ListScrollableRegion);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3ScrollableRegion.Name = "MoPubAdUnitListViewList3ScrollableRegion";
                    _moPubAdUnitListViewList3ScrollableRegion.LineNumber = 29;
                    _moPubAdUnitListViewList3ScrollableRegion.LinePosition = 4;
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_moPubAdUnitListViewList3ScrollableRegion, MoPubAdUnitListViewList3ScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_moPubAdUnitListViewList3ScrollableRegion, MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_moPubAdUnitListViewList3ScrollableRegion, MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbar);
                }
                return _moPubAdUnitListViewList3ScrollableRegion;
            }
        }

        private static Template _moPubAdUnitListViewList3ScrollableRegionContentRegion;
        public static Template MoPubAdUnitListViewList3ScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3ScrollableRegionContentRegion == null || _moPubAdUnitListViewList3ScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3ScrollableRegionContentRegion == null)
#endif
                {
                    _moPubAdUnitListViewList3ScrollableRegionContentRegion = new Template(ListTemplates.ListScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3ScrollableRegionContentRegion.Name = "MoPubAdUnitListViewList3ScrollableRegionContentRegion";
                    _moPubAdUnitListViewList3ScrollableRegionContentRegion.LineNumber = 24;
                    _moPubAdUnitListViewList3ScrollableRegionContentRegion.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList3ScrollableRegionContentRegion;
            }
        }

        private static Template _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar;
        public static Template MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar == null || _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar.Name = "MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar";
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar.LineNumber = 26;
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar, MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar, MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle);
                }
                return _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar;
        public static Template MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar == null || _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar.Name = "MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar";
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar.LineNumber = 7;
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle;
        public static Template MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle == null || _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle.Name = "MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle";
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle.LineNumber = 8;
                    _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar;
        public static Template MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar == null || _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar.Name = "MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbar";
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar.LineNumber = 27;
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar, MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar, MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle);
                }
                return _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar;
        public static Template MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar == null || _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar.Name = "MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar";
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar.LineNumber = 7;
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle;
        public static Template MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle == null || _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle.Name = "MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle";
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle.LineNumber = 8;
                    _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _moPubAdUnitListViewListItem3;
        public static Template MoPubAdUnitListViewListItem3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewListItem3 == null || _moPubAdUnitListViewListItem3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewListItem3 == null)
#endif
                {
                    _moPubAdUnitListViewListItem3 = new Template(ListItemTemplates.ListItem);
#if UNITY_EDITOR
                    _moPubAdUnitListViewListItem3.Name = "MoPubAdUnitListViewListItem3";
                    _moPubAdUnitListViewListItem3.LineNumber = 33;
                    _moPubAdUnitListViewListItem3.LinePosition = 14;
#endif
                    Delight.ListItem.HeightProperty.SetDefault(_moPubAdUnitListViewListItem3, new ElementSize(160f, ElementSizeUnit.Pixels));
                    Delight.ListItem.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewListItem3, Assets.Materials["UI-Fast-Default"]);
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Selected", _moPubAdUnitListViewListItem3, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Highlighted", _moPubAdUnitListViewListItem3, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Pressed", _moPubAdUnitListViewListItem3, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubAdUnitListViewListItem3;
            }
        }

        private static Template _moPubAdUnitListViewLabel8;
        public static Template MoPubAdUnitListViewLabel8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel8 == null || _moPubAdUnitListViewLabel8.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel8 == null)
#endif
                {
                    _moPubAdUnitListViewLabel8 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel8.Name = "MoPubAdUnitListViewLabel8";
                    _moPubAdUnitListViewLabel8.LineNumber = 34;
                    _moPubAdUnitListViewLabel8.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel8, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel8, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel8, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(-60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel8, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel8, 46f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitListViewLabel8, new ElementSize(80f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel8, new UnityEngine.Color(0.1411765f, 0.1411765f, 0.1411765f, 1f));
                    Delight.Label.TextProperty.SetHasBinding(_moPubAdUnitListViewLabel8);
                }
                return _moPubAdUnitListViewLabel8;
            }
        }

        private static Template _moPubAdUnitListViewLabel9;
        public static Template MoPubAdUnitListViewLabel9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewLabel9 == null || _moPubAdUnitListViewLabel9.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewLabel9 == null)
#endif
                {
                    _moPubAdUnitListViewLabel9 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubAdUnitListViewLabel9.Name = "MoPubAdUnitListViewLabel9";
                    _moPubAdUnitListViewLabel9.LineNumber = 35;
                    _moPubAdUnitListViewLabel9.LinePosition = 18;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubAdUnitListViewLabel9, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubAdUnitListViewLabel9, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubAdUnitListViewLabel9, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels), new ElementSize(60f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubAdUnitListViewLabel9, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubAdUnitListViewLabel9, Delight.AutoSize.Default);
                    Delight.Label.FontColorProperty.SetDefault(_moPubAdUnitListViewLabel9, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubAdUnitListViewLabel9, 40f);
                    Delight.Label.HeightProperty.SetDefault(_moPubAdUnitListViewLabel9, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.TextProperty.SetHasBinding(_moPubAdUnitListViewLabel9);
                }
                return _moPubAdUnitListViewLabel9;
            }
        }

        private static Template _moPubAdUnitListViewImage3;
        public static Template MoPubAdUnitListViewImage3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewImage3 == null || _moPubAdUnitListViewImage3.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewImage3 == null)
#endif
                {
                    _moPubAdUnitListViewImage3 = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _moPubAdUnitListViewImage3.Name = "MoPubAdUnitListViewImage3";
                    _moPubAdUnitListViewImage3.LineNumber = 36;
                    _moPubAdUnitListViewImage3.LinePosition = 18;
#endif
                    Delight.Image.HeightProperty.SetDefault(_moPubAdUnitListViewImage3, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.WidthProperty.SetDefault(_moPubAdUnitListViewImage3, new ElementSize(60f, ElementSizeUnit.Pixels));
                    Delight.Image.AlignmentProperty.SetDefault(_moPubAdUnitListViewImage3, Delight.ElementAlignment.Right);
                    Delight.Image.OffsetProperty.SetDefault(_moPubAdUnitListViewImage3, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels)));
                    Delight.Image.SpriteProperty.SetDefault(_moPubAdUnitListViewImage3, Assets.Sprites["chevron-right"]);
                    Delight.Image.MaterialProperty.SetDefault(_moPubAdUnitListViewImage3, Assets.Materials["UI-Fast-Default"]);
                }
                return _moPubAdUnitListViewImage3;
            }
        }

        private static Template _moPubAdUnitListViewRegion6;
        public static Template MoPubAdUnitListViewRegion6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubAdUnitListViewRegion6 == null || _moPubAdUnitListViewRegion6.CurrentVersion != Template.Version)
#else
                if (_moPubAdUnitListViewRegion6 == null)
#endif
                {
                    _moPubAdUnitListViewRegion6 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubAdUnitListViewRegion6.Name = "MoPubAdUnitListViewRegion6";
                    _moPubAdUnitListViewRegion6.LineNumber = 37;
                    _moPubAdUnitListViewRegion6.LinePosition = 18;
#endif
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubAdUnitListViewRegion6, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubAdUnitListViewRegion6, new UnityEngine.Color(0.8901961f, 0.8901961f, 0.8941177f, 1f));
                    Delight.Region.MarginProperty.SetDefault(_moPubAdUnitListViewRegion6, new ElementMargin(new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(45f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.HeightProperty.SetDefault(_moPubAdUnitListViewRegion6, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.OffsetProperty.SetDefault(_moPubAdUnitListViewRegion6, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(80f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _moPubAdUnitListViewRegion6;
            }
        }

        #endregion
    }

    #endregion
}
