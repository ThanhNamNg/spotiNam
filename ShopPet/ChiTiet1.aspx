<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ChiTiet1.aspx.cs" Inherits="ShopPet.ChiTiet1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- chi tiết sản phẩm --%>
    <link href="assest/css/chitiet.css" rel="stylesheet" />
    <link href="assest/font/themify-icons/themify-icons.css" rel="stylesheet" />
    <div class="products-detail-content">
        <!-- ảnh thong tin và giá -->
        <div class="product-details">
            <div>
                <div class="product-image" id="productimage" runat="server">
                </div>

            </div>

            <div class="anhct">
                <div class="product" id="anh1" runat="server"></div>
                <div class="product1" id="anh2" runat="server"></div>

            </div>

            <div class="product-cost">
                <ul class="product-detail">
                    <li>
                        <span class="product-name" id="productname" runat="server"></span>
                    </li>
                    <li style="color: red; font-weight: 700;">
                        <span class="current-price" id="productprice" runat="server">5</span>
                        <span class="currency"></span>
                    </li>

                    <li id="mota" class="mota" runat="server"></li>

                </ul>

                <%-- chi sẻ --%>
                <div class="add-to-cart">
                    <button id="addtocart" class="addtocart" onclick="copyAndShareURL()">Chia sẻ</button>
                </div>


            </div>
        </div>
    </div>
    </form>
    <!-- thông tin chính sách -->
    <div class="product-info">
        <div class="warranty-infos">
            <ul>
                <li>
                    <span class="warranty-title" style="font-weight: 600;">THÔNG TIN BÀI HÁT</span>
                </li>
                <hr />
                <li>
                    <span>Những bài hay hay hit hot nhất hiện tại</span>
                </li>
                <li>
                    <span>Nghe nhạc tận hưởng mọi lúc mọi nơi</span>
                </li>
                <li>
                    <span>Tận hưởng dai điệu âm nhạc tuyệt vời nhất cùng với NamClound</span>
                </li>
            </ul>
        </div>
    </div>
    <br>

    <style>
        .share-button {
            margin-top: 20px;
        }

            .share-button button {
                display: inline-block;
                padding: 8px 16px;
                border: 1px solid #ccc;
                border-radius: 5px;
                background-color: #f4f4f4;
                color: #333;
                text-decoration: none;
                cursor: pointer;
            }

                .share-button button:hover {
                    background-color: #e6e6e6;
                }

        /* CSS cho trang phát nhạc */
        .products-detail-content {
            display: flex;
            justify-content: center; /* Canh giữa nội dung */
            align-items: center; /* Căn theo chiều dọc */
            flex-direction: column; /* Xếp các phần tử theo chiều dọc */
            margin-top: 50px; /* Khoảng cách từ phần tử này đến phần tử trên */
        }

        .product-details {
            display: flex;
            align-items: center;
        }

        .product-image {
            margin-right: 20px;
        }

        .product-name {
            font-size: 24px;
            font-weight: bold;
            margin-bottom: 10px;
        }

        .product-cost {
            margin-top: 10px;
        }

        .product-info {
            margin-top: 20px;
        }

        .warranty-title {
            font-weight: bold;
            font-size: 18px;
        }

        .warranty-infos span {
            font-size: 16px;
        }

        .audio-player {
            width: 300px;
            margin-top: 20px;
            background-color: #f4f4f4;
            border-radius: 5px;
            padding: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

            .audio-player audio {
                width: 100%;
            }

        .rotating {
            animation: rotateImage 2s linear infinite;
        }

        @keyframes rotateImage {
            from {
                transform: rotate(0deg);
            }

            to {
                transform: rotate(360deg);
            }
        }
    </style>

    <script>
        // Lấy thẻ audio và hình ảnh
        var audio = document.querySelector("audio");
        var image = document.getElementById("img-feature");

        // Khi người dùng bắt đầu hoặc dừng phát nhạc
        audio.onplay = function () {
            image.classList.add("rotating"); // Thêm lớp "rotating" để hình ảnh quay
        };

        audio.onpause = function () {
            image.classList.remove("rotating"); // Loại bỏ lớp "rotating" để dừng quay hình ảnh
        };

        // nut chia se
        function copyAndShareURL() {
            var url = window.location.href; // Lấy đường dẫn hiện tại
            // Sao chép đường dẫn vào bộ nhớ tạm
            var tempInput = document.createElement("input");
            tempInput.style = "position: absolute; left: -1000px; top: -1000px";
            tempInput.value = url;
            document.body.appendChild(tempInput);
            tempInput.select();
            document.execCommand("copy");
            document.body.removeChild(tempInput);
            // Hiển thị thông báo
            alert("Đã sao chép đường dẫn vào bộ nhớ tạm. ");
        }

    </script>

</asp:Content>
