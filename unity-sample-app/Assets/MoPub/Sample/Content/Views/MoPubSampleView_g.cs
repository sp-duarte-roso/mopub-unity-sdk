// Internal view logic generated from "MoPubSampleView.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MoPubSampleView : UIView
    {
        #region Constructors

        public MoPubSampleView(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MoPubSampleViewTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing Grid (Grid1)
            Grid1 = new LayoutGrid(this, this, "Grid1", Grid1Template);
            MPScrollable = new ScrollableRegion(this, Grid1.Content, "MPScrollable", MPScrollableTemplate);
            Grid1.Cell.SetValue(MPScrollable, new CellIndex(1, 0));
            Region1 = new Region(this, MPScrollable.Content, "Region1", Region1Template);

            // binding <Region Height="$ {@ScreenHeight}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "ScreenHeight" }, new List<Func<object>> { () => Models.Globals }) }, new BindingPath(new List<string> { "Region1", "Height" }, new List<Func<object>> { () => this, () => Region1 }), () => Region1.Height = Models.Globals.ScreenHeight, () => { }, false));
            MoPubAdUnitSwitcher = new ViewSwitcher(this, Region1.Content, "MoPubAdUnitSwitcher", MoPubAdUnitSwitcherTemplate);
            MoPubAdUnitList = new MoPubAdUnitListView(this, MoPubAdUnitSwitcher.Content, "MoPubAdUnitList", MoPubAdUnitListTemplate);
            MoPubAdUnitList.ShowAdUnit.RegisterHandler(this, "ShowAdUnit");
            MoPubAdUnit = new MoPubAdUnitView(this, MoPubAdUnitSwitcher.Content, "MoPubAdUnit", MoPubAdUnitTemplate);
            MoPubAdUnit.NavigateBack.RegisterHandler(this, "NavigateBack");
            Region2 = new Region(this, Grid1.Content, "Region2", Region2Template);
            Grid1.Cell.SetValue(Region2, new CellIndex(0, 0));
            Label1 = new Label(this, Region2.Content, "Label1", Label1Template);
            Region3 = new Region(this, Region2.Content, "Region3", Region3Template);
            Region4 = new Region(this, Region2.Content, "Region4", Region4Template);
            Region5 = new Region(this, Grid1.Content, "Region5", Region5Template);
            Grid1.Cell.SetValue(Region5, new CellIndex(2, 0));
            Group1 = new Group(this, Region5.Content, "Group1", Group1Template);
            Region6 = new Region(this, Group1.Content, "Region6", Region6Template);
            Region7 = new Region(this, Group1.Content, "Region7", Region7Template);
            Region8 = new Region(this, Group1.Content, "Region8", Region8Template);
            PluginNameLabel = new Label(this, Region8.Content, "PluginNameLabel", PluginNameLabelTemplate);
            SdkNameLabel = new Label(this, Region8.Content, "SdkNameLabel", SdkNameLabelTemplate);
            this.AfterInitializeInternal();
        }

        public MoPubSampleView() : this(null)
        {
        }

        static MoPubSampleView()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MoPubSampleViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(Grid1Property);
            dependencyProperties.Add(Grid1TemplateProperty);
            dependencyProperties.Add(MPScrollableProperty);
            dependencyProperties.Add(MPScrollableTemplateProperty);
            dependencyProperties.Add(Region1Property);
            dependencyProperties.Add(Region1TemplateProperty);
            dependencyProperties.Add(MoPubAdUnitSwitcherProperty);
            dependencyProperties.Add(MoPubAdUnitSwitcherTemplateProperty);
            dependencyProperties.Add(MoPubAdUnitListProperty);
            dependencyProperties.Add(MoPubAdUnitListTemplateProperty);
            dependencyProperties.Add(MoPubAdUnitProperty);
            dependencyProperties.Add(MoPubAdUnitTemplateProperty);
            dependencyProperties.Add(Region2Property);
            dependencyProperties.Add(Region2TemplateProperty);
            dependencyProperties.Add(Label1Property);
            dependencyProperties.Add(Label1TemplateProperty);
            dependencyProperties.Add(Region3Property);
            dependencyProperties.Add(Region3TemplateProperty);
            dependencyProperties.Add(Region4Property);
            dependencyProperties.Add(Region4TemplateProperty);
            dependencyProperties.Add(Region5Property);
            dependencyProperties.Add(Region5TemplateProperty);
            dependencyProperties.Add(Group1Property);
            dependencyProperties.Add(Group1TemplateProperty);
            dependencyProperties.Add(Region6Property);
            dependencyProperties.Add(Region6TemplateProperty);
            dependencyProperties.Add(Region7Property);
            dependencyProperties.Add(Region7TemplateProperty);
            dependencyProperties.Add(Region8Property);
            dependencyProperties.Add(Region8TemplateProperty);
            dependencyProperties.Add(PluginNameLabelProperty);
            dependencyProperties.Add(PluginNameLabelTemplateProperty);
            dependencyProperties.Add(SdkNameLabelProperty);
            dependencyProperties.Add(SdkNameLabelTemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<LayoutGrid> Grid1Property = new DependencyProperty<LayoutGrid>("Grid1");
        public LayoutGrid Grid1
        {
            get { return Grid1Property.GetValue(this); }
            set { Grid1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Grid1TemplateProperty = new DependencyProperty<Template>("Grid1Template");
        public Template Grid1Template
        {
            get { return Grid1TemplateProperty.GetValue(this); }
            set { Grid1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ScrollableRegion> MPScrollableProperty = new DependencyProperty<ScrollableRegion>("MPScrollable");
        public ScrollableRegion MPScrollable
        {
            get { return MPScrollableProperty.GetValue(this); }
            set { MPScrollableProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MPScrollableTemplateProperty = new DependencyProperty<Template>("MPScrollableTemplate");
        public Template MPScrollableTemplate
        {
            get { return MPScrollableTemplateProperty.GetValue(this); }
            set { MPScrollableTemplateProperty.SetValue(this, value); }
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

        public readonly static DependencyProperty<ViewSwitcher> MoPubAdUnitSwitcherProperty = new DependencyProperty<ViewSwitcher>("MoPubAdUnitSwitcher");
        public ViewSwitcher MoPubAdUnitSwitcher
        {
            get { return MoPubAdUnitSwitcherProperty.GetValue(this); }
            set { MoPubAdUnitSwitcherProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MoPubAdUnitSwitcherTemplateProperty = new DependencyProperty<Template>("MoPubAdUnitSwitcherTemplate");
        public Template MoPubAdUnitSwitcherTemplate
        {
            get { return MoPubAdUnitSwitcherTemplateProperty.GetValue(this); }
            set { MoPubAdUnitSwitcherTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<MoPubAdUnitListView> MoPubAdUnitListProperty = new DependencyProperty<MoPubAdUnitListView>("MoPubAdUnitList");
        public MoPubAdUnitListView MoPubAdUnitList
        {
            get { return MoPubAdUnitListProperty.GetValue(this); }
            set { MoPubAdUnitListProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MoPubAdUnitListTemplateProperty = new DependencyProperty<Template>("MoPubAdUnitListTemplate");
        public Template MoPubAdUnitListTemplate
        {
            get { return MoPubAdUnitListTemplateProperty.GetValue(this); }
            set { MoPubAdUnitListTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<MoPubAdUnitView> MoPubAdUnitProperty = new DependencyProperty<MoPubAdUnitView>("MoPubAdUnit");
        public MoPubAdUnitView MoPubAdUnit
        {
            get { return MoPubAdUnitProperty.GetValue(this); }
            set { MoPubAdUnitProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MoPubAdUnitTemplateProperty = new DependencyProperty<Template>("MoPubAdUnitTemplate");
        public Template MoPubAdUnitTemplate
        {
            get { return MoPubAdUnitTemplateProperty.GetValue(this); }
            set { MoPubAdUnitTemplateProperty.SetValue(this, value); }
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

        public readonly static DependencyProperty<Label> PluginNameLabelProperty = new DependencyProperty<Label>("PluginNameLabel");
        public Label PluginNameLabel
        {
            get { return PluginNameLabelProperty.GetValue(this); }
            set { PluginNameLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> PluginNameLabelTemplateProperty = new DependencyProperty<Template>("PluginNameLabelTemplate");
        public Template PluginNameLabelTemplate
        {
            get { return PluginNameLabelTemplateProperty.GetValue(this); }
            set { PluginNameLabelTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> SdkNameLabelProperty = new DependencyProperty<Label>("SdkNameLabel");
        public Label SdkNameLabel
        {
            get { return SdkNameLabelProperty.GetValue(this); }
            set { SdkNameLabelProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> SdkNameLabelTemplateProperty = new DependencyProperty<Template>("SdkNameLabelTemplate");
        public Template SdkNameLabelTemplate
        {
            get { return SdkNameLabelTemplateProperty.GetValue(this); }
            set { SdkNameLabelTemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class MoPubSampleViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MoPubSampleView;
            }
        }

        private static Template _moPubSampleView;
        public static Template MoPubSampleView
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleView == null || _moPubSampleView.CurrentVersion != Template.Version)
#else
                if (_moPubSampleView == null)
#endif
                {
                    _moPubSampleView = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _moPubSampleView.Name = "MoPubSampleView";
                    _moPubSampleView.LineNumber = 0;
                    _moPubSampleView.LinePosition = 0;
#endif
                    Delight.MoPubSampleView.EnableScriptEventsProperty.SetDefault(_moPubSampleView, true);
                    Delight.MoPubSampleView.Grid1TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewGrid1);
                    Delight.MoPubSampleView.MPScrollableTemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewMPScrollable);
                    Delight.MoPubSampleView.Region1TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewRegion1);
                    Delight.MoPubSampleView.MoPubAdUnitSwitcherTemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewMoPubAdUnitSwitcher);
                    Delight.MoPubSampleView.MoPubAdUnitListTemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewMoPubAdUnitList);
                    Delight.MoPubSampleView.MoPubAdUnitTemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewMoPubAdUnit);
                    Delight.MoPubSampleView.Region2TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewRegion2);
                    Delight.MoPubSampleView.Label1TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewLabel1);
                    Delight.MoPubSampleView.Region3TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewRegion3);
                    Delight.MoPubSampleView.Region4TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewRegion4);
                    Delight.MoPubSampleView.Region5TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewRegion5);
                    Delight.MoPubSampleView.Group1TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewGroup1);
                    Delight.MoPubSampleView.Region6TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewRegion6);
                    Delight.MoPubSampleView.Region7TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewRegion7);
                    Delight.MoPubSampleView.Region8TemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewRegion8);
                    Delight.MoPubSampleView.PluginNameLabelTemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewPluginNameLabel);
                    Delight.MoPubSampleView.SdkNameLabelTemplateProperty.SetDefault(_moPubSampleView, MoPubSampleViewSdkNameLabel);
                }
                return _moPubSampleView;
            }
        }

        private static Template _moPubSampleViewGrid1;
        public static Template MoPubSampleViewGrid1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewGrid1 == null || _moPubSampleViewGrid1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewGrid1 == null)
#endif
                {
                    _moPubSampleViewGrid1 = new Template(LayoutGridTemplates.LayoutGrid);
#if UNITY_EDITOR
                    _moPubSampleViewGrid1.Name = "MoPubSampleViewGrid1";
                    _moPubSampleViewGrid1.LineNumber = 5;
                    _moPubSampleViewGrid1.LinePosition = 6;
#endif
                    Delight.LayoutGrid.ColumnsProperty.SetDefault(_moPubSampleViewGrid1, new ColumnDefinitions { new ColumnDefinition(new ElementSize(1f, ElementSizeUnit.Percents))});
                    Delight.LayoutGrid.RowsProperty.SetDefault(_moPubSampleViewGrid1, new RowDefinitions { new RowDefinition(new ElementSize(150f, ElementSizeUnit.Pixels)), new RowDefinition(new ElementSize(1f, ElementSizeUnit.Percents)), new RowDefinition(new ElementSize(150f, ElementSizeUnit.Pixels))});
                    Delight.LayoutGrid.SpacingProperty.SetDefault(_moPubSampleViewGrid1, new ElementSize(0f, ElementSizeUnit.Pixels));
                    Delight.LayoutGrid.BackgroundColorProperty.SetDefault(_moPubSampleViewGrid1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                }
                return _moPubSampleViewGrid1;
            }
        }

        private static Template _moPubSampleViewMPScrollable;
        public static Template MoPubSampleViewMPScrollable
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMPScrollable == null || _moPubSampleViewMPScrollable.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMPScrollable == null)
#endif
                {
                    _moPubSampleViewMPScrollable = new Template(ScrollableRegionTemplates.ScrollableRegion);
#if UNITY_EDITOR
                    _moPubSampleViewMPScrollable.Name = "MoPubSampleViewMPScrollable";
                    _moPubSampleViewMPScrollable.LineNumber = 8;
                    _moPubSampleViewMPScrollable.LinePosition = 10;
#endif
                    Delight.ScrollableRegion.HasInertiaProperty.SetDefault(_moPubSampleViewMPScrollable, true);
                    Delight.ScrollableRegion.ElasticityProperty.SetDefault(_moPubSampleViewMPScrollable, 0.15f);
                    Delight.ScrollableRegion.DecelerationRateProperty.SetDefault(_moPubSampleViewMPScrollable, 0.05f);
                    Delight.ScrollableRegion.CanScrollVerticallyProperty.SetDefault(_moPubSampleViewMPScrollable, true);
                    Delight.ScrollableRegion.CanScrollHorizontallyProperty.SetDefault(_moPubSampleViewMPScrollable, false);
                    Delight.ScrollableRegion.MaskContentProperty.SetDefault(_moPubSampleViewMPScrollable, true);
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_moPubSampleViewMPScrollable, MoPubSampleViewMPScrollableContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_moPubSampleViewMPScrollable, MoPubSampleViewMPScrollableHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_moPubSampleViewMPScrollable, MoPubSampleViewMPScrollableVerticalScrollbar);
                }
                return _moPubSampleViewMPScrollable;
            }
        }

        private static Template _moPubSampleViewMPScrollableContentRegion;
        public static Template MoPubSampleViewMPScrollableContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMPScrollableContentRegion == null || _moPubSampleViewMPScrollableContentRegion.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMPScrollableContentRegion == null)
