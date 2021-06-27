using System;
using System.Threading;

namespace onlineShopping.BL
{
    public class Home
    {
        public void una()
        {
           ManageProduct productServices = new ManageProduct();

        START:
            Console.Write("------------------------------------------------------\n");
            Console.WriteLine("Welcome to Calle Street Shop!\n");
            Console.WriteLine("Press [1] to view products.");
            Console.WriteLine("Press [4] to exit.");
            Console.Write("\n------------------------------------------------------\n");

            int exit = Convert.ToInt32(Console.ReadLine());
            switch (exit)
            {
                case 4:
                    Console.WriteLine("\nAre you sure you want to exit?");
                    Console.WriteLine("\nPress y if yes then n if no");
                    string optionSelected5 = Console.ReadLine().ToLower();
                    if (optionSelected5.Equals("y"))
                    {

                        Console.WriteLine("\nThank you! Come again!");
                        Console.WriteLine("Press Enter");
                        Console.ReadKey();

                    }
                    else if (optionSelected5.Equals("n"))
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
                    break;
                case 1:
                   productServices.Shopping();
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    goto START;
                    break;

            }

        }
    }
}
