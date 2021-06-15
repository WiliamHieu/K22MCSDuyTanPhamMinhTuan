using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using INVENTORY.Data;

namespace INVENTORY.WinApp.CONTROL
{
    public partial class ucChiNhanh : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler FocusedNodeChanged;

        public ucChiNhanh()
        {
            InitializeComponent();
        }

        public bool Loaded { get; private set; } = false;

        public void LoadData()
        {
            Loaded = false;
            TreeMain.Nodes.Clear();
            TreeMain.BeginUnboundLoad();
            using (var dbContext = new InventoryDbContext())
            {
                var lstChiNhanh = dbContext.DmChiNhanh.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
                TreeListNode nodeTatCa = TreeMain.AppendNode(new object[] { 0, "Tất cả" }, null, CheckState.Checked);
                foreach (DmChiNhanh entChiNhanh in lstChiNhanh)
                {
                    TreeMain.AppendNode(new object[] { entChiNhanh.Id, entChiNhanh.TenVietTat }, nodeTatCa, 0);
                }
            }
            TreeMain.EndUnboundLoad();
            TreeMain.ExpandAll();
            Loaded = true;
        }

        public int IdChiNhanh
        {
            get
            {
                return Convert.ToInt32(TreeMain.FocusedNode["Id"]);
            }
        }

        private void TreeMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            FocusedNodeChanged?.Invoke(this, new System.EventArgs());
        }

        private void TreeMain_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e)
        {
            if (Convert.ToInt32(e.Node["Id"]) == 0)
            {
                e.NodeImageIndex = 0;
            }
            else
            {
                e.NodeImageIndex = 1;
            }
        }
    }
}
