using System;

namespace INVENTORY.CONTROL
{
    public partial class ToolbarBc : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public ToolbarBc()
        {
            InitializeComponent();
        }

        public Action SenderName { get; set; }

        private void BarMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clicked != null)
            {
                switch (e.Item.Name)
                {
                    case "cmdTimKiem":
                        this.SenderName = Action.Search;
                        break;
                    case "cmdXuatExcel":
                        this.SenderName = Action.Export;
                        break;
                    case "cmdInAn":
                        this.SenderName = Action.Print;
                        break;
                    case "cmdTroGiup":
                        this.SenderName = Action.Help;
                        break;
                    case "cmdDong":
                        this.SenderName = Action.Close;
                        break;
                    default:
                        this.SenderName = Action.None;
                        break;
                }
                Clicked(this, new System.EventArgs());
            }
        }

        public enum Action
        {
            None,
            Search,
            Export,
            Print,
            Help,
            Close
        }
    }
}
