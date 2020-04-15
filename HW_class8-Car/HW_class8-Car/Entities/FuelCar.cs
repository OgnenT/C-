using HW_class8_Car.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace HW_class8_Car.Entities
{
    public class FuelCar : Car
    {
        public double FuelCapacity = 60;
        public double CurrentFuel;
        
        public void Drive(double distance)
        {

            double current = FuelCapacity - CurrentFuel;
            double litre = current - (distance / 100) * (int)usingGas;
            if (litre > 0)
            {
                Console.WriteLine($"You have left {litre:N} liters in your tank!");
                CurrentFuel -= (distance / 100) * (int)usingGas;
            }
            else
            {
                Console.WriteLine("Out of GAS!!!");
            }
        }

        public void Refuel(double litre)
        {
            double current = CurrentFuel + litre;
            if (current > FuelCapacity)
            {
                Console.WriteLine($"Too much fuel! Your tank is {FuelCapacity} litres total.");
            }
            else
                Console.WriteLine($"You have filled {litre:N} litres, now you have {current:N} left.");
        }
    }
}
