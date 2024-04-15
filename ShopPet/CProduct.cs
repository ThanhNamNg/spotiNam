using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopPet
{
    public class CProduct
    {
        public string id { get; set; }
        public string type { get; set; }
        public string anhBaiHat { get; set; }
        public string tenBaiHat { get; set; }
        public string tenTacGia { get; set; }
        public string baiHat { get; set; }
        public CProduct(string id, string type, string image, string name, string price, string detail)
        {
            this.id = id;
            this.type = type;
            this.anhBaiHat = image;
            this.tenBaiHat = name;
            this.tenTacGia = price;
            this.baiHat = detail;
        }

        public CProduct()
        {
        }
    }
}