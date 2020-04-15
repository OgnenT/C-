using HW_class8_Car.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace HW_class8_Car.Entities
{
    public class ElectricCar : Car
    {

        public int BateryCapacity = 100;
        public int BatteryUsage;
        public int CurrentBattry;


        public void Drive(int distance)
        {
            CurrentBattry = BateryCapacity - BatteryUsage;
            int restBatery = CurrentBattry - (distance / 100) * (int)usingGas; //vo ovoj slucaj usingGas(high) e 15% na 100km! :(
            if (restBatery < 0)
                Console.WriteLine("You have no battery for this distance!");
            else
            {
                Console.WriteLine($"You have: {restBatery}% battery left.");
                CurrentBattry -= (distance / 100) * (int)usingGas;
            }
        }

        public void Recharge(int minutes)
        {
            int res = CurrentBattry + (minutes / 10);
            Console.WriteLine($"You have left {res}% battery");
        }

    }
}
