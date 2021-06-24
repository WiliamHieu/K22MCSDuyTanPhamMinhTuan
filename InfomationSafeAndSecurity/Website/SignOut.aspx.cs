using System;
using System.Web;
using System.Web.Security;

public partial class SignOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Session.Clear();
        Session.Abandon();

        // Clear authentication cookie
        HttpCookie formsCookie = new HttpCookie(FormsAuthentication.FormsCookieName, "")
        {
            Expires = DateTime.Now.AddYears(-1)
        };
        Response.Cookies.Add(formsCookie);

        // Clear session cookie 
        HttpCookie sessionCookie = new HttpCookie("ASP.NET_SessionId", "")
        {
            Expires = DateTime.Now.AddYears(-1)
        };
        Response.Cookies.Add(sessionCookie);

        Response.Redirect("/");
    }
}