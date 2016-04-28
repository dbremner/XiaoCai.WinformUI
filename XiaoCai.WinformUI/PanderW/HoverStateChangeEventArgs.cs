using System;
using System.Collections.Generic;
using System.Text;

namespace XiaoCai.WinformUI.Panels
{
    public class HoverStateChangeEventArgs : EventArgs
    {
        #region FieldsPrivate

        #endregion

        #region Properties
        /// <summary>
        /// Gets the HoverState.
        /// </summary>
        public HoverState HoverState { get; }

        #endregion

        #region MethodsPublic
        /// <summary>
        /// Initializes a new instance of the HoverStateChangeEventArgs class.
        /// </summary>
        /// <param name="hoverState">The <see cref="HoverState"/> values.</param>
        public HoverStateChangeEventArgs(HoverState hoverState)
        {
            this.HoverState = hoverState;
        }
        #endregion
    }
}
