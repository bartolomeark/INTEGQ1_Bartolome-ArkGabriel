using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShopping.DL
{
   public class Product
    {
        public class tshirtList
        {
            string name;
            string details;

            public void Printbase()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Details: " + details);
            }
        }

        public class HE : tshirtList
        {
            public string productName = "Hustle Everyday Tshirt";
            public int productQuantity = 400;
            public void products()
            {
                Console.WriteLine("Available Product:");
                Console.WriteLine("Product:" + productName);
                Console.WriteLine("Stock:" + productQuantity);
                Console.WriteLine("How many would you like to buy?\n");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you like to buy " + quantity, "?");
                Console.WriteLine(" Type Y to confirm then N to cancel");
                string optionSelected = Console.ReadLine().ToLower();
                if (optionSelected.Equals("y"))
                {
                    int newproductQuantity = productQuantity - quantity;
                    Console.WriteLine("You buy " + quantity);
                    Console.WriteLine("Remaining stock is " + newproductQuantity);

                }
                else if (optionSelected.Equals("n"))
                {
                    Console.WriteLine("");

                }
            }
        }
        public class GMA : tshirtList
        {
            public string productName = "Galingan mo Araw-Araw Tshirt";
            public int productQuantity = 400;
            public void products()
            {
                Console.WriteLine("Available Product:");
                Console.WriteLine("Product:" + productName);
                Console.WriteLine("Stock:" + productQuantity);
                Console.WriteLine("How many would you like to buy?\n");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you like to buy " + quantity, "?");
                Console.WriteLine(" Type Y to confirm then N to cancel");
                string optionSelected = Console.ReadLine().ToLower();
                if (optionSelected.Equals("y"))
                {
                    int newproductQuantity = productQuantity - quantity;
                    Console.WriteLine("You buy " + quantity);
                    Console.WriteLine("Remaining stock is " + newproductQuantity);

                }
                else if (optionSelected.Equals("n"))
                {
                    Console.WriteLine("");

                }
            }
        }

        public class GHR : tshirtList
        {
            public string productName = "Grind Hustle Repeat Tshirt";
            public int productQuantity = 400;

            public void products()
            {

                Console.WriteLine("Available Product:");
                Console.WriteLine("Product:" + productName);
                Console.WriteLine("Stock:" + productQuantity);
                Console.WriteLine("How many would you like to buy?\n");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you like to buy " + quantity, "?");
                Console.WriteLine(" Type Y to confirm then N to cancel");
                string optionSelected = Console.ReadLine().ToLower();
                if (optionSelected.Equals("y"))
                {
                    int newproductQuantity = productQuantity - quantity;
                    Console.WriteLine("You buy " + quantity);
                    Console.WriteLine("Remaining stock is " + newproductQuantity);

                }
                else if (optionSelected.Equals("n"))
                {
                    Console.WriteLine("");

                }
            }
        }
        public class RDHD : tshirtList
        {
            public string productName = "Rest day, Hustle day Tshirt";
            public int productQuantity = 400;

            public void products()
            {
                Console.WriteLine("Available Product:");
                Console.WriteLine("Product:" + productName);
                Console.WriteLine("Stock:" + productQuantity);
                Console.WriteLine("How many would you like to buy?\n");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you like to buy " + quantity, "?");
                Console.WriteLine(" Type Y to confirm then N to cancel");
                string optionSelected = Console.ReadLine().ToLower();
                if (optionSelected.Equals("y"))
                {
                    int newproductQuantity = productQuantity - quantity;
                    Console.WriteLine("You buy " + quantity);
                    Console.WriteLine("Remaining stock is " + newproductQuantity);

                }
                else if (optionSelected.Equals("n"))
                {
                    Console.WriteLine("");

                }
                
            }
        }
        
    }
}
