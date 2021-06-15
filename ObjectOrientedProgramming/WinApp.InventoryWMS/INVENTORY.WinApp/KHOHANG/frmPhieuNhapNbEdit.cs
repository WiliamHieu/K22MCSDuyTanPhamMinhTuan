using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuNhapNbEdit : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();

        frmPhieuNhapNb frmParent = null;

        private DateTime dtNgayHienTai = DateTime.Now;

        public KhPhieuNhapNb entPhieuNhapNb = null;
        private KhPhieuChuyen entPhieuChuyen = null;
        private DataTable dtPhieuNhapNbCt = null;

        private string runType, saveResult = string.Empty;

        public frmPhieuNhapNbEdit(frmPhieuNhapNb frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmPhieuNhapNbChange_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();
            BindCatalog.DmKhoNhan_BindDropDown(cboKhoNhan, entPhieuNhapNb.IdKhoChuyen);

            brgWorker.RunWorkerAsync("View");
        }

        private void ToolbarLd_Clicked(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (ToolbarLd.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarLd.Action.SaveClose:
                    using (var dbContext = new InventoryDbContext())
                    {
                        entPhieuNhapNb = dbContext.KhPhieuNhapNb.ById(entPhieuNhapNb.Id).FirstOrDefault();
                        if (entPhieuNhapNb.TrangThai != 0)
                        {
                            XtraMessageBox.Show("Phiếu nhận hàng đã nhận hàng nên không thể Thay đổi kho nhận", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cboKhoNhan.Focus();
                            return;
                        }
                    }
                    if (cboKhoNhan.EditValue == null)
                    {
                        XtraMessageBox.Show("Chưa chọn Kho nhận để Thay đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboKhoNhan.Focus();
                        return;
                    }
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    ToolbarLd.DisableTool = INVENTORY.CONTROL.ToolbarLd.Action.SaveClose;
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarLd.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Equals("View"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    entPhieuChuyen = dbContext.KhPhieuChuyen.ById(entPhieuNhapNb.IdPhieuChuyen).FirstOrDefault();
                    dtPhieuNhapNbCt = oFunction.KhNhapXuat_Get_ListChiTiet("NhapNb", dbContext, entPhieuNhapNb.Id);
                }
            }
            else
            {
                using (var dbContext = new InventoryDbContext())
                {
                    dbContext.Connection.Open();
                    dbContext.Transaction = dbContext.Connection.BeginTransaction(System.Data.IsolationLevel.Snapshot);
                    try
                    {
                        entPhieuChuyen.Detach();
                        dbContext.KhPhieuChuyen.Attach(entPhieuChuyen);

                        entPhieuChuyen.IdKhoNhan = Convert.ToInt32(cboKhoNhan.EditValue);
                        dbContext.SubmitChanges();

                        entPhieuNhapNb.Detach();
                        dbContext.KhPhieuNhapNb.Attach(entPhieuNhapNb);

                        entPhieuNhapNb.IdKhoHang = entPhieuChuyen.IdKhoNhan;
                        entPhieuNhapNb.SoPhieu = oFunction.KhPhieuNhapNb_Get_SoPhieu(dbContext, entPhieuChuyen.IdKhoNhan, dtNgayHienTai);
                        dbContext.SubmitChanges();

                        dbContext.Transaction.Commit();

                        saveResult = "ThanhCong";
                    }
                    catch (Exception)
                    {
                        dbContext.Transaction.Rollback();

                        saveResult = "ThatBai";
                    }
                }
            }
        }

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ba.SetWaitDialogCaption("Kết thúc thay đổi dữ liệu");
            ba.Exit();

            if (runType.Equals("Save"))
            {
                if (saveResult.Equals("ThanhCong"))
                {
                    XtraMessageBox.Show("Thay đổi Kho nhận hàng Thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmParent.BindData();

                    ToolbarLd.SenderName = INVENTORY.CONTROL.ToolbarLd.Action.Close;
                    ToolbarLd_Clicked(sender, e);
                }
                else
                {
                    XtraMessageBox.Show("Thay đổi Kho nhận hàng Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ToolbarLd.EnableTool = INVENTORY.CONTROL.ToolbarLd.Action.SaveClose;
                }
            }
        }
    }
}