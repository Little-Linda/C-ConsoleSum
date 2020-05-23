using System;
using System.Collections.Generic;

namespace GameProto
{
    class Program
    {

        public void Cooking(string answer)
        {
            if (answer == "Y" || answer == "y")
            {
                Order order = new Order();
                PattyMaker pattyMaker = new PattyMaker();
                order.GenerateRandom();

                for (int i = 0; i <= order.list.Count - 1; i++)
                {
                    Console.WriteLine("==========1============");
                    int name = Convert.ToInt32(Console.ReadLine());

                    if (name == 7)
                    {
                        Console.WriteLine("You make a sandvich! Yam!");
                        Console.WriteLine("Сделать еще?!: Y/N");
                        Cooking(Console.ReadLine());
                    }
                    else
                    {
                        pattyMaker.Add(name);
                    }
                }

            }
            else
            {
                Console.WriteLine("жаль, попрошу кого-нибудь другого");
            }
        }

        static void Main(string[] args)
        {
            //SumGame game1 = new SumGame();
            //Console.Write("Сложить 2 числа?: Y/N ");
            //string answer = Console.ReadLine();
            //game1.Test(answer); 

            ConsoleColor color2 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta; // выводим список команд зеленым цветом
            Console.WriteLine("Здравствуйте, меня зовут котик Том и я очень хочу кушать, \t");
            Console.WriteLine("но у меня лапки и я не умею готовить,");
            Console.WriteLine("помогите мне пожалуйста, приготовьте мне сендвич \t");
            Console.WriteLine("я выведу на экран цифры, каждая соответсвует конкретному ингредиенту \t");
            Console.ForegroundColor = color2;
     
            Game game = new Game();
            Console.Write("Накормишь?: Y/N ");
            string answer = Console.ReadLine();
            game.Cooking(answer);
             

        }
    }
}
