using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Hamburger
    {
        public static List<Hamburger> MenuListesi = new List<Hamburger> 
        {
            new Hamburger {MenuAd="Dublex Burger",Fiyat=26},
            new Hamburger {MenuAd="Triplex Burger",Fiyat=31},
            new Hamburger {MenuAd="Steak Burger",Fiyat=26},
            new Hamburger {MenuAd="Cheese Burger",Fiyat=19},
            new Hamburger {MenuAd="Mexicano Burger",Fiyat=20},
            new Hamburger {MenuAd="Lokum Burger",Fiyat=25}

        };
        public string MenuAd { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return MenuAd;
        }

    }
}
