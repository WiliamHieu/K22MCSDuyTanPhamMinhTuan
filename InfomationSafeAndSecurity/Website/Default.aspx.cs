using System;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services;
using Dapper;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.User.Identity.IsAuthenticated)
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
        }
    }

    [WebMethod]
    public static string DoLogin(string Username, string Password, bool Remember)
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString;
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sqlQuery = string.Format("SELECT Username, Password, Name, Status FROM Users WHERE Username='{0}' AND Password='{1}'", Username, Password);
            Users entUser = connection.Query<Users>(sqlQuery).ToList().FirstOrDefault();
            connection.Close();

            if (entUser == null)
            {
                return "Sai Tên truy cập hoặc Mật khẩu";
            }
            if (entUser.Status != 1)
            {
                return "Người dùng đã bị khóa";
            }
            string userInfor = string.Format("{0};{1}", entUser.Username, entUser.Name);
            FormsAuthentication.SetAuthCookie(userInfor, false);
            
            return string.Empty;
        }
    }
}

public class Users
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Status { get; set; }
}
