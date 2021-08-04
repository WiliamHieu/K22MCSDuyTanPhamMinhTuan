using System;
using System.Windows.Forms;

namespace SMSSC.CONTROL
{
    public partial class ToolbarDm : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public ToolbarDm()
        {
            InitializeComponent();
        }

        public Action SenderName { get; set; }

        public Action DisableTool
        {
            set
            {
                switch (value)
                {
                    case Action.Save:
                        cmdLuu.Enabled = false;
                        cmdLuuVaDong.Enabled = false;
                        cmdLuuVaThem.Enabled = false;
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
                    case Action.Save:
                        cmdLuu.Enabled = true;
                        cmdLuuVaDong.Enabled = true;
                        cmdLuuVaThem.Enabled = true;
                        break;
                    case Action.SaveAdd:
                        cmdLuuVaThem.Enabled = true;
                        break;
                    case Action.SaveClose:
                        cmdLuuVaDong.Enabled = true;
                        break;
                }
            }
        }

        private void bmMain_HighlightedLinkChanged(object sender, DevExpress.XtraBars.HighlightedLinkChangedEventArgs e)
        {
            if (e.Link != null && (e.Link.Item is DevExpress.XtraBars.BarButtonItem || e.Link.Item is DevExpress.XtraBars.BarSubItem))
            {
                Cursor = Cursors.Hand;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void bmMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clicked != null)
            {
                switch (e.Item.Name)
                {
                    case "cmdLuu":
                        this.SenderName = Action.Save;
                        break;
                    case "cmdLuuVaDong":
                        this.SenderName = Action.SaveClose;
                        break;
                    case "cmdLuuVaThem":
                        this.SenderName = Action.SaveAdd;
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
            Save,
            SaveClose,
            SaveAdd,
            Close
        }
    }
}
