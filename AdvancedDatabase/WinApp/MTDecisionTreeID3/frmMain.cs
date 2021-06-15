using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MTDecisionTreeID3
{
    public partial class frmMain : Form
    {
        private DataTable dtSource, dtTree = null;
        private TreeNodeID3 rootNode = null;

        private string runType, error, colDecision, lstRule = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtRuleContent.ScrollBars = RichTextBoxScrollBars.Both;
        }

        private void PrintNode(TreeNodeID3 node, string tabs)
        {
            DataRow row = null;
            if (MTString.Length(node.Attribute.AttributeName) == 0)
            {
                row = dtTree.NewRow();
                row["Where"] = " THEN " + node.Attribute;
                dtTree.Rows.Add(row);
            }

            if (node.Attribute.Values != null)
            {
                for (int i = 0; i < node.Attribute.Values.Length; i++)
                {
                    row = dtTree.NewRow();
                    row["Where"] = tabs + "\t" + "IF " + node.Attribute + " = " +  node.Attribute.Values[i].ToString();
                    dtTree.Rows.Add(row);

                    TreeNodeID3 childNode = node.GetChildByBranchName(node.Attribute.Values[i]);
                    childNode.ParentNode = node;
                    PrintNode(childNode, "\t" + tabs);
                }
            }
        }

        public static void PrintTree(TreeNodeID3 tree, string value, string indent, bool last)
        {
            if (value.Length > 0)
            {
                System.Diagnostics.Debug.WriteLine(indent + "+- [" + value + "]" + tree.Attribute);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(indent + "+- " + tree.Attribute);
            }
            indent += last ? "   " : "|  ";

            if (tree.Attribute.Values != null)
            {
                for (int i = 0; i < tree.Attribute.Values.Length; i++)
                {
                    TreeNodeID3 childNode = tree.GetChildByBranchName(tree.Attribute.Values[i]);
                    PrintTree(childNode, (tree.Attribute.AttributeName.Length > 0 ? "" : tree.Attribute.Values[i]), indent, i == tree.Attribute.Values.Length - 1);
                }
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dGetFile = ExcelFileDialog.ShowDialog();
            if (dGetFile == DialogResult.OK)
            {
                txtDuongDan.Text = ExcelFileDialog.FileName;

                cboDecisionColumn.Items.Clear();
                txtRuleContent.Text = string.Empty;

                cmdAnalysic.Enabled = false;
                cboDecisionColumn.Enabled = false;

                cmdLoadData.Enabled = true;
            }
        }

        private void cmdLoadData_Click(object sender, EventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDuongDan.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn Tập tin để xử lý dữ liệu", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmdBrowse.Focus();
                return;
            }
            cmdLoadData.Enabled = false;
            BrgWorker.RunWorkerAsync("Load");
        }

        private void cmdAnalysic_Click(object sender, EventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtSource == null || dtSource.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại dữ liệu để phân tích", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmdAnalysic.Focus();
                return;
            }
            if (cboDecisionColumn.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn Cột quyết định", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDecisionColumn.Focus();
                return;
            }
            colDecision = cboDecisionColumn.SelectedItem.ToString();
            if (dtSource.Columns[colDecision].DataType != Type.GetType("System.Boolean"))
            {
                MessageBox.Show("Cột quyết định phải có dữ liệu là True/False", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDecisionColumn.Focus();
                return;
            }

            lstRule = string.Empty;
            txtRuleContent.Text = string.Empty;
            dtTree = oInitData.Tree_Init();
            BrgWorker.RunWorkerAsync("Analysic");
        }

        private void gridMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(gridMain.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void BrgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Equals("Load"))
            {
                dtSource = oExcelImport.GetDataTable(txtDuongDan.Text, out error);
            }
            else if (runType.Equals("Analysic"))
            {
                AttributeID3 attribute = null; DataTable dtDisntinct = null; 
                List<AttributeID3> lstAttribute = new List<AttributeID3>();
                List<string> lstRowValue = new List<string>();

                foreach (DataColumn column in dtSource.Columns)
                {
                    if (column.ColumnName != colDecision)
                    {
                        dtDisntinct = MTDataTable.Distinct(dtSource, column.ColumnName);
                        lstRowValue = new List<string>();

                        foreach (DataRow row in dtDisntinct.Rows)
                        {
                            lstRowValue.Add(row[column.ColumnName].ToString());
                        }
                        attribute = new AttributeID3(column.ColumnName, lstRowValue.ToArray());
                        lstAttribute.Add(attribute);
                    }
                }
                TreeID3 id3 = new TreeID3();
                rootNode = id3.MountTree(dtSource, colDecision, lstAttribute.ToArray());
            }    
        }

        private void BrgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (runType.Equals("Load"))
            {
                if (error != null && error.Length > 0)
                {
                    MessageBox.Show(error, "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmdBrowse.Focus();
                    return;
                }
                if (dtSource == null)
                {
                    MessageBox.Show("Tập tin không tồn tại dữ liệu", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmdBrowse.Focus();
                    return;
                }
                cboDecisionColumn.Items.Clear();
                foreach (DataColumn col in dtSource.Columns)
                {
                    cboDecisionColumn.Items.Add(col.ColumnName);
                }
                gridMain.DataSource = dtSource;

                cmdAnalysic.Enabled = true;
                cboDecisionColumn.Enabled = true;
            }
            else if (runType.Equals("Analysic"))
            {
                if (rootNode == null)
                {
                    MessageBox.Show("Không thể phân tích dữ liệu", "Thuật toán ID3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PrintNode(rootNode, "");

                string where = string.Empty;
                foreach (DataRow row in dtTree.Rows)
                {
                    where = row["Where"].ToString();
                    if (where.Contains("THEN"))
                    {
                        lstRule += where;
                    }
                    else
                    {
                        lstRule += "\r\n" + where;
                    }    
                }

                txtRuleContent.Text = lstRule;
            }
        }
    }
}
