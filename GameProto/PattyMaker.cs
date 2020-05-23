using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameProto
{
    class Order
    {
        // формируем рандомное число что бы задать его как длинну массива       
        // static Random random = new Random();
        // static int randomNumber = random.Next(3, 4);

        //список для выполнения "заказа" 
        public List<int> list = new List<int>();

        public void GenerateRandom()
        {

            Random random = new Random();
            int randomNumber = random.Next(3, 7);
            list.Clear();
            Console.WriteLine(string.Join(",", list));

            int Min = 2;
            int Max = 7;
            Random randNum = new Random();
            list.Add(1);
            for (int i = 0; i < randomNumber; i++)
            {
                int randomN = randNum.Next(2, 6);

                if (list.Exists((x) => x == randomN))
                {
                    randomN = randNum.Next(2, 6);
                }

                list.Add(randomN);
            }
            list.Add(7);

            Console.WriteLine(string.Join(",", list));

        }

    }
    class PattyMaker
    {
        List<int> ingredients = new List<int>();

        public void Add(int ingredient)
        {
            ingredients.Add(ingredient);
            string sandvList = string.Join(",", ingredients.ToArray());
            Console.WriteLine(sandvList);

            /*if (ingredients.Count <= len){ }*/
        }
        public void ClearIngredients()
        {
            ingredients.Clear();
        }

    }
    class Game
    {
        public void Cooking(string answer)
        {

            if (answer == "Y" || answer == "y")
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen; // выводим список команд зеленым цветом
                Console.WriteLine("1.Булочка  \t 2. Котлетка  \t 3. Салатик");
                Console.WriteLine("4. Помидорка \t 5. Огурчики \t 6. Сырочек \t 7. Булочка с кунжутом");
                Console.WriteLine("Введите номер ингредиента:");
                Console.ForegroundColor = color;

                Order order = new Order();
                PattyMaker pattyMaker = new PattyMaker();
                Console.WriteLine("=====заказ котика Тома=====");
                order.GenerateRandom();
                Console.WriteLine("===========================");

                for (int i = 0; i <= order.list.Count - 1; i++)
                {

                    string name = Console.ReadLine();
                    int Num;
                    bool isNum = int.TryParse(name.ToString(), out Num);
                    if (isNum)
                    {
                        int test = Convert.ToInt32(name);
                        if (test == 7)
                        {
                            Console.WriteLine("You make a sandvich! Yam!");
                            Console.WriteLine("Сделать еще?!: Y/N");
                            Cooking(Console.ReadLine());
                        }
                        else
                        {
                            pattyMaker.Add(test);
                        }
                    }
                    else
                    {
                        Console.WriteLine("это не цифра");
                    }

                }

            }
            else
            {
                Console.WriteLine("жаль, попрошу кого-нибудь другого");
            }
            Console.Read();
        }
    }
}
