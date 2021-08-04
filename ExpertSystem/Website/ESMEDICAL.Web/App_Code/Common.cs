using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Web;

public class Common
{
    public static string Web_AppSetting(string sKeyApp)
    {
        return ConfigurationManager.AppSettings[sKeyApp];
    }

    public static DateTime DateTime_GetServer()
    {
        return DateTime.Now.ToUniversalTime().AddHours(7);
    }

    public static DateTime DateTime_GetValue(string dateValue)
    {
        return DateTime.ParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture);
    }

    public static int QueryString_IntValue(string keyName)
    {
        int result = 0;
        if (!string.IsNullOrEmpty(HttpContext.Current.Request.QueryString[keyName]))
        {
            try
            {
                result = Convert.ToInt32(HttpContext.Current.Request.QueryString[keyName]);
            }
            catch (Exception)
            {
            }
        }
        return result;
    }

    public static string QueryString_StringValue(string keyName)
    {
        string result = string.Empty;
        if (!string.IsNullOrEmpty(HttpContext.Current.Request.QueryString[keyName]))
        {
            try
            {
                result = MTString.TextClean(HttpContext.Current.Request.QueryString[keyName]);
            }
            catch (Exception)
            {
            }
        }
        return result;
    }

    public static void Cookies_Save(string cookiesName, string cookiesValue)
    {
        HttpContext.Current.Response.Cookies[cookiesName].Value = HttpContext.Current.Server.UrlEncode(cookiesValue);
        HttpContext.Current.Response.Cookies[cookiesName].Expires = DateTime.Now.AddDays(365);
    }

    public static void Cookies_Delete(string cookiesName)
    {
        HttpContext.Current.Response.Cookies[cookiesName].Expires = DateTime.Now.AddDays(-1);
    }

    public static string Cookies_Read(string cookiesName)
    {
        if (HttpContext.Current.Request.Cookies[cookiesName] != null)
            return HttpContext.Current.Server.UrlDecode(HttpContext.Current.Request.Cookies[cookiesName].Value);
        return string.Empty;
    }

    public static string Web_UserInfo(string infoKey)
    {
        if (HttpContext.Current.User.Identity.Name.Trim().Length == 0) return "admin";
        string[] UserInfo = HttpContext.Current.User.Identity.Name.Split(';');
        if (infoKey.Equals("Username")) return UserInfo.GetValue(0).ToString();
        if (infoKey.Equals("Fullname")) return UserInfo.GetValue(1).ToString();
        return string.Empty;
    }

    public static DataTable ToDataTable<T>(IList<T> data)
    {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

        DataTable table = new DataTable();

        foreach (PropertyDescriptor prop in properties)
            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

        foreach (T item in data)
        {
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
            {
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            }
            table.Rows.Add(row);
        }
        return table;
    }
}

public class oCommad
{
    public static string ToolbarSaveClose(string closeUrl)
    {
        string toolBar = "<div class=\"mt-command\">";
        toolBar += "<div class=\"btn-group btn-group-justified\">";
        toolBar += string.Format("<div class=\"btn-group\"><button type=\"button\" data-action=\"0\" class=\"btn btn-default\"><i class=\"fa fa-floppy-o\"></i><br />Lưu & Đóng</button></div>");
        toolBar += string.Format("<div class=\"btn-group\"><button type=\"button\" data-action=\"2\" data-url=\"{0}\" class=\"btn btn-default\"><i class=\"fa fa-close\"></i><br />Đóng</button></div>", closeUrl);
        toolBar += "</div>";
        toolBar += "</div>";
        return toolBar;
    }
}