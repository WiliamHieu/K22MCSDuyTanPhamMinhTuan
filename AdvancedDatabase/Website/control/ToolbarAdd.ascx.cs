using System;
using System.Web.UI;

public partial class control_ToolbarAdd : System.Web.UI.UserControl
{
    public string Left
    {
        set
        {
            ViewState["Left"] = value;
        }
        get
        {
            if (ViewState["Left"] != null) return ViewState["Left"].ToString();
            return string.Empty;
        }
    }
    public string Right
    {
        set
        {
            ViewState["Right"] = value;
        }
        get
        {
            if (ViewState["Right"] != null) return ViewState["Right"].ToString();
            return string.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Left != null && Left.Length > 0)
            {
                string[] aLeft = Left.Split('!');
                string sLeft = "<li><a href=\"/trang-chu\"><i class=\"fa fa-home\"></i>Trang chủ</a></li>";
                for (int i = 0; i < aLeft.Length; i++)
                {
                    string[] aLink = aLeft[i].Split('|');
                    if (i == aLeft.Length - 1)
                        sLeft += string.Format("<li class=\"active\">{0}</li>", aLink.GetValue(0));
                    else
                        sLeft += string.Format("<li><a href=\"{0}\">{1}</a></li>", aLink.GetValue(1), aLink.GetValue(0));
                }
                lblLeftHolder.Text = sLeft;
            }
            if (Right != null && Right.Length > 0)
            {
                string sRight = string.Empty;
                string[] aRight = Right.Split('!');
                if (aRight.Length > 1)
                {
                    sRight += "<div class=\"dropdown pull-right\">";
                    sRight += "<button type=\"button\" class=\"btn btn-link btn-sm dropdown-toggle\" data-toggle=\"dropdown\"><i class=\"fa fa-plus-circle\"></i>Thêm <span class=\"caret\"></span></button>";
                    sRight += "<ul class=\"dropdown-menu dropdown-menu-right\">";
                    for (int i = 0; i < aRight.Length; i++)
                    {
                        string[] aLink = aRight[i].Split('|');
                        sRight += string.Format("<li><a href=\"{0}\">{1}</a></li>", aLink.GetValue(1), aLink.GetValue(0));
                    }
                    sRight += "</ul ></div>";
                }
                else
                {
                    string[] aLink = aRight[0].Split('|');
                    sRight = string.Format("<a class=\"btn btn-link btn-sm\" href=\"{0}\"><i class=\"fa fa-plus-circle\"></i>{1}</a>", aLink.GetValue(1), aLink.GetValue(0));
                }
                lblRightHolder.Text = sRight;
            }
        }
    }
}
