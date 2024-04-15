using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class TangChu1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        public string HienProducts()
        {
            ArrayList arrProduct = Application[Global.san_pham] as ArrayList;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arrProduct.Count; i++)
            {
                CProduct item = arrProduct[i] as CProduct;
                sb.Append("<div class='grid'>");
                sb.AppendFormat("<a href='/ChiTiet1.aspx?pi={2}' title='Xem {1}'><img src='{0}' alt='{1}' title='{1}' class='product-img'/>"
                    , item.anhBaiHat
                    , item.tenBaiHat
                    , item.id
                    );
                sb.AppendFormat("<div class='product-name'><a href='/ChiTiet.aspx?pi={1}' title='Xem {0}'>{0}</a></div>"
                    , item.tenBaiHat
                    , item.id
                    );
                sb.Append("</a>");
                sb.AppendFormat("<div class='product-price'>{0}</div>"
                    , item.tenTacGia);
                sb.Append("</div>");
            }

            return sb.ToString();
        }


    }
}