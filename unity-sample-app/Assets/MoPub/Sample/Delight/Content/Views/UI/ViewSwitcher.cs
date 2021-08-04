#region Using Statements
using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
#endregion

namespace Delight
{
    /// <summary>
    /// Provides logic for switching between mutliple child views and displaying one at a time. By default the views are enabled when they are displayed, behavior can be changed through the SwitchMode property. 
    /// </summary>
    public partial class ViewSwitcher
    {
        #region Fields

        public Stack<View> ViewStack { get; set; } = new Stack<View>();
        public SceneObjectView ActiveView;

        #endregion

        #region Methods

        /// <summary>
        /// Called before the view is loaded.
        /// </summary>
        protected override void BeforeLoad()
        {
            if (IgnoreObject)
                return;
            base.BeforeLoad();

            ViewStack = new Stack<View>();
            var firstChild = Content.LayoutChildren.FirstOrDefault();

            // make sure load-mode is set to Manual in children if we're loading them
            foreach (SceneObjectView child in Content.LayoutChildren)
            {
                if (!String.IsNullOrEmpty(StartView) && child.Id.IEquals(StartView))
                {
                    ActiveView = child;
                    continue;
                }

                if (ShowFirstByDefault && child == firstChild)
                {
                    ActiveView = child;
                    continue;
                }

                var childLoadMode = child.LoadMode | ChildLoadMode;
                if (SwitchMode == SwitchMode.Load || SwitchMode == SwitchMode.LoadOnce)
                {
                    var loadMode = childLoadMode | LoadMode.Manual;
                    child.LoadMode = loadMode;
                }
                else
                {
                    childLoadMode &= ~LoadMode.Manual; // remove any manual flag to force automatic if we're activating them
                    child.LoadMode = childLoadMode;
                    if (SwitchMode == SwitchMode.Enable)
                    {
                        child.IsActive = false;
                    }
                }
            }
        }

        /// <summary>
        /// Called after the view is loaded.
        /// </summary>
        protected override void AfterLoad()
        {
            if (IgnoreObject)
                return;
            base.AfterLoad();

            // load active view if it hasn't been loaded
            if (ActiveView != null)
            {
                if (SwitchMode != SwitchMode.Manual)
                {
                    if (!ActiveView.IsLoaded)
                    {
                        ActiveView.Load();
                    }

                    if (!ActiveView.IsActive)
                    {
                        ActiveView.IsActive = true;
                    }
                }

                if (ActiveView.IsLoaded)
                {
                    ActiveView.Setup(null);
                }
            }
        }

        /// <summary>
        /// Switches to view at index.
        /// </summary>
        public void SwitchTo(int index, object data = null)
        {
            var view = Content.LayoutChildren.ElementAtOrDefault(index);
            SwitchTo(view, data);
        }

        /// <summary>
        /// Switches to the view specified.
        /// </summary>
        public void SwitchTo(View view, object data = null)
        {
            if (view == ActiveView)
                return;

            if (ActiveView != null)
            {
                if (SwitchMode == SwitchMode.Load)
                {
                    ActiveView.Unload();
                }
                else
                {
                    ActiveView.IsActive = false;
                }
            }

            ActiveView = view as SceneObjectView;
            if (ActiveView == null)
                return;

            // load/activate view
            ActiveView.Load();
            ActiveView.IsActive = true;
            ActiveView.Setup(data);
        }

        /// <summary>
        /// Switches to view at index.
        /// </summary>
        public async Task SwitchToAsync(int index, object data = null)
        {
            var view = Content.LayoutChildren.ElementAtOrDefault(index);
            await SwitchToAsync(view, data);
        }

        /// <summary>
        /// Switches to the view specified.
        /// </summary>
        public async Task SwitchToAsync(View view, object data = null)
        {
            if (view == ActiveView)
                return;

            if (ActiveView != null)
            {
                if (SwitchMode == SwitchMode.Load)
                {
                    ActiveView.Unload();
                }
                else
                {
                    ActiveView.IsActive = false;
                }
            }

            ActiveView = view as SceneObjectView;
            if (ActiveView == null)
                return;

            // load/activate view
            await ActiveView.LoadAsync();
            ActiveView.IsActive = true;
            ActiveView.Setup(data);
        }

        /// <summary>
        /// Pushes active view on the stack and switches to new view.
        /// </summary>
        public void Push(View view, object data = null)
        {
            if (ActiveView != null)
            {
                ViewStack.Push(ActiveView);
            }
            SwitchTo(view, data);
        }

        /// <summary>
        /// Pops view on the stack and switches to it.
        /// </summary>
        public void Pop()
        {
            if (ViewStack.Count > 0)
            {
                SwitchTo(ViewStack.Pop());
            }
        }

        /// <summary>
        /// Switches to next view.
        /// </summary>
        public void Next(bool cycle = true, object data = null)
        {
            int index = ActiveView != null ? Content.LayoutChildren.IndexOf(ActiveView) + 1 : 0;
            if (index >= Content.LayoutChildren.Count)
            {
                if (cycle)
                {
                    index = 0;
                }
                else
                {
                    return;
                }
            }

            SwitchTo(index, data);
        }

        /// <summary>
        /// Switches to previous view.
        /// </summary>
        public void Previous(bool cycle = true, object data = null)
        {
            int index = ActiveView != null ? Content.LayoutChildren.IndexOf(ActiveView) - 1 : 0;
            if (index < 0)
            {
                if (cycle)
                {
                    index = Content.LayoutChildren.Count - 1;
                }
                else
                {
                    return;
                }
            }

            SwitchTo(index, data);
        }

        #endregion
    }
}
