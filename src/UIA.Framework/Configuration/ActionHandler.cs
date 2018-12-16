﻿namespace UIA.Framework.Configuration
{
    using System;
    using UIA.Framework.Helpers;

    /// <summary>
    /// Action handling to add logging, timeout and other intercepting actions.
    /// </summary>
    internal class ActionHandler
    {
        /// <summary>
        /// Performing action with void return type.
        /// </summary>
        /// <param name="action">Any action with void return type.</param>
        public static void Perform(Action action)
        {
            Wait.Milliseconds(Timeouts.Action);
            action.Invoke();
        }

        /// <summary>
        /// Performing action with any but void return type.
        /// </summary>
        /// <param name="action">Any action with any return type.</param>
        /// <typeparam name="T">Any return type</typeparam>
        /// <returns>Returns <paramreftype name="T"/> object for further invocation.</returns>
        public static T Perform<T>(Func<T> action)
        {
            Wait.Milliseconds(Timeouts.Action);
            return action.Invoke();
        }
    }
}