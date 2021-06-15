using System;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using INVENTORY.Data;

namespace INVENTORY.WinApp.CONTROL
{
    public partial class ucVaiTro : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler FocusedNodeChanged;

        public ucVaiTro()
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
                var lstVaiTro = dbContext.HtVaiTro.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
                foreach (var entVaiTro in lstVaiTro)
                {
                    TreeMain.AppendNode(new object[] { entVaiTro.Id, entVaiTro.Ten }, null, 0);
                }
            }
            TreeMain.EndUnboundLoad();
            TreeMain.CollapseAll();
            Loaded = true;
        }

        public int Id
        {
            get
            {
                if (TreeMain.FocusedNode != null)
                    return Convert.ToInt32(TreeMain.FocusedNode["Id"]);
                return 0;
            }
        }

        public TreeListNode FocusedNode
        {
            set
            {
                if (value != null)
                {
                    Loaded = false;
                    int IdVaiTro = Convert.ToInt32(value["Id"]);
                    TreeMain.FocusedNode = TreeMain.FindNodeByFieldValue("Id", IdVaiTro);
                    TreeMain.FocusedNode.Expanded = value.Expanded;
                    Loaded = true;
                }
            }
            get
            {
                return TreeMain.FocusedNode;
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
            e.NodeImageIndex = 0;
        }
    }
}
