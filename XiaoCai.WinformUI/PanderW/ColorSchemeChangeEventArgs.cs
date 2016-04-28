using System;
using System.Collections.Generic;
using System.Text;

namespace XiaoCai.WinformUI.Panels
{
    public class ColorSchemeChangeEventArgs : EventArgs
    {
        #region FieldsPrivate

        #endregion

        #region Properties
        /// <summary>
        /// Gets the color schema which is used for the panel.
        /// </summary>
        public ColorScheme ColorSchema { get; }

        #endregion

        #region MethodsPublic
        /// <summary>
        /// Arguments used when a ColorSchemeChange event occurs.
        /// </summary>
        /// <param name="eColorSchema">The color schema which is used for the panel.</param>
        public ColorSchemeChangeEventArgs(ColorScheme eColorSchema)
        {
            this.ColorSchema = eColorSchema;
        }

        #endregion
    }
}
