using System;
namespace Task01.Classes
{
    public partial class Car
    {
        public Car(string brand, string model, string color, int fuel, bool keys, bool isDrivable)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Fuel = fuel;
            this.HaveKeys = keys;
            this.IsDrivable = isDrivable; // samo da se menjava
        }

        public void StartCar() 
        {
            if (HaveKeys)
            {

                    if(Fuel > 0)
                    {
                        Console.WriteLine($"The car {Brand} {Model} have keys is drivable and have fuel. Start driving!");
                    }
                    else
                    {
                        this.IsDrivable = false;
                        Console.WriteLine($"The car {Brand} {Model} is ok, but don't have a fuel");
                    }
                
            }
            else
            {
                Console.WriteLine("No keys");
            }
        }

        public void StartLights()
        {
        }
    }
}