#endif
                {
                    _moPubSampleViewMPScrollableContentRegion = new Template(ScrollableRegionTemplates.ScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _moPubSampleViewMPScrollableContentRegion.Name = "MoPubSampleViewMPScrollableContentRegion";
                    _moPubSampleViewMPScrollableContentRegion.LineNumber = 24;
                    _moPubSampleViewMPScrollableContentRegion.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMPScrollableContentRegion;
            }
        }

        private static Template _moPubSampleViewMPScrollableHorizontalScrollbar;
        public static Template MoPubSampleViewMPScrollableHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMPScrollableHorizontalScrollbar == null || _moPubSampleViewMPScrollableHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMPScrollableHorizontalScrollbar == null)
#endif
                {
                    _moPubSampleViewMPScrollableHorizontalScrollbar = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _moPubSampleViewMPScrollableHorizontalScrollbar.Name = "MoPubSampleViewMPScrollableHorizontalScrollbar";
                    _moPubSampleViewMPScrollableHorizontalScrollbar.LineNumber = 26;
                    _moPubSampleViewMPScrollableHorizontalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubSampleViewMPScrollableHorizontalScrollbar, MoPubSampleViewMPScrollableHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubSampleViewMPScrollableHorizontalScrollbar, MoPubSampleViewMPScrollableHorizontalScrollbarHandle);
                }
                return _moPubSampleViewMPScrollableHorizontalScrollbar;
            }
        }

        private static Template _moPubSampleViewMPScrollableHorizontalScrollbarBar;
        public static Template MoPubSampleViewMPScrollableHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMPScrollableHorizontalScrollbarBar == null || _moPubSampleViewMPScrollableHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMPScrollableHorizontalScrollbarBar == null)
#endif
                {
                    _moPubSampleViewMPScrollableHorizontalScrollbarBar = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _moPubSampleViewMPScrollableHorizontalScrollbarBar.Name = "MoPubSampleViewMPScrollableHorizontalScrollbarBar";
                    _moPubSampleViewMPScrollableHorizontalScrollbarBar.LineNumber = 7;
                    _moPubSampleViewMPScrollableHorizontalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMPScrollableHorizontalScrollbarBar;
            }
        }

        private static Template _moPubSampleViewMPScrollableHorizontalScrollbarHandle;
        public static Template MoPubSampleViewMPScrollableHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMPScrollableHorizontalScrollbarHandle == null || _moPubSampleViewMPScrollableHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMPScrollableHorizontalScrollbarHandle == null)
#endif
                {
                    _moPubSampleViewMPScrollableHorizontalScrollbarHandle = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubSampleViewMPScrollableHorizontalScrollbarHandle.Name = "MoPubSampleViewMPScrollableHorizontalScrollbarHandle";
                    _moPubSampleViewMPScrollableHorizontalScrollbarHandle.LineNumber = 8;
                    _moPubSampleViewMPScrollableHorizontalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMPScrollableHorizontalScrollbarHandle;
            }
        }

        private static Template _moPubSampleViewMPScrollableVerticalScrollbar;
        public static Template MoPubSampleViewMPScrollableVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMPScrollableVerticalScrollbar == null || _moPubSampleViewMPScrollableVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMPScrollableVerticalScrollbar == null)
#endif
                {
                    _moPubSampleViewMPScrollableVerticalScrollbar = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _moPubSampleViewMPScrollableVerticalScrollbar.Name = "MoPubSampleViewMPScrollableVerticalScrollbar";
                    _moPubSampleViewMPScrollableVerticalScrollbar.LineNumber = 27;
                    _moPubSampleViewMPScrollableVerticalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubSampleViewMPScrollableVerticalScrollbar, MoPubSampleViewMPScrollableVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubSampleViewMPScrollableVerticalScrollbar, MoPubSampleViewMPScrollableVerticalScrollbarHandle);
                }
                return _moPubSampleViewMPScrollableVerticalScrollbar;
            }
        }

        private static Template _moPubSampleViewMPScrollableVerticalScrollbarBar;
        public static Template MoPubSampleViewMPScrollableVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMPScrollableVerticalScrollbarBar == null || _moPubSampleViewMPScrollableVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMPScrollableVerticalScrollbarBar == null)
#endif
                {
                    _moPubSampleViewMPScrollableVerticalScrollbarBar = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _moPubSampleViewMPScrollableVerticalScrollbarBar.Name = "MoPubSampleViewMPScrollableVerticalScrollbarBar";
                    _moPubSampleViewMPScrollableVerticalScrollbarBar.LineNumber = 7;
                    _moPubSampleViewMPScrollableVerticalScrollbarBar.LinePosition = 4;
#endif
                    Delight.Image.IsActiveProperty.SetDefault(_moPubSampleViewMPScrollableVerticalScrollbarBar, false);
                }
                return _moPubSampleViewMPScrollableVerticalScrollbarBar;
            }
        }

        private static Template _moPubSampleViewMPScrollableVerticalScrollbarHandle;
        public static Template MoPubSampleViewMPScrollableVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMPScrollableVerticalScrollbarHandle == null || _moPubSampleViewMPScrollableVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMPScrollableVerticalScrollbarHandle == null)
#endif
                {
                    _moPubSampleViewMPScrollableVerticalScrollbarHandle = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubSampleViewMPScrollableVerticalScrollbarHandle.Name = "MoPubSampleViewMPScrollableVerticalScrollbarHandle";
                    _moPubSampleViewMPScrollableVerticalScrollbarHandle.LineNumber = 8;
                    _moPubSampleViewMPScrollableVerticalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMPScrollableVerticalScrollbarHandle;
            }
        }

        private static Template _moPubSampleViewRegion1;
        public static Template MoPubSampleViewRegion1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewRegion1 == null || _moPubSampleViewRegion1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewRegion1 == null)
#endif
                {
                    _moPubSampleViewRegion1 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubSampleViewRegion1.Name = "MoPubSampleViewRegion1";
                    _moPubSampleViewRegion1.LineNumber = 9;
                    _moPubSampleViewRegion1.LinePosition = 14;
#endif
                    Delight.Region.HeightProperty.SetHasBinding(_moPubSampleViewRegion1);
                }
                return _moPubSampleViewRegion1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitSwitcher;
        public static Template MoPubSampleViewMoPubAdUnitSwitcher
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitSwitcher == null || _moPubSampleViewMoPubAdUnitSwitcher.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitSwitcher == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitSwitcher = new Template(ViewSwitcherTemplates.ViewSwitcher);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitSwitcher.Name = "MoPubSampleViewMoPubAdUnitSwitcher";
                    _moPubSampleViewMoPubAdUnitSwitcher.LineNumber = 10;
                    _moPubSampleViewMoPubAdUnitSwitcher.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitSwitcher;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitList;
        public static Template MoPubSampleViewMoPubAdUnitList
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitList == null || _moPubSampleViewMoPubAdUnitList.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitList == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitList = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListView);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitList.Name = "MoPubSampleViewMoPubAdUnitList";
                    _moPubSampleViewMoPubAdUnitList.LineNumber = 11;
                    _moPubSampleViewMoPubAdUnitList.LinePosition = 22;
#endif
                    Delight.MoPubAdUnitListView.Group1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListGroup1);
                    Delight.MoPubAdUnitListView.Region1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListRegion1);
                    Delight.MoPubAdUnitListView.Label1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel1);
                    Delight.MoPubAdUnitListView.List1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListList1);
                    Delight.MoPubAdUnitListView.ListItem1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListListItem1);
                    Delight.MoPubAdUnitListView.Label2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel2);
                    Delight.MoPubAdUnitListView.Label3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel3);
                    Delight.MoPubAdUnitListView.Image1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListImage1);
                    Delight.MoPubAdUnitListView.Region2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListRegion2);
                    Delight.MoPubAdUnitListView.Region3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListRegion3);
                    Delight.MoPubAdUnitListView.Label4TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel4);
                    Delight.MoPubAdUnitListView.List2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListList2);
                    Delight.MoPubAdUnitListView.ListItem2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListListItem2);
                    Delight.MoPubAdUnitListView.Label5TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel5);
                    Delight.MoPubAdUnitListView.Label6TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel6);
                    Delight.MoPubAdUnitListView.Image2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListImage2);
                    Delight.MoPubAdUnitListView.Region4TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListRegion4);
                    Delight.MoPubAdUnitListView.Region5TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListRegion5);
                    Delight.MoPubAdUnitListView.Label7TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel7);
                    Delight.MoPubAdUnitListView.List3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListList3);
                    Delight.MoPubAdUnitListView.ListItem3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListListItem3);
                    Delight.MoPubAdUnitListView.Label8TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel8);
                    Delight.MoPubAdUnitListView.Label9TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListLabel9);
                    Delight.MoPubAdUnitListView.Image3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListImage3);
                    Delight.MoPubAdUnitListView.Region6TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitList, MoPubSampleViewMoPubAdUnitListRegion6);
                }
                return _moPubSampleViewMoPubAdUnitList;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListGroup1;
        public static Template MoPubSampleViewMoPubAdUnitListGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListGroup1 == null || _moPubSampleViewMoPubAdUnitListGroup1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListGroup1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListGroup1 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewGroup1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListGroup1.Name = "MoPubSampleViewMoPubAdUnitListGroup1";
                    _moPubSampleViewMoPubAdUnitListGroup1.LineNumber = 4;
                    _moPubSampleViewMoPubAdUnitListGroup1.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListGroup1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListRegion1;
        public static Template MoPubSampleViewMoPubAdUnitListRegion1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListRegion1 == null || _moPubSampleViewMoPubAdUnitListRegion1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListRegion1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListRegion1 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewRegion1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListRegion1.Name = "MoPubSampleViewMoPubAdUnitListRegion1";
                    _moPubSampleViewMoPubAdUnitListRegion1.LineNumber = 5;
                    _moPubSampleViewMoPubAdUnitListRegion1.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListRegion1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel1;
        public static Template MoPubSampleViewMoPubAdUnitListLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel1 == null || _moPubSampleViewMoPubAdUnitListLabel1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel1 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel1.Name = "MoPubSampleViewMoPubAdUnitListLabel1";
                    _moPubSampleViewMoPubAdUnitListLabel1.LineNumber = 6;
                    _moPubSampleViewMoPubAdUnitListLabel1.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1;
        public static Template MoPubSampleViewMoPubAdUnitListList1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1 == null || _moPubSampleViewMoPubAdUnitListList1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1.Name = "MoPubSampleViewMoPubAdUnitListList1";
                    _moPubSampleViewMoPubAdUnitListList1.LineNumber = 8;
                    _moPubSampleViewMoPubAdUnitListList1.LinePosition = 10;
#endif
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList1, MoPubSampleViewMoPubAdUnitListList1ScrollableRegion);
                }
                return _moPubSampleViewMoPubAdUnitListList1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1ScrollableRegion;
        public static Template MoPubSampleViewMoPubAdUnitListList1ScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegion == null || _moPubSampleViewMoPubAdUnitListList1ScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegion == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegion = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1ScrollableRegion);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegion.Name = "MoPubSampleViewMoPubAdUnitListList1ScrollableRegion";
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegion.LineNumber = 29;
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegion.LinePosition = 4;
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList1ScrollableRegion, MoPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList1ScrollableRegion, MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList1ScrollableRegion, MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar);
                }
                return _moPubSampleViewMoPubAdUnitListList1ScrollableRegion;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion;
        public static Template MoPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion == null || _moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1ScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion.Name = "MoPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion";
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion.LineNumber = 24;
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList1ScrollableRegionContentRegion;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar;
        public static Template MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar == null || _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar.Name = "MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar";
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar.LineNumber = 26;
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar, MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar, MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle);
                }
                return _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar;
        public static Template MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar == null || _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar.Name = "MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar";
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar.LineNumber = 7;
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle;
        public static Template MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle == null || _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1ScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle.Name = "MoPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle";
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle.LineNumber = 8;
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList1ScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar;
        public static Template MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar == null || _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar.Name = "MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar";
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar.LineNumber = 27;
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar, MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar, MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle);
                }
                return _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar;
        public static Template MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar == null || _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar.Name = "MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar";
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar.LineNumber = 7;
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle;
        public static Template MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle == null || _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList1ScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle.Name = "MoPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle";
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle.LineNumber = 8;
                    _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList1ScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListListItem1;
        public static Template MoPubSampleViewMoPubAdUnitListListItem1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListListItem1 == null || _moPubSampleViewMoPubAdUnitListListItem1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListListItem1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListListItem1 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewListItem1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListListItem1.Name = "MoPubSampleViewMoPubAdUnitListListItem1";
                    _moPubSampleViewMoPubAdUnitListListItem1.LineNumber = 9;
                    _moPubSampleViewMoPubAdUnitListListItem1.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListListItem1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel2;
        public static Template MoPubSampleViewMoPubAdUnitListLabel2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel2 == null || _moPubSampleViewMoPubAdUnitListLabel2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel2 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel2.Name = "MoPubSampleViewMoPubAdUnitListLabel2";
                    _moPubSampleViewMoPubAdUnitListLabel2.LineNumber = 10;
                    _moPubSampleViewMoPubAdUnitListLabel2.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel3;
        public static Template MoPubSampleViewMoPubAdUnitListLabel3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel3 == null || _moPubSampleViewMoPubAdUnitListLabel3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel3 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel3.Name = "MoPubSampleViewMoPubAdUnitListLabel3";
                    _moPubSampleViewMoPubAdUnitListLabel3.LineNumber = 11;
                    _moPubSampleViewMoPubAdUnitListLabel3.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListImage1;
        public static Template MoPubSampleViewMoPubAdUnitListImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListImage1 == null || _moPubSampleViewMoPubAdUnitListImage1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListImage1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListImage1 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewImage1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListImage1.Name = "MoPubSampleViewMoPubAdUnitListImage1";
                    _moPubSampleViewMoPubAdUnitListImage1.LineNumber = 12;
                    _moPubSampleViewMoPubAdUnitListImage1.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListImage1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListRegion2;
        public static Template MoPubSampleViewMoPubAdUnitListRegion2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListRegion2 == null || _moPubSampleViewMoPubAdUnitListRegion2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListRegion2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListRegion2 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewRegion2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListRegion2.Name = "MoPubSampleViewMoPubAdUnitListRegion2";
                    _moPubSampleViewMoPubAdUnitListRegion2.LineNumber = 13;
                    _moPubSampleViewMoPubAdUnitListRegion2.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListRegion2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListRegion3;
        public static Template MoPubSampleViewMoPubAdUnitListRegion3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListRegion3 == null || _moPubSampleViewMoPubAdUnitListRegion3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListRegion3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListRegion3 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewRegion3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListRegion3.Name = "MoPubSampleViewMoPubAdUnitListRegion3";
                    _moPubSampleViewMoPubAdUnitListRegion3.LineNumber = 17;
                    _moPubSampleViewMoPubAdUnitListRegion3.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListRegion3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel4;
        public static Template MoPubSampleViewMoPubAdUnitListLabel4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel4 == null || _moPubSampleViewMoPubAdUnitListLabel4.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel4 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel4 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel4);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel4.Name = "MoPubSampleViewMoPubAdUnitListLabel4";
                    _moPubSampleViewMoPubAdUnitListLabel4.LineNumber = 18;
                    _moPubSampleViewMoPubAdUnitListLabel4.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel4;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2;
        public static Template MoPubSampleViewMoPubAdUnitListList2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2 == null || _moPubSampleViewMoPubAdUnitListList2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2.Name = "MoPubSampleViewMoPubAdUnitListList2";
                    _moPubSampleViewMoPubAdUnitListList2.LineNumber = 20;
                    _moPubSampleViewMoPubAdUnitListList2.LinePosition = 10;
