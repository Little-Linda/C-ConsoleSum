using System;
using System.Collections.Generic;
using System.Text;

namespace GameProto
{
    class SumGame
    {
        public void Test(string answer)
        {
            if (answer == "Y" || answer == "y")
            {
                Console.Write("Введи 1 число:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введи 2 число:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{a}+{b} = {a + b}");

                Console.WriteLine("Ещу раз? : Y/N");
                Test(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Ну как хочешь");

            }
        }
    }
}
