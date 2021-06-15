using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuNhapNbAdd : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        frmPhieuNhapNb frmParent = null;

        private DateTime dtNgayHienTai = DateTime.Now;
        public Guid IdPhieuNhapNb = Guid.Empty;

        private KhPhieuChuyen entPhieuChuyen = null;
        private KhPhieuNhapNb entPhieuNhapNb = null;
        private DataTable dtPhieuNhapNbCt = null;

        private string runType, saveResult = string.Empty;

        public frmPhieuNhapNbAdd(frmPhieuNhapNb frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmPhieuNhapNbAdd_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();

            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
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
                    if (!SaveData_Check()) return;
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

        private void gridMainView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                int rowIndex = e.RowHandle;
                if (rowIndex >= 0)
                {
                    rowIndex++;
                    e.Info.DisplayText = rowIndex.ToString();
                }
            }
        }

        private bool SaveData_Check()
        {
            using (var dbContext = new InventoryDbContext())
            {
                entPhieuNhapNb = dbContext.KhPhieuNhapNb.ById(entPhieuNhapNb.Id).FirstOrDefault();
                if (entPhieuNhapNb == null)
                {
                    XtraMessageBox.Show("Phiếu nhận hàng đã được xác nhận Nhập kho", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (dtPhieuNhapNbCt == null || dtPhieuNhapNbCt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không tồn tại Sản phẩm để tiến hành Nhập kho", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Equals("View"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    entPhieuNhapNb = dbContext.KhPhieuNhapNb.ById(IdPhieuNhapNb).FirstOrDefault();
                    entPhieuChuyen = dbContext.KhPhieuChuyen.ById(entPhieuNhapNb.IdPhieuChuyen).FirstOrDefault();
                    dtPhieuNhapNbCt = oFunction.KhNhapXuat_Get_ListChiTiet("NhapNb", dbContext, entPhieuNhapNb.Id);
                }
            }
            else if (runType.Equals("Save"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    dbContext.Connection.Open();
                    dbContext.Transaction = dbContext.Connection.BeginTransaction(System.Data.IsolationLevel.Snapshot);
                    try
                    {
                        dtNgayHienTai = AppSetting.DateTime_GetServer(dbContext);

                        KhPhieuNhap entPhieuNhap = new KhPhieuNhap
                        {
                            Id = Guid.NewGuid(),
                            IdKhoHang = AppSetting.entKhoHang.Id,
                            IdPhieuChuyen = entPhieuNhapNb.IdPhieuChuyen,
                            SoPhieu = oFunction.KhNhapXuat_Get_SoPhieu("Nhap", dbContext, dtNgayHienTai),
                            IdKhoChuyen = entPhieuNhapNb.IdKhoChuyen,
                            IdNguonNhap = oFunction.KhPhieuNhapNb_Get_NguonNhap(dbContext, entPhieuNhapNb.IdKhoChuyen),
                            LoaiNhap = 2,
                            IdNguoiTao = AppSetting.entNguoiDung.Id,
                            NgayTao = dtNgayHienTai,
                            NgayTaoDate = dtNgayHienTai.Date
                        };
                        dbContext.KhPhieuNhap.InsertOnSubmit(entPhieuNhap);

                        KhSanPham entSanPham, entSanPhamChuyen = null;
                        KhPhieuNhapCt entPhieuNhapCt = null;
                        List<KhPhieuNhapNbCt> lstPhieuNhapNbCt = dbContext.KhPhieuNhapNbCt.ByIdPhieuNhapNb(entPhieuNhapNb.Id).ToList();
                        foreach (KhPhieuNhapNbCt entPhieuNhapNbCt in lstPhieuNhapNbCt)
                        {
                            entSanPhamChuyen = dbContext.KhSanPham.ById(entPhieuNhapNbCt.IdSanPham).FirstOrDefault();

                            entSanPham = new KhSanPham
                            {
                                Id = Guid.NewGuid(),
                                IdSanPham = entSanPhamChuyen.IdSanPham,
                                IdKhoHang = entPhieuNhap.IdKhoHang,
                                IdNguonNhap = entSanPhamChuyen.IdNguonNhap,
                                IdLoaiVatTu = entSanPhamChuyen.IdLoaiVatTu,
                                SoLuongNhap = entPhieuNhapNbCt.SoLuong,
                                SoLuongTon = entPhieuNhapNbCt.SoLuong,
                                NgayTao = entSanPhamChuyen.NgayTao
                            };
                            dbContext.KhSanPham.InsertOnSubmit(entSanPham);
                            entPhieuNhapCt = new KhPhieuNhapCt
                            {
                                Id = Guid.NewGuid(),
                                IdPhieuNhap = entPhieuNhap.Id,
                                IdLoaiVatTu = entSanPham.IdLoaiVatTu,
                                IdSanPham = entSanPham.Id,
                                SoLuong = entSanPham.SoLuongNhap,
                                NgayTaoDate = entPhieuNhap.NgayTaoDate
                            };
                            dbContext.KhPhieuNhapCt.InsertOnSubmit(entPhieuNhapCt);
                            dbContext.SubmitChanges();
                        }
                        dbContext.CustomGenKhPhieuNhapNbDelete(entPhieuNhapNb.Id, true);

                        entPhieuChuyen.Detach();
                        dbContext.KhPhieuChuyen.Attach(entPhieuChuyen);

                        entPhieuChuyen.TrangThaiNhan = 1;
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
            if (runType.Equals("View"))
            {
                ba.SetWaitDialogCaption("Kết thúc truy vấn và Bắt đầu hiển thị dữ liệu");

                txtSoPhieu.EditValue = entPhieuNhapNb.SoPhieu;
                txtNgayTao.EditValue = entPhieuNhapNb.NgayTao.ToString("dd/MM/yyyy HH:mm");
                txtKhoChuyen.EditValue = oFunction.DmKhoHang_Entity(entPhieuNhapNb.IdKhoChuyen).Ten;
                txtNguoiGiao.EditValue = oFunction.HtNguoiDung_Entity(entPhieuNhapNb.IdNguoiGiao).Ten;
                txtChuThich.EditValue = entPhieuNhapNb.ChuThich;

                gridMain.DataSource = dtPhieuNhapNbCt;

                if (!oSecurity.CheckEdit(this.Name))
                {
                    ToolbarLd.DisableTool = INVENTORY.CONTROL.ToolbarLd.Action.SaveClose;
                }

                ba.SetWaitDialogCaption("Kết thúc hiển thị dữ liệu");
                ba.Exit();
            }
            else if (runType.Equals("Save"))
            {
                ba.SetWaitDialogCaption("Kết thúc thay đổi dữ liệu");
                ba.Exit();

                if (saveResult.Equals("ThanhCong"))
                {
                    XtraMessageBox.Show("Cập nhật Phiếu nhận hàng Thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmParent.BindData();

                    ToolbarLd.SenderName = INVENTORY.CONTROL.ToolbarLd.Action.Close;
                    ToolbarLd_Clicked(sender, e);
                }
                else if (saveResult.Equals("ThatBai"))
                {
                    XtraMessageBox.Show("Cập nhật Phiếu nhận hàng Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ToolbarLd.EnableTool = INVENTORY.CONTROL.ToolbarLd.Action.SaveClose;
                }
            }
        }
    }
}