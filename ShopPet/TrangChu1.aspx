<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TangChu1.aspx.cs" Inherits="ShopPet.TangChu1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
          <!-- Các item quảng bá và list truyện-->
    <div class="main_content">
        <!-- item -->
        <div class="item">
            <div class="item_1">
                <div class="icon"><i class="ti-gift"></i></div>
                <div class="item_infor">Các giai điệu <br> hấp dẫn</div>
            </div>
            <div class="item_1">
                <div class="icon"><i class="ti-money"></i></div>
                <div class="item_infor">Nghe nhạc <br> miễn phí</div>
            </div>
            <div class="item_1">
                <div class="icon"><i class="ti-info"></i></div>
                <div class="item_infor">Thông tin <br>rõ ràng </div>
            </div>
            <div class="item_1">
                <div class="icon"><i class="ti-truck"></i></div>
                <div class="item_infor">Mọi lúc <br>mọi nơi </div>
            </div>
        </div>  

        <!-- list sp -->
        <br>
        <h3 class="banchay">Nhạc hay nhất</h3>
        <%--<a href="ThongkeUser.aspx">Thống kê User</a>--%>
        <br>
        <div class="product-list">
            <%= HienProducts() %>
        </div>
        <%-- quảng cáo --%>
        <div class="quangcao">
            <img src="assest/img/gif.gif" alt="hinhanh" class="quangcao-img">
        </div>
        <br />
        <%-- list thứ 2 --%>
        <div class="product-list"> 
            <%= HienProducts() %>
        </div>
    </div>

</asp:Content>
