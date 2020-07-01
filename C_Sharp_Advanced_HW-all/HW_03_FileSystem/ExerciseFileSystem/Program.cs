using System;
using System.IO;

namespace ExerciseFileSystem
{
    class Program
    {
        public static string Calculate(int num1, int num2)
        {
            int result = num1 + num2;
            return ($"{num1} + {num2} = {result}");
        }

        static void Main(string[] args)
        {
            string currentFolder = Directory.GetCurrentDirectory();
            string myNewFolder = Path.Combine(currentFolder, "Exercise");
            string myNewFile = Path.Combine(myNewFolder, "calculations.txt");

            if (!Directory.Exists(myNewFolder))
            {
                Directory.CreateDirectory(myNewFolder);
            }
            if (!File.Exists(myNewFile))
            {
                File.Create(myNewFile);
            }

            Console.WriteLine("Please enter first numbers.");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second numbers.");
            int secondNum = int.Parse(Console.ReadLine());

            using (StreamWriter sw = new StreamWriter(myNewFile, true))
            {
                sw.WriteLine("Your result: " + Calculate(firstNum, secondNum) + " | Time: " + DateTime.Now);
                
                Console.WriteLine($"Writing completed for - {Calculate(firstNum, secondNum)}");
            }




            //Calculate(firstNum, secondNum);
        }
    }
}
