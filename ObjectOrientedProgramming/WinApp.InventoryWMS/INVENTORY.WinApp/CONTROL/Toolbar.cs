using System;
using System.Data;

namespace INVENTORY.CONTROL
{
    public partial class Toolbar : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;
        public event EventHandler Changed;

        public Toolbar()
        {
            InitializeComponent();

            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
            dtTemp.Columns.Add(new DataColumn("Id", typeof(int)));
            DataRow dcTemp = dtTemp.NewRow();
            dcTemp["Ten"] = "Hiển thị";
            dcTemp["Id"] = 0;
            dtTemp.Rows.Add(dcTemp);
            dcTemp = dtTemp.NewRow();
            dcTemp["Ten"] = "Ẩn";
            dcTemp["Id"] = -1;
            dtTemp.Rows.Add(dcTemp);

            cboTrangThai.DataSource = dtTemp;
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
                    case Action.Hide:
                        cmdAn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        lblTrangThai.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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

        public int TrangThai
        {
            get
            {
                return Convert.ToInt32(lblTrangThai.EditValue);
            }
        }

        public Action SenderName { get; set; }

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
                    case "cmdAn":
                        this.SenderName = Action.Hide;
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

        private void lblTrangThai_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(this, new System.EventArgs());
        }

        public enum Action
        {
            None,
            Add,
            Edit,
            Delete,
            Hide,
            Refresh,
            Export,
            Print,
            Help,
            Close
        }
    }
}
