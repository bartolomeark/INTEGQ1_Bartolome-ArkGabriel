using onlineShopping.BL;
using System;
using System.Threading;



namespace onlineShopping
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            START:
            Console.Write("------------------------------------------------------\n");
            Console.Write("------------------------------------------------------\n");
            Console.WriteLine("Welcome to Calle Street Shop!");
            Signup user = new Signup();

            Console.WriteLine("[1]LOG IN ");
            Console.WriteLine("[2]Register ");
            Console.WriteLine("");

            Console.WriteLine("[3]EXIT");
            Console.Write("------------------------------------------------------\n");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.loginMethod();
            }
            else if (userInput.Equals(2))
            {
                user.registerMethod();
            }
            else if (userInput.Equals(3))
            {
                Console.WriteLine("\nAre you sure you want to exit?");
                Console.WriteLine("\nPress y if yes then n if no");
                string optionSelected5 = Console.ReadLine().ToLower();
                if (optionSelected5.Equals("y"))
                {

                    Console.WriteLine("\nThank you! Come again!");
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();

                }else if(optionSelected5.Equals("n"))
                    {
                    Console.WriteLine("");
                    Console.WriteLine("Restarting...");
                    for (int i = 3; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                    goto START;
                    }
                    else
                    {
                    Console.WriteLine("Invalid Option!");
                    }
                
                    


            }
        }
    }
}

