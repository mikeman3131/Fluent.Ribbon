﻿
namespace Fluent
{
    /// <summary>
    /// Represents logical sizes of a ribbon control 
    /// </summary>
    public enum RibbonControlSize
    {
        /// <summary>
        /// Large size of a control
        /// </summary>
        Large = 0,
        /// <summary>
        /// Middle size of a control
        /// </summary>
        Middle,
        /// <summary>
        /// Small size of a control
        /// </summary>
        Small
    }

    /// <summary>
    /// Base interface for Fluent controls
    /// </summary>
    public interface IRibbonControl : IKeyTipedControl
    {
        /// <summary>
        /// Gets or sets element Text
        /// </summary>
        object Header { get; set; }

        /// <summary>
        /// Gets or sets Icon for the element
        /// </summary>
        object Icon { get; set; }

    }
}
