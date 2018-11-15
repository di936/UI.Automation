using System;

namespace UIA.Framework.Devices.Commands
{
    [Flags]
    internal enum KeyboardCommands
    {
        ExtendedKey = 0x0001,
        KeyUp = 0x0002
    }
}