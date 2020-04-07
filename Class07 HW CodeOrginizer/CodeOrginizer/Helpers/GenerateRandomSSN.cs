using System;
using System.Collections.Generic;
using System.Text;
using CodeOrginizer.Entities;

namespace CodeOrginizer.Helpers
{
    public class GenerateRandomSSN
    {
        public static long GenerateSSN()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
        }
    }
}
