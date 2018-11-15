﻿using System;

namespace UIA.Framework.Devices.Commands
{
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
}