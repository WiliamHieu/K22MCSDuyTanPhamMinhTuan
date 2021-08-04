<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="UserInfo" %>
<%@ Register Src="~/control/Breakcum.ascx" TagPrefix="uc1" TagName="Breakcum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" runat="Server">
        <uc1:Breakcum ID="ucBreakcum" runat="server" Left="Thông tin Người dùng|/thong-tin-nguoi-dung" Right="/" />
        <asp:Literal ID="lblToolbar" runat="server"/>
        <div class="row">
            <div class="col-md-12 mb-1 hide"><div class="alert alert-danger"></div></div>
            <div class="col-md-12 mb-1">
                <div class="input-group">
                    <span class="input-group-addon mw-70">Họ tên</span>
                    <input id="txtFullName" type="text" runat="server" class="form-control input-sm" readonly="true"  />
                </div>
            </div>
            <div class="col-md-12 mb-1">
                <div class="input-group">
                    <span class="input-group-addon mw-70">Username</span>
                    <input id="txtUsername" type="text" runat="server" class="form-control input-sm" readonly="true"  />
                </div>
            </div>
            <div class="col-md-12 mb-1 mb-1">
                <div class="input-group">
                    <span class="input-group-addon mw-70">Password</span>
                    <input id="txtOldPassword" type="password" class="form-control input-sm" placeholder="Mật khẩu cũ..." maxlength="100" />
                </div>
            </div>
            <div class="col-md-12 mb-1">
                <div class="input-group">
                    <span class="input-group-addon mw-70">Pass mới</span>
                    <input id="txtNewPassword" type="password" class="form-control input-sm" placeholder="Mật khẩu mới..." maxlength="100" />
                </div>
            </div>
        </div>
        <script type="text/javascript" src="/js/UserInfo.js"></script>
</asp:Content>

