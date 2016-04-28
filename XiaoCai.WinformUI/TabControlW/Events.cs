using System.Windows.Forms;
using System.Drawing;

namespace XiaoCai.WinformUI
{
    public delegate void UpDownButtonPaintEventHandler(
        object sender,
        UpDownButtonPaintEventArgs e);

    public class UpDownButtonPaintEventArgs : PaintEventArgs
    {
        public UpDownButtonPaintEventArgs(
            Graphics graphics,
            Rectangle clipRect,
            bool mouseOver,
            bool mousePress,
            bool mouseInUpButton)
            : base(graphics, clipRect)
        {
            MouseOver = mouseOver;
            MousePress = mousePress;
            MouseInUpButton = mouseInUpButton;
        }

        public bool MouseOver { get; }

        public bool MousePress { get; }

        public bool MouseInUpButton { get; }
    }
}
