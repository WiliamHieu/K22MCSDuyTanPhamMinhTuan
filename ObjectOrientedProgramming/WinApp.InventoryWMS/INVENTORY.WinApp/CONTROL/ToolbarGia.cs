using System;

namespace INVENTORY.CONTROL
{
    public partial class ToolbarGia : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public ToolbarGia()
        {
            InitializeComponent();
        }

        public Action SenderName { get; set; }

        public string FormName
        {
            set
            {
                if (!oSecurity.CheckEdit(value))
                {
                    cmdSua.Caption = "Chi tiết";
                }
                if (!oSecurity.CheckDelete(value))
                {
                    cmdXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
            }
        }

        public string EditCaption
        {
            set
            {
                cmdSua.Caption = value;
            }
        }

        public Action HideTool
        {
            set
            {
                switch (value)
                {
                    case Action.Save:
                        cmdLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Action.Edit:
                        cmdSua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Action.Delete:
                        cmdXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Action.Refresh:
                        cmdNapLai.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Action.Export:
                        cmdXuatExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Action.Print:
                        cmdInAn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
                        break;
                    case Action.Edit:
                        cmdSua.Enabled = false;
                        break;
                    case Action.Delete:
                        cmdXoa.Enabled = false;
                        break;
                    case Action.Refresh:
                        cmdNapLai.Enabled = false;
                        break;
                    case Action.Export:
                        cmdXuatExcel.Enabled = false;
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
                        break;
                    case Action.Edit:
                        cmdSua.Enabled = true;
                        break;
                    case Action.Delete:
                        cmdXoa.Enabled = true;
                        break;
                    case Action.Refresh:
                        cmdNapLai.Enabled = true;
                        break;
                    case Action.Export:
                        cmdXuatExcel.Enabled = true;
                        break;
                    case Action.Print:
                        cmdInAn.Enabled = true;
                        break;
                }
            }
        }

        private void BarMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clicked != null)
            {
                switch (e.Item.Name)
                {
                    case "cmdLuu":
                        this.SenderName = Action.Save;
                        break;
                    case "cmdSua":
                        this.SenderName = Action.Edit;
                        break;
                    case "cmdXoa":
                        this.SenderName = Action.Delete;
                        break;
                    case "cmdNapLai":
                        this.SenderName = Action.Refresh;
                        break;
                    case "cmdXuatExcel":
                        this.SenderName = Action.Export;
                        break;
                    case "cmdInAn":
                        this.SenderName = Action.Print;
                        break;
                    case "cmdTroGiup":
                        this.SenderName = Action.Help;
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
            Edit,
            Delete,
            Refresh,
            Export,
            Print,
            Help,
            Close
        }
    }
}
