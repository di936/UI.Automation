using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace UIA.Framework.Devices
{
    public class Cursor
    {
        private readonly int _value;

        [StructLayout(LayoutKind.Sequential)]
        public struct CursorInfo
        {
            public uint size;
            public uint flags;
            public IntPtr handle;
            public Point point;

            public static CursorInfo New()
            {
                return new CursorInfo { size = (uint)Marshal.SizeOf(typeof(CursorInfo)) };
            }
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorInfo(ref CursorInfo cursorInfo);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref System.Drawing.Point cursorInfo);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursor(IntPtr hInstance, IDC_STANDARD_CURSORS lpCursorName);

        [DllImport("user32.dll")]
        public static extern IntPtr SetCursor(IntPtr hCursor);

        public enum IDC_STANDARD_CURSORS
        {
            IDC_ARROW = 32512,
            IDC_IBEAM = 32513,
            IDC_WAIT = 32514,
            IDC_CROSS = 32515,
            IDC_UPARROW = 32516,
            IDC_SIZE = 32640,
            IDC_ICON = 32641,
            IDC_SIZENWSE = 32642,
            IDC_SIZENESW = 32643,
            IDC_SIZEWE = 32644,
            IDC_SIZENS = 32645,
            IDC_SIZEALL = 32646,
            IDC_NO = 32648,
            IDC_HAND = 32649,
            IDC_APPSTARTING = 32650,
            IDC_HELP = 32651
        }

        public static Cursor IShapedCursor = new Cursor(IDC_STANDARD_CURSORS.IDC_IBEAM);
        public static Cursor Pointer = new Cursor(IDC_STANDARD_CURSORS.IDC_ARROW);
        public static readonly Cursor DefaultAndWait = new Cursor(IDC_STANDARD_CURSORS.IDC_APPSTARTING);
        public static readonly Cursor Wait = new Cursor(IDC_STANDARD_CURSORS.IDC_WAIT);

        static Cursor()
        {
            WaitCursors.Add(DefaultAndWait);
            WaitCursors.Add(Wait);
            WaitCursors.AddRange(DynamicWaitCursors());
        }

        public Cursor(int value)
        {
            _value = value;
        }

        private Cursor(IDC_STANDARD_CURSORS cursor)
        {
            _value = LoadCursor(IntPtr.Zero, cursor).ToInt32();
        }

        public static List<Cursor> DynamicWaitCursors()
        {
            return new List<Cursor> {new Cursor(Cursors.WaitCursor.Handle.ToInt32())};
        }

        public static List<Cursor> WaitCursors { get; } = new List<Cursor>();

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Cursor)) return false;
            return ((Cursor) obj)._value == _value;
        }

        public override int GetHashCode()
        {
            return _value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}