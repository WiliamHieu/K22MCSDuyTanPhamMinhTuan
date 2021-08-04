using System;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SMSSC.CONTROL
{
    public partial class ToolbarLd : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        private Action _senderName;

        public ToolbarLd()
        {
            InitializeComponent();
        }

        public Action SenderName
        {
            get
            {
                return this._senderName;
            }
            set
            {
                this._senderName = value;
            }
        }

        public Action DisableTool
        {
            set
            {
                switch (value)
                {
                    case Action.SaveClose:
                        cmdLuuVaDong.Enabled = false;
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
                    case Action.SaveClose:
                        cmdLuuVaDong.Enabled = true;
                        break;
                }
            }
        }

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
                    case "cmdLuuVaDong":
                        this.SenderName = Action.SaveClose;
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
            SaveClose,
            Close
        }
    }
}
