using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.UI;
using System.Web.Security;
using Accord.Statistics.Filters;
using Accord.Math;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees;
using Accord.Math.Optimization.Losses;
using Accord.MachineLearning.DecisionTrees.Rules;

using ESMEDICAL.Data;

public partial class Diabetes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.User.Identity.IsAuthenticated)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("/login");
            return;
        }
        if (!Page.IsPostBack)
        {
            DateTime currentDateTime = Common.DateTime_GetServer();
            string fromDate = Common.Cookies_Read("FromDate");
            if (fromDate == null || fromDate.Length == 0)
            {
                fromDate = currentDateTime.ToString("dd/MM/yyyy");
            }
            hFromDate.Value = fromDate;
            lblFromDateText.Text = fromDate;

            string toDate = Common.Cookies_Read("ToDate");
            if (toDate == null || toDate.Length == 0)
            {
                toDate = currentDateTime.ToString("dd/MM/yyyy");
            }
            hToDate.Value = toDate;
            lblToDateText.Text = toDate;

            string gender = Common.Cookies_Read("Gender");
            cboGender.SelectedValue = gender;

            string dataHtml = GetData(fromDate, toDate, gender, 1);
            if (dataHtml.Length > 0)
            {
                string[] aDataHtml = dataHtml.Split('|');
                lblDataHolder.Text = aDataHtml[0];
                hTotalPages.Value = aDataHtml[1];
                hRowNumber.Value = aDataHtml[2];
            }
        }
    }

    [WebMethod]
    public static string GetData(string FromDate, string ToDate, string Gender, int PageIndex)
    {
        DateTime fromDate = Common.DateTime_GetValue(FromDate);
        fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 0, 0);
        DateTime toDate = Common.DateTime_GetValue(ToDate);
        toDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59, 999);

        string result = string.Empty;
        using (var dbContext = new EsMedicalDbContext())
        {
            var lstDiabetes = dbContext.CustomDiabetesGetList(fromDate, toDate, Gender, PageIndex, 20).ToList();
            StringBuilder sbResult = new StringBuilder();
            int totalPages = 0; long rowNumber = 0; string editHtml, deleteHtml = string.Empty;
            if (lstDiabetes != null && lstDiabetes.Count > 0)
            {
                totalPages = Convert.ToInt32(lstDiabetes[0].TotalPages);
                foreach (var entDiabetes in lstDiabetes)
                {
                    rowNumber = entDiabetes.RowNumber.Value;

                    editHtml = string.Format("<a class=\"btn btn-default btn-xs\" title=\"Sửa\" href=\"/diabetes/{0}\"><i class=\"fa fa-pencil\"></i></a>", entDiabetes.Id);
                    deleteHtml = string.Format("<a class=\"btn btn-default btn-xs\" title=\"Xóa\" href=\"javascript:;\" onclick=\"javascript:DeleteData('{0}')\"><i class=\"fa fa-trash-o\"></i></a>", entDiabetes.Id);

                    sbResult.AppendFormat("<tr id=\"tr{0}\"{1}>", rowNumber, (rowNumber % 2 == 0 ? " class=\"alternate\"" : string.Empty));
                    sbResult.AppendFormat("<td class=\"order\">{0}</td>", rowNumber.ToString("#,###0"));
                    sbResult.AppendFormat("<td class=\"cnumber\">{0}</td>", entDiabetes.Age);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Gender);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Polyuria);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Polydipsia);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.SuddenWeightLoss);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Weakness);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Polyphagia);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.GenitalThrush);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.VisualBlurring);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Itching);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Irritability);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.DelayedHealing);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.PartialParesis);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.MuscleStiffness);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Alopecia);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Obesity);
                    sbResult.AppendFormat("<td class=\"type\">{0}</td>", entDiabetes.Class);
                    sbResult.AppendFormat("<td class=\"btn-2\"><div class=\"btn-group\">{0}{1}</div></td>", editHtml, deleteHtml);
                    sbResult.Append("</tr>");
                }
            }
            else
            {
                if (PageIndex == 1) sbResult.AppendLine("<tr><td colspan=\"19\">Không tồn tại dữ liệu</td></tr>");
            }
            return sbResult + "|" + totalPages + "|" + rowNumber;
        }
    }

    [WebMethod]
    public static string DeleteData(int DiabetesId, string FromDate, string ToDate, string Gender, int PageIndex)
    {
        using (var dbContext = new EsMedicalDbContext())
        {
            dbContext.Connection.Open();
            dbContext.Transaction = dbContext.Connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                dbContext.Diabetes.Delete(DiabetesId);
                dbContext.SubmitChanges();

                var lstDiabetes = dbContext.Diabetes.ToList();

                DataTable dtDiabetes = Common.ToDataTable(lstDiabetes);
                if (dtDiabetes.Columns.Contains("Id")) dtDiabetes.Columns.Remove("Id");
                if (dtDiabetes.Columns.Contains("CreatedDate")) dtDiabetes.Columns.Remove("CreatedDate");
                if (dtDiabetes.Columns.Contains("CreatedBy")) dtDiabetes.Columns.Remove("CreatedBy");

                var codebook = new Codification()
                {
                    DefaultMissingValueReplacement = Double.NaN
                };
                codebook.Learn(dtDiabetes);

                DataTable symbols = codebook.Apply(dtDiabetes);

                string colDecision = "Class";
                string[] inputNames = new string[dtDiabetes.Columns.Count - 1];
                for (int i = 0; i < dtDiabetes.Columns.Count; i++)
                {
                    if (dtDiabetes.Columns[i].ColumnName != colDecision)
                    {
                        inputNames[i] = dtDiabetes.Columns[i].ColumnName;
                    }
                }

                double[][] inputs = symbols.ToJagged(inputNames);
                int[] outputs = symbols.ToArray<int>(colDecision);

                // Create a new learning algorithm
                var c45Learning = new C45Learning()
                {
                    Attributes = DecisionVariable.FromCodebook(codebook, inputNames)
                };

                // Use the learning algorithm to induce a new tree:
                DecisionTree tree = c45Learning.Learn(inputs, outputs);

                // To get the estimated class labels, we can use
                int[] predicted = tree.Decide(inputs);

                // The classification error (~0.214) can be computed as 
                double error = new ZeroOneLoss(outputs).Loss(predicted);

                // Moreover, we may decide to convert our tree to a set of rules:
                DecisionSet rules = tree.ToRules();

                // And using the codebook, we can inspect the tree reasoning:
                string ruleText = rules.ToString(codebook, colDecision, System.Globalization.CultureInfo.InvariantCulture);

                string[] aruleText = ruleText.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                List<string> lstPositiveRule = aruleText.Where(d => d.Contains("Positive")).ToList();

                DataTable dtRule = dtDiabetes.Clone();

                DiabetesRules entDiabetesRule = null;
                List<DiabetesRules> lstDiabetesRule = new List<DiabetesRules>();

                string colName, colValue, colAgeEnd = string.Empty; string colAgeStart = string.Empty;

                foreach (string entPositiveRule in lstPositiveRule)
                {
                    string[] aPositiveRule = entPositiveRule.Replace("Positive =: ", "").Replace("(", "").Replace(")", "").Split(new char[] { '&', '&' }, StringSplitOptions.RemoveEmptyEntries);
                    if (aPositiveRule != null && aPositiveRule.Length > 0)
                    {
                        entDiabetesRule = new DiabetesRules
                        {
                            Class = "Positive",
                            CreatedDate = Common.DateTime_GetServer(),
                            CreatedBy = Common.Web_UserInfo("Username")
                        };
                        foreach (var ruleItem in aPositiveRule)
                        {
                            string[] separatingStrings = { "==", ">=", "<=", ">", "<" };
                            string[] aRuleValue = ruleItem.TrimStart().TrimEnd().Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
                            if (aRuleValue.Length > 0)
                            {
                                colName = aRuleValue[0].TrimStart().TrimEnd();
                                colValue = aRuleValue[1].TrimStart().TrimEnd();

                                if (colName == "Age")
                                {
                                    if (ruleItem.Contains(">=") || ruleItem.Contains(">"))
                                    {
                                        colAgeStart = colValue;
                                        colAgeEnd = "100";
                                    }
                                    else if (ruleItem.Contains("<=") || ruleItem.Contains("<"))
                                    {
                                        colAgeStart = "0";
                                        colAgeEnd = colValue;
                                    }
                                }

                                if (colName.Equals("Age"))
                                {
                                    entDiabetesRule.AgeStart = Convert.ToDecimal(colAgeStart);
                                    entDiabetesRule.AgeEnd = Convert.ToDecimal(colAgeEnd);
                                }
                                if (colName.Equals("Gender")) entDiabetesRule.Gender = colValue;
                                if (colName.Equals("Polyuria")) entDiabetesRule.Polyuria = colValue;
                                if (colName.Equals("Polydipsia")) entDiabetesRule.Polydipsia = colValue;
                                if (colName.Equals("SuddenWeightLoss")) entDiabetesRule.SuddenWeightLoss = colValue;
                                if (colName.Equals("Weakness")) entDiabetesRule.Weakness = colValue;
                                if (colName.Equals("Polyphagia")) entDiabetesRule.Polyphagia = colValue;
                                if (colName.Equals("GenitalThrush")) entDiabetesRule.GenitalThrush = colValue;
                                if (colName.Equals("VisualBlurring")) entDiabetesRule.VisualBlurring = colValue;
                                if (colName.Equals("Itching")) entDiabetesRule.Itching = colValue;
                                if (colName.Equals("Irritability")) entDiabetesRule.Irritability = colValue;
                                if (colName.Equals("DelayedHealing")) entDiabetesRule.DelayedHealing = colValue;
                                if (colName.Equals("PartialParesis")) entDiabetesRule.PartialParesis = colValue;
                                if (colName.Equals("MuscleStiffness")) entDiabetesRule.MuscleStiffness = colValue;
                                if (colName.Equals("Alopecia")) entDiabetesRule.Alopecia = colValue;
                                if (colName.Equals("Obesity")) entDiabetesRule.Obesity = colValue;
                            }
                        }
                        lstDiabetesRule.Add(entDiabetesRule);
                    }
                }

                dbContext.DiabetesRules.DeleteAllOnSubmit(dbContext.DiabetesRules);
                dbContext.SubmitChanges();

                dbContext.DiabetesRules.InsertAllOnSubmit(lstDiabetesRule);
                dbContext.SubmitChanges();

                dbContext.Transaction.Commit();

                return GetData(FromDate, ToDate, Gender, PageIndex);
            }
            catch (Exception ex)
            {
                dbContext.Transaction.Rollback();

                return "ErrorLỗi thay đổi cơ sở dữ liệu: " + ex.Message;
            }
        }
    }
}