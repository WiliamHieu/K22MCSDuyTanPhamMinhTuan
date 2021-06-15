using ExcelDataReader;
using System;
using System.Data;
using System.IO;

namespace MTDecisionTreeID3
{
    public static class oInitData
    {
        public static DataTable Tree_Init()
        {
            DataTable dtResult = new DataTable("Rule");
            dtResult.Columns.Add(new DataColumn("Where", typeof(string)));
            return dtResult;
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
}
