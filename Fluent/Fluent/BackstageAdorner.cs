﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Fluent
{
    public class BackstageAdorner :Adorner
    {
        #region Fields

        private UIElement backstage = null;
        private double topOffset = 0;
        VisualCollection visualChildren;

        #endregion

        #region Constructors

        public BackstageAdorner(UIElement adornedElement, UIElement backstage, double topOffset)
            : base(adornedElement)
        {
            this.backstage = backstage;
            this.topOffset = topOffset;
            visualChildren = new VisualCollection(this);
            visualChildren.Add(backstage);
        }

        #endregion

        #region Layout & Visual Children

        /// <summary>
        /// Positions child elements and determines
        /// a size for the control
        /// </summary>
        /// <param name="finalSize">The final area within the parent 
        /// that this element should use to arrange 
        /// itself and its children</param>
        /// <returns>The actual size used</returns>
        protected override Size ArrangeOverride(Size finalSize)
        {
            backstage.Arrange(new Rect(0, topOffset, finalSize.Width, finalSize.Height - topOffset));            
            return finalSize;
        }

        /// <summary>
        /// Measures KeyTips
        /// </summary>
        /// <param name="constraint">The available size that this element can give to child elements.</param>
        /// <returns>The size that the groups container determines it needs during 
        /// layout, based on its calculations of child element sizes.
        /// </returns>
        protected override Size MeasureOverride(Size constraint)
        {
            return AdornedElement.RenderSize;            
        }

        /// <summary>
        /// Gets visual children count
        /// </summary>
        protected override int VisualChildrenCount { get { return visualChildren.Count; } }

        /// <summary>
        /// Returns a child at the specified index from a collection of child elements
        /// </summary>
        /// <param name="index">The zero-based index of the requested child element in the collection</param>
        /// <returns>The requested child element</returns>
        protected override Visual GetVisualChild(int index) { return visualChildren[index]; }

        #endregion
    }
}
