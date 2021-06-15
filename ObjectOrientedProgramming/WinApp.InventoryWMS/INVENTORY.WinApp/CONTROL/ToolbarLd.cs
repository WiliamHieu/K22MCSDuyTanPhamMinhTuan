using System;
using System.Windows.Forms;

using DevExpress.XtraBars;

namespace INVENTORY.CONTROL
{
    public partial class ToolbarLd : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Clicked;

        public ToolbarLd()
        {
            InitializeComponent();
        }

        public Action SenderName { get; set; }

        public void Permission_Set(string formName, bool isEdit)
        {
            if (formName.Length > 0 && formName.Contains("Add"))
            {
                formName = formName.Replace("Add", "");
            }
            if (formName.Length > 0 && formName.Contains("Edit"))
            {
                formName = formName.Replace("Edit", "");
            }
            if (!oSecurity.CheckEdit(formName) && isEdit)
            {
                cmdLuuVaDong.Enabled = false;
            }
        }

        public Action DisableTool
        {
            set
            {
                switch (value)
                {
                    case Action.SaveClose:
                        cmdLuuVaDong.Enabled = false;
                        break;
                }
            }
        }

        public Action EnableTool
        {
            set
            {
                switch (value)
                {
                    case Action.SaveClose:
                        cmdLuuVaDong.Enabled = true;
                        break;
                }
            }
        }

        private void bmMain_HighlightedLinkChanged(object sender, HighlightedLinkChangedEventArgs e)
        {
            if (e.Link != null && (e.Link.Item is BarButtonItem || e.Link.Item is BarSubItem))
            {
                Cursor = Cursors.Hand;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void bmMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Clicked != null)
            {
                switch (e.Item.Name)
                {
                    case "cmdLuuVaDong":
                        this.SenderName = Action.SaveClose;
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
            SaveClose,
            Close
        }
    }
}