#endif
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList2, MoPubSampleViewMoPubAdUnitListList2ScrollableRegion);
                }
                return _moPubSampleViewMoPubAdUnitListList2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2ScrollableRegion;
        public static Template MoPubSampleViewMoPubAdUnitListList2ScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegion == null || _moPubSampleViewMoPubAdUnitListList2ScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegion == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegion = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2ScrollableRegion);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegion.Name = "MoPubSampleViewMoPubAdUnitListList2ScrollableRegion";
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegion.LineNumber = 29;
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegion.LinePosition = 4;
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList2ScrollableRegion, MoPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList2ScrollableRegion, MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList2ScrollableRegion, MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar);
                }
                return _moPubSampleViewMoPubAdUnitListList2ScrollableRegion;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion;
        public static Template MoPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion == null || _moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2ScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion.Name = "MoPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion";
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion.LineNumber = 24;
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList2ScrollableRegionContentRegion;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar;
        public static Template MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar == null || _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar.Name = "MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar";
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar.LineNumber = 26;
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar, MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar, MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle);
                }
                return _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar;
        public static Template MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar == null || _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar.Name = "MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar";
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar.LineNumber = 7;
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle;
        public static Template MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle == null || _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2ScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle.Name = "MoPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle";
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle.LineNumber = 8;
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList2ScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar;
        public static Template MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar == null || _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar.Name = "MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar";
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar.LineNumber = 27;
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar, MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar, MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle);
                }
                return _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar;
        public static Template MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar == null || _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar.Name = "MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar";
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar.LineNumber = 7;
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle;
        public static Template MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle == null || _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList2ScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle.Name = "MoPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle";
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle.LineNumber = 8;
                    _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList2ScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListListItem2;
        public static Template MoPubSampleViewMoPubAdUnitListListItem2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListListItem2 == null || _moPubSampleViewMoPubAdUnitListListItem2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListListItem2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListListItem2 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewListItem2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListListItem2.Name = "MoPubSampleViewMoPubAdUnitListListItem2";
                    _moPubSampleViewMoPubAdUnitListListItem2.LineNumber = 21;
                    _moPubSampleViewMoPubAdUnitListListItem2.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListListItem2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel5;
        public static Template MoPubSampleViewMoPubAdUnitListLabel5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel5 == null || _moPubSampleViewMoPubAdUnitListLabel5.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel5 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel5 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel5);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel5.Name = "MoPubSampleViewMoPubAdUnitListLabel5";
                    _moPubSampleViewMoPubAdUnitListLabel5.LineNumber = 22;
                    _moPubSampleViewMoPubAdUnitListLabel5.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel5;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel6;
        public static Template MoPubSampleViewMoPubAdUnitListLabel6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel6 == null || _moPubSampleViewMoPubAdUnitListLabel6.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel6 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel6 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel6);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel6.Name = "MoPubSampleViewMoPubAdUnitListLabel6";
                    _moPubSampleViewMoPubAdUnitListLabel6.LineNumber = 23;
                    _moPubSampleViewMoPubAdUnitListLabel6.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel6;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListImage2;
        public static Template MoPubSampleViewMoPubAdUnitListImage2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListImage2 == null || _moPubSampleViewMoPubAdUnitListImage2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListImage2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListImage2 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewImage2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListImage2.Name = "MoPubSampleViewMoPubAdUnitListImage2";
                    _moPubSampleViewMoPubAdUnitListImage2.LineNumber = 24;
                    _moPubSampleViewMoPubAdUnitListImage2.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListImage2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListRegion4;
        public static Template MoPubSampleViewMoPubAdUnitListRegion4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListRegion4 == null || _moPubSampleViewMoPubAdUnitListRegion4.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListRegion4 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListRegion4 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewRegion4);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListRegion4.Name = "MoPubSampleViewMoPubAdUnitListRegion4";
                    _moPubSampleViewMoPubAdUnitListRegion4.LineNumber = 25;
                    _moPubSampleViewMoPubAdUnitListRegion4.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListRegion4;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListRegion5;
        public static Template MoPubSampleViewMoPubAdUnitListRegion5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListRegion5 == null || _moPubSampleViewMoPubAdUnitListRegion5.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListRegion5 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListRegion5 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewRegion5);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListRegion5.Name = "MoPubSampleViewMoPubAdUnitListRegion5";
                    _moPubSampleViewMoPubAdUnitListRegion5.LineNumber = 29;
                    _moPubSampleViewMoPubAdUnitListRegion5.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListRegion5;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel7;
        public static Template MoPubSampleViewMoPubAdUnitListLabel7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel7 == null || _moPubSampleViewMoPubAdUnitListLabel7.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel7 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel7 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel7);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel7.Name = "MoPubSampleViewMoPubAdUnitListLabel7";
                    _moPubSampleViewMoPubAdUnitListLabel7.LineNumber = 30;
                    _moPubSampleViewMoPubAdUnitListLabel7.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel7;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3;
        public static Template MoPubSampleViewMoPubAdUnitListList3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3 == null || _moPubSampleViewMoPubAdUnitListList3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3.Name = "MoPubSampleViewMoPubAdUnitListList3";
                    _moPubSampleViewMoPubAdUnitListList3.LineNumber = 32;
                    _moPubSampleViewMoPubAdUnitListList3.LinePosition = 10;
#endif
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList3, MoPubSampleViewMoPubAdUnitListList3ScrollableRegion);
                }
                return _moPubSampleViewMoPubAdUnitListList3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3ScrollableRegion;
        public static Template MoPubSampleViewMoPubAdUnitListList3ScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegion == null || _moPubSampleViewMoPubAdUnitListList3ScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegion == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegion = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3ScrollableRegion);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegion.Name = "MoPubSampleViewMoPubAdUnitListList3ScrollableRegion";
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegion.LineNumber = 29;
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegion.LinePosition = 4;
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList3ScrollableRegion, MoPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList3ScrollableRegion, MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList3ScrollableRegion, MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar);
                }
                return _moPubSampleViewMoPubAdUnitListList3ScrollableRegion;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion;
        public static Template MoPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion == null || _moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3ScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion.Name = "MoPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion";
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion.LineNumber = 24;
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList3ScrollableRegionContentRegion;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar;
        public static Template MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar == null || _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar.Name = "MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar";
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar.LineNumber = 26;
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar, MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar, MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle);
                }
                return _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar;
        public static Template MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar == null || _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar.Name = "MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar";
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar.LineNumber = 7;
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle;
        public static Template MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle == null || _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3ScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle.Name = "MoPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle";
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle.LineNumber = 8;
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList3ScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar;
        public static Template MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar == null || _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar.Name = "MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar";
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar.LineNumber = 27;
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar.LinePosition = 4;
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar, MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar, MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle);
                }
                return _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar;
        public static Template MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar == null || _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar.Name = "MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar";
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar.LineNumber = 7;
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle;
        public static Template MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle == null || _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewList3ScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle.Name = "MoPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle";
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle.LineNumber = 8;
                    _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListList3ScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListListItem3;
        public static Template MoPubSampleViewMoPubAdUnitListListItem3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListListItem3 == null || _moPubSampleViewMoPubAdUnitListListItem3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListListItem3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListListItem3 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewListItem3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListListItem3.Name = "MoPubSampleViewMoPubAdUnitListListItem3";
                    _moPubSampleViewMoPubAdUnitListListItem3.LineNumber = 33;
                    _moPubSampleViewMoPubAdUnitListListItem3.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListListItem3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel8;
        public static Template MoPubSampleViewMoPubAdUnitListLabel8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel8 == null || _moPubSampleViewMoPubAdUnitListLabel8.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel8 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel8 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel8);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel8.Name = "MoPubSampleViewMoPubAdUnitListLabel8";
                    _moPubSampleViewMoPubAdUnitListLabel8.LineNumber = 34;
                    _moPubSampleViewMoPubAdUnitListLabel8.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel8;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListLabel9;
        public static Template MoPubSampleViewMoPubAdUnitListLabel9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListLabel9 == null || _moPubSampleViewMoPubAdUnitListLabel9.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListLabel9 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListLabel9 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewLabel9);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListLabel9.Name = "MoPubSampleViewMoPubAdUnitListLabel9";
                    _moPubSampleViewMoPubAdUnitListLabel9.LineNumber = 35;
                    _moPubSampleViewMoPubAdUnitListLabel9.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListLabel9;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListImage3;
        public static Template MoPubSampleViewMoPubAdUnitListImage3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListImage3 == null || _moPubSampleViewMoPubAdUnitListImage3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListImage3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListImage3 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewImage3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListImage3.Name = "MoPubSampleViewMoPubAdUnitListImage3";
                    _moPubSampleViewMoPubAdUnitListImage3.LineNumber = 36;
                    _moPubSampleViewMoPubAdUnitListImage3.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListImage3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitListRegion6;
        public static Template MoPubSampleViewMoPubAdUnitListRegion6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitListRegion6 == null || _moPubSampleViewMoPubAdUnitListRegion6.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitListRegion6 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitListRegion6 = new Template(MoPubAdUnitListViewTemplates.MoPubAdUnitListViewRegion6);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitListRegion6.Name = "MoPubSampleViewMoPubAdUnitListRegion6";
                    _moPubSampleViewMoPubAdUnitListRegion6.LineNumber = 37;
                    _moPubSampleViewMoPubAdUnitListRegion6.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitListRegion6;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnit;
        public static Template MoPubSampleViewMoPubAdUnit
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnit == null || _moPubSampleViewMoPubAdUnit.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnit == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnit = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitView);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnit.Name = "MoPubSampleViewMoPubAdUnit";
                    _moPubSampleViewMoPubAdUnit.LineNumber = 12;
                    _moPubSampleViewMoPubAdUnit.LinePosition = 22;
