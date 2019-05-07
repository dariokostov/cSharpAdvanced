using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public static class Methods
    {
        public static void PrintVendor(Vendor vendor)
        {
            Console.WriteLine($"--------------Store Name: *{vendor.Name.ToUpper()}* has these products available--------------");
            foreach (var item in vendor.Products)
            {
                
                Console.WriteLine($"{item.ID} { item.Name } {item.Price}");
            }
        }

        public static User RegisterUser()
        {
            Console.WriteLine("------------------------------------Welcome to the E-Shop!-------------------------------------");
            Console.WriteLine("-------------------------Please register , enter your desired username:-------------------------");
            string username = Console.ReadLine();

            if (!String.IsNullOrEmpty(username) && username.Length > 3)
            {
                User user = new User(username);
                Console.WriteLine($"--------------------------You are registered, Welcome {username}--------------------------");
                return user;
            }
            else
            {
                Console.WriteLine("--------------------Registration was NOT succesfull , please try again!--------------------");
                System.Threading.Thread.Sleep(2000);
                return RegisterUser();
            }
        }

        public static void UsersActions(Dictionary<Vendor, List<Product>> somelist)
        {
            string userAction = Console.ReadLine();
            switch (userAction)
            {
                case "1":
                    Console.WriteLine("---------------------------------List of all Vendors:------------------------------------");                    
                    foreach (var item in somelist)
                    {
                        Console.WriteLine($"{item.Key.ID} {item.Key.Name}");
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

                case "2":          
                    foreach (var item in somelist)
                    {

                            item.Key.AddProduct(item.Value);
                            Methods.PrintVendor(item.Key);
                  
                    }
                    goto case "3";

                case "3":
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
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                case "7":

                    break;
                default:
                    Console.WriteLine("-------------------Invallid input , please enter number from 1 to 7-------------------");
                   
                    break;
            }
        }
    }
}
