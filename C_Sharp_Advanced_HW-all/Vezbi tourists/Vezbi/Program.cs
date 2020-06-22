using System;
using System.Collections.Generic;
using Vezbi.Extensions;
using System.Linq;


namespace Vezbi
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryThatYouChoose = DB.GetAll().Country(DB.MyFunc());
            foreach (var country in countryThatYouChoose)
            {
                Console.WriteLine(country);
            }

            
            Console.ReadLine();
        }
    }
}
