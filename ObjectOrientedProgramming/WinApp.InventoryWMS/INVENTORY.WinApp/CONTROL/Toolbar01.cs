using System;

namespace INVENTORY.CONTROL
{
    public partial class Toolbar01 : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public Action SenderName { get; set; }

        public Toolbar01()
        {
            InitializeComponent();
        }

        public bool ShowAccept
        {
            set
            {
                if (value)
                    cmdXacNhan.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                else
                    cmdXacNhan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        public DateTime ThoiGian
        {
            set
            {
                barTuNgay.EditValue = value.AddDays(-AppSetting.entThietLap.NgayDuLieu);
                barDenNgay.EditValue = value;
            }
        }

        public DateTime TuNgay
        {
            set
            {
                barTuNgay.EditValue = value;
            }
            get
            {
                return barTuNgay.EditValue != null ? Convert.ToDateTime(barTuNgay.EditValue).Date : DateTime.Now.Date;
            }
        }

        public DateTime DenNgay
        {
            get
            {
                return barDenNgay.EditValue != null ? Convert.ToDateTime(barDenNgay.EditValue).Date : DateTime.Now.Date;
            }
        }

        public string FormName
        {
            set
            {
                if (!oSecurity.CheckAdd(value))
                {
                    cmdThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
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

        public Action HideTool
        {
            set
            {
                switch (value)
                {
                    case Action.Add:
                        cmdThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Action.Edit:
                        cmdSua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Action.Delete:
                        cmdXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Action.DateData:
                        barTuNgay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        barDenNgay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
                    case Action.Add:
                        cmdThem.Enabled = false;
                        break;
                    case Action.Edit:
                        cmdSua.Enabled = false;
                        break;
                    case Action.Delete:
                        cmdXoa.Enabled = false;
                        break;
                    case Action.Accept:
                        cmdXacNhan.Enabled = false;
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
                    case Action.Add:
                        cmdThem.Enabled = true;
                        break;
                    case Action.Edit:
                        cmdSua.Enabled = true;
                        break;
                    case Action.Delete:
                        cmdXoa.Enabled = true;
                        break;
                    case Action.Accept:
                        cmdXacNhan.Enabled = true;
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
                    case "cmdThem":
                        this.SenderName = Action.Add;
                        break;
                    case "cmdSua":
                        this.SenderName = Action.Edit;
                        break;
                    case "cmdXoa":
                        this.SenderName = Action.Delete;
                        break;
                    case "cmdXacNhan":
                        this.SenderName = Action.Accept;
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
            Add,
            Edit,
            Delete,
            Accept,
            Refresh,
            DateData,
            Export,
            Print,
            Help,
            Close
        }
    }
}
