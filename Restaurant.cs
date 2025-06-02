using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class Restaurant
    {
        private List<Menu> menu = new List<Menu>();
        private List<OrderItem> orderItems = new List<OrderItem>();

        public void ListOfItems()
        {
            Console.WriteLine("-----------------------------------");
            menu.Add(new Menu(1, "Dal Fry", 150));
            menu.Add(new Menu(2, "Kaju Masala", 190));
            menu.Add(new Menu(3, "Kaju Curry", 180));
            menu.Add(new Menu(4, "Shahi Paneer", 200));
            menu.Add(new Menu(5, "Paneer Masala", 200));
            menu.Add(new Menu(6, "Tawa Paneer", 180));
            menu.Add(new Menu(7, "Plain Naan", 20));
            menu.Add(new Menu(8, "Butter Naan", 30));
            menu.Add(new Menu(9, "Plain Rice", 100));
            menu.Add(new Menu(10, "Veg Pulav", 200));

        }
        public void DisplayMenu()
        {
            try
            {
                ListOfItems();
                foreach (var item in menu)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred while displaying the menu: " + ex.Message);
                return;
            }
        }
        public void PlaceOrder()
        {
            try
            {
                Console.Write("Enter the item number you want to order: ");
                if(int.TryParse(Console.ReadLine(), out int itemId))
                {
                    Menu selectItem = menu.Find(m => m.Id == itemId);
                    if(selectItem != null)
                    {
                        Console.Write("Enter the quantity: ");
                        if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                        {
                            OrderItem orderItem = new OrderItem(selectItem, quantity);
                            orderItems.Add(orderItem);
                            Console.WriteLine("Order placed successfully for " + selectItem.Name + " x " + quantity);
                        }
                        
                    }
                
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while placing the order: " + ex.Message);
                return;
            }
        }
        public void ViewOrder()
        {
            if (orderItems.Count == 0)
            {
                Console.WriteLine("No items in the order.");
                return;
            }
            Console.WriteLine("Current Order:");
            foreach (var item in orderItems)
            {
                Console.WriteLine(item);
            }
        }
        public void Checkout()
        {
            try
            {
                if(orderItems.Count > 0)
                {
                    double total = 0;
                    Console.WriteLine("Your order details...");
                    foreach (var item in orderItems)
                    {
                        Console.WriteLine(item);
                        total = total + item.GetTotalPrice();
                    }
                    Console.WriteLine("Total Amount: " + total);
                    Console.WriteLine("Thank You!");
                    menu.Clear();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occur during the checkout" + ex.Message);
            }
        }
    }   
}
