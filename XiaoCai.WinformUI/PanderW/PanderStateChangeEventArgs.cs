using System;

namespace XiaoCai.WinformUI.Panels
{
	public class PanderStateChangeEventArgs : EventArgs
	{
		#region FieldsPrivate

	    #endregion
		
		#region Properties
		
		/// <summary>
        /// Gets a value indicating whether the panel expands.
		/// </summary>
        public bool Expand { get; }

	    #endregion

		#region MethodsPublic
        /// <summary>
        /// arguments used when a XPanderStateChange event occurs.
        /// </summary>
        /// <param name="bExpand">Gets a value indicating whether the panel expands.</param>
		public PanderStateChangeEventArgs(bool bExpand)
		{
			this.Expand = bExpand;
		}

		#endregion
	}
}
