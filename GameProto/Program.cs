using System;
using System.Collections.Generic;

namespace GameProto
{   
    class Program
    {
        static void Main(string[] args)
        {
            // SumGame game1 = new SumGame();
            //Console.Write("Сложить 2 числа?: Y/N ");
            //string answer = Console.ReadLine();
            //game1.Test(answer);

            Order order = new Order();
            order.GenerateRandom();
            
        }
    }
}
