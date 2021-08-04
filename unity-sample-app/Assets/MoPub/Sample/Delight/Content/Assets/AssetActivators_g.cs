// Asset data activators generated from parsed views and assets
#region Using Statements
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public static partial class Assets
    {
        static Assets()
        {
            ViewActivators = new Dictionary<string, Func<View, View, string, Template, bool, View>>();
            ViewActivators.Add("MoPubAdUnitListView", (x, y, z, w, a) => new MoPubAdUnitListView(x, y, z, w, a));
            ViewActivators.Add("UIView", (x, y, z, w, a) => new UIView(x, y, z, w, a));
            ViewActivators.Add("Group", (x, y, z, w, a) => new Group(x, y, z, w, a));
            ViewActivators.Add("Region", (x, y, z, w, a) => new Region(x, y, z, w, a));
            ViewActivators.Add("Label", (x, y, z, w, a) => new Label(x, y, z, w, a));
            ViewActivators.Add("List", (x, y, z, w, a) => new List(x, y, z, w, a));
            ViewActivators.Add("ListItem", (x, y, z, w, a) => new ListItem(x, y, z, w, a));
            ViewActivators.Add("Image", (x, y, z, w, a) => new Image(x, y, z, w, a));
            ViewActivators.Add("MoPubAdUnitView", (x, y, z, w, a) => new MoPubAdUnitView(x, y, z, w, a));
            ViewActivators.Add("Button", (x, y, z, w, a) => new Button(x, y, z, w, a));
            ViewActivators.Add("InputField", (x, y, z, w, a) => new InputField(x, y, z, w, a));
            ViewActivators.Add("Expander", (x, y, z, w, a) => new Expander(x, y, z, w, a));
            ViewActivators.Add("ExpanderHeader", (x, y, z, w, a) => new ExpanderHeader(x, y, z, w, a));
            ViewActivators.Add("ExpanderContent", (x, y, z, w, a) => new ExpanderContent(x, y, z, w, a));
            ViewActivators.Add("MoPubSampleView", (x, y, z, w, a) => new MoPubSampleView(x, y, z, w, a));
            ViewActivators.Add("LayoutGrid", (x, y, z, w, a) => new LayoutGrid(x, y, z, w, a));
            ViewActivators.Add("ScrollableRegion", (x, y, z, w, a) => new ScrollableRegion(x, y, z, w, a));
            ViewActivators.Add("ViewSwitcher", (x, y, z, w, a) => new ViewSwitcher(x, y, z, w, a));
            ViewActivators.Add("SceneObjectView", (x, y, z, w, a) => new SceneObjectView(x, y, z, w, a));
            ViewActivators.Add("UIImageView", (x, y, z, w, a) => new UIImageView(x, y, z, w, a));
            ViewActivators.Add("CanvasRendererView", (x, y, z, w, a) => new CanvasRendererView(x, y, z, w, a));
            ViewActivators.Add("CheckBox", (x, y, z, w, a) => new CheckBox(x, y, z, w, a));
            ViewActivators.Add("Collection", (x, y, z, w, a) => new Collection(x, y, z, w, a));
            ViewActivators.Add("ComboBox", (x, y, z, w, a) => new ComboBox(x, y, z, w, a));
            ViewActivators.Add("ComboBoxListItem", (x, y, z, w, a) => new ComboBoxListItem(x, y, z, w, a));
            ViewActivators.Add("UICanvas", (x, y, z, w, a) => new UICanvas(x, y, z, w, a));
            ViewActivators.Add("DefaultExpanderHeader", (x, y, z, w, a) => new DefaultExpanderHeader(x, y, z, w, a));
            ViewActivators.Add("Frame", (x, y, z, w, a) => new Frame(x, y, z, w, a));
            ViewActivators.Add("GridSplitter", (x, y, z, w, a) => new GridSplitter(x, y, z, w, a));
            ViewActivators.Add("GridSplitterHandle", (x, y, z, w, a) => new GridSplitterHandle(x, y, z, w, a));
            ViewActivators.Add("LayoutRoot", (x, y, z, w, a) => new LayoutRoot(x, y, z, w, a));
            ViewActivators.Add("NavigationButton", (x, y, z, w, a) => new NavigationButton(x, y, z, w, a));
            ViewActivators.Add("Mask", (x, y, z, w, a) => new Mask(x, y, z, w, a));
            ViewActivators.Add("Navigator", (x, y, z, w, a) => new Navigator(x, y, z, w, a));
            ViewActivators.Add("RadioButton", (x, y, z, w, a) => new RadioButton(x, y, z, w, a));
            ViewActivators.Add("RawImage", (x, y, z, w, a) => new RawImage(x, y, z, w, a));
            ViewActivators.Add("RectMask2D", (x, y, z, w, a) => new RectMask2D(x, y, z, w, a));
            ViewActivators.Add("Scrollbar", (x, y, z, w, a) => new Scrollbar(x, y, z, w, a));
            ViewActivators.Add("SelectionIndicator", (x, y, z, w, a) => new SelectionIndicator(x, y, z, w, a));
            ViewActivators.Add("Slider", (x, y, z, w, a) => new Slider(x, y, z, w, a));
            ViewActivators.Add("Tab", (x, y, z, w, a) => new Tab(x, y, z, w, a));
            ViewActivators.Add("TabHeader", (x, y, z, w, a) => new TabHeader(x, y, z, w, a));
            ViewActivators.Add("TabPanel", (x, y, z, w, a) => new TabPanel(x, y, z, w, a));
            ViewActivators.Add("ToggleGroup", (x, y, z, w, a) => new ToggleGroup(x, y, z, w, a));

            ViewTypes = new Dictionary<string, Type>();
            ViewTypes.Add("MoPubAdUnitListView", typeof(MoPubAdUnitListView));
            ViewTypes.Add("UIView", typeof(UIView));
            ViewTypes.Add("Group", typeof(Group));
            ViewTypes.Add("Region", typeof(Region));
            ViewTypes.Add("Label", typeof(Label));
            ViewTypes.Add("List", typeof(List));
            ViewTypes.Add("ListItem", typeof(ListItem));
            ViewTypes.Add("Image", typeof(Image));
            ViewTypes.Add("MoPubAdUnitView", typeof(MoPubAdUnitView));
            ViewTypes.Add("Button", typeof(Button));
            ViewTypes.Add("InputField", typeof(InputField));
            ViewTypes.Add("Expander", typeof(Expander));
            ViewTypes.Add("ExpanderHeader", typeof(ExpanderHeader));
            ViewTypes.Add("ExpanderContent", typeof(ExpanderContent));
            ViewTypes.Add("MoPubSampleView", typeof(MoPubSampleView));
            ViewTypes.Add("LayoutGrid", typeof(LayoutGrid));
            ViewTypes.Add("ScrollableRegion", typeof(ScrollableRegion));
            ViewTypes.Add("ViewSwitcher", typeof(ViewSwitcher));
            ViewTypes.Add("SceneObjectView", typeof(SceneObjectView));
            ViewTypes.Add("UIImageView", typeof(UIImageView));
            ViewTypes.Add("CanvasRendererView", typeof(CanvasRendererView));
            ViewTypes.Add("CheckBox", typeof(CheckBox));
            ViewTypes.Add("Collection", typeof(Collection));
            ViewTypes.Add("ComboBox", typeof(ComboBox));
            ViewTypes.Add("ComboBoxListItem", typeof(ComboBoxListItem));
            ViewTypes.Add("UICanvas", typeof(UICanvas));
            ViewTypes.Add("DefaultExpanderHeader", typeof(DefaultExpanderHeader));
            ViewTypes.Add("Frame", typeof(Frame));
            ViewTypes.Add("GridSplitter", typeof(GridSplitter));
            ViewTypes.Add("GridSplitterHandle", typeof(GridSplitterHandle));
            ViewTypes.Add("LayoutRoot", typeof(LayoutRoot));
            ViewTypes.Add("NavigationButton", typeof(NavigationButton));
            ViewTypes.Add("Mask", typeof(Mask));
            ViewTypes.Add("Navigator", typeof(Navigator));
            ViewTypes.Add("RadioButton", typeof(RadioButton));
            ViewTypes.Add("RawImage", typeof(RawImage));
            ViewTypes.Add("RectMask2D", typeof(RectMask2D));
            ViewTypes.Add("Scrollbar", typeof(Scrollbar));
            ViewTypes.Add("SelectionIndicator", typeof(SelectionIndicator));
            ViewTypes.Add("Slider", typeof(Slider));
            ViewTypes.Add("Tab", typeof(Tab));
            ViewTypes.Add("TabHeader", typeof(TabHeader));
            ViewTypes.Add("TabPanel", typeof(TabPanel));
            ViewTypes.Add("ToggleGroup", typeof(ToggleGroup));

            AttachedPropertyActivators = new Dictionary<string, Func<View, string, AttachedProperty>>();
            AttachedPropertyActivators.Add("System.Int32", (x, y) => new AttachedProperty<System.Int32>(x, y));
            AttachedPropertyActivators.Add("System.Boolean", (x, y) => new AttachedProperty<System.Boolean>(x, y));
            AttachedPropertyActivators.Add("Delight.CellIndex", (x, y) => new AttachedProperty<Delight.CellIndex>(x, y));
            AttachedPropertyActivators.Add("System.String", (x, y) => new AttachedProperty<System.String>(x, y));
        }
    }
}
