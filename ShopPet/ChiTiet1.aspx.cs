using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class ChiTiet1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string request = Request.QueryString["pi"];
            ArrayList arrProduct = Application[Global.san_pham] as ArrayList;

            foreach (CProduct sp in arrProduct)
            {
                if (sp.id == request)
                {
                    productimage.InnerHtml = "<img src='" + sp.anhBaiHat + "' id ='img-feature' alt='" + sp.id + "' style='width: 200px; height: 200px; border-radius: 50%; transition: transform 2s linear; box-shadow: 0px 0px 20px 5px rgba(0, 0, 0, 0.5);'>";

                    productname.InnerText = sp.tenBaiHat;
                    productprice.InnerText = "Tác giả: "+ sp.tenTacGia;
                    mota.InnerHtml = "<audio controls>  <source src='"+ sp.baiHat  +"' type=\"audio/mpeg\">  Your browser does not support the audio element.</audio>";


                }

            }
        }
    }
}