#endif
                    Delight.MoPubAdUnitView.Group1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup1);
                    Delight.MoPubAdUnitView.Group2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup2);
                    Delight.MoPubAdUnitView.Image1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitImage1);
                    Delight.MoPubAdUnitView.Button1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitButton1);
                    Delight.MoPubAdUnitView.Region1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion1);
                    Delight.MoPubAdUnitView.AdUnitNameTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitAdUnitName);
                    Delight.MoPubAdUnitView.Label1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitLabel1);
                    Delight.MoPubAdUnitView.AdUnitIdTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitAdUnitId);
                    Delight.MoPubAdUnitView.Region2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion2);
                    Delight.MoPubAdUnitView.KeywordsTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitKeywords);
                    Delight.MoPubAdUnitView.KeywordsDelimiterTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitKeywordsDelimiter);
                    Delight.MoPubAdUnitView.UserDataKeywordsTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitUserDataKeywords);
                    Delight.MoPubAdUnitView.UserDataKeywordsDelimiterTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter);
                    Delight.MoPubAdUnitView.Region3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion3);
                    Delight.MoPubAdUnitView.LoadAdButtonTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitLoadAdButton);
                    Delight.MoPubAdUnitView.ShowAdButtonTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitShowAdButton);
                    Delight.MoPubAdUnitView.Region4TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion4);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdLoadedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader1);
                    Delight.MoPubAdUnitView.Region5TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion5);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent1TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent1);
                    Delight.MoPubAdUnitView.Group3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup3);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnAdLoadedExpanderHeightLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel);
                    Delight.MoPubAdUnitView.Region6TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion6);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdClickedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader2);
                    Delight.MoPubAdUnitView.Region7TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion7);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent2TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent2);
                    Delight.MoPubAdUnitView.OnAdClickedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region8TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion8);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdFailedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader3);
                    Delight.MoPubAdUnitView.Region9TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion9);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent3TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent3);
                    Delight.MoPubAdUnitView.Group4TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup4);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnAdFailedExpanderErrorLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel);
                    Delight.MoPubAdUnitView.Region10TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion10);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader4TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader4);
                    Delight.MoPubAdUnitView.Region11TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion11);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent4TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent4);
                    Delight.MoPubAdUnitView.OnInterstitialLoadedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region12TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion12);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialShownExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader5TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader5);
                    Delight.MoPubAdUnitView.Region13TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion13);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent5TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent5);
                    Delight.MoPubAdUnitView.OnInterstitialShownExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region14TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion14);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader6TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader6);
                    Delight.MoPubAdUnitView.Region15TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion15);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent6TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent6);
                    Delight.MoPubAdUnitView.OnInterstitialClickedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region16TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion16);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader7TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader7);
                    Delight.MoPubAdUnitView.Region17TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion17);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent7TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent7);
                    Delight.MoPubAdUnitView.OnInterstitialDismissedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region18TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion18);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader8TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader8);
                    Delight.MoPubAdUnitView.Region19TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion19);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent8TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent8);
                    Delight.MoPubAdUnitView.Group5TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup5);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnInterstitialFailedExpanderErrorLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel);
                    Delight.MoPubAdUnitView.Region20TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion20);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader9TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader9);
                    Delight.MoPubAdUnitView.Region21TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion21);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent9TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent9);
                    Delight.MoPubAdUnitView.OnRewardedVideoLoadedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region22TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion22);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader10TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader10);
                    Delight.MoPubAdUnitView.Region23TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion23);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent10TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent10);
                    Delight.MoPubAdUnitView.OnRewardedVideoShownExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region24TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion24);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader11TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader11);
                    Delight.MoPubAdUnitView.Region25TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion25);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent11TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent11);
                    Delight.MoPubAdUnitView.OnRewardedVideoClickedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region26TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion26);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader12TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader12);
                    Delight.MoPubAdUnitView.Region27TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion27);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent12TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent12);
                    Delight.MoPubAdUnitView.OnRewardedVideoClosedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.Region28TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion28);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader13TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader13);
                    Delight.MoPubAdUnitView.Region29TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion29);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent13TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent13);
                    Delight.MoPubAdUnitView.Group6TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup6);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderLabelLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel);
                    Delight.MoPubAdUnitView.OnRewardedVideoReceivedRewardExpanderAmountLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel);
                    Delight.MoPubAdUnitView.Region30TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion30);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader14TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader14);
                    Delight.MoPubAdUnitView.Region31TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion31);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent14TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent14);
                    Delight.MoPubAdUnitView.Group7TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup7);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedToPlayExpanderErrorLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel);
                    Delight.MoPubAdUnitView.Region32TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion32);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader15TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader15);
                    Delight.MoPubAdUnitView.Region33TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion33);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent15TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent15);
                    Delight.MoPubAdUnitView.Group8TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup8);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnRewardedVideoFailedEventExpanderErrorLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel);
                    Delight.MoPubAdUnitView.Region34TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion34);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader16TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader16);
                    Delight.MoPubAdUnitView.Region35TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion35);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent16TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent16);
                    Delight.MoPubAdUnitView.Group9TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup9);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnImpressionTrackedBgExpanderImpressionDataFieldTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField);
                    Delight.MoPubAdUnitView.Region36TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion36);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpander);
                    Delight.MoPubAdUnitView.ExpanderHeader17TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderHeader17);
                    Delight.MoPubAdUnitView.Region37TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion37);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderMPEventChevronTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderCheckImageTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderEventLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel);
                    Delight.MoPubAdUnitView.ExpanderContent17TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitExpanderContent17);
                    Delight.MoPubAdUnitView.Group10TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitGroup10);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderAdUnitIdLabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel);
                    Delight.MoPubAdUnitView.OnImpressionTrackedExpanderImpressionDataFieldTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField);
                    Delight.MoPubAdUnitView.Region38TemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnit, MoPubSampleViewMoPubAdUnitRegion38);
                }
                return _moPubSampleViewMoPubAdUnit;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup1;
        public static Template MoPubSampleViewMoPubAdUnitGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup1 == null || _moPubSampleViewMoPubAdUnitGroup1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup1 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup1.Name = "MoPubSampleViewMoPubAdUnitGroup1";
                    _moPubSampleViewMoPubAdUnitGroup1.LineNumber = 11;
                    _moPubSampleViewMoPubAdUnitGroup1.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup2;
        public static Template MoPubSampleViewMoPubAdUnitGroup2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup2 == null || _moPubSampleViewMoPubAdUnitGroup2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup2 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup2.Name = "MoPubSampleViewMoPubAdUnitGroup2";
                    _moPubSampleViewMoPubAdUnitGroup2.LineNumber = 12;
                    _moPubSampleViewMoPubAdUnitGroup2.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitImage1;
        public static Template MoPubSampleViewMoPubAdUnitImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitImage1 == null || _moPubSampleViewMoPubAdUnitImage1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitImage1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitImage1 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewImage1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitImage1.Name = "MoPubSampleViewMoPubAdUnitImage1";
                    _moPubSampleViewMoPubAdUnitImage1.LineNumber = 13;
                    _moPubSampleViewMoPubAdUnitImage1.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitImage1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitButton1;
        public static Template MoPubSampleViewMoPubAdUnitButton1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitButton1 == null || _moPubSampleViewMoPubAdUnitButton1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitButton1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitButton1 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewButton1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitButton1.Name = "MoPubSampleViewMoPubAdUnitButton1";
                    _moPubSampleViewMoPubAdUnitButton1.LineNumber = 14;
                    _moPubSampleViewMoPubAdUnitButton1.LinePosition = 14;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitButton1, MoPubSampleViewMoPubAdUnitButton1Label);
                }
                return _moPubSampleViewMoPubAdUnitButton1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitButton1Label;
        public static Template MoPubSampleViewMoPubAdUnitButton1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitButton1Label == null || _moPubSampleViewMoPubAdUnitButton1Label.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitButton1Label == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitButton1Label = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewButton1Label);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitButton1Label.Name = "MoPubSampleViewMoPubAdUnitButton1Label";
                    _moPubSampleViewMoPubAdUnitButton1Label.LineNumber = 15;
                    _moPubSampleViewMoPubAdUnitButton1Label.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitButton1Label;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion1;
        public static Template MoPubSampleViewMoPubAdUnitRegion1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion1 == null || _moPubSampleViewMoPubAdUnitRegion1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion1 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion1.Name = "MoPubSampleViewMoPubAdUnitRegion1";
                    _moPubSampleViewMoPubAdUnitRegion1.LineNumber = 17;
                    _moPubSampleViewMoPubAdUnitRegion1.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitAdUnitName;
        public static Template MoPubSampleViewMoPubAdUnitAdUnitName
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitAdUnitName == null || _moPubSampleViewMoPubAdUnitAdUnitName.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitAdUnitName == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitAdUnitName = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewAdUnitName);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitAdUnitName.Name = "MoPubSampleViewMoPubAdUnitAdUnitName";
                    _moPubSampleViewMoPubAdUnitAdUnitName.LineNumber = 18;
                    _moPubSampleViewMoPubAdUnitAdUnitName.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitAdUnitName;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitLabel1;
        public static Template MoPubSampleViewMoPubAdUnitLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitLabel1 == null || _moPubSampleViewMoPubAdUnitLabel1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitLabel1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitLabel1 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewLabel1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitLabel1.Name = "MoPubSampleViewMoPubAdUnitLabel1";
                    _moPubSampleViewMoPubAdUnitLabel1.LineNumber = 21;
                    _moPubSampleViewMoPubAdUnitLabel1.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitLabel1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitAdUnitId;
        public static Template MoPubSampleViewMoPubAdUnitAdUnitId
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitAdUnitId == null || _moPubSampleViewMoPubAdUnitAdUnitId.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitAdUnitId == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitAdUnitId = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewAdUnitId);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitAdUnitId.Name = "MoPubSampleViewMoPubAdUnitAdUnitId";
                    _moPubSampleViewMoPubAdUnitAdUnitId.LineNumber = 22;
                    _moPubSampleViewMoPubAdUnitAdUnitId.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitAdUnitId;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion2;
        public static Template MoPubSampleViewMoPubAdUnitRegion2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion2 == null || _moPubSampleViewMoPubAdUnitRegion2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion2 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion2.Name = "MoPubSampleViewMoPubAdUnitRegion2";
                    _moPubSampleViewMoPubAdUnitRegion2.LineNumber = 23;
                    _moPubSampleViewMoPubAdUnitRegion2.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitKeywords;
        public static Template MoPubSampleViewMoPubAdUnitKeywords
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitKeywords == null || _moPubSampleViewMoPubAdUnitKeywords.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitKeywords == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitKeywords = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewKeywords);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitKeywords.Name = "MoPubSampleViewMoPubAdUnitKeywords";
                    _moPubSampleViewMoPubAdUnitKeywords.LineNumber = 25;
                    _moPubSampleViewMoPubAdUnitKeywords.LinePosition = 10;
#endif
                    Delight.InputField.InputFieldPlaceholderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitKeywords, MoPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder);
                    Delight.InputField.TextAreaTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitKeywords, MoPubSampleViewMoPubAdUnitKeywordsTextArea);
                    Delight.InputField.InputTextTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitKeywords, MoPubSampleViewMoPubAdUnitKeywordsInputText);
                }
                return _moPubSampleViewMoPubAdUnitKeywords;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder;
        public static Template MoPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder == null || _moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewKeywordsInputFieldPlaceholder);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder.Name = "MoPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder";
                    _moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder.LineNumber = 12;
                    _moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitKeywordsInputFieldPlaceholder;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitKeywordsTextArea;
        public static Template MoPubSampleViewMoPubAdUnitKeywordsTextArea
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitKeywordsTextArea == null || _moPubSampleViewMoPubAdUnitKeywordsTextArea.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitKeywordsTextArea == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitKeywordsTextArea = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewKeywordsTextArea);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitKeywordsTextArea.Name = "MoPubSampleViewMoPubAdUnitKeywordsTextArea";
                    _moPubSampleViewMoPubAdUnitKeywordsTextArea.LineNumber = 13;
                    _moPubSampleViewMoPubAdUnitKeywordsTextArea.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitKeywordsTextArea;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitKeywordsInputText;
        public static Template MoPubSampleViewMoPubAdUnitKeywordsInputText
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitKeywordsInputText == null || _moPubSampleViewMoPubAdUnitKeywordsInputText.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitKeywordsInputText == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitKeywordsInputText = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewKeywordsInputText);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitKeywordsInputText.Name = "MoPubSampleViewMoPubAdUnitKeywordsInputText";
                    _moPubSampleViewMoPubAdUnitKeywordsInputText.LineNumber = 14;
                    _moPubSampleViewMoPubAdUnitKeywordsInputText.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitKeywordsInputText;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitKeywordsDelimiter;
        public static Template MoPubSampleViewMoPubAdUnitKeywordsDelimiter
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitKeywordsDelimiter == null || _moPubSampleViewMoPubAdUnitKeywordsDelimiter.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitKeywordsDelimiter == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitKeywordsDelimiter = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewKeywordsDelimiter);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitKeywordsDelimiter.Name = "MoPubSampleViewMoPubAdUnitKeywordsDelimiter";
                    _moPubSampleViewMoPubAdUnitKeywordsDelimiter.LineNumber = 26;
                    _moPubSampleViewMoPubAdUnitKeywordsDelimiter.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitKeywordsDelimiter;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitUserDataKeywords;
        public static Template MoPubSampleViewMoPubAdUnitUserDataKeywords
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitUserDataKeywords == null || _moPubSampleViewMoPubAdUnitUserDataKeywords.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitUserDataKeywords == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitUserDataKeywords = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewUserDataKeywords);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitUserDataKeywords.Name = "MoPubSampleViewMoPubAdUnitUserDataKeywords";
                    _moPubSampleViewMoPubAdUnitUserDataKeywords.LineNumber = 28;
                    _moPubSampleViewMoPubAdUnitUserDataKeywords.LinePosition = 10;
