namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Automation;

    /// <summary>
    /// Every element should implement following properties and methods.
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// Gets a string containing the accelerator key combinations for the element.
        /// </summary>
        string AcceleratorKey { get; }

        /// <summary>
        /// Gets a string containing the access key character for the element.
        /// </summary>
        string AccessKey { get; }

        /// <summary>
        /// Gets a string containing the UI Automation identifier (ID) for the element.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets the coordinates of the rectangle that completely encloses the element.
        /// </summary>
        Rect BoundingRectangle { get; }

        /// <summary>
        /// Gets a string containing the class name of the element as assigned by the control developer.
        /// </summary>
        string ClassName { get; }

        /// <summary>
        /// Gets the <see cref="ControlType"/> of the element.
        /// </summary>
        ControlType RawType { get; }

        /// <summary>
        /// Gets the name of the underlying UI framework.
        /// </summary>
        string FrameworkId { get; }

        /// <summary>
        /// Gets a value indicating whether the element has keyboard focus.
        /// </summary>
        bool HasKeyboardFocus { get; }

        /// <summary>
        /// Gets the help text associated with the element.
        /// </summary>
        string HelpText { get; }

        /// <summary>
        /// Gets a value indicating whether the element is a content element.
        /// </summary>
        bool IsContentElement { get; }

        /// <summary>
        /// Gets a value indicating whether the element is viewed as a control.
        /// </summary>
        bool IsControlElement { get; }

        /// <summary>
        /// Gets a value indicating whether the user interface (UI) item referenced by the UI Automation element is enabled.
        /// </summary>
        bool IsEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether the UI Automation element can accept keyboard focus.
        /// </summary>
        bool IsKeyboardFocusable { get; }

        /// <summary>
        /// Gets a value indicating whether the UI Automation element is visible on the screen.
        /// </summary>
        bool IsOffscreen { get; }

        /// <summary>
        /// Gets a value indicating whether the UI Automation element contains protected content.
        /// </summary>
        bool IsPassword { get; }

        /// <summary>
        /// Gets a value indicating whether the UI Automation element is required to be filled out on a form.
        /// </summary>
        bool IsRequiredForForm { get; }

        /// <summary>
        /// Gets a description of the status of an item within an element.
        /// </summary>
        string ItemStatus { get; }

        /// <summary>
        /// Gets a description of the type of an item.
        /// </summary>
        string ItemType { get; }

        /// <summary>
        /// Gets the element that contains the text label for this element.
        /// </summary>
        AutomationElement LabeledBy { get; }

        /// <summary>
        /// Gets a description of the control type.
        /// </summary>
        string LocalizedControlType { get; }

        /// <summary>
        /// Gets the name of the element.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the handle of the element's window.
        /// </summary>
        int WindowHandle { get; }

        /// <summary>
        /// Gets the orientation of the control.
        /// </summary>
        OrientationType Orientation { get; }

        /// <summary>
        /// Gets the process identifier (ID) of this element.
        /// </summary>
        int ProcessId { get; }

        /// <summary>
        /// Retrieves a point on the <see cref="AutomationElement"/> that can be clicked.
        /// </summary>
        /// <returns>The physical screen coordinates of a point that can be used by a client to click on this element.</returns>
        Point GetClickablePoint();

        /// <summary>
        /// Retrieves the control patterns that this <see cref="AutomationElement"/> supports.
        /// </summary>
        /// <returns>An array of <see cref="AutomationPattern"/> objects that represent the supported control patterns.</returns>
        List<AutomationPattern> GetSupportedPatterns();

        /// <summary>
        /// Retrieves the identifiers of properties supported by the element.
        /// </summary>
        /// <returns>An array of supported property identifiers.</returns>
        List<AutomationProperty> GetSupportedProperties();

        /// <summary>
        /// Retrieves the specified pattern object on this <see cref="AutomationElement"/>.
        /// </summary>
        /// <param name="pattern">The identifier of the pattern to retrieve.</param>
        /// <returns>The pattern object, if the specified pattern is currently supported by the <see cref="AutomationElement"/>.</returns>
        object GetCurrentPattern(AutomationPattern pattern);

        /// <summary>
        /// Retrieves the current value of the specified property from an <see cref="AutomationElement"/>.
        /// </summary>
        /// <param name="property">The UI Automation property identifier specifying which property to retrieve.</param>
        /// <returns>An object containing the value of the specified property.</returns>
        object GetCurrentPropertyValue(AutomationProperty property);

        /// <summary>
        /// Retrieves the current value of the specified property from an <see cref="AutomationElement"/>.
        /// </summary>
        /// <param name="property">The UI Automation property identifier specifying which property to retrieve.</param>
        /// <param name="ignoreDefaultValue">A value that specifies whether a default value should be ignored if the specified property is supported.</param>
        /// <returns>An object containing the value of the specified property, or NotSupported if the element does not supply a value and <paramref name="ignoreDefaultValue"/> is True.</returns>
        object GetCurrentPropertyValue(AutomationProperty property, bool ignoreDefaultValue);

        /// <summary>
        /// Sets focus on the <see cref="AutomationElement"/>.
        /// </summary>
        void SetFocus();
    }
}