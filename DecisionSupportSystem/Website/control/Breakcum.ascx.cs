using System;
using System.Web.UI;

public partial class control_Breakcum : System.Web.UI.UserControl
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
                string sLeft = "<li><a href=\"/trang-chu\"><i class=\"fa fa-home fa-fw\"></i>Trang chủ</a></li>";
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
                string sRight = string.Format("<a class=\"btn btn-link btn-sm\" href=\"{0}\"><i class=\"fa fa-backward fa-fw\"></i>Quay lại</a>", Right);
                lblRightHolder.Text = sRight;
            }

        }
    }
}
