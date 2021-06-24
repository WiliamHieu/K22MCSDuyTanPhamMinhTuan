using System;
using System.Configuration;
using System.Web;

public class Common
{
    public static string Web_AppSetting(string appSettingKey)
    {
        return ConfigurationManager.AppSettings[appSettingKey];
    }

    public static string Web_UserInfo(string userInfoKey)
    {
        if (HttpContext.Current.User.Identity.Name.Trim().Length == 0) return string.Empty;
        string[] UserInfo = HttpContext.Current.User.Identity.Name.Split(';');
        if (userInfoKey.Equals("Username")) return UserInfo.GetValue(0).ToString();
        if (userInfoKey.Equals("Name")) return UserInfo.GetValue(1).ToString();
        return string.Empty;
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