#endif
                    Delight.InputField.InputFieldPlaceholderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitUserDataKeywords, MoPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder);
                    Delight.InputField.TextAreaTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitUserDataKeywords, MoPubSampleViewMoPubAdUnitUserDataKeywordsTextArea);
                    Delight.InputField.InputTextTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitUserDataKeywords, MoPubSampleViewMoPubAdUnitUserDataKeywordsInputText);
                }
                return _moPubSampleViewMoPubAdUnitUserDataKeywords;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder;
        public static Template MoPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder == null || _moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewUserDataKeywordsInputFieldPlaceholder);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder.Name = "MoPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder";
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder.LineNumber = 12;
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitUserDataKeywordsInputFieldPlaceholder;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea;
        public static Template MoPubSampleViewMoPubAdUnitUserDataKeywordsTextArea
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea == null || _moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewUserDataKeywordsTextArea);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea.Name = "MoPubSampleViewMoPubAdUnitUserDataKeywordsTextArea";
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea.LineNumber = 13;
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitUserDataKeywordsTextArea;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitUserDataKeywordsInputText;
        public static Template MoPubSampleViewMoPubAdUnitUserDataKeywordsInputText
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitUserDataKeywordsInputText == null || _moPubSampleViewMoPubAdUnitUserDataKeywordsInputText.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitUserDataKeywordsInputText == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsInputText = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewUserDataKeywordsInputText);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsInputText.Name = "MoPubSampleViewMoPubAdUnitUserDataKeywordsInputText";
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsInputText.LineNumber = 14;
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsInputText.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitUserDataKeywordsInputText;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter;
        public static Template MoPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter == null || _moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewUserDataKeywordsDelimiter);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter.Name = "MoPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter";
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter.LineNumber = 29;
                    _moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitUserDataKeywordsDelimiter;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion3;
        public static Template MoPubSampleViewMoPubAdUnitRegion3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion3 == null || _moPubSampleViewMoPubAdUnitRegion3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion3 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion3.Name = "MoPubSampleViewMoPubAdUnitRegion3";
                    _moPubSampleViewMoPubAdUnitRegion3.LineNumber = 31;
                    _moPubSampleViewMoPubAdUnitRegion3.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitLoadAdButton;
        public static Template MoPubSampleViewMoPubAdUnitLoadAdButton
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitLoadAdButton == null || _moPubSampleViewMoPubAdUnitLoadAdButton.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitLoadAdButton == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitLoadAdButton = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewLoadAdButton);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitLoadAdButton.Name = "MoPubSampleViewMoPubAdUnitLoadAdButton";
                    _moPubSampleViewMoPubAdUnitLoadAdButton.LineNumber = 33;
                    _moPubSampleViewMoPubAdUnitLoadAdButton.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitLoadAdButton, MoPubSampleViewMoPubAdUnitLoadAdButtonLabel);
                }
                return _moPubSampleViewMoPubAdUnitLoadAdButton;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitLoadAdButtonLabel;
        public static Template MoPubSampleViewMoPubAdUnitLoadAdButtonLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitLoadAdButtonLabel == null || _moPubSampleViewMoPubAdUnitLoadAdButtonLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitLoadAdButtonLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitLoadAdButtonLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewLoadAdButtonLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitLoadAdButtonLabel.Name = "MoPubSampleViewMoPubAdUnitLoadAdButtonLabel";
                    _moPubSampleViewMoPubAdUnitLoadAdButtonLabel.LineNumber = 15;
                    _moPubSampleViewMoPubAdUnitLoadAdButtonLabel.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitLoadAdButtonLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitShowAdButton;
        public static Template MoPubSampleViewMoPubAdUnitShowAdButton
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitShowAdButton == null || _moPubSampleViewMoPubAdUnitShowAdButton.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitShowAdButton == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitShowAdButton = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewShowAdButton);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitShowAdButton.Name = "MoPubSampleViewMoPubAdUnitShowAdButton";
                    _moPubSampleViewMoPubAdUnitShowAdButton.LineNumber = 34;
                    _moPubSampleViewMoPubAdUnitShowAdButton.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitShowAdButton, MoPubSampleViewMoPubAdUnitShowAdButtonLabel);
                }
                return _moPubSampleViewMoPubAdUnitShowAdButton;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitShowAdButtonLabel;
        public static Template MoPubSampleViewMoPubAdUnitShowAdButtonLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitShowAdButtonLabel == null || _moPubSampleViewMoPubAdUnitShowAdButtonLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitShowAdButtonLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitShowAdButtonLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewShowAdButtonLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitShowAdButtonLabel.Name = "MoPubSampleViewMoPubAdUnitShowAdButtonLabel";
                    _moPubSampleViewMoPubAdUnitShowAdButtonLabel.LineNumber = 15;
                    _moPubSampleViewMoPubAdUnitShowAdButtonLabel.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitShowAdButtonLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion4;
        public static Template MoPubSampleViewMoPubAdUnitRegion4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion4 == null || _moPubSampleViewMoPubAdUnitRegion4.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion4 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion4 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion4);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion4.Name = "MoPubSampleViewMoPubAdUnitRegion4";
                    _moPubSampleViewMoPubAdUnitRegion4.LineNumber = 37;
                    _moPubSampleViewMoPubAdUnitRegion4.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion4;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdLoadedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnAdLoadedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpander == null || _moPubSampleViewMoPubAdUnitOnAdLoadedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdLoadedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpander.Name = "MoPubSampleViewMoPubAdUnitOnAdLoadedExpander";
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpander.LineNumber = 43;
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdLoadedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader1;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader1 == null || _moPubSampleViewMoPubAdUnitExpanderHeader1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader1 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader1.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader1";
                    _moPubSampleViewMoPubAdUnitExpanderHeader1.LineNumber = 45;
                    _moPubSampleViewMoPubAdUnitExpanderHeader1.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion5;
        public static Template MoPubSampleViewMoPubAdUnitRegion5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion5 == null || _moPubSampleViewMoPubAdUnitRegion5.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion5 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion5 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion5);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion5.Name = "MoPubSampleViewMoPubAdUnitRegion5";
                    _moPubSampleViewMoPubAdUnitRegion5.LineNumber = 46;
                    _moPubSampleViewMoPubAdUnitRegion5.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion5;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdLoadedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron.LineNumber = 47;
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdLoadedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage.LineNumber = 49;
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdLoadedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel.LineNumber = 50;
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent1;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent1 == null || _moPubSampleViewMoPubAdUnitExpanderContent1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent1 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent1 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent1);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent1.Name = "MoPubSampleViewMoPubAdUnitExpanderContent1";
                    _moPubSampleViewMoPubAdUnitExpanderContent1.LineNumber = 53;
                    _moPubSampleViewMoPubAdUnitExpanderContent1.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent1;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup3;
        public static Template MoPubSampleViewMoPubAdUnitGroup3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup3 == null || _moPubSampleViewMoPubAdUnitGroup3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup3 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup3.Name = "MoPubSampleViewMoPubAdUnitGroup3";
                    _moPubSampleViewMoPubAdUnitGroup3.LineNumber = 54;
                    _moPubSampleViewMoPubAdUnitGroup3.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdLoadedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel.LineNumber = 55;
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel == null || _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdLoadedExpanderHeightLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel.Name = "MoPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel";
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel.LineNumber = 56;
                    _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdLoadedExpanderHeightLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion6;
        public static Template MoPubSampleViewMoPubAdUnitRegion6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion6 == null || _moPubSampleViewMoPubAdUnitRegion6.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion6 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion6 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion6);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion6.Name = "MoPubSampleViewMoPubAdUnitRegion6";
                    _moPubSampleViewMoPubAdUnitRegion6.LineNumber = 60;
                    _moPubSampleViewMoPubAdUnitRegion6.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion6;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdClickedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnAdClickedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpander == null || _moPubSampleViewMoPubAdUnitOnAdClickedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdClickedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpander.Name = "MoPubSampleViewMoPubAdUnitOnAdClickedExpander";
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpander.LineNumber = 62;
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdClickedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader2;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader2 == null || _moPubSampleViewMoPubAdUnitExpanderHeader2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader2 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader2.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader2";
                    _moPubSampleViewMoPubAdUnitExpanderHeader2.LineNumber = 64;
                    _moPubSampleViewMoPubAdUnitExpanderHeader2.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion7;
        public static Template MoPubSampleViewMoPubAdUnitRegion7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion7 == null || _moPubSampleViewMoPubAdUnitRegion7.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion7 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion7 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion7);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion7.Name = "MoPubSampleViewMoPubAdUnitRegion7";
                    _moPubSampleViewMoPubAdUnitRegion7.LineNumber = 65;
                    _moPubSampleViewMoPubAdUnitRegion7.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion7;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdClickedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron.LineNumber = 66;
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdClickedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdClickedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage.LineNumber = 68;
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdClickedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdClickedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel.LineNumber = 69;
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdClickedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent2;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent2 == null || _moPubSampleViewMoPubAdUnitExpanderContent2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent2 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent2 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent2);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent2.Name = "MoPubSampleViewMoPubAdUnitExpanderContent2";
                    _moPubSampleViewMoPubAdUnitExpanderContent2.LineNumber = 72;
                    _moPubSampleViewMoPubAdUnitExpanderContent2.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent2;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdClickedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel.LineNumber = 73;
                    _moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdClickedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion8;
        public static Template MoPubSampleViewMoPubAdUnitRegion8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion8 == null || _moPubSampleViewMoPubAdUnitRegion8.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion8 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion8 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion8);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion8.Name = "MoPubSampleViewMoPubAdUnitRegion8";
                    _moPubSampleViewMoPubAdUnitRegion8.LineNumber = 76;
                    _moPubSampleViewMoPubAdUnitRegion8.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion8;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdFailedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnAdFailedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpander == null || _moPubSampleViewMoPubAdUnitOnAdFailedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdFailedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpander.Name = "MoPubSampleViewMoPubAdUnitOnAdFailedExpander";
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpander.LineNumber = 78;
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdFailedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader3;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader3 == null || _moPubSampleViewMoPubAdUnitExpanderHeader3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader3 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader3.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader3";
                    _moPubSampleViewMoPubAdUnitExpanderHeader3.LineNumber = 80;
                    _moPubSampleViewMoPubAdUnitExpanderHeader3.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion9;
        public static Template MoPubSampleViewMoPubAdUnitRegion9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion9 == null || _moPubSampleViewMoPubAdUnitRegion9.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion9 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion9 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion9);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion9.Name = "MoPubSampleViewMoPubAdUnitRegion9";
                    _moPubSampleViewMoPubAdUnitRegion9.LineNumber = 81;
                    _moPubSampleViewMoPubAdUnitRegion9.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion9;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdFailedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron.LineNumber = 82;
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdFailedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdFailedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage.LineNumber = 84;
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdFailedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdFailedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel.LineNumber = 85;
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdFailedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent3;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent3 == null || _moPubSampleViewMoPubAdUnitExpanderContent3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent3 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent3 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent3);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent3.Name = "MoPubSampleViewMoPubAdUnitExpanderContent3";
                    _moPubSampleViewMoPubAdUnitExpanderContent3.LineNumber = 88;
                    _moPubSampleViewMoPubAdUnitExpanderContent3.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent3;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup4;
        public static Template MoPubSampleViewMoPubAdUnitGroup4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup4 == null || _moPubSampleViewMoPubAdUnitGroup4.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup4 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup4 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup4);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup4.Name = "MoPubSampleViewMoPubAdUnitGroup4";
                    _moPubSampleViewMoPubAdUnitGroup4.LineNumber = 89;
                    _moPubSampleViewMoPubAdUnitGroup4.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup4;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdFailedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel.LineNumber = 90;
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdFailedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel == null || _moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnAdFailedExpanderErrorLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel.Name = "MoPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel";
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel.LineNumber = 91;
                    _moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnAdFailedExpanderErrorLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion10;
        public static Template MoPubSampleViewMoPubAdUnitRegion10
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion10 == null || _moPubSampleViewMoPubAdUnitRegion10.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion10 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion10 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion10);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion10.Name = "MoPubSampleViewMoPubAdUnitRegion10";
                    _moPubSampleViewMoPubAdUnitRegion10.LineNumber = 95;
                    _moPubSampleViewMoPubAdUnitRegion10.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion10;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander == null || _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialLoadedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander";
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander.LineNumber = 101;
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader4;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader4 == null || _moPubSampleViewMoPubAdUnitExpanderHeader4.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader4 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader4 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader4);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader4.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader4";
                    _moPubSampleViewMoPubAdUnitExpanderHeader4.LineNumber = 103;
                    _moPubSampleViewMoPubAdUnitExpanderHeader4.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader4;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion11;
        public static Template MoPubSampleViewMoPubAdUnitRegion11
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion11 == null || _moPubSampleViewMoPubAdUnitRegion11.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion11 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion11 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion11);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion11.Name = "MoPubSampleViewMoPubAdUnitRegion11";
                    _moPubSampleViewMoPubAdUnitRegion11.LineNumber = 104;
                    _moPubSampleViewMoPubAdUnitRegion11.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion11;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialLoadedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron.LineNumber = 105;
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialLoadedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage.LineNumber = 107;
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialLoadedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel.LineNumber = 108;
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent4;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent4 == null || _moPubSampleViewMoPubAdUnitExpanderContent4.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent4 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent4 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent4);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent4.Name = "MoPubSampleViewMoPubAdUnitExpanderContent4";
                    _moPubSampleViewMoPubAdUnitExpanderContent4.LineNumber = 111;
                    _moPubSampleViewMoPubAdUnitExpanderContent4.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent4;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialLoadedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel.LineNumber = 112;
                    _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialLoadedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion12;
        public static Template MoPubSampleViewMoPubAdUnitRegion12
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion12 == null || _moPubSampleViewMoPubAdUnitRegion12.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion12 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion12 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion12);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion12.Name = "MoPubSampleViewMoPubAdUnitRegion12";
                    _moPubSampleViewMoPubAdUnitRegion12.LineNumber = 115;
                    _moPubSampleViewMoPubAdUnitRegion12.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion12;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialShownExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialShownExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpander == null || _moPubSampleViewMoPubAdUnitOnInterstitialShownExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialShownExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpander.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialShownExpander";
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpander.LineNumber = 117;
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialShownExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader5;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader5 == null || _moPubSampleViewMoPubAdUnitExpanderHeader5.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader5 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader5 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader5);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader5.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader5";
                    _moPubSampleViewMoPubAdUnitExpanderHeader5.LineNumber = 119;
                    _moPubSampleViewMoPubAdUnitExpanderHeader5.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader5;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion13;
        public static Template MoPubSampleViewMoPubAdUnitRegion13
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion13 == null || _moPubSampleViewMoPubAdUnitRegion13.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion13 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion13 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion13);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion13.Name = "MoPubSampleViewMoPubAdUnitRegion13";
                    _moPubSampleViewMoPubAdUnitRegion13.LineNumber = 120;
                    _moPubSampleViewMoPubAdUnitRegion13.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion13;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialShownExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron.LineNumber = 121;
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialShownExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage.LineNumber = 123;
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialShownExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel.LineNumber = 124;
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent5;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent5 == null || _moPubSampleViewMoPubAdUnitExpanderContent5.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent5 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent5 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent5);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent5.Name = "MoPubSampleViewMoPubAdUnitExpanderContent5";
                    _moPubSampleViewMoPubAdUnitExpanderContent5.LineNumber = 127;
                    _moPubSampleViewMoPubAdUnitExpanderContent5.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent5;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialShownExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel.LineNumber = 128;
                    _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialShownExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion14;
        public static Template MoPubSampleViewMoPubAdUnitRegion14
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion14 == null || _moPubSampleViewMoPubAdUnitRegion14.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion14 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion14 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion14);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion14.Name = "MoPubSampleViewMoPubAdUnitRegion14";
                    _moPubSampleViewMoPubAdUnitRegion14.LineNumber = 131;
                    _moPubSampleViewMoPubAdUnitRegion14.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion14;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander == null || _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialClickedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpander";
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander.LineNumber = 133;
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader6;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader6 == null || _moPubSampleViewMoPubAdUnitExpanderHeader6.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader6 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader6 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader6);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader6.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader6";
                    _moPubSampleViewMoPubAdUnitExpanderHeader6.LineNumber = 135;
                    _moPubSampleViewMoPubAdUnitExpanderHeader6.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader6;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion15;
        public static Template MoPubSampleViewMoPubAdUnitRegion15
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion15 == null || _moPubSampleViewMoPubAdUnitRegion15.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion15 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion15 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion15);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion15.Name = "MoPubSampleViewMoPubAdUnitRegion15";
                    _moPubSampleViewMoPubAdUnitRegion15.LineNumber = 136;
                    _moPubSampleViewMoPubAdUnitRegion15.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion15;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialClickedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron.LineNumber = 137;
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialClickedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage.LineNumber = 139;
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialClickedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel.LineNumber = 140;
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent6;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent6 == null || _moPubSampleViewMoPubAdUnitExpanderContent6.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent6 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent6 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent6);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent6.Name = "MoPubSampleViewMoPubAdUnitExpanderContent6";
                    _moPubSampleViewMoPubAdUnitExpanderContent6.LineNumber = 143;
                    _moPubSampleViewMoPubAdUnitExpanderContent6.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent6;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialClickedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel.LineNumber = 144;
                    _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialClickedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion16;
        public static Template MoPubSampleViewMoPubAdUnitRegion16
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion16 == null || _moPubSampleViewMoPubAdUnitRegion16.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion16 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion16 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion16);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion16.Name = "MoPubSampleViewMoPubAdUnitRegion16";
                    _moPubSampleViewMoPubAdUnitRegion16.LineNumber = 147;
                    _moPubSampleViewMoPubAdUnitRegion16.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion16;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander == null || _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialDismissedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander";
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander.LineNumber = 149;
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader7;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader7 == null || _moPubSampleViewMoPubAdUnitExpanderHeader7.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader7 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader7 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader7);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader7.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader7";
                    _moPubSampleViewMoPubAdUnitExpanderHeader7.LineNumber = 151;
                    _moPubSampleViewMoPubAdUnitExpanderHeader7.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader7;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion17;
        public static Template MoPubSampleViewMoPubAdUnitRegion17
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion17 == null || _moPubSampleViewMoPubAdUnitRegion17.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion17 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion17 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion17);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion17.Name = "MoPubSampleViewMoPubAdUnitRegion17";
                    _moPubSampleViewMoPubAdUnitRegion17.LineNumber = 152;
                    _moPubSampleViewMoPubAdUnitRegion17.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion17;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialDismissedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron.LineNumber = 153;
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialDismissedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage.LineNumber = 155;
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialDismissedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel.LineNumber = 156;
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent7;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent7 == null || _moPubSampleViewMoPubAdUnitExpanderContent7.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent7 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent7 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent7);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent7.Name = "MoPubSampleViewMoPubAdUnitExpanderContent7";
                    _moPubSampleViewMoPubAdUnitExpanderContent7.LineNumber = 159;
                    _moPubSampleViewMoPubAdUnitExpanderContent7.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent7;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialDismissedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel.LineNumber = 160;
                    _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialDismissedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion18;
        public static Template MoPubSampleViewMoPubAdUnitRegion18
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion18 == null || _moPubSampleViewMoPubAdUnitRegion18.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion18 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion18 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion18);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion18.Name = "MoPubSampleViewMoPubAdUnitRegion18";
                    _moPubSampleViewMoPubAdUnitRegion18.LineNumber = 163;
                    _moPubSampleViewMoPubAdUnitRegion18.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion18;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander == null || _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialFailedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpander";
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander.LineNumber = 165;
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader8;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader8 == null || _moPubSampleViewMoPubAdUnitExpanderHeader8.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader8 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader8 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader8);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader8.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader8";
                    _moPubSampleViewMoPubAdUnitExpanderHeader8.LineNumber = 167;
                    _moPubSampleViewMoPubAdUnitExpanderHeader8.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader8;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion19;
        public static Template MoPubSampleViewMoPubAdUnitRegion19
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion19 == null || _moPubSampleViewMoPubAdUnitRegion19.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion19 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion19 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion19);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion19.Name = "MoPubSampleViewMoPubAdUnitRegion19";
                    _moPubSampleViewMoPubAdUnitRegion19.LineNumber = 168;
                    _moPubSampleViewMoPubAdUnitRegion19.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion19;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialFailedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron.LineNumber = 169;
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialFailedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage.LineNumber = 171;
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialFailedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel.LineNumber = 172;
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent8;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent8 == null || _moPubSampleViewMoPubAdUnitExpanderContent8.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent8 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent8 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent8);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent8.Name = "MoPubSampleViewMoPubAdUnitExpanderContent8";
                    _moPubSampleViewMoPubAdUnitExpanderContent8.LineNumber = 175;
                    _moPubSampleViewMoPubAdUnitExpanderContent8.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent8;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup5;
        public static Template MoPubSampleViewMoPubAdUnitGroup5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup5 == null || _moPubSampleViewMoPubAdUnitGroup5.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup5 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup5 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup5);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup5.Name = "MoPubSampleViewMoPubAdUnitGroup5";
                    _moPubSampleViewMoPubAdUnitGroup5.LineNumber = 176;
                    _moPubSampleViewMoPubAdUnitGroup5.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup5;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialFailedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel.LineNumber = 177;
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel == null || _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnInterstitialFailedExpanderErrorLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel.Name = "MoPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel";
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel.LineNumber = 178;
                    _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnInterstitialFailedExpanderErrorLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion20;
        public static Template MoPubSampleViewMoPubAdUnitRegion20
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion20 == null || _moPubSampleViewMoPubAdUnitRegion20.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion20 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion20 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion20);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion20.Name = "MoPubSampleViewMoPubAdUnitRegion20";
                    _moPubSampleViewMoPubAdUnitRegion20.LineNumber = 182;
                    _moPubSampleViewMoPubAdUnitRegion20.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion20;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoLoadedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander.LineNumber = 188;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader9;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader9 == null || _moPubSampleViewMoPubAdUnitExpanderHeader9.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader9 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader9 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader9);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader9.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader9";
                    _moPubSampleViewMoPubAdUnitExpanderHeader9.LineNumber = 190;
                    _moPubSampleViewMoPubAdUnitExpanderHeader9.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader9;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion21;
        public static Template MoPubSampleViewMoPubAdUnitRegion21
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion21 == null || _moPubSampleViewMoPubAdUnitRegion21.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion21 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion21 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion21);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion21.Name = "MoPubSampleViewMoPubAdUnitRegion21";
                    _moPubSampleViewMoPubAdUnitRegion21.LineNumber = 191;
                    _moPubSampleViewMoPubAdUnitRegion21.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion21;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoLoadedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron.LineNumber = 192;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoLoadedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage.LineNumber = 194;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoLoadedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel.LineNumber = 195;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent9;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent9 == null || _moPubSampleViewMoPubAdUnitExpanderContent9.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent9 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent9 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent9);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent9.Name = "MoPubSampleViewMoPubAdUnitExpanderContent9";
                    _moPubSampleViewMoPubAdUnitExpanderContent9.LineNumber = 198;
                    _moPubSampleViewMoPubAdUnitExpanderContent9.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent9;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoLoadedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel.LineNumber = 199;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoLoadedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion22;
        public static Template MoPubSampleViewMoPubAdUnitRegion22
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion22 == null || _moPubSampleViewMoPubAdUnitRegion22.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion22 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion22 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion22);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion22.Name = "MoPubSampleViewMoPubAdUnitRegion22";
                    _moPubSampleViewMoPubAdUnitRegion22.LineNumber = 202;
                    _moPubSampleViewMoPubAdUnitRegion22.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion22;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoShownExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander.LineNumber = 204;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader10;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader10
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader10 == null || _moPubSampleViewMoPubAdUnitExpanderHeader10.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader10 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader10 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader10);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader10.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader10";
                    _moPubSampleViewMoPubAdUnitExpanderHeader10.LineNumber = 206;
                    _moPubSampleViewMoPubAdUnitExpanderHeader10.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader10;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion23;
        public static Template MoPubSampleViewMoPubAdUnitRegion23
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion23 == null || _moPubSampleViewMoPubAdUnitRegion23.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion23 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion23 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion23);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion23.Name = "MoPubSampleViewMoPubAdUnitRegion23";
                    _moPubSampleViewMoPubAdUnitRegion23.LineNumber = 207;
                    _moPubSampleViewMoPubAdUnitRegion23.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion23;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoShownExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron.LineNumber = 208;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoShownExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage.LineNumber = 210;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoShownExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel.LineNumber = 211;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent10;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent10
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent10 == null || _moPubSampleViewMoPubAdUnitExpanderContent10.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent10 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent10 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent10);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent10.Name = "MoPubSampleViewMoPubAdUnitExpanderContent10";
                    _moPubSampleViewMoPubAdUnitExpanderContent10.LineNumber = 214;
                    _moPubSampleViewMoPubAdUnitExpanderContent10.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent10;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoShownExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel.LineNumber = 215;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoShownExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion24;
        public static Template MoPubSampleViewMoPubAdUnitRegion24
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion24 == null || _moPubSampleViewMoPubAdUnitRegion24.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion24 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion24 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion24);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion24.Name = "MoPubSampleViewMoPubAdUnitRegion24";
                    _moPubSampleViewMoPubAdUnitRegion24.LineNumber = 218;
                    _moPubSampleViewMoPubAdUnitRegion24.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion24;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClickedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander.LineNumber = 220;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader11;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader11
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader11 == null || _moPubSampleViewMoPubAdUnitExpanderHeader11.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader11 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader11 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader11);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader11.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader11";
                    _moPubSampleViewMoPubAdUnitExpanderHeader11.LineNumber = 222;
                    _moPubSampleViewMoPubAdUnitExpanderHeader11.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader11;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion25;
        public static Template MoPubSampleViewMoPubAdUnitRegion25
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion25 == null || _moPubSampleViewMoPubAdUnitRegion25.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion25 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion25 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion25);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion25.Name = "MoPubSampleViewMoPubAdUnitRegion25";
                    _moPubSampleViewMoPubAdUnitRegion25.LineNumber = 223;
                    _moPubSampleViewMoPubAdUnitRegion25.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion25;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClickedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron.LineNumber = 224;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClickedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage.LineNumber = 226;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClickedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel.LineNumber = 227;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent11;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent11
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent11 == null || _moPubSampleViewMoPubAdUnitExpanderContent11.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent11 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent11 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent11);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent11.Name = "MoPubSampleViewMoPubAdUnitExpanderContent11";
                    _moPubSampleViewMoPubAdUnitExpanderContent11.LineNumber = 230;
                    _moPubSampleViewMoPubAdUnitExpanderContent11.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent11;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClickedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel.LineNumber = 231;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClickedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion26;
        public static Template MoPubSampleViewMoPubAdUnitRegion26
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion26 == null || _moPubSampleViewMoPubAdUnitRegion26.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion26 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion26 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion26);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion26.Name = "MoPubSampleViewMoPubAdUnitRegion26";
                    _moPubSampleViewMoPubAdUnitRegion26.LineNumber = 234;
                    _moPubSampleViewMoPubAdUnitRegion26.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion26;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClosedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander.LineNumber = 236;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader12;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader12
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader12 == null || _moPubSampleViewMoPubAdUnitExpanderHeader12.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader12 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader12 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader12);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader12.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader12";
                    _moPubSampleViewMoPubAdUnitExpanderHeader12.LineNumber = 238;
                    _moPubSampleViewMoPubAdUnitExpanderHeader12.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader12;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion27;
        public static Template MoPubSampleViewMoPubAdUnitRegion27
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion27 == null || _moPubSampleViewMoPubAdUnitRegion27.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion27 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion27 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion27);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion27.Name = "MoPubSampleViewMoPubAdUnitRegion27";
                    _moPubSampleViewMoPubAdUnitRegion27.LineNumber = 239;
                    _moPubSampleViewMoPubAdUnitRegion27.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion27;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClosedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron.LineNumber = 240;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClosedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage.LineNumber = 242;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClosedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel.LineNumber = 243;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent12;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent12
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent12 == null || _moPubSampleViewMoPubAdUnitExpanderContent12.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent12 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent12 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent12);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent12.Name = "MoPubSampleViewMoPubAdUnitExpanderContent12";
                    _moPubSampleViewMoPubAdUnitExpanderContent12.LineNumber = 246;
                    _moPubSampleViewMoPubAdUnitExpanderContent12.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent12;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoClosedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel.LineNumber = 247;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoClosedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion28;
        public static Template MoPubSampleViewMoPubAdUnitRegion28
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion28 == null || _moPubSampleViewMoPubAdUnitRegion28.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion28 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion28 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion28);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion28.Name = "MoPubSampleViewMoPubAdUnitRegion28";
                    _moPubSampleViewMoPubAdUnitRegion28.LineNumber = 250;
                    _moPubSampleViewMoPubAdUnitRegion28.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion28;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoReceivedRewardExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander.LineNumber = 252;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader13;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader13
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader13 == null || _moPubSampleViewMoPubAdUnitExpanderHeader13.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader13 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader13 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader13);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader13.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader13";
                    _moPubSampleViewMoPubAdUnitExpanderHeader13.LineNumber = 254;
                    _moPubSampleViewMoPubAdUnitExpanderHeader13.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader13;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion29;
        public static Template MoPubSampleViewMoPubAdUnitRegion29
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion29 == null || _moPubSampleViewMoPubAdUnitRegion29.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion29 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion29 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion29);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion29.Name = "MoPubSampleViewMoPubAdUnitRegion29";
                    _moPubSampleViewMoPubAdUnitRegion29.LineNumber = 255;
                    _moPubSampleViewMoPubAdUnitRegion29.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion29;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron.LineNumber = 256;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage.LineNumber = 258;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel.LineNumber = 259;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent13;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent13
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent13 == null || _moPubSampleViewMoPubAdUnitExpanderContent13.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent13 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent13 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent13);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent13.Name = "MoPubSampleViewMoPubAdUnitExpanderContent13";
                    _moPubSampleViewMoPubAdUnitExpanderContent13.LineNumber = 263;
                    _moPubSampleViewMoPubAdUnitExpanderContent13.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent13;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup6;
        public static Template MoPubSampleViewMoPubAdUnitGroup6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup6 == null || _moPubSampleViewMoPubAdUnitGroup6.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup6 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup6 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup6);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup6.Name = "MoPubSampleViewMoPubAdUnitGroup6";
                    _moPubSampleViewMoPubAdUnitGroup6.LineNumber = 264;
                    _moPubSampleViewMoPubAdUnitGroup6.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup6;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel.LineNumber = 265;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderLabelLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel.LineNumber = 266;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderLabelLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoReceivedRewardExpanderAmountLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel.LineNumber = 267;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoReceivedRewardExpanderAmountLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion30;
        public static Template MoPubSampleViewMoPubAdUnitRegion30
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion30 == null || _moPubSampleViewMoPubAdUnitRegion30.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion30 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion30 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion30);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion30.Name = "MoPubSampleViewMoPubAdUnitRegion30";
                    _moPubSampleViewMoPubAdUnitRegion30.LineNumber = 271;
                    _moPubSampleViewMoPubAdUnitRegion30.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion30;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedToPlayExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander.LineNumber = 273;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader14;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader14
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader14 == null || _moPubSampleViewMoPubAdUnitExpanderHeader14.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader14 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader14 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader14);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader14.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader14";
                    _moPubSampleViewMoPubAdUnitExpanderHeader14.LineNumber = 275;
                    _moPubSampleViewMoPubAdUnitExpanderHeader14.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader14;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion31;
        public static Template MoPubSampleViewMoPubAdUnitRegion31
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion31 == null || _moPubSampleViewMoPubAdUnitRegion31.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion31 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion31 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion31);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion31.Name = "MoPubSampleViewMoPubAdUnitRegion31";
                    _moPubSampleViewMoPubAdUnitRegion31.LineNumber = 276;
                    _moPubSampleViewMoPubAdUnitRegion31.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion31;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron.LineNumber = 277;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage.LineNumber = 279;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel.LineNumber = 280;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent14;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent14
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent14 == null || _moPubSampleViewMoPubAdUnitExpanderContent14.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent14 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent14 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent14);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent14.Name = "MoPubSampleViewMoPubAdUnitExpanderContent14";
                    _moPubSampleViewMoPubAdUnitExpanderContent14.LineNumber = 283;
                    _moPubSampleViewMoPubAdUnitExpanderContent14.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent14;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup7;
        public static Template MoPubSampleViewMoPubAdUnitGroup7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup7 == null || _moPubSampleViewMoPubAdUnitGroup7.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup7 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup7 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup7);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup7.Name = "MoPubSampleViewMoPubAdUnitGroup7";
                    _moPubSampleViewMoPubAdUnitGroup7.LineNumber = 284;
                    _moPubSampleViewMoPubAdUnitGroup7.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup7;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel.LineNumber = 285;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedToPlayExpanderErrorLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel.LineNumber = 286;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedToPlayExpanderErrorLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion32;
        public static Template MoPubSampleViewMoPubAdUnitRegion32
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion32 == null || _moPubSampleViewMoPubAdUnitRegion32.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion32 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion32 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion32);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion32.Name = "MoPubSampleViewMoPubAdUnitRegion32";
                    _moPubSampleViewMoPubAdUnitRegion32.LineNumber = 290;
                    _moPubSampleViewMoPubAdUnitRegion32.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion32;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedEventExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander.LineNumber = 292;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader15;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader15
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader15 == null || _moPubSampleViewMoPubAdUnitExpanderHeader15.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader15 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader15 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader15);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader15.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader15";
                    _moPubSampleViewMoPubAdUnitExpanderHeader15.LineNumber = 294;
                    _moPubSampleViewMoPubAdUnitExpanderHeader15.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader15;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion33;
        public static Template MoPubSampleViewMoPubAdUnitRegion33
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion33 == null || _moPubSampleViewMoPubAdUnitRegion33.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion33 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion33 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion33);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion33.Name = "MoPubSampleViewMoPubAdUnitRegion33";
                    _moPubSampleViewMoPubAdUnitRegion33.LineNumber = 295;
                    _moPubSampleViewMoPubAdUnitRegion33.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion33;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedEventExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron.LineNumber = 296;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedEventExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage.LineNumber = 298;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedEventExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel.LineNumber = 299;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent15;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent15
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent15 == null || _moPubSampleViewMoPubAdUnitExpanderContent15.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent15 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent15 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent15);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent15.Name = "MoPubSampleViewMoPubAdUnitExpanderContent15";
                    _moPubSampleViewMoPubAdUnitExpanderContent15.LineNumber = 302;
                    _moPubSampleViewMoPubAdUnitExpanderContent15.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent15;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup8;
        public static Template MoPubSampleViewMoPubAdUnitGroup8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup8 == null || _moPubSampleViewMoPubAdUnitGroup8.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup8 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup8 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup8);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup8.Name = "MoPubSampleViewMoPubAdUnitGroup8";
                    _moPubSampleViewMoPubAdUnitGroup8.LineNumber = 303;
                    _moPubSampleViewMoPubAdUnitGroup8.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup8;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedEventExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel.LineNumber = 304;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel == null || _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnRewardedVideoFailedEventExpanderErrorLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel.Name = "MoPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel";
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel.LineNumber = 305;
                    _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnRewardedVideoFailedEventExpanderErrorLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion34;
        public static Template MoPubSampleViewMoPubAdUnitRegion34
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion34 == null || _moPubSampleViewMoPubAdUnitRegion34.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion34 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion34 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion34);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion34.Name = "MoPubSampleViewMoPubAdUnitRegion34";
                    _moPubSampleViewMoPubAdUnitRegion34.LineNumber = 309;
                    _moPubSampleViewMoPubAdUnitRegion34.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion34;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander.LineNumber = 315;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader16;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader16
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader16 == null || _moPubSampleViewMoPubAdUnitExpanderHeader16.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader16 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader16 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader16);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader16.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader16";
                    _moPubSampleViewMoPubAdUnitExpanderHeader16.LineNumber = 317;
                    _moPubSampleViewMoPubAdUnitExpanderHeader16.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader16;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion35;
        public static Template MoPubSampleViewMoPubAdUnitRegion35
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion35 == null || _moPubSampleViewMoPubAdUnitRegion35.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion35 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion35 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion35);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion35.Name = "MoPubSampleViewMoPubAdUnitRegion35";
                    _moPubSampleViewMoPubAdUnitRegion35.LineNumber = 318;
                    _moPubSampleViewMoPubAdUnitRegion35.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion35;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron.LineNumber = 319;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage.LineNumber = 321;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel.LineNumber = 322;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent16;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent16
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent16 == null || _moPubSampleViewMoPubAdUnitExpanderContent16.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent16 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent16 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent16);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent16.Name = "MoPubSampleViewMoPubAdUnitExpanderContent16";
                    _moPubSampleViewMoPubAdUnitExpanderContent16.LineNumber = 325;
                    _moPubSampleViewMoPubAdUnitExpanderContent16.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent16;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup9;
        public static Template MoPubSampleViewMoPubAdUnitGroup9
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup9 == null || _moPubSampleViewMoPubAdUnitGroup9.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup9 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup9 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup9);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup9.Name = "MoPubSampleViewMoPubAdUnitGroup9";
                    _moPubSampleViewMoPubAdUnitGroup9.LineNumber = 326;
                    _moPubSampleViewMoPubAdUnitGroup9.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup9;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel.LineNumber = 327;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataField);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField.LineNumber = 328;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField.LinePosition = 22;
