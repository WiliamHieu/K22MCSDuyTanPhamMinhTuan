using System;
using System.Web.Services;
using System.Web.UI;
using System.Linq;

using ESMEDICAL.Data;

public partial class UserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            lblToolbar.Text = oCommad.ToolbarSaveClose("/");
            ViewData();
        }
    }

    protected void ViewData()
    {
        using (var dbManager = new EsMedicalDbContext())
        {
            var Username = Common.Web_UserInfo("Username");
            var entUser = dbManager.Users.GetByKey(Username);
            txtFullName.Value = entUser.Name;
            txtUsername.Value = entUser.Username;
        }
    }

    [WebMethod]
    public static string DoSave(string OldPassword, string NewPassword)
    {
        using (var dbManager = new EsMedicalDbContext())
        {
            var Username = Common.Web_UserInfo("Username");
            var entUser = dbManager.Users.GetByKey(Username);

            if (entUser.Password != MTString.TextEncrypt(OldPassword))
            {
                return "Mật khẩu cũ không đúng";
            }
            try
            {
                entUser.Password = MTString.TextEncrypt(NewPassword);
                dbManager.SubmitChanges();
                return "ThanhCong";
            }
            catch (Exception ex)
            {
                return "LoiThay đổi mật khẩu thất bại: " + ex.Message;
            }
        }
    }
}