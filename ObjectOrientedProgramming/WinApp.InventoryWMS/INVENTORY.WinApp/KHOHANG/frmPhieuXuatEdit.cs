using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuXuatEdit : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        public Form frmParent = null;

        private DateTime dtNgayHienTai = DateTime.Now;
        public Guid IdPhieuXuat = Guid.Empty;

        private DmBoPhan entBoPhan = null;
        private KhPhieuXuat entPhieuXuat = null;
        private DataTable dtPhieuXuatCt, dtPhieuXuatCtDel = null;

        private string saveResult, runType = string.Empty;

        public frmPhieuXuatEdit(Form frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmPhieuXuatEdit_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();

            BindCatalog.DmBoPhan_BindDropDown(cboBoPhan);
            BindCatalog.NguoiNhan_BindDropDown(cboNguoiNhan, AppSetting.entKhoHang.Id);

            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
            brgWorker.RunWorkerAsync("View");
        }

        private void frmPhieuXuatEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            if (ba != null) ba.Exit();
        }

        private void cboBoPhan_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if ((e.CloseMode == PopupCloseMode.ButtonClick || e.CloseMode == PopupCloseMode.Normal) && e.AcceptValue && e.Value != null)
            {
                entBoPhan = cboBoPhan.Properties.GetRowByKeyValue(e.Value) as DmBoPhan;
            }
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
            int SoLuongXuat = Convert.ToInt32(txtSoLuong.EditValue);
            if (SoLuongXuat <= 0)
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
            DataRow[] aPhieuXuatCt = dtPhieuXuatCt.Select(string.Format("IdLoaiVatTu='{0}'", cboLoaiVatTu.EditValue));
            if (aPhieuXuatCt.Length > 0) SoLuongDaChon = Convert.ToInt32(aPhieuXuatCt[0]["SoLuong"]) - Convert.ToInt32(aPhieuXuatCt[0]["SoLuongOld"]);
            if (SoLuongTon < SoLuongDaChon + SoLuongXuat)
            {
                XtraMessageBox.Show("Loại vật tư vừa chọn không đủ số lượng xuất", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiVatTu.Focus();
                return;
            }
            int SoLuong = aPhieuXuatCt.Length > 0 ? Convert.ToInt32(aPhieuXuatCt[0]["SoLuong"]) + SoLuongXuat : SoLuongXuat;

            if (aPhieuXuatCt.Length > 0)
            {
                aPhieuXuatCt[0]["SoLuong"] = SoLuong;
                aPhieuXuatCt[0]["SoLuongTon"] = SoLuongTon;
                if (Convert.ToInt32(aPhieuXuatCt[0]["Status"]) == 1) aPhieuXuatCt[0]["Status"] = 2;
            }
            else
            {
                var entLoaiVatTu = cboLoaiVatTu.Properties.GetRowByKeyValue(cboLoaiVatTu.EditValue) as CustomDmLoaiVatTuGetDropDownResult;

                DataRow drPhieuXuat = dtPhieuXuatCt.NewRow();
                drPhieuXuat["Id"] = Guid.NewGuid();
                drPhieuXuat["IdLoaiVatTu"] = cboLoaiVatTu.EditValue;
                drPhieuXuat["TenLoaiVatTu"] = entLoaiVatTu.Ten;
                drPhieuXuat["TenDonViTinh"] = entLoaiVatTu.TenDonViTinh;
                drPhieuXuat["TenDonViTinh"] = entLoaiVatTu.QuyCach;
                drPhieuXuat["SoLuong"] = SoLuong;
                drPhieuXuat["SoLuongOld"] = 0;
                drPhieuXuat["Status"] = 0;
                dtPhieuXuatCt.Rows.Add(drPhieuXuat);
            }
            dtPhieuXuatCt.AcceptChanges();

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
                    if (Convert.ToInt32(row["Status"]) != 0)
                    {
                        dtPhieuXuatCtDel.ImportRow(row);
                    }
                    row.Delete();
                }
                dtPhieuXuatCt.AcceptChanges();
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
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SaveClose:
                    if (!SaveData_Check()) return;
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SaveAdd:
                    if (!SaveData_Check()) return;
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                    brgWorker.RunWorkerAsync("Save");
                    break;
                case INVENTORY.CONTROL.ToolbarMv.Action.SavePrint:
                    if (!SaveData_Check()) return;
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu lưu thay đổi dữ liệu");
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
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

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuXoa":
                    cmdXoa_Click(sender, e);
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
                    if (gridMainView.FocusedColumn.Name.Contains("ChuThich"))
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

        private void gridMain_txtChuThich_EditValueChanged(object sender, EventArgs e)
        {
            gridMainView.PostEditor();
            if (Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Status")) == 1)
                gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "Status", 2);
            gridMainView.UpdateCurrentRow();
        }

        private bool SaveData_Check()
        {
            if (cboNguoiNhan.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Người nhận", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNguoiNhan.Focus();
                return false;
            }
            if (dtPhieuXuatCt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Chưa nhập Sản phẩm cho Phiếu xuất", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            ColumnView viewMain = gridMain.FocusedView as ColumnView;
            viewMain.CloseEditor();
            if (!viewMain.UpdateCurrentRow())
            {
                XtraMessageBox.Show("Không thể cập nhật Dữ liệu thay đổi trong Danh sách", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string checkHangTon = oFunction.KhNhapXuat_Check_HangTon(null, entPhieuXuat.IdKhoHang, dtPhieuXuatCt, true);
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
                DataTable dtThongTinPhieu = oReport.KH_PhieuXuat_GetTable(entPhieuXuat, entBoPhan);
                DataTable dtThongTinSanPham = dtPhieuXuatCt;
                oReport.KH_PhieuXuat_Print(dtThongTinPhieu, dtThongTinSanPham);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra trong quá trình in dữ liệu " + ex.Message, AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Equals("View"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    entPhieuXuat = dbContext.KhPhieuXuat.ById(IdPhieuXuat).FirstOrDefault();
                    dtPhieuXuatCt = oFunction.KhNhapXuat_Get_ListChiTiet("Xuat", dbContext, IdPhieuXuat);

                    entBoPhan = dbContext.DmBoPhan.ById(entPhieuXuat.IdBoPhan).FirstOrDefault();
                }
            }
            else if (runType.Equals("Save"))
            {
                dtNgayHienTai = AppSetting.DateTime_GetServer();
                using (var dbContext = new InventoryDbContext())
                {
                    dbContext.Connection.Open();
                    dbContext.Transaction = dbContext.Connection.BeginTransaction(System.Data.IsolationLevel.Snapshot);
                    try
                    {
                        entPhieuXuat.Detach();
                        dbContext.KhPhieuXuat.Attach(entPhieuXuat);

                        entPhieuXuat.IdBoPhan = new Guid(cboBoPhan.EditValue.ToString());
                        entPhieuXuat.IdNguoiNhan = Convert.ToInt32(cboNguoiNhan.EditValue);
                        entPhieuXuat.ChuThich = MTString.TextClean(txtChuThich.EditValue);
                        dbContext.SubmitChanges();

                        if (dtPhieuXuatCt.Select("Status<>1").Length > 0 || dtPhieuXuatCtDel.Rows.Count > 0)
                        {
                            dbContext.CustomGenKhPhieuXuatDelete(entPhieuXuat.IdKhoHang, entPhieuXuat.Id, false);

                            KhPhieuXuatCt entPhieuXuatCt = null;
                            foreach (DataRow row in dtPhieuXuatCt.Rows)
                            {
                                entPhieuXuatCt = new KhPhieuXuatCt
                                {
                                    Id = Guid.NewGuid(),
                                    IdPhieuXuat = entPhieuXuat.Id,
                                    IdLoaiVatTu = MTValue.Guid(row["IdLoaiVatTu"]),
                                    SoLuong = Convert.ToInt32(row["SoLuong"]),
                                    NgayTaoDate = entPhieuXuat.NgayTaoDate,
                                    ChuThich = MTString.TextClean(row["ChuThich"])
                                };
                                dbContext.KhPhieuXuatCt.InsertOnSubmit(entPhieuXuatCt);
                            }
                            dbContext.SubmitChanges();
                            dbContext.CustomGenKhPhieuXuatCtUpdate(entPhieuXuat.IdKhoHang, entPhieuXuat.Id);
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
        }

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (runType.Equals("View"))
            {
                ba.SetWaitDialogCaption("Kết thúc truy vấn và Bắt đầu hiển thị dữ liệu");

                BindCatalog.DmLoaiVatTu_BindDropDown(cboLoaiVatTu, entPhieuXuat.IdKhoHang, Guid.Empty, 1);

                txtSoPhieu.EditValue = entPhieuXuat.SoPhieu;
                txtNgayTao.EditValue = entPhieuXuat.NgayTao.ToString("dd/MM/yyyy HH:mm");
                cboBoPhan.EditValue = entPhieuXuat.IdBoPhan;
                cboNguoiNhan.EditValue = entPhieuXuat.IdNguoiNhan;
                txtChuThich.EditValue = entPhieuXuat.ChuThich;

                dtPhieuXuatCtDel = dtPhieuXuatCt.Clone();
                gridMain.DataSource = dtPhieuXuatCt;

                if (!oSecurity.CheckLockData(this.Name, entPhieuXuat.IdNguoiTao, entPhieuXuat.NgayTao, dtNgayHienTai))
                {
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;

                    cmdChon.Enabled = false;
                    cmdXoa.Enabled = false;
                    MainMenu.Enabled = false;

                    gridMainView.OptionsBehavior.Editable = false;
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
                    XtraMessageBox.Show("Sửa đổi Phiếu xuất Thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (frmParent != null && frmParent.GetType() == typeof(frmPhieuXuat))
                        ((frmPhieuXuat)frmParent).BindData();

                    if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.Save)
                    {
                        oReport.location = new Point(0, 0);
                        ToolbarMv.EnableTool = INVENTORY.CONTROL.ToolbarMv.Action.Print;

                        cmdChon.Enabled = false;
                        cmdXoa.Enabled = false;
                        MainMenu.Enabled = false;

                        gridMainView.OptionsBehavior.Editable = false;
                    }
                    else if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SaveAdd)
                    {
                        oReport.location = new Point(0, 0);
                        this.DialogResult = DialogResult.OK;
                        ToolbarMv.SenderName = INVENTORY.CONTROL.ToolbarMv.Action.Close;
                        ToolbarMv_Clicked(sender, e);
                    }
                    else if (ToolbarMv.SenderName == INVENTORY.CONTROL.ToolbarMv.Action.SavePrint)
                    {
                        if (frmParent != null && frmParent.GetType() == typeof(frmPhieuXuat))
                        {
                            oReport.location = this.Location;
                            oReport.dtThongTinPhieu = oReport.KH_PhieuXuat_GetTable(entPhieuXuat, entBoPhan);
                            oReport.dtThongTinSanPham = dtPhieuXuatCt;
                            this.DialogResult = DialogResult.Yes;
                        }
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
                    XtraMessageBox.Show("Sửa đổi Phiếu xuất Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ToolbarMv.EnableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                }
            }
        }
    }
}