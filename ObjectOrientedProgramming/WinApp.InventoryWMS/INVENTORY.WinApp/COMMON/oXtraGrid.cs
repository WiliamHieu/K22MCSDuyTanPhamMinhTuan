using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Text;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;

public class oXtraGrid
{
    public static ArrayList ExtractSummaryItems(GridView view)
    {
        ArrayList items = new ArrayList();
        foreach (GridSummaryItem si in view.GroupSummary)
            if (si is GridGroupSummaryItem && si.SummaryType != SummaryItemType.None)
                items.Add(si);
        return items;
    }

    public static void DrawBackground(RowObjectCustomDrawEventArgs e, GridView view)
    {
        GridGroupRowPainter painter;
        GridGroupRowInfo info;
        painter = e.Painter as GridGroupRowPainter;
        info = e.Info as GridGroupRowInfo;
        int level = view.GetRowLevel(e.RowHandle);
        int row = view.GetDataRowHandleByGroupRowHandle(e.RowHandle);
        info.GroupText = string.Format("{0}", view.GetRowCellDisplayText(row, view.GroupedColumns[level]));
        e.Appearance.DrawBackground(e.Cache, info.Bounds);
        painter.ElementsPainter.GroupRow.DrawObject(info);
    }

    public static void DrawSummaryValues(RowObjectCustomDrawEventArgs e, GridView view, ArrayList items)
    {
        Hashtable values = view.GetGroupSummaryValues(e.RowHandle);
        foreach (GridGroupSummaryItem item in items)
        {
            Rectangle rect = GetColumnBounds(view, item);
            if (rect.IsEmpty) continue;
            string text = item.GetDisplayText(values[item], false);
            rect = CalcSummaryRect(text, e, view.Columns[item.FieldName]);
            e.Appearance.DrawString(e.Cache, text, rect);
        }
    }

    private static Rectangle GetColumnBounds(GridView view, GridGroupSummaryItem item)
    {
        GridColumn column = view.Columns[item.FieldName];
        return GetColumnBounds(column);
    }

    private static Rectangle GetColumnBounds(GridColumn column)
    {
        GridViewInfo gridInfo = (GridViewInfo)column.View.GetViewInfo();
        GridColumnInfoArgs colInfo = gridInfo.ColumnsInfo[column];
        if (colInfo != null)
            return colInfo.Bounds;
        else
            return Rectangle.Empty;
    }

    private static Rectangle CalcSummaryRect(string text, RowObjectCustomDrawEventArgs e, GridColumn column)
    {
        SizeF sz = TextUtils.GetStringSize(e.Graphics, text, e.Appearance.Font);
        int width = Convert.ToInt32(sz.Width) + 1;
        Rectangle result = GetColumnBounds(column);
        result = FixLeftEdge(width, result);
        result.Width = result.Width;
        result.Y = e.Bounds.Y;
        result.Height = e.Bounds.Height - 2;
        return PreventSummaryTextOverlapping(e, result);
    }

    private static Rectangle FixLeftEdge(int width, Rectangle result)
    {
        int delta = result.Width - width - 2;
        if (delta > 0)
        {
            result.X += delta;
            result.Width -= delta;
        }
        return result;
    }

    private static Rectangle PreventSummaryTextOverlapping(RowObjectCustomDrawEventArgs e, Rectangle rect)
    {
        GridGroupRowInfo gInfo = (GridGroupRowInfo)e.Info;
        int groupTextLocation = gInfo.ButtonBounds.Right + 10;
        int groupTextWidth = TextUtils.GetStringSize(e.Graphics, gInfo.GroupText, e.Appearance.Font).Width;
        Rectangle r = new Rectangle(groupTextLocation, 0, groupTextWidth, e.Info.Bounds.Height);
        if (r.Right > rect.X)
        {
            if (r.Right > rect.Right)
                rect.Width = 0;
            else
            {
                rect.Width -= r.Right - rect.X;
                rect.X = r.Right;
            }
        }
        return rect;
    }

