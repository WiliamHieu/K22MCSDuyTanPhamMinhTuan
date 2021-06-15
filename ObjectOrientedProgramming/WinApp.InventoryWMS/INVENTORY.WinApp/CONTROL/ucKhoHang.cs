using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;

using INVENTORY.Data;

namespace INVENTORY.WinApp.CONTROL
{
    public partial class ucKhoHang : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler FocusedNodeChanged;

        public ucKhoHang()
        {
            InitializeComponent();
        }

        public bool Loaded { get; set; } = false;

        public void LoadData()
        {
            Loaded = false;
            TreeMain.Nodes.Clear();
            TreeMain.BeginUnboundLoad();
            TreeListNode nodeChiNhanh, nodeKhoHang = null;

            using (var dbContext = new InventoryDbContext())
            {
                var lstChiNhanh = dbContext.DmChiNhanh.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
                TreeListNode nodeTatCa = TreeMain.AppendNode(new object[] { 0, "Tất cả" }, null, CheckState.Checked);
                foreach (DmChiNhanh entChiNhanh in lstChiNhanh)
                {
                    nodeChiNhanh = TreeMain.AppendNode(new object[] { 0, entChiNhanh.Id, 0, entChiNhanh.TenVietTat }, null, 0);
                    var lstKhoHang = dbContext.DmKhoHang.ByTrangThai(1).ByIdChiNhanh(entChiNhanh.Id).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
                    foreach (var entKhoHang in lstKhoHang)
                    {
                        nodeKhoHang = TreeMain.AppendNode(new object[] { 0, entKhoHang.IdChiNhanh, entKhoHang.Id, entKhoHang.Ten }, nodeChiNhanh, 0);
                        var lstVaiTro = dbContext.CustomHtVaiTroGetKhoHang(entKhoHang.Id).ToList();
                        foreach (var entVaiTro in lstVaiTro)
                        {
                            TreeMain.AppendNode(new object[] { entVaiTro.Id, entKhoHang.IdChiNhanh, entKhoHang.Id, entVaiTro.Ten }, nodeKhoHang, 0);
                        }
                    }
                }
            }

            TreeMain.EndUnboundLoad();
            foreach (TreeListNode node in TreeMain.Nodes)
            {
                node.Expanded = true;
            }
            Loaded = true;
        }

        public int IdKhoHang
        {
            get
            {
                return Convert.ToInt32(TreeMain.FocusedNode["IdKhoHang"]);
            }
        }

        public int IdChiNhanh
        {
            get
            {
                return Convert.ToInt32(TreeMain.FocusedNode["IdChiNhanh"]);
            }
        }

        public int IdVaiTro
        {
            get
            {
                return Convert.ToInt32(TreeMain.FocusedNode["Id"]);
            }
        }

        private void TreeMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (FocusedNodeChanged != null)
            {
                FocusedNodeChanged(this, new System.EventArgs());
            }
        }

        private void TreeMain_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e)
        {
            e.NodeImageIndex = e.Node.Level;
        }
    }
}
