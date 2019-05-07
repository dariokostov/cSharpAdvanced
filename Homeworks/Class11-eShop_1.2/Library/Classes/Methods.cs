using System;
using System.Collections.Generic;

namespace Library.Classes
{
    public static class Methods
    {
        public static void PrintVendor(Vendor vendor)
        {
            Console.WriteLine($"--------------Store Name: *{vendor.Name.ToUpper()}* has these products available--------------");
            foreach (var item in vendor.Products)
            {

                Console.WriteLine($"{item.ID}. { item.Name } {item.Price}");
            }
        }

        public static User RegisterUser()
        {
            Console.WriteLine("------------------------------------Welcome to the E-Shop!-------------------------------------");
            Console.WriteLine("-------------------------Please register, enter your desired username:-------------------------");
            string username = Console.ReadLine();

            if (!String.IsNullOrEmpty(username) && username.Length > 3)
            {
                User user = new User(username);
                Console.WriteLine($"--------------------------You are registered, Welcome {username}--------------------------");
                return user;
            }
            else
            {
                Console.WriteLine("--------------------Registration was NOT succesfull, please try again!--------------------");
                System.Threading.Thread.Sleep(2000);
                return RegisterUser();
            }
        }

        public static void UsersActions(Dictionary<Vendor, List<Product>> somelist)
        {
            string userAction = Console.ReadLine();
            switch (userAction)
            {
                case "1": //Get the full list of vendors
                    Console.WriteLine("---------------------------------List of all Vendors:------------------------------------");
                    foreach (var item in somelist)
                    {
                        Console.WriteLine($"{item.Key.ID}. {item.Key.Name}");
                    }
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    int chosenVendor = int.Parse(Console.ReadLine());
                    foreach (var item in somelist)
                    {
                        item.Key.AddProduct(item.Value);
                        if (chosenVendor == item.Key.ID)
                        {
                            Methods.PrintVendor(item.Key);
                        }
                    }
                    goto case "3";

                case "2": //Search all products based on Vendors name with name and price
                    foreach (var item in somelist)
                    {
                        item.Key.AddProduct(item.Value);
                        Methods.PrintVendor(item.Key);
                    }
                    goto case "3";

                case "3": //Create a new order by providing product code and quantity and add to user orders
                    Console.WriteLine("\nProvide product code and quantity");
                    Console.Write("Product code: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Quantity: ");

                    int quantity = int.Parse(Console.ReadLine());
                    Order ordering = new Order(id, quantity);
                    foreach (var item in somelist.Values)
                    {
                        foreach (var item1 in item)
                        {
                            if (ordering.ID == item1.ID)
                            {
                                Console.WriteLine($"Your ordered products {item1.Name} Cost {item1.Price} \nThe total amount for {quantity} items is ${item1.Price * quantity}");
                            }
                        }
                    }
                    break;
                case "4": //Get state of shopping cart (name / quantity / price)

                    break;
                case "5": //Remove existing order by index

                    break;
                case "6": //Finish oreder with order receipt including username , products name quantity and price and total price

                    break;
                case "7": //Exit shop
                    Console.WriteLine($"Thank you for visiting our shop! Please visit us again.");
                    break;
                default:
                    Console.WriteLine("-------------------Invallid input , please enter number from 1 to 7-------------------");
                    break;
            }
        }
    }
}