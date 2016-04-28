using System;

namespace XiaoCai.WinformUI.Docking
{
	public class DockContentEventArgs : EventArgs
	{
	    public DockContentEventArgs(IDockContent content)
		{
			Content = content;
		}

		public IDockContent Content { get; }
	}
}
