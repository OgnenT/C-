using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbi.Extensions
{
    public class DB
    {
        public static Dictionary<int, string> GetAll()
        {
            return new Dictionary<int, string>()
            {
                {200, "BG" },
                {400, "SRB" },
                {800, "GR"},
                {600, "PL" },
                {1000, "IT" },
                {150, "RU" },
                {300, "FR"},
                {500, "DE" }
            };
        }

        public static Func<int, bool> MyFunc()
        {
            Console.WriteLine("Please insert number from 100 - 1000");
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                return country => country >= input;
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a number!");

            }

            return null;
        }


    }
}