using HW_class8_Car.Entities;
using HW_class8_Car.Enums;
using System;


namespace HW_class8_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFuelCar = new FuelCar()
            {
                Id = 255214881,
                Brand = "Peugeot",
                Model = "2008",
                Doors = 4,
                TopSpeed = 200,
                CurrentFuel = 30,
                usingGas = Consumption.economic
            };

            myFuelCar.PrintInfo();
            Console.WriteLine("How many Km you will drive?");
            int km = Convert.ToInt32(Console.ReadLine());
            myFuelCar.Drive(km);
            Console.WriteLine("Refuel your tank! (insert number of liters)");
            double refuel = Convert.ToDouble(Console.ReadLine());
            myFuelCar.Refuel(refuel);

            Console.WriteLine("\n----------------------\n");

            var myElectricCar = new ElectricCar()
            {
                Id = 100525045,
                Brand = "Tesla",
                Model = "ZX",
                Doors = 2,
                TopSpeed = 320,
                usingGas = Consumption.high,
                engine = EngineType.electric,
                BatteryUsage = 20
            };

            myElectricCar.PrintInfo();
            Console.WriteLine($"How many Km will you drive with your Electric car? (Remain battery: {myElectricCar.BateryCapacity - myElectricCar.BatteryUsage}%)");
            int km1 = Convert.ToInt32(Console.ReadLine());
            myElectricCar.Drive(km1);
            Console.WriteLine("Recharge your battery! (insert minutes of charging)");
            int recharge = Convert.ToInt32(Console.ReadLine());
            myElectricCar.Recharge(recharge);

            Console.ReadLine();
        }
    }
}
