
using System;
using System.Collections.Generic;
using System.Text;
using static onlineShopping.DL.Product;

namespace onlineShopping.BL
{
    class ManageProduct
    {
        
        public void Shopping()
        {
            Console.Write("------------------------------------------------------");
            Console.Write("------------------------------------------------------\n");
            Console.WriteLine("Welcome to Calle Street Shop");
            Console.WriteLine("Choose you want to buy:");
            Console.WriteLine("[1] Hustle Everyday\n[2] Galingan mo Araw-Araw Tshirt\n[3] Grind Hustle Repeat\n[4] Rest day, Hustle day\n\n[0] To Exit");
            Console.Write("\n------------------------------------------------------\n");
            int optionSelected = Convert.ToInt32(Console.ReadLine());

            if (optionSelected.Equals(1))
            {
                HE he = new HE();
                he.products();
            }
            else if (optionSelected.Equals(2))
            {
                GMA gma = new GMA();
                gma.products();
            }
            else if (optionSelected.Equals(3))
            {
                GHR ghr = new GHR();
                ghr.products();
            }
            else if (optionSelected.Equals(4))
            {
                RDHD rdhd = new RDHD();
                rdhd.products();
            }
            else
            {
                Console.WriteLine("Press Enter to Exit.");
                Console.ReadKey();
            }
        }
    }
}
