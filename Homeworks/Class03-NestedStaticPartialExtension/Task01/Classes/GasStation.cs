using System;
namespace Task01.Classes
{
    public static class GasStation
    {

        public static void Refill(Car car)
        {
            car.Fuel += 50;
            Console.WriteLine($"+ 50 liters, now you have {car.Fuel} liters");
        }

        public static void PumpUpTires(Car car)
        {
            if (car.IsDrivable == false)
            {
                car.IsDrivable = true;
                Console.WriteLine($"{car.Brand} {car.Model} is drivable now. Start driving!");
            }
            else
            {
                Console.WriteLine($"{car.Brand} {car.Model} is ok!");
            }
        }
    }
}
