using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuNhapAdd : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        public frmPhieuNhap frmParent = null;

        private DateTime dtNgayHienTai = DateTime.Now;

        private KhPhieuNhap entPhieuNhap = null;
        private DataTable dtPhieuNhapCt = null;

        private string saveResult= string.Empty;

        public frmPhieuNhapAdd(frmPhieuNhap frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmPhieuNhapAdd_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();

            txtSoPhieu.EditValue = oFunction.KhNhapXuat_Get_SoPhieu("Nhap", null, dtNgayHienTai);
            txtNgayTao.EditValue = dtNgayHienTai.ToString("dd/MM/yyyy HH:mm");

            BindCatalog.DmNguonNhap_BindDropDown(cboNguonNhap);
            BindCatalog.DmLoaiVatTu_BindDropDown(cboLoaiVatTu, AppSetting.entKhoHang.Id, Guid.Empty, 0);

            dtPhieuNhapCt = oInitData.KH_SanPham_InitTable();
            gridMain.DataSource = dtPhieuNhapCt;

            ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Print;
        }

        private void frmPhieuNhapAdd_FormClosing(object sender, FormClosingEventArgs e)
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
                if (cmdThem.Enabled) cmdThem_Click(sender, e);
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
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
            int SoLuongNhap = Convert.ToInt32(txtSoLuong.EditValue);
            if (SoLuongNhap == 0)
            {
                XtraMessageBox.Show("Chưa nhập Số lượng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            DataRow[] aPhieuNhapCt = dtPhieuNhapCt.Select(string.Format("IdLoaiVatTu='{0}'", cboLoaiVatTu.EditValue));
            int SoLuong = aPhieuNhapCt.Length > 0 ? Convert.ToInt32(aPhieuNhapCt[0]["SoLuong"]) + SoLuongNhap : SoLuongNhap;

            if (aPhieuNhapCt.Length > 0)
            {
                aPhieuNhapCt[0]["SoLuong"] = SoLuong;
            }
            else
            {
                var entLoaiVatTu = cboLoaiVatTu.Properties.GetRowByKeyValue(cboLoaiVatTu.EditValue) as CustomDmLoaiVatTuGetDropDownResult;

                DataRow drPhieuNhapCt = dtPhieuNhapCt.NewRow();
                drPhieuNhapCt["Id"] = Guid.NewGuid();
                drPhieuNhapCt["IdSanPham"] = Guid.NewGuid();
                drPhieuNhapCt["IdLoaiVatTu"] = cboLoaiVatTu.EditValue;
                drPhieuNhapCt["TenLoaiVatTu"] = entLoaiVatTu.Ten;
                drPhieuNhapCt["QuyCach"] = entLoaiVatTu.QuyCach;
                drPhieuNhapCt["TenDonViTinh"] = entLoaiVatTu.TenDonViTinh;
                drPhieuNhapCt["SoLuong"] = SoLuong;
                drPhieuNhapCt["Status"] = 0;
                dtPhieuNhapCt.Rows.Add(drPhieuNhapCt);
            }
            dtPhieuNhapCt.AcceptChanges();

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
                    XtraMessageBox.Show("Chưa chọn Danh sách Sản phẩm để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa Danh sách Sản phẩm đã chọn không?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drResult == DialogResult.No) return;

                List<DataRow> lstRowsSelected = oXtraGrid.Get_SelectedRows(gridMainView);
                foreach (DataRow row in lstRowsSelected)
                {
                    row.Delete();
                }
                dtPhieuNhapCt.AcceptChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Xóa bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdThayDoi_Click(object sender, EventArgs e)
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
                    XtraMessageBox.Show("Chưa chọn Danh sách Sản phẩm để Thay đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (gridMainView.GetSelectedRows().Length > 1)
                {
                    XtraMessageBox.Show("Mỗi lần chỉ Thay đổi một Loại vật tư", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var frm = new frmPhieuNhapModify(this)
                {
                    IdKhoHang = AppSetting.entKhoHang.Id,
                    rowPhieuNhapCt = gridMainView.GetDataRow(gridMainView.FocusedRowHandle)
                };
                frm.ShowDialog();
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
                    ba.CreateWaitDialog();
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SaveClose:
                    if (!SaveData_Check()) return;
                    ba.CreateWaitDialog();
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SaveAdd:
                    if (!SaveData_Check()) return;
                    ba.CreateWaitDialog();
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SavePrint:
                    if (!SaveData_Check()) return;
                    ba.CreateWaitDialog();
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
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

        private void MenuNhap_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuXoa":
                    cmdXoa_Click(sender, e);
                    break;
                case "mnuThayDoi":
                    cmdThayDoi_Click(sender, e);
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
                    if (gridMainView.FocusedColumn.Name.EndsWith("SoLuong") || gridMainView.FocusedColumn.Name.EndsWith("ChuThich"))
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

        private void gridMain_spSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridMainView.PostEditor();
                gridMainView.UpdateCurrentRow();
                gridMainView.UpdateTotalSummary();
            }
            catch (Exception)
            {
            }
        }

        public void HangNhap_Update()
        {
            gridMainView.PostEditor();
            gridMainView.UpdateCurrentRow();
        }

        private void Print()
        {
            try
            {
                DataTable dtThongTinPhieu = oReport.KH_PhieuNhap_GetTable(entPhieuNhap);
                DataTable dtThongTinSanPham = dtPhieuNhapCt;
                oReport.KH_PhieuNhap_Print(dtThongTinPhieu, dtThongTinSanPham);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Có lỗi xảy ra trong quá trình in dữ liệu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveData_Check()
        {
            if (cboNguonNhap.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Nguồn nhập", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNguonNhap.Focus();
                return false;
            }
            if (dtPhieuNhapCt == null || dtPhieuNhapCt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Chưa nhập Sản phẩm cho Phiếu nhập", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            ColumnView viewMain = gridMain.FocusedView as ColumnView;
            viewMain.CloseEditor();
            if (!viewMain.UpdateCurrentRow())
            {
                XtraMessageBox.Show("Không thể cập nhật Dữ liệu thay đổi trong Danh sách", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

                    entPhieuNhap = new KhPhieuNhap
                    {
                        Id = Guid.NewGuid(),
                        IdKhoHang = AppSetting.entKhoHang.Id,
                        SoPhieu = oFunction.KhNhapXuat_Get_SoPhieu("Nhap", dbContext, dtNgayHienTai),
                        IdNguonNhap = new Guid(cboNguonNhap.EditValue.ToString()),
                        IdNguoiTao = AppSetting.entNguoiDung.Id,
                        NgayTao = dtNgayHienTai,
                        NgayTaoDate = dtNgayHienTai.Date,
                        ChuThich = MTString.TextClean(txtChuThich.EditValue)
                    };
                    dbContext.KhPhieuNhap.InsertOnSubmit(entPhieuNhap);
                    dbContext.SubmitChanges();

                    Guid IdSanPham = Guid.Empty;
                    KhSanPham entSanPham = null;
                    KhPhieuNhapCt entPhieuNhapCt = null;
                    foreach (DataRow row in dtPhieuNhapCt.Rows)
                    {
                        IdSanPham = Guid.NewGuid();
                        entSanPham = new KhSanPham
                        {
                            Id = IdSanPham,
                            IdSanPham = IdSanPham,
                            IdKhoHang = entPhieuNhap.IdKhoHang,
                            IdNguonNhap = entPhieuNhap.IdNguonNhap,
                            IdLoaiVatTu = MTValue.Guid(row["IdLoaiVatTu"]),
                            SoLuongNhap = Convert.ToInt32(row["SoLuong"]),
                            SoLuongTon = Convert.ToInt32(row["SoLuong"]),
                            NgayTao = entPhieuNhap.NgayTao
                        };
                        dbContext.KhSanPham.InsertOnSubmit(entSanPham);

                        entPhieuNhapCt = new KhPhieuNhapCt
                        {
                            Id = Guid.NewGuid(),
                            IdPhieuNhap = entPhieuNhap.Id,
                            IdLoaiVatTu = entSanPham.IdLoaiVatTu,
                            IdSanPham = entSanPham.Id,
                            SoLuong = entSanPham.SoLuongNhap,
                            NgayTaoDate = entPhieuNhap.NgayTaoDate,
                            ChuThich = MTString.Text(row["ChuThich"])
                        };
                        dbContext.KhPhieuNhapCt.InsertOnSubmit(entPhieuNhapCt);
                    }
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

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ba.SetWaitDialogCaption("Kết thúc thay đổi dữ liệu");
            ba.Exit();

            if (saveResult.Equals("ThanhCong"))
            {
                XtraMessageBox.Show("Tạo mới Phiếu nhập Thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmParent.BindData();

                if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.Save)
                {
                    ToolbarMv.EnableTool = INVENTORY.CONTROL.ToolbarMv.Action.Print;

                    cmdThem.Enabled = false;
                    cmdXoa.Enabled = false;
                    cmdThayDoi.Enabled = false;
                    MenuNhap.Enabled = false;

                    gridMainView.OptionsBehavior.Editable = false;
                }
                else if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SaveAdd)
                {
                    this.DialogResult = DialogResult.OK;
                    ToolbarMv.SenderName = INVENTORY.CONTROL.ToolbarMv.Action.Close;
                    ToolbarMv_Clicked(sender, e);
                }
                else if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SavePrint)
                {
                    oReport.dtThongTinPhieu = oReport.KH_PhieuNhap_GetTable(entPhieuNhap);
                    oReport.dtThongTinSanPham = dtPhieuNhapCt;

                    this.DialogResult = DialogResult.Yes;
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
                XtraMessageBox.Show("Tạo mới Phiếu nhập Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToolbarMv.EnableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
            }
        }
    }
}