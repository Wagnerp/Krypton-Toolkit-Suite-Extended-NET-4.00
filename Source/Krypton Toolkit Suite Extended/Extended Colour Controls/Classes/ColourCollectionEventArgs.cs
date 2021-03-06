﻿using System;
using System.Drawing;

namespace ExtendedColourControls
{
    public class ColourCollectionEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ColourCollectionEventArgs"/> class for the specified color.
        /// </summary>
        /// <param name="index">The color index that the event is responding to.</param>
        /// <param name="color">The %Color% that the event is responding to.</param>
        public ColourCollectionEventArgs(int index, Color colour)
        {
            this.Index = index;
            this.Colour = colour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColourCollectionEventArgs"/> class.
        /// </summary>
        protected ColourCollectionEventArgs()
        { }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the color that raised the event.
        /// </summary>
        /// <value>The color that raised the event.</value>
        public Color Colour { get; protected set; }

        /// <summary>
        /// Gets the color index that raised the event.
        /// </summary>
        /// <value>The color index that raised the event.</value>
        public int Index { get; protected set; }

        #endregion
    }
}
