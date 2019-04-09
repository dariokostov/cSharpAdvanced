using System;
using Task01.Classes;

namespace Task01
{
    class MainClass
    {
        //--------------------------------Task 1--------------------------------

        //Create a partial class Car - [all properties should be in the first part of the class and all methods should be in the second part of the class] 
        //The class Car should contain: 
        //Properties: Brand: string, Model: string, Color: string, Fuel: int, HaveKeys: bool, IsDrivable: bool
        //Methods: StartCar() : void, StartLights() : void
        //Implement a logic for both methods based on some of the properties(you should know which ones)
        //Both methods should print a message accordingly

        //--------------------------------Task 2--------------------------------

        //Add an extension method on the Car class: Drive(string place): void
        //Add a static mathod on the Car class: GetCarStats(Car c): string
        //Drive method should print a message: ...Driving to[place]. And take some fuel(random)
        //GetCarStats method should return a string with all stats of the car

        //--------------------------------Task 3--------------------------------

        //Create a static class GasStation
        //GasStation should contain 2 methods: Refill(Car c) : void, PumpUpTires(Car c) : void
        //Refill should add a random fuel to the car.And print a message of how much fuel is added
        //PumpUpTires should change the state of the car to drivable if it's not. And print a message that the car now is in good state

        public static void Main(string[] args)
        {
            Car myCar = new Car("Golf", "5", "Red", 40, true);
            Car myCar2 = new Car("BMW", "520", "Black", 80, true);


            Console.WriteLine($"------------{myCar.Brand} {myCar.Model}------------");
            Console.WriteLine(Car.GetCarStats(myCar));
            myCar.StartCar();
            myCar.StartLights();
            myCar.Drive("Belgrad");
            GasStation.Refill(myCar);
            myCar.Drive("Belgrad");
            GasStation.PumpUpTires(myCar);

            Console.WriteLine($"------------{myCar.Brand} {myCar2.Model}------------");
            Console.WriteLine(Car.GetCarStats(myCar2));
            myCar2.StartCar();
            myCar2.StartLights();
            myCar2.Drive("Belgrad");
            GasStation.Refill(myCar2);
            GasStation.PumpUpTires(myCar2);

            Console.ReadLine();
        }
    }
}
