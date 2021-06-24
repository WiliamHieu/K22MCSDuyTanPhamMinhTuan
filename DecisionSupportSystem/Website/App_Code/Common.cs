using System;
using System.Configuration;
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
}
