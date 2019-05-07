using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Order :IItem
    {
        public int Quantity { get; set; }

        public string Name { get; set; }

        public int ID { get; set; }

        public double Price { get; set; }

        public List<Order> orders = new List<Order>();

        public Order(int id,int quantity)
        {
            ID = id;
            Quantity = quantity;
            

            for (int i = 0; i < quantity; i++)
            {
                orders.Add(this);
            }
            PrintOrderPrice();
        }

        public void PrintOrderPrice()
        {
            Price = Price* Quantity;

        }

    
        

        
    }
}
