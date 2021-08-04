using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace SMSSC.CONTROL
{
    public partial class ToolbarNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public ToolbarNhap()
        {
            InitializeComponent();
        }

        private void ToolbarNhap_Enter(object sender, EventArgs e)
        {
            MaiToolbar.ItemLinks[0].Focus();
        }

        public Action SenderName { get; set; }

        public Action HideTool
        {
            set
            {
                switch (value)
                {
                    case Action.Add:
                        cmdThem.Visibility = BarItemVisibility.Never;
                        break;
                    case Action.Delete:
                        cmdXoa.Visibility = BarItemVisibility.Never;
                        break;
                }
            }
        }

        public Action DisableTool
        {
            set
            {
                switch (value)
                {
                    case Action.Add:
                        cmdThem.Enabled = false;
                        break;
                    case Action.Delete:
                        cmdXoa.Enabled = false;
                        break;
                    case Action.Modify:
                        cmdThem.Enabled = false;
                        cmdXoa.Enabled = false;
                        break;
                }
            }
        }

        public Action EnableTool
        {
            set
            {
                switch (value)
                {
                    case Action.Add:
                        cmdThem.Enabled = true;
                        break;
                    case Action.Delete:
                        cmdXoa.Enabled = true;
                        break;
                }
            }
        }

        private void bmMain_HighlightedLinkChanged(object sender, HighlightedLinkChangedEventArgs e)
        {
            if (e.Link != null && e.Link.Item is BarButtonItem)
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
                    case "cmdThem":
                        this.SenderName = Action.Add;
                        break;
                    case "cmdXoa":
                        this.SenderName = Action.Delete;
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
            Add,
            Delete,
            Modify
        }
    }
}
