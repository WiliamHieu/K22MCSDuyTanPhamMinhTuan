<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Diabetes.aspx.cs" Inherits="Diabetes" %>
<%@ Register Src="~/Control/ToolbarAdd.ascx" TagPrefix="uc1" TagName="ToolbarAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" runat="Server">
        <uc1:ToolbarAdd ID="ucToolbarAdd" runat="server" Left="Bệnh tiểu đường|/Diabetes.aspx" Right="Thêm|/diabetes/0"/>
        <asp:HiddenField ID="hTotalPages" runat="server" ClientIDMode="Static" Value="0"/>
        <asp:HiddenField ID="hRowNumber" runat="server" ClientIDMode="Static" Value="0"/>
	    <div class="row mb-2">
            <div class="col-md-12 mb-1 hide"><div class="alert alert-danger"></div></div>
            <div class="col-sm-6 col-md-6 mb-1">
                <div class="input-group date">
                    <span class="input-group-addon mw-65">Từ ngày</span>
                    <div id="dvFromDateName" class="form-control input-sm"><asp:Literal ID="lblFromDateText" runat="server" Text="Tất cả" /></div>
                    <asp:HiddenField ID="hFromDate" runat="server" ClientIDMode="Static" Value="0" />
                    <div class="input-group-btn"><button id="btnFromDate" type="button" class="btn btn-default btn-sm" data-date-format="dd/mm/yyyy"><i class="fa fa-calendar-o fa-fw"></i></button></div>
                </div>
            </div>
            <div class="col-sm-6 col-md-6 mb-1">
                <div class="input-group date">
                    <span class="input-group-addon mw-65">Đến ngày</span>
                    <div id="dvToDateText" class="form-control input-sm"><asp:Literal ID="lblToDateText" runat="server" Text="Tất cả" /></div>
                    <asp:HiddenField ID="hToDate" runat="server" ClientIDMode="Static" Value="0" />
                    <div class="input-group-btn"><button id="btnToDate" type="button" class="btn btn-default btn-sm" data-date-format="dd/mm/yyyy"><i class="fa fa-calendar-o fa-fw"></i></button></div>
                </div>
            </div>
            <div class="col-sm-6 col-md-6 mb-1">
                <div class="input-group">
                    <span class="input-group-addon mw-65">Số tuổi</span>
                    <asp:TextBox ID="txtAge" runat="server" ClientIDMode="Static" type="text" CssClass="form-control input-sm number" MaxLength="3"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-6 col-md-6 mb-1">
                <div class="input-group">
                    <asp:DropDownList ID="cboGender" runat="server" ClientIDMode="Static" CssClass="form-control input-sm">
                        <asp:ListItem Value="" Selected="True">Giới tính</asp:ListItem>
                        <asp:ListItem Value="Male">Nam</asp:ListItem>
                        <asp:ListItem Value="Female">Nữ</asp:ListItem>
                    </asp:DropDownList>
                    <div class="input-group-btn"><button id="btnSearch" type="button" class="btn btn-default btn-sm"><i class="fa fa-search"></i>Tìm</button></div>
                </div>
            </div>
            <div class="col-md-12">
                <div class="table-responsive">
                    <table class="gridview mt-table">
                        <thead>
                            <tr>
                                <th class="order">STT</th>
                                <th class="tnumber">Age</th>
                                <th class="type">Gender</th>
                                <th class="type">Polyu</th>
                                <th class="type">Polyd</th>
                                <th class="type">SWLoss</th>
                                <th class="type">Wness</th>
                                <th class="type">Polyp</th>
                                <th class="type">GThrush</th>
                                <th class="type">VBlurring</th>
                                <th class="type">Itching</th>
                                <th class="type">Irrita</th>
                                <th class="type">DHealing</th>
                                <th class="type">PParesis</th>
                                <th class="type">MStiffness</th>
                                <th class="type">Alopecia</th>
                                <th class="type">Obesity</th>
                                <th class="type">Class</th>
                                <th class="btn-2"></th>
                            </tr>
                        </thead>
                        <tbody id="dataHolder">
                            <asp:Literal ID="lblDataHolder" runat="server"/>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
	    <div class="row">
            <div id="page-bottom" class="col-md-12 text-center"></div>
        </div>
        <script src="/js/jquery.bootpag.min.js"></script>
        <script type="text/javascript" src="/js/Diabetes.js"></script>
</asp:Content>

