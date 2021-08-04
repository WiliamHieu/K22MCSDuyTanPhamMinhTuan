using System;
using System.Data;
using System.IO;
using DevExpress.XtraEditors;
using ExcelDataReader;
using SMSSC.Data;
using SMSSC.Entities;

public class AppSetting
{
    public static string MessageCaption()
    {
        return "SMS Smart Care";
    }

    public static DateTime DateTime_GetServer()
    {
        DataTable dtDateTime = DataRepository.Provider.ExecuteDataSet("dbo.Custom_DateTime_GetValue").Tables[0];
        return Convert.ToDateTime(dtDateTime.Rows[0][0]);
    }
}

public class oExcelImport
{
    public static DataTable GetDataTable(string filePath, out string message)
    {
        if (!File.Exists(filePath))
        {
            message = "Tập tin không tồn tại";
            return null;
        }
        var fileInfo = new FileInfo(filePath);
        if (!fileInfo.Extension.Contains(".xlsx") && !fileInfo.Extension.Contains(".xls"))
        {
            message = "Tập tin không đúng định dạng";
            return null;
        }
        FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
        IExcelDataReader excelReader;
        if (fileInfo.Extension.Contains(".xlsx"))
        {
            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        }
        else
        {
            excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
        }
        var conf = new ExcelDataSetConfiguration
        {
            ConfigureDataTable = _ => new ExcelDataTableConfiguration
            {
                UseHeaderRow = true
            }
        };
        DataSet dsaveResult = excelReader.AsDataSet(conf);
        if (dsaveResult == null || dsaveResult.Tables.Count == 0)
        {
            message = "Tập tin không tồn tại dữ liệu";
            return null;
        }
        message = string.Empty;
        return dsaveResult.Tables[0];
    }
}

public class oInitData
{
    public static DataTable TrangThai_InitTable()
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("Id", typeof(int)));
        DataRow dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Kích hoạt";
        dcTemp["Id"] = 1;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Không";
        dcTemp["Id"] = 0;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Ẩn";
        dcTemp["Id"] = -1;
        dtTemp.Rows.Add(dcTemp);
        return dtTemp;
    }

    public static DataTable Brand_InitTable()
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("Id", typeof(Guid)));
        DataRow dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "-- Tất cả --";
        dcTemp["Id"] = Guid.Empty;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Samsung";
        dcTemp["Id"] = "734750C1-1EDA-4C08-B4A7-5A401195F3E1";
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Xiaomi";
        dcTemp["Id"] = "4478B3CB-6F6C-4971-B344-5BB6E7C42BC7";
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Oppo";
        dcTemp["Id"] = "E8BFA2D2-4D7D-43D9-9D2B-1C68271EA62A";
        dtTemp.Rows.Add(dcTemp);
        return dtTemp;
    }

    public static DataTable MobileNetwork_InitTable()
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("Id", typeof(string)));
        DataRow dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "-- Tất cả --";
        dcTemp["Id"] = "";
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Mobifone";
        dcTemp["Id"] = "089, 090, 093, 070, 079, 077, 076, 078";
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Viettel";
        dcTemp["Id"] = "086, 096, 097, 098, 032, 033, 034, 035, 036, 037, 038, 039";
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Vinaphone";
        dcTemp["Id"] = "088, 091, 094, 083, 084, 085, 081, 082";
        dtTemp.Rows.Add(dcTemp);
        return dtTemp;
    }
}

public class BindData
{
    public static void MessageTemplate_BindDropDown(LookUpEdit cboTemp)
    {
        var lstResult = DataRepository.MessageTemplateProvider.GetPaged("Status=1", "CreatedDate DESC");
        cboTemp.Properties.DisplayMember = "Title";
        cboTemp.Properties.ValueMember = "ContentText";
        cboTemp.Properties.DataSource = lstResult;

        cboTemp.EditValue = null;
        cboTemp.Properties.NullText = " -- Tin mẫu --";
    }

    public static void Brand_BindDropDown(LookUpEdit cboTemp)
    {
        cboTemp.Properties.DisplayMember = "Ten";
        cboTemp.Properties.ValueMember = "Id";
        cboTemp.Properties.DataSource = oInitData.Brand_InitTable();

        cboTemp.EditValue = Guid.Empty;
        cboTemp.Properties.NullText = "-- Tất cả --";
    }

    public static void MobileNetwork_BindDropDown(LookUpEdit cboTemp)
    {
        cboTemp.Properties.DisplayMember = "Ten";
        cboTemp.Properties.ValueMember = "Id";
        cboTemp.Properties.DataSource = oInitData.MobileNetwork_InitTable();

        cboTemp.EditValue = string.Empty;
        cboTemp.Properties.NullText = "-- Tất cả --";
    }
}