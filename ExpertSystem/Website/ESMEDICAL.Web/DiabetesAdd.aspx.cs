using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Security;
using System.Web.Services;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees.Rules;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using ESMEDICAL.Data;

public partial class DiabetesAdd : System.Web.UI.Page
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
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                int diabetesId = Common.QueryString_IntValue("Id");
                if (diabetesId > 0)
                {
                    hDiabetesId.Value = diabetesId.ToString();
                    ViewData();
                }
            }
        }
    }

    private void ViewData()
    {
        try
        {
            using (var dbManager = new EsMedicalDbContext())
            {
                var entDiabetes = dbManager.Diabetes.ById(Convert.ToInt32(hDiabetesId.Value)).FirstOrDefault();
                if (entDiabetes != null)
                {
                    cboGender.SelectedValue = entDiabetes.Gender;
                    txtAge.Text = entDiabetes.Age.ToString();
                    rblPolyuria.SelectedValue = entDiabetes.Polyuria;
                    rblPolydipsia.SelectedValue = entDiabetes.Polydipsia;
                    rblSuddenWeightLoss.SelectedValue = entDiabetes.SuddenWeightLoss;
                    rblWeakness.SelectedValue = entDiabetes.Weakness;
                    rblPolyphagia.SelectedValue = entDiabetes.Polyphagia;
                    rblGenitalThrush.SelectedValue = entDiabetes.GenitalThrush;
                    rblVisualBlurring.SelectedValue = entDiabetes.VisualBlurring;
                    rblItching.SelectedValue = entDiabetes.Itching;
                    rblIrritability.SelectedValue = entDiabetes.Irritability;
                    rblDelayedHealing.SelectedValue = entDiabetes.DelayedHealing;
                    rblPartialParesis.SelectedValue = entDiabetes.PartialParesis;
                    rblMuscleStiffness.SelectedValue = entDiabetes.MuscleStiffness;
                    rblAlopecia.SelectedValue = entDiabetes.Alopecia;
                    rblObesity.SelectedValue = entDiabetes.Obesity;
                    rblClass.SelectedValue = entDiabetes.Class;
                }
            }
        }
        catch (Exception)
        {
        }
    }

    [WebMethod]
    public static string Save(int DiabetesId, int Age, string Gender, string Polyuria, string Polydipsia, string SuddenWeightLoss, string Weakness, string Polyphagia, string GenitalThrush, string VisualBlurring, string Itching, string Irritability, string DelayedHealing, string PartialParesis, string MuscleStiffness, string Alopecia, string Obesity, string Class)
    {
        using (var dbContext = new EsMedicalDbContext())
        {
            dbContext.Connection.Open();
            dbContext.Transaction = dbContext.Connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                Diabetes entDiabetes = DiabetesId.Equals(0) ? new Diabetes() : dbContext.Diabetes.ById(DiabetesId).FirstOrDefault();
                entDiabetes.Age = Convert.ToInt16(Age);
                entDiabetes.Gender = Gender;
                entDiabetes.Polyuria = Polyuria;
                entDiabetes.Polydipsia = Polydipsia;
                entDiabetes.SuddenWeightLoss = SuddenWeightLoss;
                entDiabetes.Weakness = Weakness;
                entDiabetes.Polyphagia = Polyphagia;
                entDiabetes.GenitalThrush = GenitalThrush;
                entDiabetes.VisualBlurring = VisualBlurring;
                entDiabetes.Itching = Itching;
                entDiabetes.Irritability = Irritability;
                entDiabetes.DelayedHealing = DelayedHealing;
                entDiabetes.PartialParesis = PartialParesis;
                entDiabetes.MuscleStiffness = MuscleStiffness;
                entDiabetes.Alopecia = Alopecia;
                entDiabetes.Obesity = Obesity;
                entDiabetes.Class = Class;
                entDiabetes.CreatedDate = Common.DateTime_GetServer();
                entDiabetes.CreatedBy = Common.Web_UserInfo("Username");
                if (DiabetesId.Equals(0)) dbContext.Diabetes.InsertOnSubmit(entDiabetes);

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

                return "Cập nhật dữ liệu thành công!";
            }
            catch (Exception ex)
            {
                dbContext.Transaction.Rollback();

                return "ErrorLỗi thay đổi cơ sở dữ liệu: " + ex.Message;
            }
        }
    }
}
