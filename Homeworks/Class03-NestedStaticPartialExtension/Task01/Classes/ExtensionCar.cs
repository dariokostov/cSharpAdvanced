using System;
namespace Task01.Classes
{
    public static class ExtensionCar
    {
        public static void Drive(this Car car, string place)
        {
            if (car.Fuel >= 50)
            {
                car.Fuel -= 50;
                Console.WriteLine($"{car.Brand} {car.Model} driving to {place}. And take some fuel. You have {car.Fuel} liters now");
            }
            else
            {
                Console.WriteLine($"You don't have fuel for traveling to {place}");
            }
        }
    }
}
