using ESMEDICAL.Data;
using System.Linq;
using System.Web.Services;

public partial class Default : System.Web.UI.Page
{
    [WebMethod]
    public static string Search(string Name, int Age, string Gender, string Polyuria, string Polydipsia, string SuddenWeightLoss, string Weakness, string Polyphagia, string GenitalThrush, string VisualBlurring, string Itching, string Irritability, string DelayedHealing, string PartialParesis, string MuscleStiffness, string Alopecia, string Obesity)
    {
        string result = string.Empty;
        using (var dbContext = new EsMedicalDbContext())
        {
            var lstDiabetesRules = dbContext.DiabetesRules.ToList();

            int colCount; int ruleCount; bool isExists = false;
            foreach (var entDiabetesRule in lstDiabetesRules)
            {
                colCount = 0; ruleCount = 0;

                if (entDiabetesRule.AgeStart != null)
                {
                    colCount++;
                    ruleCount += (Age >= entDiabetesRule.AgeStart && Age <= entDiabetesRule.AgeEnd) ? 1 : 0;
                }
                if (entDiabetesRule.Gender != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Gender.Equals(Gender) ? 1 : 0;
                    
                }
                if (entDiabetesRule.Polyuria != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Polyuria.Equals(Polyuria) ? 1 : 0;
                }
                if (entDiabetesRule.Polydipsia != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Polydipsia.Equals(Polydipsia) ? 1 : 0;
                }
                if (entDiabetesRule.SuddenWeightLoss != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.SuddenWeightLoss.Equals(SuddenWeightLoss) ? 1 : 0;
                }
                if (entDiabetesRule.Weakness != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Weakness.Equals(Weakness) ? 1 : 0;
                }
                if (entDiabetesRule.Polyphagia != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Polyphagia.Equals(Polyphagia) ? 1 : 0;
                }
                if (entDiabetesRule.GenitalThrush != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.GenitalThrush.Equals(GenitalThrush) ? 1 : 0;
                }
                if (entDiabetesRule.VisualBlurring != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.VisualBlurring.Equals(VisualBlurring) ? 1 : 0;
                }
                if (entDiabetesRule.Itching != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Itching.Equals(Itching) ? 1 : 0;
                }
                if (entDiabetesRule.Irritability != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Irritability.Equals(Irritability) ? 1 : 0;
                }
                if (entDiabetesRule.DelayedHealing != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.DelayedHealing.Equals(DelayedHealing) ? 1 : 0;
                }
                if (entDiabetesRule.PartialParesis != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.PartialParesis.Equals(PartialParesis) ? 1 : 0;
                }
                if (entDiabetesRule.MuscleStiffness != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.MuscleStiffness.Equals(MuscleStiffness) ? 1 : 0;
                }
                if (entDiabetesRule.Alopecia != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Alopecia.Equals(Alopecia) ? 1 : 0;
                }
                if (entDiabetesRule.Obesity != null)
                {
                    colCount++;
                    ruleCount += entDiabetesRule.Obesity.Equals(Obesity) ? 1 : 0;
                }
                if (ruleCount == colCount)
                {
                    isExists = true;
                    break;
                }
            }

            if (isExists)
                result = "<div class=\"alert alert-danger\">Xin chia buồn, bạn có khả năng đã <b>Dương tính</b> với Bệnh tiểu đường</div>";
            else
                result = "<div class=\"alert alert-success\">Xin chúc mừng, tình trạng của bạn không liên quan đến Bệnh tiểu đường</div>";
        }
        return result;
    }
}
