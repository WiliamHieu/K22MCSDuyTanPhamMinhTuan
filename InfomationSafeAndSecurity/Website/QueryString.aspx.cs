using System;
using System.Linq;
using System.Web.UI;
using System.Data.SqlClient;

using Dapper;

public partial class QueryString : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string validate = Common.Cookies_Read("Validate");
        if (validate.Length > 0) chkValidate.Checked = Convert.ToBoolean(validate);

        if (!Page.IsPostBack)
        {
            ViewData();
        }
    }

    private void ViewData()
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString;
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string queryString = Request.QueryString["Id"];
            string sqlQuery = string.Empty;

            int ProductId = 0;
            if (chkValidate.Checked)
            {
                try
                {
                    int.TryParse(Request.QueryString["Id"], out ProductId);
                }
                catch (Exception)
                {
                }
                sqlQuery = string.Format("SELECT * FROM Products WHERE Id={0}", ProductId);
            }
            else
            {
                sqlQuery = string.Format("SELECT * FROM Products WHERE Id={0}", queryString);
            }

            Products entProduct = connection.Query<Products>(sqlQuery).ToList().FirstOrDefault();
            connection.Close();

            if (entProduct != null)
            {
                lblName.Text = entProduct.Name;
                lblDescription.Text = entProduct.Description;
                imgImage.ImageUrl = entProduct.ImageUrl;
                lblPrice.Text = entProduct.Price.ToString("N0");
            }
        }
    }
}

public class Products
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public long Price { get; set; }
    public int Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
}
