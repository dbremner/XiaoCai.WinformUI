using System.Windows.Forms;
using System.Drawing;
using XiaoCai.WinformUI.Panels;


namespace XiaoCai.WinformUI
{
    public partial class LabelW : Label, IStyle
    {
        private OfficeColorTable _officeColorTable;

        public LabelW()
        {
            base.BackColor = Color.Transparent;
        }

        public bool UseStyle { get; set; } = false;

        #region IStyle 成员
        public void SetStyle(Style style)
        {
            if (UseStyle)
            {
                _officeColorTable = StyleBuilderFactory.GetOffice2007ColorTable(style);
                this.ForeColor = _officeColorTable.LabelTextColor;
            }
            else
            {
                this.ForeColor = SystemColors.ControlText;
            }
            this.Refresh();
        }

        private Style _style = Style.Office2007Blue;

        public Style Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
                SetStyle(_style);
            }
        }

        #endregion
    }
}
