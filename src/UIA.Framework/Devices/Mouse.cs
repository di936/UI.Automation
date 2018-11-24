using System;
using System.Runtime.InteropServices;
using UIA.Framework.Configuration;
using UIA.Framework.Helpers;

namespace UIA.Framework.Devices
{
    public class Mouse
    {
        [Flags]
        private enum MouseCommands
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

        private enum SystemMetric
        {
            SM_CXSCREEN = 0,
            SM_CYSCREEN = 1,
        }

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        private static extern void MouseEvent(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(SystemMetric smIndex);

        private static int CalculateAbsoluteCoordinateX(int x)
        {
            return (x * 65536) / GetSystemMetrics(SystemMetric.SM_CXSCREEN);
        }

        private static int CalculateAbsoluteCoordinateY(int y)
        {
            return (y * 65536) / GetSystemMetrics(SystemMetric.SM_CYSCREEN);
        }

        public static void Click(double x, double y)
        {
            MouseEvent((int)MouseCommands.Absolute | (int)MouseCommands.Move, CalculateAbsoluteCoordinateX((int)x), CalculateAbsoluteCoordinateY((int)y), 0, 0);
            Wait.Milliseconds(Timeouts.Device);
            MouseEvent((int)MouseCommands.LeftDown | (int)MouseCommands.LeftUp, 0, 0, 0, 0);
        }
    }
}