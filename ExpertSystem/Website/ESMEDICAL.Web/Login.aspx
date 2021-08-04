<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<%@ Register Src="~/Control/ToolbarAdd.ascx" TagPrefix="uc1" TagName="ToolbarAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" runat="Server">
    <div class="mt-login">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="panel panel-default">
                        <div class="panel-heading">ĐĂNG NHẬP</div>
                        <div class="panel-body">
                            <div class="col-md-12 mb-1 hide"><div class="alert alert-danger"></div></div>
                            <div class="col-md-12 mb-1">
                                <div class="input-group">
                                    <span class="input-group-addon login-icon"><i class="fa fa-user-o fa-fw"></i></span>
                                    <input id="txtUsername" type="text" class="form-control input-sm" placeholder="Tên truy cập..."  maxlength="30" />
                                </div>
                            </div>
                            <div class="col-md-12 mb-1">
                                <div class="input-group">
                                    <span class="input-group-addon login-icon"><i class="fa fa-lock fa-fw"></i></span>
                                    <input id="txtPassword" type="password" class="form-control input-sm" placeholder="Mật khẩu..." maxlength="100" />
                                </div>
                            </div>
                            <div class="col-md-12 mb-1">
                                <button id="cmdLogin" type="button" class="btn btn-default btn-block btn-sm"><i class="fa fa-sign-in"></i> Đăng nhập</button>
                            </div>   
                            <div class="col-md-12">
                                <div class="copyright">
                                    Copyright &#169; 2021 by <a target="_blank" href="http://esmedical.mtsoftware.vn">ESMedical</a>
                                </div>
                            </div>                
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="/js/Login.js"></script>
</asp:Content>
