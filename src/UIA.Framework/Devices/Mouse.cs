using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using UIA.Framework.Devices.Commands;
using UIA.Framework.Devices.Inputs;

namespace UIA.Framework.Devices
{
    public static class Mouse
    {
        private static Point screen = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        private static extern void MouseEvent(uint flags, int x, int y, int data, ulong extraInfo);

        [DllImport("user32.dll", EntryPoint = "CreateCursor")]
        private static extern void CreateCursor(IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, byte[] pvANDPlane, byte[] pvXORPlane);

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(ref CursorInfo cursorInfo);

        [DllImport("user32.dll")]

        static extern bool GetCursorPos(ref System.Drawing.Point cursorInfo);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern void SetCursorPos(int x, int y);

        [DllImport("user32", EntryPoint = "SendInput")]
        static extern int SendInput(uint numberOfInputs, ref Input input, int structSize);

        [DllImport("user32", EntryPoint = "SendInput")]
        static extern int SendInput64(int numberOfInputs, ref Input64 input, int structSize);

        public static MouseCursor Cursor
        {
            get
            {
                CursorInfo cursorInfo = CursorInfo.New();
                GetCursorInfo(ref cursorInfo);
                int i = cursorInfo.handle.ToInt32();
                return new MouseCursor(i);
            }
        }

        public static void Click(double x, double y)
        {
            SetCursorPos((int)x, (int)y);
            var input = new Input()
            {
                mi = new MouseInput((int) MouseCommands.LeftDown | (int) MouseCommands.LeftUp, IntPtr.Zero)
            };

            SendInput(1, ref input, Marshal.SizeOf(typeof(Input)));
        }
    }
}