    public static void Print(GridControl gridMain, string title)
    {
        try
        {
            if (!gridMain.IsPrintingAvailable)
            {
                XtraMessageBox.Show("Không tìm thấy Thư viện In", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PrintableComponentLink printableComponentLink = new PrintableComponentLink()
            {
                PrintingSystemBase = new PrintingSystemBase(),
                Component = gridMain,
                Landscape = true,
                PaperKind = PaperKind.A4,
                Margins = new Margins(15, 15, 60, 15)
            };
            PageHeaderFooter phf = printableComponentLink.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.Clear();
            phf.Header.Font = new Font("Tahoma", 18, FontStyle.Bold);
            phf.Header.Content.AddRange(new string[] { null, title, null });
            phf.Header.LineAlignment = BrickAlignment.Far;

            printableComponentLink.ShowRibbonPreview(gridMain.LookAndFeel);
        }
        catch (Exception)
        {
            XtraMessageBox.Show("Lỗi xảy ra trong quá trình In", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void Print(DevExpress.XtraPivotGrid.PivotGridControl gridMain)
    {
        try
        {
            if (!gridMain.IsPrintingAvailable)
            {
                XtraMessageBox.Show("Không tìm thấy Thư viện In", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gridMain.ShowPrintPreview();
        }
        catch (Exception)
        {
            XtraMessageBox.Show("Lỗi xảy ra trong quá trình In", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void ExportXLSX(GridView view, string fileName)
    {
        try
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                DefaultExt = ".xlsx",
                FileName = fileName + ".xlsx"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
                view.ExportToXlsx(saveFile.FileName, new XlsxExportOptions(TextExportMode.Text));
        }
        catch (Exception)
        {
            XtraMessageBox.Show("Lỗi khi Xuất Excel, có thể đang mở tập tin mà cố tình ghi đè", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void ExportXLSX(DevExpress.XtraPivotGrid.PivotGridControl gridMain, string fileName)
    {
        try
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.DefaultExt = ".xlsx";
            saveFile.FileName = fileName + ".xlsx";
            if (saveFile.ShowDialog() == DialogResult.OK)
                gridMain.ExportToXlsx(saveFile.FileName, new DevExpress.XtraPrinting.XlsxExportOptions(DevExpress.XtraPrinting.TextExportMode.Text));
        }
        catch (Exception)
        {
            XtraMessageBox.Show("Lỗi khi Xuất Excel, có thể đang mở tập tin mà cố tình ghi đè", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static List<DataRow> Get_SelectedRows(GridView view)
    {
        List<DataRow> ListRows = new List<DataRow>();
        foreach (int rowIndex in view.GetSelectedRows())
        {
            if (view.IsGroupRow(rowIndex))
            {
                for (int i = 0; i < view.GetChildRowCount(rowIndex); i++)
                {
                    int childRowHandle = view.GetChildRowHandle(rowIndex, i);
                    ListRows.Add(view.GetDataRow(childRowHandle));
                }
            }
            else
            {
                ListRows.Add(view.GetDataRow(rowIndex));
            }
        }
        return ListRows;
    }
}
public class oXtraTreeList
{
    public static void TreeList_SetCheckedChildNodes(TreeListNode node, CheckState check)
    {
        for (int i = 0; i < node.Nodes.Count; i++)
        {
            node.Nodes[i].CheckState = check;
            TreeList_SetCheckedChildNodes(node.Nodes[i], check);
        }
    }

    public static void TreeList_SetCheckedParentNodes(TreeListNode node, CheckState check)
    {
        if (node.ParentNode != null)
        {
            bool b = false;
            CheckState state;
            for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
            {
                state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                if (!check.Equals(state))
                {
                    b = !b;
                    break;
                }
            }
            node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
            TreeList_SetCheckedParentNodes(node.ParentNode, check);
        }
    }
}
