using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuChuyenAdd : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        public frmPhieuChuyen frmParent = null;

        private DateTime dtNgayHienTai = DateTime.Now;

        private KhPhieuChuyen entPhieuChuyen = null;
        private DataTable dtPhieuChuyenCt = null;

        private string saveResult = string.Empty;

        public frmPhieuChuyenAdd(frmPhieuChuyen frm)
        {
            InitializeComponent();
            frmParent = frm;
            ToolbarMv.ShowTool = INVENTORY.CONTROL.ToolbarMv.Action.SaveAccept;
        }

        private void frmPhieuChuyenAdd_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();

            txtSoPhieu.EditValue = oFunction.KhNhapXuat_Get_SoPhieu("Chuyen", null, dtNgayHienTai);
            txtNgayTao.EditValue = dtNgayHienTai.ToString("dd/MM/yyyy HH:mm");

            BindCatalog.DmKhoNhan_BindDropDown(cboKhoNhan, AppSetting.entKhoHang.Id);
            BindCatalog.NguoiGiao_BindDropDown(cboNguoiGiao, AppSetting.entKhoHang.Id);
            BindCatalog.DmLoaiVatTu_BindDropDown(cboLoaiVatTu, AppSetting.entKhoHang.Id, Guid.Empty, 1);

            cboNguoiGiao.EditValue = AppSetting.entNguoiDung.Id;

            dtPhieuChuyenCt = oInitData.KH_SanPham_InitTable();
            gridMain.DataSource = dtPhieuChuyenCt;

            ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Print;
        }

        private void frmPhieuChuyenAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            if (ba != null) ba.Exit();
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmdChon.Enabled) cmdChon_Click(sender, e);
            }
        }

        private void cmdChon_Click(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboLoaiVatTu.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Loại vật tư", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiVatTu.Focus();
                return;
            }
            int SoLuongChuyen = Convert.ToInt32(txtSoLuong.EditValue);
            if (SoLuongChuyen <= 0)
            {
                XtraMessageBox.Show("Chưa nhập Số lượng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            int SoLuongTon = oFunction.KhSanPham_Get_SoLuong(null, AppSetting.entKhoHang.Id, MTValue.Guid(cboLoaiVatTu.EditValue));
            if (SoLuongTon == 0)
            {
                XtraMessageBox.Show("Loại vật tư vừa chọn đã hết hàng trong kho", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiVatTu.Focus();
                return;
            }
            int SoLuongDaChon = 0;
            DataRow[] aPhieuChuyenCt = dtPhieuChuyenCt.Select(string.Format("IdLoaiVatTu='{0}'", cboLoaiVatTu.EditValue));
            if (aPhieuChuyenCt.Length > 0) SoLuongDaChon = Convert.ToInt32(aPhieuChuyenCt[0]["SoLuong"]);
            if (SoLuongTon < SoLuongDaChon + SoLuongChuyen)
            {
                XtraMessageBox.Show("Loại vật tư vừa chọn không đủ số lượng xuất!", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiVatTu.Focus();
                return;
            }
            int SoLuong = aPhieuChuyenCt.Length > 0 ? Convert.ToInt32(aPhieuChuyenCt[0]["SoLuong"]) + SoLuongChuyen : SoLuongChuyen;

            if (aPhieuChuyenCt.Length > 0)
            {
                aPhieuChuyenCt[0]["SoLuong"] = SoLuong;
            }
            else
            {
                var entLoaiVatTu = cboLoaiVatTu.Properties.GetRowByKeyValue(cboLoaiVatTu.EditValue) as CustomDmLoaiVatTuGetDropDownResult;

                DataRow drPhieuChuyenCt = dtPhieuChuyenCt.NewRow();
                drPhieuChuyenCt["Id"] = Guid.NewGuid();
                drPhieuChuyenCt["IdLoaiVatTu"] = cboLoaiVatTu.EditValue;
                drPhieuChuyenCt["TenLoaiVatTu"] = entLoaiVatTu.Ten;
                drPhieuChuyenCt["TenDonViTinh"] = entLoaiVatTu.TenDonViTinh;
                drPhieuChuyenCt["QuyCach"] = entLoaiVatTu.QuyCach;
                drPhieuChuyenCt["SoLuong"] = SoLuong;
                dtPhieuChuyenCt.Rows.Add(drPhieuChuyenCt);
            }
            dtPhieuChuyenCt.AcceptChanges();

            cboLoaiVatTu.EditValue = null;
            txtSoLuong.EditValue = null;
            cboLoaiVatTu.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                {
                    XtraMessageBox.Show("Chưa chọn Danh sách sản phẩm để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa Danh sách sản phẩm đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drResult == DialogResult.No) return;

                List<DataRow> lstRowsSelected = oXtraGrid.Get_SelectedRows(gridMainView);
                foreach (DataRow rowDel in lstRowsSelected)
                {
                    rowDel.Delete();
                }
                dtPhieuChuyenCt.AcceptChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Xóa bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolbarMv_Clicked(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (ToolbarMv.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarMv.Action.Save:
                    if (!SaveData_Check()) return;
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SaveClose:
                    if (!SaveData_Check()) return;
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SaveAdd:
                    if (!SaveData_Check()) return;
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SavePrint:
                    if (!SaveData_Check()) return;
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SaveAccept:
                    if (!SaveData_Check()) return;
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.Print:
                    Print();
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.ExportExcel:
                    oXtraGrid.ExportXLSX(gridMainView, txtSoPhieu.Text);
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.Close:
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

        private void gridMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.None && !gridMainView.IsLastRow)
                {
                    if (gridMainView.FocusedColumn.Name.EndsWith("ChuThich"))
                    {
                        gridMainView.MoveNext();
                        gridMainView.ShowEditor();
                        e.Handled = true;
                    }
                }
            }
            else if (e.KeyData == Keys.Delete)
            {
                if (cmdXoa.Enabled) cmdXoa_Click(sender, e);
                e.Handled = true;
            }
        }

        private bool SaveData_Check()
        {
            if (cboKhoNhan.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Kho nhận", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoNhan.Focus();
                return false;
            }
            if (cboNguoiGiao.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Người giao", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNguoiGiao.Focus();
                return false;
            }
            if (dtPhieuChuyenCt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Chưa nhập Sản phẩm cho Phiếu chuyển", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string checkHangTon = oFunction.KhNhapXuat_Check_HangTon(null, AppSetting.entKhoHang.Id, dtPhieuChuyenCt, false);
            if (checkHangTon.Length > 0)
            {
                XtraMessageBox.Show(checkHangTon, AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void Print()
        {
            try
            {
                DataTable dtThongTinPhieu = oReport.KH_PhieuChuyen_GetTable(entPhieuChuyen);
                DataTable dtThongTinSanPham = dtPhieuChuyenCt;
                oReport.KH_PhieuChuyen_Print(dtThongTinPhieu, dtPhieuChuyenCt);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Có lỗi khi in Phiếu chuyển!", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var dbContext = new InventoryDbContext())
            {
                dbContext.Connection.Open();
                dbContext.Transaction = dbContext.Connection.BeginTransaction(System.Data.IsolationLevel.Snapshot);
                try
                {
                    dtNgayHienTai = AppSetting.DateTime_GetServer(dbContext);

                    entPhieuChuyen = new KhPhieuChuyen
                    {
                        Id = Guid.NewGuid(),
                        IdKhoHang = AppSetting.entKhoHang.Id,
                        SoPhieu = oFunction.KhNhapXuat_Get_SoPhieu("Chuyen", dbContext, dtNgayHienTai),
                        IdKhoNhan = Convert.ToInt32(cboKhoNhan.EditValue),
                        IdNguoiGiao = Convert.ToInt32(cboNguoiGiao.EditValue),
                        IdNguoiTao = AppSetting.entNguoiDung.Id,
                        TrangThai = ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SaveAccept ? 1 : 0,
                        NgayTao = dtNgayHienTai,
                        NgayTaoDate = dtNgayHienTai.Date,
                        ChuThich = MTString.TextClean(txtChuThich.EditValue)
                    };
                    dbContext.KhPhieuChuyen.InsertOnSubmit(entPhieuChuyen);
                    dbContext.SubmitChanges();

                    if (entPhieuChuyen.TrangThai == 1)
                    {
                        KhPhieuNhapNb entPhieuNhapNb = new KhPhieuNhapNb
                        {
                            Id = Guid.NewGuid(),
                            IdKhoHang = entPhieuChuyen.IdKhoNhan,
                            IdPhieuChuyen = entPhieuChuyen.Id,
                            SoPhieu = oFunction.KhPhieuNhapNb_Get_SoPhieu(dbContext, entPhieuChuyen.IdKhoNhan, dtNgayHienTai),
                            IdNguonNhap = oFunction.KhPhieuNhapNb_Get_NguonNhap(dbContext, entPhieuChuyen.IdKhoHang),
                            IdKhoChuyen = entPhieuChuyen.IdKhoHang,
                            IdNguoiGiao = entPhieuChuyen.IdNguoiGiao,
                            IdNguoiTao = entPhieuChuyen.IdNguoiTao,
                            NgayTao = entPhieuChuyen.NgayTao,
                            NgayTaoDate = entPhieuChuyen.NgayTaoDate,
                            ChuThich = entPhieuChuyen.ChuThich
                        };
                        dbContext.KhPhieuNhapNb.InsertOnSubmit(entPhieuNhapNb);
                        dbContext.SubmitChanges();

                        KhPhieuChuyenCt entPhieuChuyenCt = null;
                        foreach (DataRow row in dtPhieuChuyenCt.Rows)
                        {
                            entPhieuChuyenCt = new KhPhieuChuyenCt
                            {
                                Id = Guid.NewGuid(),
                                IdPhieuChuyen = entPhieuChuyen.Id,
                                IdLoaiVatTu = MTValue.Guid(row["IdLoaiVatTu"]),
                                SoLuong = Convert.ToInt32(row["SoLuong"]),
                                NgayTaoDate = entPhieuChuyen.NgayTaoDate,
                                ChuThich = MTString.Text(row["ChuThich"])
                            };
                            dbContext.KhPhieuChuyenCt.InsertOnSubmit(entPhieuChuyenCt);
                        }
                        dbContext.SubmitChanges();
                        dbContext.CustomGenKhPhieuChuyenCtUpdate(entPhieuChuyen.IdKhoHang, entPhieuChuyen.Id, entPhieuNhapNb.Id);
                    }
                    else
                    {
                        KhPhieuChuyenCt entPhieuChuyenCt = null;
                        foreach (DataRow row in dtPhieuChuyenCt.Rows)
                        {
                            entPhieuChuyenCt = new KhPhieuChuyenCt
                            {
                                Id = Guid.NewGuid(),
                                IdPhieuChuyen = entPhieuChuyen.Id,
                                IdLoaiVatTu = MTValue.Guid(row["IdLoaiVatTu"]),
                                SoLuong = Convert.ToInt32(row["SoLuong"]),
                                NgayTaoDate = entPhieuChuyen.NgayTaoDate,
                                ChuThich = MTString.Text(row["ChuThich"])
                            };
                            dbContext.KhPhieuChuyenCt.InsertOnSubmit(entPhieuChuyenCt);
                        }
                        dbContext.SubmitChanges();
                    }
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

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ba.SetWaitDialogCaption("Kết thúc thay đổi dữ liệu");
            ba.Exit();

            if (saveResult.Equals("ThanhCong"))
            {
                XtraMessageBox.Show("Tạo mới Phiếu chuyển Thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmParent.BindData();

                if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.Save)
                {
                    MainMenu.Enabled = false;
                    cmdChon.Enabled = false;
                    cmdXoa.Enabled = false;

                    ToolbarMv.EnableTool = INVENTORY.CONTROL.ToolbarMv.Action.Print;
                }
                else if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SaveAdd)
                {
                    this.DialogResult = DialogResult.OK;
                    ToolbarMv.SenderName = INVENTORY.CONTROL.ToolbarMv.Action.Close;
                    ToolbarMv_Clicked(sender, e);
                }
                else if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SavePrint)
                {
                    oReport.dtThongTinPhieu = oReport.KH_PhieuChuyen_GetTable(entPhieuChuyen);
                    oReport.dtThongTinSanPham = dtPhieuChuyenCt;
                    this.DialogResult = DialogResult.Yes;
                    ToolbarMv.SenderName = INVENTORY.CONTROL.ToolbarMv.Action.Close;
                    ToolbarMv_Clicked(sender, e);
                }
                else if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SaveAccept)
                {
                    ToolbarMv.SenderName = INVENTORY.CONTROL.ToolbarMv.Action.Close;
                    ToolbarMv_Clicked(sender, e);
                }
                else if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SaveClose)
                {
                    ToolbarMv.SenderName = INVENTORY.CONTROL.ToolbarMv.Action.Close;
                    ToolbarMv_Clicked(sender, e);
                }
            }
            else if (saveResult.Equals("ThatBai"))
            {
                XtraMessageBox.Show("Tạo mới Phiếu chuyển Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToolbarMv.EnableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
            }
        }
    }
}