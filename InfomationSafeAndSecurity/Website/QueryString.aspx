<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="QueryString.aspx.cs" Inherits="QueryString" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" Runat="Server">
        <section class="mt-detail">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="alert alert-success">
                            <div class="checkbox checkbox-primary">
                                <asp:CheckBox ID="chkValidate" runat="server" ClientIDMode="Static" CssClass="styled" Text="Lọc dữ liệu đầu vào" />
                            </div>                        
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <h1 class="title"><asp:Literal ID="lblName" runat="server"></asp:Literal></h1>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12 col-md-4">
                        <asp:Image ID="imgImage" runat="server" CssClass="image" />
                    </div>
                    <div class="col-xs-12 col-md-8">
                        <p class="description">
                            <asp:Literal ID="lblDescription" runat="server"></asp:Literal>
                        </p>
                        <p class="price">
                            <asp:Literal ID="lblPrice" runat="server"></asp:Literal>
                        </p>
                        <div class="accessories"><ul class="list-group"><li class="fa-cube">Dây sạc, Sách HDSD</li><li class="fa-clock">Bảo hành 12 tháng</li><li class="fa-undo">Không đổi trả</li></ul></div>
                        <div class="button">
                            <a class="buy-now" href="#">Mua ngay<span>Giao trong vòng 1 giờ</span></a><a class="buy-ins" href="#">Mua trả góp<span> Lãi suất 0%</span></a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <script type="text/javascript" src="/js/QueryString.js"></script>
</asp:Content>

