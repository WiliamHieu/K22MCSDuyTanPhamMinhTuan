<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" Runat="Server">
         <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">Giới thiệu</h4>
                    </div>
                    <div class="panel-body">
                        <div class="col-md-12 about-text">
                            Theo báo cáo của Tổ chức Y tế Thế giới (WHO), bệnh tiểu đường là một trong những căn bệnh mãn tính đe dọa tính mạng phát triển nhanh nhất, đã ảnh hưởng đến 422 triệu người trên toàn thế giới, theo báo cáo của Tổ chức Y tế Thế giới (WHO), vào năm 2018. Do sự hiện diện của giai đoạn không có triệu chứng tương đối dài, nên việc phát hiện sớm bệnh tiểu đường là luôn mong muốn cho một kết quả có ý nghĩa về mặt lâm sàng. Khoảng 50% tất cả những người mắc bệnh tiểu đường không được chẩn đoán vì giai đoạn không có triệu chứng kéo dài của nó. Việc chẩn đoán sớm bệnh tiểu đường chỉ có thể thực hiện được bằng cách đánh giá đúng các triệu chứng dấu hiệu phổ biến và ít phổ biến hơn, có thể được tìm thấy trong các giai đoạn khác nhau từ khi bắt đầu phát bệnh cho đến khi chẩn đoán. Kỹ thuật phân loại khai thác dữ liệu đã được các nhà nghiên cứu chấp nhận tốt cho mô hình dự báo rủi ro của bệnh. Để dự đoán khả năng mắc bệnh tiểu đường cần một bộ dữ liệu, trong đó chứa dữ liệu của bệnh nhân tiểu đường mới hoặc sẽ là bệnh nhân tiểu đường. Trong nghiên cứu này, chúng tôi đã sử dụng bộ dữ liệu gồm 520 trường hợp, được thu thập bằng cách sử dụng bảng câu hỏi trực tiếp từ các bệnh nhân của Bệnh viện Tiểu đường Sylhet ở Sylhet, Bangladesh. 
                            <div class="author">Dữ liệu có các cột tương ứng với giá trị hoặc triệu chứng được mô tả như bên dưới:</div>
                            <table class="table table-bordered">
                                <tr>
                                    <td>Age</td>
                                    <td>Tuổi bệnh nhân</td>
                                </tr>
                                <tr>
                                    <td>Gender</td>
                                    <td>Giới tính bệnh nhân</td>
                                </tr>
                                <tr>
                                    <td>Polyuria</td>
                                    <td>Triệu chứng đi tiểu nhiều (khối lượng >= 2.5 lít trong vòng 24 giờ ở người lớn)</td>
                                </tr>
                                <tr>
                                    <td>Polydipsia</td>
                                    <td>Triệu chứng khát nước, luôn cảm muốn uống nước bất kể uống bao nhiêu nước vẫn thấy khô miệng</td>
                                </tr>
                                <tr>
                                    <td>Sudden Weight Loss</td>
                                    <td>Cơ thể bị sụt cân không rỏ nguyên nhân trong một thời gian ngắn</td>
                                </tr>
                                <tr>
                                    <td>Weakness</td>
                                    <td>Triệu chứng mệt mỏi, cơ thể luôn cảm thấy mệt mỏi, kiệt sức, đặc biệt khi vừa ngủ dậy</td>
                                </tr>
                                <tr>
                                    <td>Polyphagia</td>
                                    <td>Triệu chứng đói quá mức, luôn muốn ăn cho dù vừa ăn xong, lúc nào cũng cảm thấy đói</td>
                                </tr>
                                <tr>
                                    <td>Genital Thrush</td>
                                    <td>Bị bệnh tưa miệng, xuất hiện các mảng trắng trong miệng hoặc lưỡi đỏ khác thường</td>
                                </tr>
                                <tr>
                                    <td>Visual Blurring</td>
                                    <td>Triệu chứng mờ mắt, thị lực giảm suốt, có hiện tượng xuất huyết, phù nề trong mắt</td>
                                </tr>
                                <tr>
                                    <td>Itching</td>
                                    <td>Triệu chứng ngứa, da bị khô, bong tróc và nứt nẻ</td>
                                </tr>
                                <tr>
                                    <td>Irritability</td>
                                    <td>Triệu chứng khó chịu, cơ thể luôn bứt rứt, khó chịu và hay cáu gắt</td>
                                </tr>
                                <tr>
                                    <td>Delayed Healing</td>
                                    <td>Triệu chứng khó lành vết thương, xuất hiện các biến chứng khác trong quá trình hồi phục</td>
                                </tr>
                                <tr>
                                    <td>Partial Paresis</td>
                                    <td>Triệu chứng liệt, cơ thể sẽ bị liệt một bộ phận nào đó</td>
                                </tr>
                                <tr>
                                    <td>Muscle Stiffness</td>
                                    <td>Triệu chứng cứng cơ, cảm thấy cơ xương khớp bị cứng, khó vận động</td>
                                </tr>
                                <tr>
                                    <td>Alopecia</td>
                                    <td>Triệu chứng rụng tóc, tóc rất yếu, mỏng và rụng nhiều</td>
                                </tr>
                                <tr>
                                    <td>Obesity</td>
                                    <td>Mắc bệnh béo phì</td>
                                </tr>
                            </table>
                            <div class="author">Nhóm tác giả lớp K22MCS - Đại học Duy Tân:</div>
                            <ul class="list-unstyled">
                                <li>+ Phạm Minh Tuấn</li>
                                <li>+ Võ Đình Hiếu</li>
                                <li>+ Nguyễn Anh Quân</li>
                                <li>+ Phạm Thanh Thúy</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>  
</asp:Content>

