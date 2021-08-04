#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
#endregion

namespace Delight
{
    public partial class MoPubAdUnitListView
    {
        public void AdUnitClickHandler(MoPubAdUnit adUnit)
        {
            ShowAdUnit?.Invoke(this, adUnit);
        }
    }
}
