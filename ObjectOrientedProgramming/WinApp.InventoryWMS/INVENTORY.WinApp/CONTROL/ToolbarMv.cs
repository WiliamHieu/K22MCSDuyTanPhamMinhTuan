using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace INVENTORY.CONTROL
{
    public partial class ToolbarMv : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public ToolbarMv()
        {
            InitializeComponent();
        }

        public Action SenderName { get; set; }

        public string AcceptCaption
        {
            set
            {
                cmdLuuVaChuyen.Caption = value;
            }
        }

        public Action HideTool
        {
            set
            {
                switch (value)
                {
                    case Action.Save:
                        cmdLuu.Visibility = BarItemVisibility.Never;
                        break;
                    case Action.SaveClose:
                        cmdLuuVaDong.Visibility = BarItemVisibility.Never;
                        break;
                    case Action.SaveAdd:
                        cmdLuuVaThem.Visibility = BarItemVisibility.Never;
                        break;
                    case Action.SavePrint:
                        cmdLuuVaIn.Visibility = BarItemVisibility.Never;
                        break;
                    case Action.SaveAccept:
                        cmdLuuVaChuyen.Visibility = BarItemVisibility.Never;
                        break;
                }
            }
        }

        public Action ShowTool
        {
            set
            {
                switch (value)
                {
                    case Action.SaveAccept:
                        cmdLuuVaChuyen.Visibility = BarItemVisibility.Always;
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
                    case Action.Save:
                        cmdLuu.Enabled = false;
                        cmdLuuVaDong.Enabled = false;
                        cmdLuuVaThem.Enabled = false;
                        cmdLuuVaChuyen.Enabled = false;
                        cmdLuuVaIn.Enabled = false;
                        break;
                    case Action.SaveAccept:
                        cmdLuuVaChuyen.Enabled = false;
                        break;
                    case Action.Print:
                        cmdInAn.Enabled = false;
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
                        cmdLuuVaChuyen.Enabled = true;
                        cmdLuuVaIn.Enabled = true;
                        break;
                    case Action.SaveAccept:
                        cmdLuuVaChuyen.Enabled = true;
                        break;
                    case Action.SavePrint:
                        cmdLuuVaIn.Enabled = true;
                        break;
                    case Action.Print:
                        cmdInAn.Enabled = true;
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
                    case "cmdLuu":
                        this.SenderName = Action.Save;
                        break;
                    case "cmdLuuVaDong":
                        this.SenderName = Action.SaveClose;
                        break;
                    case "cmdLuuVaThem":
                        this.SenderName = Action.SaveAdd;
                        break;
                    case "cmdLuuVaIn":
                        this.SenderName = Action.SavePrint;
                        break;
                    case "cmdLuuVaChuyen":
                        this.SenderName = Action.SaveAccept;
                        break;
                    case "cmdInAn":
                        this.SenderName = Action.Print;
                        break;
                    case "cmdXuatExcel":
                        this.SenderName = Action.ExportExcel;
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
            SavePrint,
            SaveAccept,
            Print,
            ExportExcel,
            Close
        }
    }
}
