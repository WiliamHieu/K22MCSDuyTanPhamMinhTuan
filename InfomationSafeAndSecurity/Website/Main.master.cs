using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Security;
using System.Web.UI;

public partial class Main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            form1.Action = Request.RawUrl;

            StringBuilder sbMenu = new StringBuilder();
            sbMenu.Append("<li><a href=\"/\">Trang chủ</a></li>");
            sbMenu.Append("<li><a href=\"/about\">Giới thiệu</a></li>");
            lblMainMenu.Text = sbMenu.ToString();
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
