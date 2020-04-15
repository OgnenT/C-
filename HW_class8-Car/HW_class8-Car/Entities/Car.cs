using HW_class8_Car.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW_class8_Car.Entities
{
    public class Car
    {
        public Car()
        {

        }
        public int Id;
        public string Brand;
        public string Model;
        public int Doors;
        public int TopSpeed;

        public Consumption usingGas;
        public EngineType engine = EngineType.petrol;

       
        public void PrintInfo()
        {
            Console.WriteLine($"This is {Brand} {Model} with id: {Id}, with {Doors} doors and top-speed of {TopSpeed}km." +
                $"\nYour car has {usingGas} consumption and {engine} engine.\n");
        }

    }
}
