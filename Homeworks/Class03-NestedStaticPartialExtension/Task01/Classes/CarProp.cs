using System;
namespace Task01.Classes
{
    public partial class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Fuel { get; set; }
        public bool HaveKeys { get; set; }
        public bool IsDrivable { get; set; }

        public Car(string brand, string model, string color, int fuel, bool keys)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Fuel = fuel;
            this.HaveKeys = keys;
            this.IsDrivable = false;
        }
    }
}
