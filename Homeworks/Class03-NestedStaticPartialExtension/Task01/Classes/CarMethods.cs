using System;
namespace Task01.Classes
{
    public partial class Car
    {
        public void StartCar() 
        {
            if (HaveKeys)
            {

                if(Fuel > 30)
                {
                    this.IsDrivable = true;
                    Console.WriteLine($"The car {Brand} {Model} have keys and have fuel. Start driving!");
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
            Console.WriteLine("Lights is started");
        }

        public static string GetCarStats(Car car)
        {
            return $"Car info: \nBrand: {car.Brand}\nModel: {car.Model}\nColor: {car.Color}\nFiel: {car.Fuel}\n\n";
        }
    }
}
