using System;

namespace SMSSC.CONTROL
{
    public partial class Toolbar01 : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public Action SenderName { get; set; }

        public Toolbar01()
        {
            InitializeComponent();
        }

        public DateTime ThoiGian
        {
            set
            {
                barTuNgay.EditValue = value.AddDays(-30);
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
                if (barTuNgay.EditValue == null) return DateTime.Now;
                return ((DateTime)barTuNgay.EditValue).Date;
            }
        }

        public DateTime DenNgay
        {
            get
            {
                if (barDenNgay.EditValue == null) return DateTime.Now;
                return ((DateTime)barDenNgay.EditValue).Date;
            }
        }

        public Action HideTool
        {
            set
            {
                switch (value)
                {
                    case Action.Send:
                        cmdGui.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
                    case Action.Send:
                        cmdGui.Enabled = false;
                        break;
                    case Action.Delete:
                        cmdXoa.Enabled = false;
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
                    case Action.Send:
                        cmdGui.Enabled = true;
                        break;
                    case Action.Delete:
                        cmdXoa.Enabled = true;
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
                    case "cmdGui":
                        this.SenderName = Action.Send;
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
            Send,
            Delete,
            Refresh,
            DateData,
            Export,
            Print,
            Help,
            Close
        }
    }
}