#endif
                    Delight.InputField.InputFieldPlaceholderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder);
                    Delight.InputField.TextAreaTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea);
                    Delight.InputField.InputTextTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField, MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText);
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataField;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder.LineNumber = 12;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputFieldPlaceholder;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldTextArea);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea.LineNumber = 13;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldTextArea;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedBgExpanderImpressionDataFieldInputText);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText.LineNumber = 14;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedBgExpanderImpressionDataFieldInputText;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion36;
        public static Template MoPubSampleViewMoPubAdUnitRegion36
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion36 == null || _moPubSampleViewMoPubAdUnitRegion36.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion36 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion36 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion36);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion36.Name = "MoPubSampleViewMoPubAdUnitRegion36";
                    _moPubSampleViewMoPubAdUnitRegion36.LineNumber = 332;
                    _moPubSampleViewMoPubAdUnitRegion36.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion36;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpander
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpander);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpander";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander.LineNumber = 334;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpander;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderHeader17;
        public static Template MoPubSampleViewMoPubAdUnitExpanderHeader17
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderHeader17 == null || _moPubSampleViewMoPubAdUnitExpanderHeader17.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderHeader17 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderHeader17 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderHeader17);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderHeader17.Name = "MoPubSampleViewMoPubAdUnitExpanderHeader17";
                    _moPubSampleViewMoPubAdUnitExpanderHeader17.LineNumber = 336;
                    _moPubSampleViewMoPubAdUnitExpanderHeader17.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderHeader17;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion37;
        public static Template MoPubSampleViewMoPubAdUnitRegion37
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion37 == null || _moPubSampleViewMoPubAdUnitRegion37.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion37 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion37 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion37);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion37.Name = "MoPubSampleViewMoPubAdUnitRegion37";
                    _moPubSampleViewMoPubAdUnitRegion37.LineNumber = 337;
                    _moPubSampleViewMoPubAdUnitRegion37.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion37;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpanderMPEventChevron);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron.LineNumber = 338;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderMPEventChevron;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpanderCheckImage);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage.LineNumber = 340;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderCheckImage;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpanderEventLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel.LineNumber = 341;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderEventLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitExpanderContent17;
        public static Template MoPubSampleViewMoPubAdUnitExpanderContent17
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitExpanderContent17 == null || _moPubSampleViewMoPubAdUnitExpanderContent17.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitExpanderContent17 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitExpanderContent17 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewExpanderContent17);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitExpanderContent17.Name = "MoPubSampleViewMoPubAdUnitExpanderContent17";
                    _moPubSampleViewMoPubAdUnitExpanderContent17.LineNumber = 344;
                    _moPubSampleViewMoPubAdUnitExpanderContent17.LinePosition = 14;
