<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" Runat="Server">
         <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">Thông tin bệnh nhân</h4>
                    </div>
                    <div class="panel-body">
                        <div class="col-md-12 result mb-1 hide"></div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <label for="txtName">Họ tên</label>
                                <input id="txtName" type="text" class="form-control input-sm" placeholder="Họ tên ..." maxlength="100" />
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvGender">Giới tính</label>
                                <asp:DropDownList ID="cboGender" runat="server" ClientIDMode="Static" CssClass="form-control input-sm">
                                    <asp:ListItem Value="">Giới tính</asp:ListItem>
                                    <asp:ListItem Value="Male">Nam</asp:ListItem>
                                    <asp:ListItem Value="Female">Nữ</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvGenderName">Số tuổi</label>
                                <input id="txtAge" type="text" class="form-control input-sm number" placeholder="Tuổi ..." maxlength="2" />
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvPolyuria">Đi tiểu nhiều (Polyuria)</label>
                                <div id="dvPolyuria" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblPolyuria" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Tiểu nhiều hơn bình thường (>= 2.5 lít trong vòng 24 giờ ở người lớn)</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvPolydipsia">Chứng khát nước (Polydipsia)</label>
                                <div id="dvPolydipsia" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblPolydipsia" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Luôn cảm thấy khát nước bất kể uống bao nhiêu nước vẫn khô miệng</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvSuddenWeightLoss">Sụt cân bất thường (Sudden Weight Loss)</label>
                                <div id="dvSuddenWeightLoss" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblSuddenWeightLoss" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Cơ thể bị sụt cân không rỏ nguyên nhân trong một thời gian ngắn</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvWeakness">Cơ thể mệt mỏi (Weakness)</label>
                                <div id="dvWeakness" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblWeakness" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Luôn cảm thấy mệt mỏi, kiệt sức, đặc biệt khi vừa ngủ dậy</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvPolyphagia">Chứng đói quá mức (Polyphagia)</label>
                                <div id="dvPolyphagia" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblPolyphagia" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Luôn cảm thấy đói quá mức nên dẫn đến ăn quá nhiều</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvGenitalThrush">Bị bệnh tưa miệng (Genital Thrush)</label>
                                <div id="dvGenitalThrush" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblGenitalThrush" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Xuất hiện các mảng trắng trong miệng hoặc lưỡi đỏ khác thường</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvVisualBlurring">Chứng mờ mắt (Visual Blurring)</label>
                                <div id="dvVisualBlurring" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblVisualBlurring" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Mắt bị giảm thị lực, có hiện tượng xuất huyết, phù nề trong mắt</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvItching">Triệu chứng ngứa (Itching)</label>
                                <div id="dvItching" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblItching" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Da khô, bong tróc và ngứa ngáy</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvIrritability">Khó chịu và hay cáu gắt (Irritability)</label>
                                <div id="dvIrritability" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblIrritability" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Luôn cảm thấy khó chịu trong người và hay cáu gắt</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvDelayedHealing">Vết thương khó lành (Delayed Healing)</label>
                                <div id="dvDelayedHealing" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblDelayedHealing" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Rất lâu lành vết thương và xuất hiện các biến chứng khác trong quá trình hồi phục</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvPartialParesis">Liệt một bộ phận (Partial Paresis)</label>
                                <div id="dvPartialParesis" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblPartialParesis" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Không thể vận động một bộ phận nào đó</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvMuscleStiffness">Bị cứng cơ (Muscle Stiffness)</label>
                                <div id="dvMuscleStiffness" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblMuscleStiffness" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Cảm thấy cơ xương khớp bị cứng, khó vận động</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvAlopecia">Bị rụng tóc (Alopecia)</label>
                                <div id="dvAlopecia" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblAlopecia" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Tóc yếu, mỏng và rụng nhiều</div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-md-6">
                            <div class="form-group">
                                <label for="dvObesity">Bị béo phì (Obesity)</label>
                                <div id="dvObesity" class="form-control input-sm">
                                    <asp:RadioButtonList ID="rblObesity" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="No" Selected="True">Không</asp:ListItem>
                                        <asp:ListItem Value="Yes">Có</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="form-item-desc">Cơ thể đang bị bệnh béo phì</div>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <button type="button" class="btn btn-primary">Kiểm tra</button>
                            <button type="button" class="btn btn-default">Làm lại</button>
                        </div>
                    </div>
                </div>      
            </div>
            <script type="text/javascript" src="/js/Default.js"></script>
        </div>  
</asp:Content>

