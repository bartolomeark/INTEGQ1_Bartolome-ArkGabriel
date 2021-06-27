using onlineShopping.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace onlineShopping.BL
{
    public class Signup
    {
        public List<Customer> UserCredentials = new List<Customer>()
        {
            new Customer("Ark","Gabriel")
        };


        public void loginMethod()
        {
            string username, password, Username, Password;
            int ctr = 0;
            Signup c = new Signup();
            Console.WriteLine("Create Account:");
            Console.WriteLine("");
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Successfuly Created!");
            Console.WriteLine("");
            for (int i = 2; i > 0; i--)
            {
                Console.WriteLine();
                Thread.Sleep(1000);
            }
            Console.WriteLine("Login");


            do
            {
                Console.Write("Input a username: ");
                Username = Console.ReadLine();

                Console.Write("Input a password: ");
                Password = Console.ReadLine();

                if (username != Username || password != Password)
                {
                    ctr++;
                }
                else
                {
                    ctr = 1;

                }
            }
            while ((username != Username || password != Password) && (ctr != 3));

            if (ctr == 3)
            {
                Console.Write("\nLogin attemp three or more times. Try later!\n\n");
                Console.WriteLine("Try again in 5 seconds.");
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                    loginMethod();
                }

            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Confirming...\n");
                    Thread.Sleep(3000);


                }
                Console.Write("\nThe password entered successfully!\n\n");
                Console.Write("------------------------------------------------------\n");
                Home home = new Home();
                home.una();
            }
        }

    }
}





