using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ShopPet
{
    public class Global : System.Web.HttpApplication
    {
        public const string san_pham = "sanpham";

        protected void Application_Start(object sender, EventArgs e)
        {
       
            List<CUser> arrUser = new List<CUser>();
            arrUser.Add(new CUser() { name = "Anh", email = "a@gmail.com", password = "1234" });
            Application["user"] = arrUser;
          

            ArrayList arrProduct = new ArrayList();
            arrProduct.Add(new CProduct()
            {
                id = "1",
                type="cho",
                anhBaiHat = "./assest/img/Nhac/n1.png",
                tenBaiHat = "Nâng Chén Tiêu Sầu",
                tenTacGia = "Bích Phương ",
                baiHat = "./assest/img/n1.mp3"
            });
            arrProduct.Add(new CProduct()
            {
                id = "2",
                type="cho",
                anhBaiHat = "./assest/img/Nhac/n2.png",
                tenBaiHat = "Có Sao Cũng Đành",
                tenTacGia = "DatKaa ",
                baiHat = "./assest/img/n2.mp3"
            });

            arrProduct.Add(new CProduct()
            {
                id = "3",
                type = "cho",
                anhBaiHat = "./assest/img/Nhac/n3.png",
                tenBaiHat = "Cẩm Tú Cầu",
                tenTacGia = "RayO (Việt Nam), Huỳnh Văn",
                baiHat = "./assest/img/n3.mp3"
            });

            arrProduct.Add(new CProduct()
            {
                id = "4",
                type = "cho",
                anhBaiHat = "./assest/img/Nhac/n4.png",
                tenBaiHat = "Đợi đến tháng 13",
                tenTacGia = "Vũ Thịnh, Viam (Trần Việt Nam)",
                baiHat = "./assest/img/n4.mp3"
            });

           
            arrProduct.Add(new CProduct()
            {
                id = "5",
                type = "cho",
                anhBaiHat = "./assest/img/Nhac/n5.png",
                tenBaiHat = "Ngược Chiều Yêu",
                tenTacGia = "Đỗ Hoàng Dương",
                baiHat = "./assest/img/n5.mp3"
            });


            arrProduct.Add(new CProduct()
            {
                id = "5",
                type = "cho",
                anhBaiHat = "./assest/img/Nhac/n5.png",
                tenBaiHat = "Ngược Chiều Yêu",
                tenTacGia = "Đỗ Hoàng Dương",
                baiHat = "./assest/img/n5.mp3"
            });

            arrProduct.Add(new CProduct()
            {
                id = "6",
                type = "cho",
                anhBaiHat = "./assest/img/Nhac/n6.png",
                tenBaiHat = "Bồ Công Anh",
                tenTacGia = "Phong Max",
                baiHat = "./assest/img/n6.mp3"
            });

            arrProduct.Add(new CProduct()
            {
                id = "7",
                type = "cho",
                anhBaiHat = "./assest/img/Nhac/n7.png",
                tenBaiHat = "Magnetic",
                tenTacGia = "ILLIT",
                baiHat = "./assest/img/n7.mp3"
            });

            arrProduct.Add(new CProduct()
            {
                id = "8",
                type = "cho",
                anhBaiHat = "./assest/img/Nhac/n8.png",
                tenBaiHat = "SHEESH",
                tenTacGia = "BABYMONSTER",
                baiHat = "./assest/img/n8.mp3"
            });

            arrProduct.Add(new CProduct()
            {
                id = "9",
                type = "cho",
                anhBaiHat = "./assest/img/Nhac/n9.png",
                tenBaiHat = "Chưa Chắc / 未必 (DJ R7 Remix)",
                tenTacGia = "Ngôn Cẩn Vũ",
                baiHat = "./assest/img/n9.mp3"
            });

        

         


            
            ///Application["product"] = arrProduct;
            Application[san_pham] = arrProduct;


        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["dangnhap"]= 0;
            Session["giohang"] = new ArrayList();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}