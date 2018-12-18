namespace UIA.Framework.Configuration
{
    using System;
    using System.Diagnostics;
    using System.Timers;
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
        /// <param name="timeout">Timeout.</param>
        /// <typeparam name="T">Any return type</typeparam>
        public static void Perform(Action action, int timeout)
        {
            var timer = new Stopwatch();
            timer.Start();
            do
            {
                try
                {
                    Wait.Milliseconds(Timeouts.Action);
                    action.Invoke();
                    return;
                }
                catch (Exception ex)
                {
                    if (timer.ElapsedMilliseconds < timeout)
                    {
                        continue;
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }
            while (true);
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

        /// <summary>
        /// Performing action with any but void return type.
        /// </summary>
        /// <param name="action">Any action with any return type.</param>
        /// <param name="timeout">Timeout.</param>
        /// <typeparam name="T">Any return type</typeparam>
        /// <returns>Returns <paramreftype name="T"/> object for further invocation.</returns>
        public static T Perform<T>(Func<T> action, int timeout)
        {
            var timer = new Stopwatch();
            timer.Start();
            do
            {
                try
                {
                    Wait.Milliseconds(Timeouts.Action);
                    return action.Invoke();
                }
                catch (Exception ex)
                {
                    if (timer.ElapsedMilliseconds < timeout)
                    {
                        continue;
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }
            while (true);
        }
    }
}