using System;
using UIA.Framework.Helpers;

namespace UIA.Framework.Configuration
{
    internal class ActionHandler
    {
        public static void Perform(Action action)
        {
            Wait.Milliseconds(Timeouts.Action);
            action.Invoke();
        }

        public static T Perform<T>(Func<T> action)
        {
            Wait.Milliseconds(Timeouts.Action);
            return action.Invoke();
        }
    }
}
