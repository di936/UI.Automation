﻿using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    interface IGrid
    {
        int ColumnCount { get; }
        int RowCount { get; }
        AutomationElement GetItem(int row, int column);
    }
}