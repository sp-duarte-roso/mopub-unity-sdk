﻿#region Using Statements
using System;
using System.Collections.Generic;
#endregion

namespace Delight
{
    public class XmlEditorUndoInfo
    {
        public List<string> Lines;
        public bool NeedReparse;
        public int CaretX;
        public int CaretY;
    }
}