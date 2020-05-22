using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameProto
{
    class Order
    {
        // формируем рандомное число что бы задать его как длинну массива
        static Random random = new Random();
        static int randomNumber = random.Next(3, 7);
        //пока пустой массив для "заказа"

        public int[] arrOrder = new int[randomNumber];

        //список для выполнения "заказа"
        public List<int> list = new List<int>();
        
                public void GenerateRandom()
                {
                    int Min = 2;
                    int Max = 7;
                    Random randNum = new Random();
                    int test = randNum.Next(1, 7);
                    for (int i = 0; i < arrOrder.Length; i++)
                    {
                        

                        if (!arrOrder.Contains(test))
                        {
                            Console.WriteLine(test);
                            Console.WriteLine("=================");
                            //добавляем в пустой массив рандомное значение от 1 до 7
                            arrOrder[i] = test;
                        } 
                    }
                    //return arrOrder;
                    Console.WriteLine(string.Join(",", arrOrder));
        }


     

    }
    class PattyMaker
    {

    }
}
