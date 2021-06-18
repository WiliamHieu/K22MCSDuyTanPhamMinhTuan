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
                foreach (DmChiNhanh entChiNhanh in lstChiNhanh)
                {
                    nodeChiNhanh = TreeMain.AppendNode(new object[] { 0, entChiNhanh.Id, 0, entChiNhanh.TenVietTat }, null, 0);
                    var lstKhoHang = dbContext.DmKhoHang.ByTrangThai(1).ByIdChiNhanh(entChiNhanh.Id).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
                    foreach (var entKhoHang in lstKhoHang)
                    {
                        nodeKhoHang = TreeMain.AppendNode(new object[] { entKhoHang.Id, entKhoHang.IdChiNhanh, 0, entKhoHang.Ten }, nodeChiNhanh, 0);
                        var lstVaiTro = dbContext.CustomHtVaiTroGetKhoHang(entKhoHang.Id).ToList();
                        foreach (var entVaiTro in lstVaiTro)
                        {
                            TreeMain.AppendNode(new object[] { entKhoHang.Id, entKhoHang.IdChiNhanh, entVaiTro.Id, entVaiTro.Ten }, nodeKhoHang, 0);
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
                return Convert.ToInt32(TreeMain.FocusedNode["Id"]);
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
                return Convert.ToInt32(TreeMain.FocusedNode["IdVaiTro"]);
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
