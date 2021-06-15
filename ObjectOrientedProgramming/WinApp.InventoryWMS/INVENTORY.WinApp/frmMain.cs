using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int firstLoad = 0;

        public frmMain()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = AppSetting.entThietLap.TenPhanMem;
            cmdNguoiDungOnline.Caption = AppSetting.entNguoiDung.Ten;

            cboKhoHienTai.DataSource = AppSetting.lstKhoHang;
            lblKhoHienTai.EditValue = AppSetting.entKhoHang.Id;

            Layout_Init();
            firstLoad = 1;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ribbon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = null;
            switch (e.Item.Name)
            {
                //////////TRỢ GIÚP///////////
                case "cmdTGPhanHoiLoiHeThong":
                    Process.Start("http://www.mtsoftware.vn");
                    return;
                case "cmdTGGioiThieuPhanMem":
                    frm = new frmAbout();
                    frm.ShowDialog();
                    return;

                //////////QUẢN TRỊ///////////
                case "cmdHTDangXuat":
                    Application_Exit(true);
                    return;
                case "cmdHTKetThuc":
                    Application_Exit(false);
                    return;
                case "cmdHTNguoiDungInfor":
                    frm = new HETHONG.frmNguoiDungEdit();
                    frm.ShowDialog();
                    return;
                case "cmdHTThietLap":
                    frm = new HETHONG.frmThietLap();
                    frm.ShowDialog();
                    return;

                case "cmdNguoiDungOnline":
                    frm = new HETHONG.frmNguoiDungEdit();
                    frm.ShowDialog();
                    return;
                case "cmdHTNguoiDung":
                    frm = new HETHONG.frmNguoiDung();
                    break;
                case "cmdHTVaiTro":
                    frm = new HETHONG.frmVaiTro();
                    break;
                case "cmdHTPhanQuyen":
                    frm = new HETHONG.frmPhanQuyen();
                    break;

                //Danh mục
                case "cmdDMChiNhanh":
                    frm = new DANHMUC.frmChiNhanh();
                    break;
                case "cmdDMKhoHang":
                    frm = new DANHMUC.frmKhoHang();
                    break;

                case "cmdDMNguonNhap":
                    frm = new DANHMUC.frmNguonNhap();
                    break;
                case "cmdDMBoPhan":
                    frm = new DANHMUC.frmBoPhan();
                    break;

                case "cmdDMNhomVatTu":
                    frm = new DANHMUC.frmNhomVatTu();
                    break;
                case "cmdDMLoaiVatTu":
                    frm = new DANHMUC.frmLoaiVatTu();
                    break;
                case "cmdDMDonViTinh":
                    frm = new DANHMUC.frmDonViTinh();
                    break;

                // Kho hàng
                case "cmdKHPhieuNhap":
                    frm = new KHOHANG.frmPhieuNhap();
                    break;
                case "cmdKHPhieuChuyen":
                    frm = new KHOHANG.frmPhieuChuyen();
                    break;
                case "cmdKHPhieuNhapNb":
                    frm = new KHOHANG.frmPhieuNhapNb();
                    break;
                case "cmdKHPhieuXuat":
                    frm = new KHOHANG.frmPhieuXuat();
                    break;
                case "cmdKHHangTonKho":
                    frm = new KHOHANG.frmHangTon();
                    break;

                //Báo cáo
                case "cmdBCHangNhap":
                    frm = new BAOCAO.FORM.frmHangNhap();
                    break;
                case "cmdBCHangXuat":
                    frm = new BAOCAO.FORM.frmHangXuat();
                    break;

                case "cmdBCHangChuyen":
                    frm = new BAOCAO.FORM.frmHangChuyen();
                    break;
                case "cmdBCHangLuuKho":
                    frm = new BAOCAO.FORM.frmHangLuuKho();
                    break;

                case "cmdBCNhapXuatTon":
                    frm = new BAOCAO.FORM.frmNhapXuatTon();
                    break;
                case "cmdBCHangTonTheoKho":
                    frm = new BAOCAO.FORM.frmHangTonTheoKho();
                    break;
            }
            if (frm == null) return;
            foreach (Form mdichild in this.MdiChildren)
            {
                if (frm.Name == mdichild.Name)
                {
                    mdichild.Activate();
                    return;
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void cmdCopyRight_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void cboKhoHienTai_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (firstLoad == 0) return;
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
        }

        private void lblKhoHienTai_EditValueChanged(object sender, EventArgs e)
        {
            if (firstLoad == 0) return;
            brgWorker.RunWorkerAsync();
        }

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var dbContext = new InventoryDbContext())
                {
                    int IdKhoHang = Convert.ToInt32(lblKhoHienTai.EditValue);
                    var entNguoiDungVaiTro = dbContext.HtNguoiDungVaiTro.ByIdNguoiDung(AppSetting.entNguoiDung.Id).ByIdKhoHang(IdKhoHang).FirstOrDefault();
                    AppSetting.entKhoHang = dbContext.DmKhoHang.ById(entNguoiDungVaiTro.IdKhoHang).FirstOrDefault();
                    AppSetting.entChiNhanh = dbContext.DmChiNhanh.ById(AppSetting.entKhoHang.IdChiNhanh).FirstOrDefault();
                    AppSetting.lstQuyenHan = dbContext.HtQuyenHan.ByIdVaiTro(entNguoiDungVaiTro.IdVaiTro).ToList();
                }
            }
            catch (Exception)
            {
            }
        }

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Form mdichild in this.MdiChildren)
            {
                mdichild.Close();
            }
            Layout_Init();
        }

        private void Layout_Init()
        {
            foreach (DevExpress.XtraBars.Ribbon.RibbonPage page in mainRibbon.Pages)
            {
                int PageVisibleCount = 0;
                foreach (DevExpress.XtraBars.Ribbon.RibbonPageGroup group in page.Groups)
                {
                    if (group.Name.Equals("groupHTNguoiDung")) continue;
                    int countVisible = 0;
                    foreach (var itemLink in group.ItemLinks)
                    {
                        if (itemLink is BarButtonItemLink item)
                        {
                            if (oSecurity.CheckView("frm" + item.Item.Name.Remove(0, 5)))
                            {
                                item.Visible = true;
                                countVisible++;
                            }
                            else
                            {
                                item.Visible = false;
                            }
                        }
                    }
                    group.Visible = countVisible > 0;
                    PageVisibleCount = countVisible > 0 ? PageVisibleCount + 1 : PageVisibleCount;
                }
                page.Visible = PageVisibleCount > 0;
            }

            if (pageHeThong.Groups.Count == 0)
                pageHeThong.Visible = false;
            else
                pageHeThong.Visible = true;
        }

        private void Application_Exit(bool IsRestart)
        {
            try
            {
                if (brgWorker.IsBusy) brgWorker.CancelAsync();

                if (IsRestart) Application.Restart();
                else Application.Exit();
            }
            catch (Exception)
            {
            }
        }
    }
}