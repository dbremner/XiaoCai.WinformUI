using System;
using System.Drawing;

namespace XiaoCai.WinformUI.Docking
{
	public sealed class NestedDockingStatus
	{
		internal NestedDockingStatus(DockPane pane)
		{
			DockPane = pane;
		}

	    public DockPane DockPane { get; } = null;

	    public NestedPaneCollection NestedPanes { get; private set; } = null;

	    public DockPane PreviousPane { get; private set; } = null;

	    public DockAlignment Alignment { get; private set; } = DockAlignment.Left;

	    public double Proportion { get; private set; } = 0.5;

	    public bool IsDisplaying { get; private set; } = false;

	    public DockPane DisplayingPreviousPane { get; private set; } = null;

	    public DockAlignment DisplayingAlignment { get; private set; } = DockAlignment.Left;

	    public double DisplayingProportion { get; private set; } = 0.5;

	    public Rectangle LogicalBounds { get; private set; } = Rectangle.Empty;

	    public Rectangle PaneBounds { get; private set; } = Rectangle.Empty;

	    public Rectangle SplitterBounds { get; private set; } = Rectangle.Empty;

	    internal void SetStatus(NestedPaneCollection nestedPanes, DockPane previousPane, DockAlignment alignment, double proportion)
		{
			NestedPanes = nestedPanes;
			PreviousPane = previousPane;
			Alignment = alignment;
			Proportion = proportion;
		}

		internal void SetDisplayingStatus(bool isDisplaying, DockPane displayingPreviousPane, DockAlignment displayingAlignment, double displayingProportion)
		{
			IsDisplaying = isDisplaying;
			DisplayingPreviousPane = displayingPreviousPane;
			DisplayingAlignment = displayingAlignment;
			DisplayingProportion = displayingProportion;
		}

		internal void SetDisplayingBounds(Rectangle logicalBounds, Rectangle paneBounds, Rectangle splitterBounds)
		{
			LogicalBounds = logicalBounds;
			PaneBounds = paneBounds;
			SplitterBounds = splitterBounds;
		}
	}
}
