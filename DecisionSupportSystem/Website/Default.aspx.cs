using System;
using System.Web.Services;

public partial class Default : System.Web.UI.Page
{
    [WebMethod]
    public static string Search(string Name, int Age, int Gender, int Polyuria, int Polydipsia, int SuddenWeightLoss, int Weakness, int Polyphagia, int GenitalThrush, int VisualBlurring, int Itching, int Irritability, int DelayedHealing, int PartialParesis, int MuscleStiffness, int Alopecia, int Obesity)
    {
        string result = string.Empty;
        try
        {
            if (Polyuria.Equals(0))
            {
                if (Polydipsia.Equals(1))
                {
                    if (Irritability.Equals(0))
                    {
                        if (Itching.Equals(1))
                        {
                            if (Gender.Equals(0))
                            {
                                result = Alopecia.Equals(1) ? "Positive" : "Negative";
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
                else //Polydipsia.Equals(0)
                {
                    if (Gender.Equals(0))
                    {
                        if (Irritability.Equals(0))
                        {
                            if (DelayedHealing.Equals(1))
                            {
                                result = Age <= 40 ? "Positive" : "Negative";
                            }
                            else
                            {
                                result = "Negative";
                            }
                        }
                        else
                        {
                            if (GenitalThrush.Equals(0))
                            {
                                result = Age <= 42 ? "Positive" : "Negative";
                            }
                            else
                            {
                                result = "Positive";
                            }
                        }
                    }
                    else //Gender.Equals(1)
                    {
                        if (Alopecia.Equals(1))
                        {
                            result = "Negative";
                        }
                        else
                        {
                            if (VisualBlurring.Equals(0))
                            {
                                result = Age <= 34 ? "Positive" : "Negative";
                            }
                            else
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
                                    result = Age <= 42 ? "Positive" : "Negative";
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
            string title = string.Format("Xin chào: {0}, năm nay: {1} tuổi. Với các thông số bạn chọn và dựa vào dữ liệu tổng hợp của chúng tôi. ", Name, Age);

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
