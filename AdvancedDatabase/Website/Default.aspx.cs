using System;
using System.Web.Services;

public partial class Default : System.Web.UI.Page
{
    [WebMethod]
    public static string Search(string Name, string Age, int Gender, int Polyuria, int Polydipsia, int SuddenWeightLoss, int Weakness, int Polyphagia, int GenitalThrush, int VisualBlurring, int Itching, int Irritability, int DelayedHealing, int PartialParesis, int MuscleStiffness, int Alopecia, int Obesity)
    {
        string result = string.Empty;
        try
        {
            if (Polyuria.Equals(0))
            {
                if (Gender.Equals(0))
                {
                    if (Polydipsia.Equals(1))
                    {
                        if (Irritability.Equals(0))
                        {
                            if (MuscleStiffness.Equals(1))
                            {
                                result = VisualBlurring.Equals(0) ? "Positive" : "Negative";
                            }
                            else
                            {
                                if (PartialParesis.Equals(0))
                                {
                                    result = "Positive";
                                }
                                else
                                {
                                    if (Age.Equals("35-53"))
                                    {
                                        result = "Negative";
                                    }
                                    else if (Age.Equals("54-71"))
                                    {
                                        result = "Positive";
                                    }
                                    else if (Age.Equals("16-34"))
                                    {
                                        result = "Negative";
                                    }
                                    else if (Age.Equals("72-90"))
                                    {
                                        result = "Positive";
                                    }
                                }    
                            }
                        }
                        else
                        {
                            result = "Positive";
                        }
                    }
                    else
                    {
                        if (Irritability.Equals(0))
                        {
                            if (Age.Equals("16-34"))
                            {
                                result = "Negative";
                            }
                            if (Age.Equals("35-53"))
                            {
                                if (DelayedHealing.Equals(1))
                                {
                                    if (Itching.Equals(1))
                                    {
                                        result = SuddenWeightLoss.Equals(0) ? "Negative" : "Positive";
                                    }
                                    else
                                    {
                                        result = SuddenWeightLoss.Equals(0) ? "Positive" : "Negative";
                                    }
                                }
                                else
                                {
                                    result = "Negative";
                                }
                            }
                            if (Age.Equals("54-71"))
                            {
                                if (PartialParesis.Equals(0))
                                {
                                    result = "Negative";
                                }
                                else
                                {
                                    result = MuscleStiffness.Equals(0) ? "Positive" : "Negative";
                                }
                            }
                            if (Age.Equals("72-90"))
                            {
                                result = Weakness.Equals(1) ? "Positive" : "Negative";
                            }
                        }
                        else
                        {
                            if (GenitalThrush.Equals(0))
                            {
                                if (Age.Equals("16-34"))
                                {
                                    result = "Negative";
                                }
                                if (Age.Equals("35-53"))
                                {
                                    result = Polyphagia.Equals(0) ? "Negative" : "Positive";
                                }
                                if (Age.Equals("54-71"))
                                {
                                    result = "Negative";
                                }
                                if (Age.Equals("72-90"))
                                {
                                    result = "Positive";
                                }
                            }
                            else
                            {
                                result = "Positive";
                            }
                        }    
                    }
                }
                else //Gender.Equals(1)
                {
                    if (Alopecia.Equals(1))
                    {
                        result = DelayedHealing.Equals(1) ? "Negative" : "Positive";
                    }
                    else
                    {
                        if (Alopecia.Equals(1))
                        {
                            result = "Negative";
                        }
                        else
                        {
                            if (Age.Equals("16-34"))
                            {
                                result = VisualBlurring.Equals(0) ? "Negative" : "Positive";
                            }
                            if (Age.Equals("35-53"))
                            {
                                if (Irritability.Equals(0))
                                {
                                    result = "Positive";
                                }
                                else
                                {
                                    result = Polydipsia.Equals(0) ? "Negative" : "Positive";
                                }    
                            }
                            if (Age.Equals("54-71"))
                            {
                                result = "Positive";
                            }
                            if (Age.Equals("72-90"))
                            {
                                result = "Positive";
                            }
                        }
                    }
                }
            }
            else //Polyuria.Equals(1)
            {
                if (Polydipsia.Equals(1))
                {
                    result = "Positive";
                }
                else
                {
                    if (Itching.Equals(1))
                    {
                        if (DelayedHealing.Equals(1))
                        {
                            if (Alopecia.Equals(1))
                            {
                                if (Gender.Equals(0))
                                {
                                    if (Age.Equals("16-34"))
                                    {
                                        result = "Negative";
                                    }
                                    if (Age.Equals("35-53"))
                                    {
                                        result = SuddenWeightLoss.Equals(0) ? "Positive" : "Negative";
                                    }
                                    if (Age.Equals("54-71"))
                                    {
                                        result = "Negative";
                                    }
                                    if (Age.Equals("72-90"))
                                    {
                                        result = "Negative";
                                    }
                                }
                                else
                                {
                                    result = "Positive";
                                }
                            }
                            else
                            {
                                result = "Positive";
                            }
                        }
                        else
                        {
                            result = "Positive";
                        }
                    }
                    else
                    {
                        result = "Positive";
                    }
                }
            }
            string title = string.Format("Xin chào: {0}. Với các thông số bạn chọn và dựa vào dữ liệu tổng hợp của chúng tôi. ", Name);

            if (result.Equals("Positive"))
                result = "<div class=\"alert alert-danger\">" + title + "Xin chia buồn, bạn đã <b>Dương tính</b> với Bệnh tiểu đường tuýt 1</div>";
            else
                result = "<div class=\"alert alert-success\">" + title + "Xin chúc mừng, tình trạng của bạn không liên quan đến Bệnh tiểu đường tuýt 1</div>";
        }
        catch (Exception ex)
        {
            result = "Loi<div class=\"alert alert-danger\">Lỗi xảy ra khi tra cứu dữ liệu: " + ex.Message + "</div>";
        }
        return result;
    }
}
