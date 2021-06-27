using onlineShopping.DL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading;


namespace onlineShopping.BL
{
    public class Signup
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-PT5DGTR;Initial Catalog=Customerdb;Integrated Security=True");


        public void Add(Customer obj)
        {

            SqlCommand cmd = new SqlCommand("addCustomer", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", obj.username);
            cmd.Parameters.AddWithValue("@password", obj.password);
        }
        string username,password,Username,Password;
        public List<Customer> UserCredentials = new List<Customer>()
        {
            new Customer()
        };


        public void registerMethod()
        {
            
            Console.WriteLine("Create Account:");
            Console.WriteLine("");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Successfuly Created!");
            Console.WriteLine("");

            Console.WriteLine("Username: "+username);
            Console.WriteLine("Password: "+password);
            this.username = username;
            this.password = password;
            loginMethod();

            
        }
        public void loginMethod()
        {
            
            int ctr = 0;
            
            for (int i = 2; i > 0; i--)
            {
                Console.WriteLine();
                Thread.Sleep(1000);
            }
            Console.WriteLine("Login");


            do
            {
                Console.Write("Input a username: ");
                string Username = Console.ReadLine();

                Console.Write("Input a password: ");
                string Password = Console.ReadLine();

                this.Username = Username;
                this.Password = Password;

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

                   
                    
                }
                Signup sign = new Signup();
                Console.WriteLine("Don't have an account? Register Now?");
                Console.WriteLine("[1] If Yes\n[2] If No");

                int optionselected = Convert.ToInt32(Console.ReadLine());
                if (optionselected.Equals(1))
                {
                    sign.registerMethod();
                }
                else if (optionselected.Equals(2))
                {
                    sign.loginMethod();
                }
                else
                {

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
