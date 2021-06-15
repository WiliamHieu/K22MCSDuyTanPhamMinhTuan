
using System;
using System.Linq;
using System.Collections.Generic;

using DevExpress.XtraGrid.Views.Base;

using INVENTORY.Data;

namespace INVENTORY.WinApp.HETHONG
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        List<CustomHtQuyenHanGetListResult> lstQuyenHan = null;

        public frmPhanQuyen()
        {
            InitializeComponent();
            ToolbarGia.HideTool = INVENTORY.CONTROL.ToolbarGia.Action.Delete;
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            ToolbarGia.FormName = this.Name;
            ToolbarGia.DisableTool = INVENTORY.CONTROL.ToolbarGia.Action.Save;
            ucVaiTro.LoadData();
        }

        private void frmPhanQuyen_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            if (!ucVaiTro.Loaded) return;
            using (var dbContext = new InventoryDbContext())
            {
                lstQuyenHan = dbContext.CustomHtQuyenHanGetList(ucVaiTro.Id).ToList();
                gridMain.DataSource = lstQuyenHan;
            }
        }

        private void ToolbarGia_Clicked(object sender, EventArgs e)
        {
            switch (ToolbarGia.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarGia.Action.Edit:
                    gridMainView.Columns["Xem"].OptionsColumn.AllowEdit = true;
                    gridMainView.Columns["Them"].OptionsColumn.AllowEdit = true;
                    gridMainView.Columns["Sua"].OptionsColumn.AllowEdit = true;
                    gridMainView.Columns["Xoa"].OptionsColumn.AllowEdit = true;
                    ToolbarGia.EnableTool = INVENTORY.CONTROL.ToolbarGia.Action.Save;
                    ToolbarGia.DisableTool = INVENTORY.CONTROL.ToolbarGia.Action.Edit;
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Save:
                    ColumnView viewMain = (ColumnView)gridMain.FocusedView;
                    if (!(viewMain.PostEditor() && viewMain.UpdateCurrentRow())) return;

                    var lstChanged = lstQuyenHan.Where(d => d.ThayDoi == 1).ToList();

                    if (lstChanged != null && lstChanged.Count > 0)
                    {
                        using (var dbContext = new InventoryDbContext())
                        {
                            HtQuyenHan entQuyenHan = null;
                            foreach (var entChanged in lstChanged)
                            {
                                entQuyenHan = new HtQuyenHan
                                {
                                    Id = entChanged.Id,
                                    TenForm = entChanged.TenForm,
                                    IdVaiTro = entChanged.IdVaiTro.Value,
                                    Xem = entChanged.Xem,
                                    Them = entChanged.Them,
                                    Sua = entChanged.Sua,
                                    Xoa = entChanged.Xoa
                                };
                                if (entQuyenHan.Id == 0)
                                {
                                    if (entQuyenHan.Xem)
                                    {
                                        dbContext.HtQuyenHan.InsertOnSubmit(entQuyenHan);
                                        dbContext.SubmitChanges();
                                    }
                                }
                                else
                                {
                                    if (!entQuyenHan.Xem)
                                    {
                                        dbContext.HtQuyenHan.Delete(entQuyenHan.Id);
                                    }
                                    dbContext.SubmitChanges();
                                }
                            }
                        }
                    }
                    gridMainView.Columns["Xem"].OptionsColumn.AllowEdit = false;
                    gridMainView.Columns["Them"].OptionsColumn.AllowEdit = false;
                    gridMainView.Columns["Sua"].OptionsColumn.AllowEdit = false;
                    gridMainView.Columns["Xoa"].OptionsColumn.AllowEdit = false;
                    ToolbarGia.EnableTool = INVENTORY.CONTROL.ToolbarGia.Action.Edit;
                    ToolbarGia.DisableTool = INVENTORY.CONTROL.ToolbarGia.Action.Save;
                    BindData();
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Refresh:
                    BindData();
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Export:
                    oXtraGrid.ExportXLSX(gridMainView, "PhanQuyen");
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Print:
                    oXtraGrid.Print(gridMain, this.Text);
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void ucVaiTro_FocusedNodeChanged(object sender, EventArgs e)
        {
            BindData();
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
        
        private void gridMain_chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            gridMainView.PostEditor();
            bool Xem = Convert.ToBoolean(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Xem"));
            if (Xem == false)
            {
                if (gridMainView.FocusedColumn.FieldName.Equals("Xem"))
                {
                    gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "Them", false);
                    gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "Sua", false);
                    gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "Xoa", false);
                }
                else
                {
                    gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "Xem", true);
                }
                gridMainView.PostEditor();
            }
            gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "ThayDoi", 1);
        }
    }
}