#endif
                }
                return _moPubSampleViewMoPubAdUnitExpanderContent17;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitGroup10;
        public static Template MoPubSampleViewMoPubAdUnitGroup10
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitGroup10 == null || _moPubSampleViewMoPubAdUnitGroup10.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitGroup10 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitGroup10 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewGroup10);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitGroup10.Name = "MoPubSampleViewMoPubAdUnitGroup10";
                    _moPubSampleViewMoPubAdUnitGroup10.LineNumber = 345;
                    _moPubSampleViewMoPubAdUnitGroup10.LinePosition = 18;
#endif
                }
                return _moPubSampleViewMoPubAdUnitGroup10;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpanderAdUnitIdLabel);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel.LineNumber = 346;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel.LinePosition = 22;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderAdUnitIdLabel;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataField);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField.LineNumber = 347;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField.LinePosition = 22;
#endif
                    Delight.InputField.InputFieldPlaceholderTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder);
                    Delight.InputField.TextAreaTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea);
                    Delight.InputField.InputTextTemplateProperty.SetDefault(_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField, MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText);
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataField;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder.LineNumber = 12;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputFieldPlaceholder;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldTextArea);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea.LineNumber = 13;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea.LinePosition = 4;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldTextArea;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText;
        public static Template MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText == null || _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewOnImpressionTrackedExpanderImpressionDataFieldInputText);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText.Name = "MoPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText";
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText.LineNumber = 14;
                    _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText.LinePosition = 6;
