namespace UIA.Framework.Helpers
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows;

    /// <summary>
    /// Standard cursors.
    /// </summary>
    [Flags]
    internal enum StandardCursors
    {
        Arrow = 32512,
        IBeam = 32513,
        Wait = 32514,
        Cross = 32515,
        UpArrow = 32516,
        Size = 32640,
        Icon = 32641,
        SizeNWSE = 32642,
        SizeNESW = 32643,
        SizeWE = 32644,
        SizeNS = 32645,
        SizeAll = 32646,
        No = 32648,
        Hand = 32649,
        AppStarting = 32650,
        Help = 32651
    }

    /// <summary>
    /// Standard mouse commands.
    /// </summary>
    [Flags]
    internal enum MouseCommands
    {
        Absolute = 0x8000,
        LeftDown = 0x0002,
        LeftUp = 0x0004,
        MiddleDown = 0x0020,
        MiddleUp = 0x0040,
        Move = 0x0001,
        RightDown = 0x0008,
        RightUp = 0x0010,
        WheelMove = 0x0800,
        XDown = 0x0080,
        XUp = 0x0100,
        Wheel = 0x0800,
        HWheel = 0x01000
    }

    /// <summary>
    /// System metrics for coordinates positioning.
    /// </summary>
    [Flags]
    internal enum SystemMetric
    {
        SM_CXScreen = 0,
        SM_CYScreen = 1,
    }

    /// <summary>
    /// Standard keyboard commands
    /// </summary>
    [Flags]
    internal enum KeyboardCommands
    {
        ExtendedKey = 0x0001,
        KeyUp = 0x0002
    }

    /// <summary>
    /// Standard keyboard keys.
    /// </summary>
    [Flags]
    internal enum VirtualKeys
    {
        LButton = 0x01,
        RButton = 0x02,
        Cancel = 0x03,
        MButtom = 0x04,
        XButton1 = 0x05,
        XButton2 = 0x06,
        Back = 0x08,
        Tab = 0x09,
        Clear = 0x0C,
        Return = 0x0D,
        Shift = 0x10,
        Control = 0x11,
        Menu = 0x12,
        Pause = 0x13,
        Capital = 0x14,
        Kana = 0x15,
        Hanguel = 0x15,
        Hangul = 0x15,
        Junja = 0x17,
        Final = 0x18,
        Hanja = 0x19,
        Kanji = 0x19,
        Escape = 0x1B,
        Convert = 0x1C,
        NonConvert = 0x1D,
        Accept = 0x1E,
        ModeChange = 0x1F,
        Space = 0x20,
        Prior = 0x21,
        Next = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25,
        Up = 0x26,
        Right = 0x27,
        Down = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        Snapshot = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,
        Key0 = 0x30,
        Key1 = 0x31,
        Key2 = 0x32,
        Key3 = 0x33,
        Key4 = 0x34,
        Key5 = 0x35,
        Key6 = 0x36,
        Key7 = 0x37,
        Key8 = 0x38,
        Key9 = 0x39,
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,
        LWin = 0x5B,
        RWin = 0x5C,
        Apps = 0x5D,
        Sleep = 0x5F,
        Numpad0 = 0x60,
        Numpad1 = 0x61,
        Numpad2 = 0x62,
        Numpad3 = 0x63,
        Numpad4 = 0x64,
        Numpad5 = 0x65,
        Numpad6 = 0x66,
        Numpad7 = 0x67,
        Numpad8 = 0x68,
        Numpad9 = 0x69,
        Multiply = 0x6A,
        Add = 0x6B,
        Separator = 0x6C,
        Substract = 0x6D,
        Decimal = 0x6E,
        Divide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
        NumLock = 0x90,
        Scroll = 0x91,
        LShift = 0xA0,
        RShift = 0xA1,
        LControl = 0xA2,
        RControl = 0xA3,
        LMenu = 0xA4,
        RMenu = 0xA5,
        Browser_Back = 0xA6,
        Browser_FORWARD = 0xA7,
        Browser_Refresh = 0xA8,
        Browser_Stop = 0xA9,
        Browser_Search = 0xAA,
        Browser_Favourites = 0xAB,
        Browser_Home = 0xAC,
        Volume_Mute = 0xAD,
        Volume_Down = 0xAE,
        Volume_Up = 0xAF,
        Media_Next_Track = 0xB0,
        Media_Prev_Track = 0xB1,
        Media_Stop = 0xB2,
        Media_Play_Pause = 0xB3,
        Launch_Mail = 0xB4,
        Launch_Media_Select = 0xB5,
        Launch_App1 = 0xB6,
        Launch_App2 = 0xB7,
        OEM_1 = 0xBA,
        OEM_Plus = 0xBB,
        OEM_Comma = 0xBC,
        OEM_Minus = 0xBD,
        OEM_Period = 0xBE,
        OEM_2 = 0xBF,
        OEM_3 = 0xC0,
        OEM_4 = 0xDB,
        OEM_5 = 0xDC,
        OEM_6 = 0xDD,
        OEM_7 = 0xDE,
        OEM_8 = 0xDF,
        OEM_102 = 0xE2,
        ProcessKey = 0xE5,
        Packet = 0xE7,
        ATTN = 0xF6,
        CRSEL = 0xF7,
        EXSEL = 0xF8,
        EREOF = 0xF9,
        Play = 0xFA,
        Zoom = 0xFB,
        NoName = 0xFC,
        PA1 = 0xFD,
        OEM_Clear = 0xFE
    }

    /// <summary>
    /// Struct for cursor.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct CursorInfo
    {
        public uint Size;
        public uint Flags;
        public IntPtr Handle;
        public Point Point;

        public static CursorInfo New()
        {
            return new CursorInfo { Size = (uint)Marshal.SizeOf(typeof(CursorInfo)) };
        }
    }

    /// <summary>
    /// External WindowsAPI methods.
    /// </summary>
    internal static class WindowsAPI
    {
        /// <summary>
        /// Calculate absolute coordinate X.
        /// </summary>
        /// <param name="x">Coordinate X.</param>
        /// <returns>Absolute coordinate X.</returns>
        public static int CalculateAbsoluteCoordinateX(int x) => (x * 65536) / GetSystemMetrics(SystemMetric.SM_CXScreen);

        /// <summary>
        /// Calculate absolute coordinate Y.
        /// </summary>
        /// <param name="y">Coordinate Y.</param>
        /// <returns>Absolute coordinate Y.</returns>
        public static int CalculateAbsoluteCoordinateY(int y) => (y * 65536) / GetSystemMetrics(SystemMetric.SM_CYScreen);

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        public static extern void MouseEvent(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(SystemMetric smIndex);

        [DllImport("user32.dll")]
        public static extern bool GetCursorInfo(ref CursorInfo cursorInfo);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref Point cursorInfo);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursor(IntPtr hInstance, StandardCursors lpCursorName);

        [DllImport("user32.dll")]
        public static extern IntPtr SetCursor(IntPtr hCursor);

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void KeyboardEvent(int bVk, int bScan, int dwFlags, int dwExtraInfo);
    }
}