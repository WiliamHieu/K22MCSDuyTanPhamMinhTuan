<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4 mt-login">
                <div class="panel panel-default">
                    <div class="panel-heading">ĐĂNG NHẬP</div>
                    <div class="panel-body">
                        <div class="col-md-12 mb-1 hide"><div class="alert alert-danger"></div></div>
                        <div class="col-md-12 mb-1">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user-o fa-fw"></i></span>
                                <input id="txtUsername" type="text" class="form-control input-sm" placeholder="Tên truy cập..."  maxlength="30" />
                            </div>
                        </div>
                        <div class="col-md-12 mb-1">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-lock fa-fw"></i></span>
                                <input id="txtPassword" type="password" class="form-control input-sm" placeholder="Mật khẩu..." maxlength="100" />
                            </div>
                        </div>
                        <div class="col-md-12 mb-1">
                            <div class="form-control input-sm">
                                <div class="checkbox checkbox-primary">
                                    <asp:CheckBox ID="chkRemember" runat="server" ClientIDMode="Static" CssClass="styled" Text="Nhớ mật khẩu" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12 mb-3">
                            <button id="cmdLogin" type="button" class="btn btn-default btn-block btn-sm"><i class="fa fa-sign-in"></i> Đăng nhập</button>
                        </div>  
                        <div class="col-md-12 account">
                            Username: admin<span></span>Password: admin123
                        </div>     
                    </div>
                </div>
            </div>
            <div class="col-md-12 mb-1">
                <input id="chkValidate" type="checkbox" /> Lọc dữ liệu đầu vào
            </div>
            <div class="col-md-12">
                <textarea id="txtSQLQuery" cols="20" rows="3" class="form-control input-sm" readonly="readonly">SELECT Username, Password, Name, Status FROM Users WHERE Username='' AND Password=''</textarea>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="/js/Default.js"></script>
</asp:Content>