#endif
                }
                return _moPubSampleViewMoPubAdUnitOnImpressionTrackedExpanderImpressionDataFieldInputText;
            }
        }

        private static Template _moPubSampleViewMoPubAdUnitRegion38;
        public static Template MoPubSampleViewMoPubAdUnitRegion38
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewMoPubAdUnitRegion38 == null || _moPubSampleViewMoPubAdUnitRegion38.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewMoPubAdUnitRegion38 == null)
#endif
                {
                    _moPubSampleViewMoPubAdUnitRegion38 = new Template(MoPubAdUnitViewTemplates.MoPubAdUnitViewRegion38);
#if UNITY_EDITOR
                    _moPubSampleViewMoPubAdUnitRegion38.Name = "MoPubSampleViewMoPubAdUnitRegion38";
                    _moPubSampleViewMoPubAdUnitRegion38.LineNumber = 351;
                    _moPubSampleViewMoPubAdUnitRegion38.LinePosition = 10;
#endif
                }
                return _moPubSampleViewMoPubAdUnitRegion38;
            }
        }

        private static Template _moPubSampleViewRegion2;
        public static Template MoPubSampleViewRegion2
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewRegion2 == null || _moPubSampleViewRegion2.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewRegion2 == null)
#endif
                {
                    _moPubSampleViewRegion2 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubSampleViewRegion2.Name = "MoPubSampleViewRegion2";
                    _moPubSampleViewRegion2.LineNumber = 18;
                    _moPubSampleViewRegion2.LinePosition = 10;
#endif
                    Delight.Region.WidthProperty.SetDefault(_moPubSampleViewRegion2, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubSampleViewRegion2, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Region.MarginProperty.SetDefault(_moPubSampleViewRegion2, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _moPubSampleViewRegion2;
            }
        }

        private static Template _moPubSampleViewLabel1;
        public static Template MoPubSampleViewLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewLabel1 == null || _moPubSampleViewLabel1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewLabel1 == null)
#endif
                {
                    _moPubSampleViewLabel1 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubSampleViewLabel1.Name = "MoPubSampleViewLabel1";
                    _moPubSampleViewLabel1.LineNumber = 19;
                    _moPubSampleViewLabel1.LinePosition = 14;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubSampleViewLabel1, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubSampleViewLabel1, Delight.ElementAlignment.Left);
                    Delight.Label.MarginProperty.SetDefault(_moPubSampleViewLabel1, new ElementMargin(new ElementSize(-3f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubSampleViewLabel1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.TextAlignmentProperty.SetDefault(_moPubSampleViewLabel1, TMPro.TextAlignmentOptions.Center);
                    Delight.Label.FontSizeProperty.SetDefault(_moPubSampleViewLabel1, 48f);
                    Delight.Label.OffsetProperty.SetDefault(_moPubSampleViewLabel1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Label.HeightProperty.SetDefault(_moPubSampleViewLabel1, new ElementSize(120f, ElementSizeUnit.Pixels));
                    Delight.Label.TextProperty.SetDefault(_moPubSampleViewLabel1, "MoPub Unity Sample");
                }
                return _moPubSampleViewLabel1;
            }
        }

        private static Template _moPubSampleViewRegion3;
        public static Template MoPubSampleViewRegion3
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewRegion3 == null || _moPubSampleViewRegion3.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewRegion3 == null)
#endif
                {
                    _moPubSampleViewRegion3 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubSampleViewRegion3.Name = "MoPubSampleViewRegion3";
                    _moPubSampleViewRegion3.LineNumber = 20;
                    _moPubSampleViewRegion3.LinePosition = 14;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubSampleViewRegion3, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.OffsetProperty.SetDefault(_moPubSampleViewRegion3, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(-3f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubSampleViewRegion3, new UnityEngine.Color(0.8117647f, 0.8117647f, 0.8117647f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubSampleViewRegion3, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.AlignmentProperty.SetDefault(_moPubSampleViewRegion3, Delight.ElementAlignment.Bottom);
                }
                return _moPubSampleViewRegion3;
            }
        }

        private static Template _moPubSampleViewRegion4;
        public static Template MoPubSampleViewRegion4
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewRegion4 == null || _moPubSampleViewRegion4.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewRegion4 == null)
#endif
                {
                    _moPubSampleViewRegion4 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubSampleViewRegion4.Name = "MoPubSampleViewRegion4";
                    _moPubSampleViewRegion4.LineNumber = 21;
                    _moPubSampleViewRegion4.LinePosition = 14;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubSampleViewRegion4, new ElementSize(3f, ElementSizeUnit.Pixels));
                    Delight.Region.OffsetProperty.SetDefault(_moPubSampleViewRegion4, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubSampleViewRegion4, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubSampleViewRegion4, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.AlignmentProperty.SetDefault(_moPubSampleViewRegion4, Delight.ElementAlignment.Bottom);
                }
                return _moPubSampleViewRegion4;
            }
        }

        private static Template _moPubSampleViewRegion5;
        public static Template MoPubSampleViewRegion5
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewRegion5 == null || _moPubSampleViewRegion5.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewRegion5 == null)
#endif
                {
                    _moPubSampleViewRegion5 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubSampleViewRegion5.Name = "MoPubSampleViewRegion5";
                    _moPubSampleViewRegion5.LineNumber = 25;
                    _moPubSampleViewRegion5.LinePosition = 10;
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubSampleViewRegion5, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Region.WidthProperty.SetDefault(_moPubSampleViewRegion5, new ElementSize(1f, ElementSizeUnit.Percents));
                }
                return _moPubSampleViewRegion5;
            }
        }

        private static Template _moPubSampleViewGroup1;
        public static Template MoPubSampleViewGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewGroup1 == null || _moPubSampleViewGroup1.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewGroup1 == null)
#endif
                {
                    _moPubSampleViewGroup1 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _moPubSampleViewGroup1.Name = "MoPubSampleViewGroup1";
                    _moPubSampleViewGroup1.LineNumber = 26;
                    _moPubSampleViewGroup1.LinePosition = 14;
#endif
                    Delight.Group.OrientationProperty.SetDefault(_moPubSampleViewGroup1, Delight.ElementOrientation.Vertical);
                    Delight.Group.ContentAlignmentProperty.SetDefault(_moPubSampleViewGroup1, Delight.ElementAlignment.Bottom);
                    Delight.Group.HeightProperty.SetDefault(_moPubSampleViewGroup1, new ElementSize(150f, ElementSizeUnit.Pixels));
                    Delight.Group.AlignmentProperty.SetDefault(_moPubSampleViewGroup1, Delight.ElementAlignment.Bottom);
                    Delight.Group.WidthProperty.SetDefault(_moPubSampleViewGroup1, new ElementSize(1f, ElementSizeUnit.Percents));
                }
                return _moPubSampleViewGroup1;
            }
        }

        private static Template _moPubSampleViewRegion6;
        public static Template MoPubSampleViewRegion6
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewRegion6 == null || _moPubSampleViewRegion6.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewRegion6 == null)
#endif
                {
                    _moPubSampleViewRegion6 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubSampleViewRegion6.Name = "MoPubSampleViewRegion6";
                    _moPubSampleViewRegion6.LineNumber = 27;
                    _moPubSampleViewRegion6.LinePosition = 18;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubSampleViewRegion6, new ElementSize(3f, ElementSizeUnit.Pixels));
                    Delight.Region.OffsetProperty.SetDefault(_moPubSampleViewRegion6, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubSampleViewRegion6, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubSampleViewRegion6, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.AlignmentProperty.SetDefault(_moPubSampleViewRegion6, Delight.ElementAlignment.Bottom);
                }
                return _moPubSampleViewRegion6;
            }
        }

        private static Template _moPubSampleViewRegion7;
        public static Template MoPubSampleViewRegion7
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewRegion7 == null || _moPubSampleViewRegion7.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewRegion7 == null)
#endif
                {
                    _moPubSampleViewRegion7 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubSampleViewRegion7.Name = "MoPubSampleViewRegion7";
                    _moPubSampleViewRegion7.LineNumber = 28;
                    _moPubSampleViewRegion7.LinePosition = 18;
#endif
                    Delight.Region.HeightProperty.SetDefault(_moPubSampleViewRegion7, new ElementSize(2f, ElementSizeUnit.Pixels));
                    Delight.Region.OffsetProperty.SetDefault(_moPubSampleViewRegion7, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.BackgroundColorProperty.SetDefault(_moPubSampleViewRegion7, new UnityEngine.Color(0.8117647f, 0.8117647f, 0.8117647f, 1f));
                    Delight.Region.BackgroundMaterialProperty.SetDefault(_moPubSampleViewRegion7, Assets.Materials["UI-Fast-Default"]);
                    Delight.Region.AlignmentProperty.SetDefault(_moPubSampleViewRegion7, Delight.ElementAlignment.Bottom);
                }
                return _moPubSampleViewRegion7;
            }
        }

        private static Template _moPubSampleViewRegion8;
        public static Template MoPubSampleViewRegion8
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewRegion8 == null || _moPubSampleViewRegion8.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewRegion8 == null)
#endif
                {
                    _moPubSampleViewRegion8 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _moPubSampleViewRegion8.Name = "MoPubSampleViewRegion8";
                    _moPubSampleViewRegion8.LineNumber = 29;
                    _moPubSampleViewRegion8.LinePosition = 18;
#endif
                    Delight.Region.MarginProperty.SetDefault(_moPubSampleViewRegion8, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Region.WidthProperty.SetDefault(_moPubSampleViewRegion8, new ElementSize(1f, ElementSizeUnit.Percents));
                }
                return _moPubSampleViewRegion8;
            }
        }

        private static Template _moPubSampleViewPluginNameLabel;
        public static Template MoPubSampleViewPluginNameLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewPluginNameLabel == null || _moPubSampleViewPluginNameLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewPluginNameLabel == null)
#endif
                {
                    _moPubSampleViewPluginNameLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubSampleViewPluginNameLabel.Name = "MoPubSampleViewPluginNameLabel";
                    _moPubSampleViewPluginNameLabel.LineNumber = 30;
                    _moPubSampleViewPluginNameLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubSampleViewPluginNameLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubSampleViewPluginNameLabel, Delight.ElementAlignment.Bottom);
                    Delight.Label.MarginProperty.SetDefault(_moPubSampleViewPluginNameLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubSampleViewPluginNameLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubSampleViewPluginNameLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubSampleViewPluginNameLabel, 34f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubSampleViewPluginNameLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubSampleViewPluginNameLabel, Delight.AutoSize.Default);
                    Delight.Label.TextProperty.SetDefault(_moPubSampleViewPluginNameLabel, "plugin_name_placeholder");
                    Delight.Label.TextAlignmentProperty.SetDefault(_moPubSampleViewPluginNameLabel, TMPro.TextAlignmentOptions.Bottom);
                    Delight.Label.OffsetProperty.SetDefault(_moPubSampleViewPluginNameLabel, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(50f, ElementSizeUnit.Pixels)));
                }
                return _moPubSampleViewPluginNameLabel;
            }
        }

        private static Template _moPubSampleViewSdkNameLabel;
        public static Template MoPubSampleViewSdkNameLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_moPubSampleViewSdkNameLabel == null || _moPubSampleViewSdkNameLabel.CurrentVersion != Template.Version)
#else
                if (_moPubSampleViewSdkNameLabel == null)
#endif
                {
                    _moPubSampleViewSdkNameLabel = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _moPubSampleViewSdkNameLabel.Name = "MoPubSampleViewSdkNameLabel";
                    _moPubSampleViewSdkNameLabel.LineNumber = 32;
                    _moPubSampleViewSdkNameLabel.LinePosition = 22;
#endif
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_moPubSampleViewSdkNameLabel, false);
                    Delight.Label.AlignmentProperty.SetDefault(_moPubSampleViewSdkNameLabel, Delight.ElementAlignment.Bottom);
                    Delight.Label.MarginProperty.SetDefault(_moPubSampleViewSdkNameLabel, new ElementMargin(new ElementSize(30f, ElementSizeUnit.Pixels)));
                    Delight.Label.WidthProperty.SetDefault(_moPubSampleViewSdkNameLabel, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_moPubSampleViewSdkNameLabel, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontSizeProperty.SetDefault(_moPubSampleViewSdkNameLabel, 34f);
                    Delight.Label.FontColorProperty.SetDefault(_moPubSampleViewSdkNameLabel, new UnityEngine.Color(0.6666667f, 0.6666667f, 0.6666667f, 1f));
                    Delight.Label.AutoSizeProperty.SetDefault(_moPubSampleViewSdkNameLabel, Delight.AutoSize.Default);
                    Delight.Label.TextProperty.SetDefault(_moPubSampleViewSdkNameLabel, "sdk_name_placeholder");
                    Delight.Label.TextAlignmentProperty.SetDefault(_moPubSampleViewSdkNameLabel, TMPro.TextAlignmentOptions.Center);
                }
                return _moPubSampleViewSdkNameLabel;
            }
        }

        #endregion
    }

    #endregion
}
