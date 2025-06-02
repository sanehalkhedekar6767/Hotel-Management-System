using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            bool running = true;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-----------Welcome to the Sahyadri Restaurant-----------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();

            while(running)
            {
                Console.WriteLine();
                Console.WriteLine("1. Display Menu");
                Console.WriteLine("2. Place Order");
                Console.WriteLine("3. View Order");
                Console.WriteLine("4. View Bill");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                switch (option)
                {
                    case 1:
                        restaurant.DisplayMenu();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case 2:
                        restaurant.PlaceOrder();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case 3:
                        restaurant.ViewOrder();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case 4:
                        restaurant.Checkout();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Thank you! Visit Again");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }

            } 
        }
    }
}