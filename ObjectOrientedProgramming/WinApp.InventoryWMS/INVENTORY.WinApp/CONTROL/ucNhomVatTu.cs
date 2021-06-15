using System;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using INVENTORY.Data;

namespace INVENTORY.WinApp.CONTROL
{
    public partial class ucNhomVatTu : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler FocusedNodeChanged;

        public ucNhomVatTu()
        {
            InitializeComponent();
        }

        public bool Loaded { get; private set; } = false;

        public void LoadData(bool ShowCheckBox)
        {
            Loaded = false;
            TreeMain.Nodes.Clear();
            TreeMain.BeginUnboundLoad();

            TreeListNode nodeAll = TreeMain.AppendNode(new object[] { DBNull.Value, "Tất cả" }, null, 0);
            using (var dbContext = new InventoryDbContext())
            {
                var lstNhomVatTu = dbContext.DmNhomVatTu.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
                foreach (var entNhomVatTu in lstNhomVatTu)
                {
                    TreeMain.AppendNode(new object[] { entNhomVatTu.Id, entNhomVatTu.Ten }, nodeAll, 0);
                }
            }
            TreeMain.EndUnboundLoad();
            TreeMain.OptionsView.ShowCheckBoxes = ShowCheckBox;
            if (ShowCheckBox) TreeMain.CheckAll();
            if (TreeMain.Nodes.Count > 0) TreeMain.Nodes.FirstNode.ExpandAll();

            Loaded = true;
        }

        public object IdNhomVatTu
        {
            get
            {
                if (TreeMain.FocusedNode != null) return TreeMain.FocusedNode["Id"];
                return DBNull.Value;
            }
        }

        public string GetCheckedIds
        {
            get
            {
                string lstIdNhomVatTu = string.Empty;
                foreach (TreeListNode node in TreeMain.GetAllCheckedNodes())
                {
                    if (node.ParentNode != null) lstIdNhomVatTu += node["Id"] + ",";
                }
                if (lstIdNhomVatTu.Length > 0) lstIdNhomVatTu = (lstIdNhomVatTu + ",").Replace(",,", "");
                return lstIdNhomVatTu;
            }
        }

        private void TreeMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            FocusedNodeChanged?.Invoke(this, new System.EventArgs());
        }

        private void TreeMain_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            oXtraTreeList.TreeList_SetCheckedChildNodes(e.Node, e.Node.CheckState);
            oXtraTreeList.TreeList_SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        private void TreeMain_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e)
        {
            e.NodeImageIndex = e.Node.Level;
        }
    }
}
