using System;
using System.Collections.Generic;
using System.Text;

namespace XiaoCai.WinformUI.Panels
{

    public class PanelStyleChangeEventArgs : EventArgs
    {
        #region FieldsPrivate

        #endregion

        #region Properties
        /// <summary>
        /// Gets the style of the panel.
        /// </summary>
        public PanelStyle PanelStyle { get; }

        #endregion

        #region MethodsPublic
        /// <summary>
        /// Arguments used when a PanelStyleChange event occurs.
        /// </summary>
        /// <param name="ePanelStyle">the style of the panel.</param>
        public PanelStyleChangeEventArgs(PanelStyle ePanelStyle)
        {
            this.PanelStyle = ePanelStyle;
        }

        #endregion
    }
}
