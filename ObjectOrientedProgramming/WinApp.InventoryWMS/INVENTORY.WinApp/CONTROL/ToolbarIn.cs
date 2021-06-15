using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace INVENTORY.CONTROL
{
    public partial class ToolbarIn : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public ToolbarIn()
        {
            InitializeComponent();
        }

        public Action SenderName { get; set; }

        private void bmMain_HighlightedLinkChanged(object sender, HighlightedLinkChangedEventArgs e)
        {
            if (e.Link != null && (e.Link.Item is BarButtonItem || e.Link.Item is BarSubItem))
            {
                Cursor = Cursors.Hand;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void bmMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Clicked != null)
            {
                switch (e.Item.Name)
                {
                    case "cmdInAn":
                        this.SenderName = Action.Print;
                        break;
                    case "cmdDong":
                        this.SenderName = Action.Close;
                        break;
                    default:
                        this.SenderName = Action.None;
                        break;
                }
                Clicked(this, new System.EventArgs());
            }
        }

        public enum Action
        {
            None,
            Print,
            Close
        }
    }
}
