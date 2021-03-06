using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuNhapEdit : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        public Form frmParent = null;

        private DateTime dtNgayHienTai = DateTime.Now;
        public Guid IdPhieuNhap = Guid.Empty;

        private KhPhieuNhap entPhieuNhap = null;
        private DataTable dtPhieuNhapCt, dtPhieuNhapCtDel = null;

        private string saveResult, runType = string.Empty;

        public frmPhieuNhapEdit(Form frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmPhieuNhapEdit_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();

            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
            brgWorker.RunWorkerAsync("View");
        }

        private void frmPhieuNhapEdit_FormClosing(object sender, FormClosingEventArgs e)
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
                if (Convert.ToInt32(aPhieuNhapCt[0]["Status"]) == 1) aPhieuNhapCt[0]["Status"] = 2;
            }
            else
            {
                var entLoaiVatTu = cboLoaiVatTu.Properties.GetRowByKeyValue(cboLoaiVatTu.EditValue) as CustomDmLoaiVatTuGetDropDownResult;

                DataRow drPhieuNhapCt = dtPhieuNhapCt.NewRow();
                drPhieuNhapCt["Id"] = Guid.NewGuid();
                drPhieuNhapCt["IdLoaiVatTu"] = cboLoaiVatTu.EditValue;
                drPhieuNhapCt["TenLoaiVatTu"] = entLoaiVatTu.Ten;
                drPhieuNhapCt["TenDonViTinh"] = entLoaiVatTu.TenDonViTinh;
                drPhieuNhapCt["QuyCach"] = entLoaiVatTu.QuyCach;
                drPhieuNhapCt["SoLuong"] = SoLuong;
                drPhieuNhapCt["SoLuongNhap"] = 0;
                drPhieuNhapCt["SoLuongTon"] = SoLuong;
                drPhieuNhapCt["SoLuongOld"] = SoLuong;
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
                    using (var dbContext = new InventoryDbContext())
                    {
                        bool checkModified = dbContext.KhSanPham.Where(d => d.SoLuongNhap != d.SoLuongTon).Any(d => d.IdLoaiVatTu == MTValue.Guid(row["IdLoaiVatTu"]));
                        if (checkModified == false)
                        {
                            dtPhieuNhapCtDel.ImportRow(row);
                            row.Delete();
                        }
                        else
                        {
                            XtraMessageBox.Show("Loại vật tư " + row["TenLoaiVatTu"] + " đã thay đổi hàng tồn nên không thể Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
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
                    IdKhoHang = entPhieuNhap.IdKhoHang,
                    rowPhieuNhapCt = gridMainView.GetDataRow(gridMainView.FocusedRowHandle)
                };
                frm.ShowDialog();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Xóa bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuNhap_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuXoa":
                    if (cmdXoa.Enabled) cmdXoa_Click(sender, e);
                    break;
                case "mnuThayDoi":
                    if (cmdThayDoi.Enabled) cmdThayDoi_Click(sender, e);
                    break;
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

        private void gridMain_txtChuThich_EditValueChanged(object sender, EventArgs e)
        {
            gridMainView.PostEditor();
            if (Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Status")) == 1)
                gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "Status", 2);
            gridMainView.UpdateCurrentRow();
        }

        public void HangNhap_Update()
        {
            gridMainView.PostEditor();
            gridMainView.UpdateCurrentRow();
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
            using (var dbContext = new InventoryDbContext())
            {
                DataRow[] aPhieuNhapCt = dtPhieuNhapCt.Select("SoLuong<>SoLuongOld");
                if (aPhieuNhapCt != null && aPhieuNhapCt.Length > 0)
                {
                    KhSanPham entSanPham = null;
                    foreach (DataRow row in aPhieuNhapCt)
                    {
                        entSanPham = dbContext.KhSanPham.ById(MTValue.Guid(row["IdSanPham"])).FirstOrDefault();
                        if (entSanPham != null && (Convert.ToInt32(row["SoLuong"]) < entSanPham.SoLuongNhap - entSanPham.SoLuongTon))
                        {
                            XtraMessageBox.Show("Loại vật tư " + row["TenLoaiVatTu"] + " đã thay đổi hàng tồn nên không thể Thay đổi số lượng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                if (dtPhieuNhapCtDel != null && dtPhieuNhapCtDel.Rows.Count > 0)
                {
                    foreach (DataRow row in dtPhieuNhapCtDel.Rows)
                    {
                        if (dbContext.KhSanPham.Where(d => d.SoLuongTon != d.SoLuongNhap).Any(d => d.IdLoaiVatTu == MTValue.Guid(row["IdLoaiVatTu"])))
                        {
                            XtraMessageBox.Show("Loại vật tư " + row["TenLoaiVatTu"] + " đã thay đổi hàng tồn nên không thể Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
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

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Equals("View"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    entPhieuNhap = dbContext.KhPhieuNhap.ById(IdPhieuNhap).FirstOrDefault();
                    dtPhieuNhapCt = oFunction.KhNhapXuat_Get_ListChiTiet(entPhieuNhap.LoaiNhap.Equals(0) ? "Nhap" : "NhapDn", dbContext, entPhieuNhap.Id);
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

                        entPhieuNhap.Detach();
                        dbContext.KhPhieuNhap.Attach(entPhieuNhap);

                        entPhieuNhap.IdNguonNhap = new Guid(cboNguonNhap.EditValue.ToString());
                        entPhieuNhap.ChuThich = MTString.TextClean(txtChuThichHd.EditValue);
                        dbContext.SubmitChanges();

                        KhSanPham entSanPham = null;
                        KhPhieuNhapCt entPhieuNhapCt = null;

                        DataRow[] aPhieuNhapAdd = dtPhieuNhapCt.Select("Status=0");
                        if (aPhieuNhapAdd != null && aPhieuNhapAdd.Length > 0)
                        {
                            Guid IdSanPham = Guid.Empty;
                            int SoLuong = 0;
                            entPhieuNhap.UpdateTon = true;
                            foreach (DataRow rowAdd in aPhieuNhapAdd)
                            {
                                IdSanPham = Guid.NewGuid();
                                SoLuong = Convert.ToInt32(rowAdd["SoLuong"]);

                                entSanPham = new KhSanPham
                                {
                                    Id = IdSanPham,
                                    IdSanPham = IdSanPham,
                                    IdKhoHang = entPhieuNhap.IdKhoHang,
                                    IdNguonNhap = entPhieuNhap.IdNguonNhap,
                                    IdLoaiVatTu = new Guid(rowAdd["IdLoaiVatTu"].ToString()),
                                    SoLuongNhap = SoLuong,
                                    SoLuongTon = SoLuong,
                                    NgayTao = entPhieuNhap.NgayTao
                                };
                                dbContext.KhSanPham.InsertOnSubmit(entSanPham);

                                entPhieuNhapCt = new KhPhieuNhapCt
                                {
                                    Id = Guid.NewGuid(),
                                    IdPhieuNhap = entPhieuNhap.Id,
                                    IdLoaiVatTu = entSanPham.IdLoaiVatTu,
                                    IdSanPham = entSanPham.Id,
                                    SoLuong = SoLuong,
                                    NgayTaoDate = entPhieuNhap.NgayTaoDate,
                                    ChuThich = MTString.Text(rowAdd["ChuThich"])
                                };
                                dbContext.KhPhieuNhapCt.InsertOnSubmit(entPhieuNhapCt);

                                dbContext.SubmitChanges();
                            }
                        }
                        DataRow[] aPhieuNhapEdit = dtPhieuNhapCt.Select("Status=2");
                        if (aPhieuNhapEdit != null && aPhieuNhapEdit.Length > 0)
                        {
                            Guid IdPhieuNhapCt = Guid.Empty;
                            foreach (DataRow rowEdit in aPhieuNhapEdit)
                            {
                                IdPhieuNhapCt = new Guid(rowEdit["Id"].ToString());
                                entPhieuNhapCt = dbContext.KhPhieuNhapCt.ById(IdPhieuNhapCt).FirstOrDefault();
                                entPhieuNhapCt.IdLoaiVatTu = new Guid(rowEdit["IdLoaiVatTu"].ToString());
                                entPhieuNhapCt.IdSanPham = new Guid(rowEdit["IdSanPham"].ToString());
                                entPhieuNhapCt.SoLuong = Convert.ToInt32(rowEdit["SoLuong"]);
                                entPhieuNhapCt.NgayTaoDate = entPhieuNhap.NgayTaoDate;
                                entPhieuNhapCt.ChuThich = MTString.Text(rowEdit["ChuThich"]);

                                entSanPham = dbContext.KhSanPham.ById(entPhieuNhapCt.IdSanPham).FirstOrDefault();
                                int ChenhLech = entPhieuNhapCt.SoLuong - Convert.ToInt32(rowEdit["SoLuongOld"]);
                                if (ChenhLech != 0)
                                {
                                    entSanPham.SoLuongNhap += ChenhLech;
                                    entSanPham.SoLuongTon += ChenhLech;
                                    entPhieuNhap.UpdateTon = true;
                                }
                                entSanPham.IdLoaiVatTu = entPhieuNhapCt.IdLoaiVatTu;

                                dbContext.SubmitChanges();
                            }
                        }
                        if (dtPhieuNhapCtDel != null && dtPhieuNhapCtDel.Rows.Count > 0)
                        {
                            entPhieuNhap.UpdateTon = true;
                            foreach (DataRow rowDel in dtPhieuNhapCtDel.Rows)
                            {
                                entPhieuNhapCt = dbContext.KhPhieuNhapCt.ById(new Guid(rowDel["Id"].ToString())).FirstOrDefault();
                                if (entPhieuNhapCt != null)
                                {
                                    dbContext.KhPhieuNhapCt.Delete(entPhieuNhapCt.Id);
                                    dbContext.SubmitChanges();

                                    dbContext.KhSanPham.Delete(entPhieuNhapCt.IdSanPham);
                                    dbContext.SubmitChanges();
                                }
                            }
                        }

                        dbContext.CustomGenKhPhieuNhapUpdate(entPhieuNhap.Id, entPhieuNhap.IdNguonNhap);

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

                txtSoPhieu.EditValue = entPhieuNhap.SoPhieu;
                txtNgayTao.EditValue = entPhieuNhap.NgayTao.ToString("dd/MM/yyyy HH:mm");
                txtChuThichHd.EditValue = entPhieuNhap.ChuThich;

                if (entPhieuNhap.LoaiNhap > 0)
                {
                    var entNguonNhap = oFunction.DmNguonNhap_Entity(entPhieuNhap.IdNguonNhap);
                    txtTenNguonNhap.EditValue = entNguonNhap.Ten;
                    txtTenNguonNhap.Visible = true;
                    cboNguonNhap.Visible = false;
                }
                else
                {
                    BindCatalog.DmNguonNhap_BindDropDown(cboNguonNhap);
                    cboNguonNhap.EditValue = entPhieuNhap.IdNguonNhap;

                    BindCatalog.DmLoaiVatTu_BindDropDown(cboLoaiVatTu, entPhieuNhap.IdKhoHang, Guid.Empty, 0);
                }

                dtPhieuNhapCtDel = dtPhieuNhapCt.Clone();
                gridMain.DataSource = dtPhieuNhapCt;

                if (!oSecurity.CheckLockData(this.Name, entPhieuNhap.IdNguoiTao, entPhieuNhap.NgayTao, dtNgayHienTai) || entPhieuNhap.LoaiNhap > 0)
                {
                    ToolbarMv.DisableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;

                    cmdThem.Enabled = false;
                    cmdXoa.Enabled = false;
                    cmdThayDoi.Enabled = false;

                    MenuNhap.Enabled = false;

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
                    XtraMessageBox.Show("Sửa đổi Phiếu nhập Thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (frmParent != null && frmParent.GetType() == typeof(frmPhieuNhap))
                        ((frmPhieuNhap)frmParent).BindData();

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
                    XtraMessageBox.Show("Sửa đổi Phiếu nhập Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ToolbarMv.EnableTool = INVENTORY.CONTROL.ToolbarMv.Action.Save;
                }
            }
        }
    }
}