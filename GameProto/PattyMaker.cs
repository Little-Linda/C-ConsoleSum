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
        static int randomNumber = random.Next(3, 8);
        //пока пустой массив для "заказа" 

        public int[] arrOrder = new int[randomNumber];

        //список для выполнения "заказа"
        public List<int> list = new List<int>();
        
                public void GenerateRandom()
                {
                    int Min = 2;
                    int Max = 7;
                    Random randNum = new Random();

                    for (int i = 0; i < arrOrder.Length; i++)
                    {
                        arrOrder[0] = 1;
                        int test = randNum.Next(2, 6);

                        if (arrOrder.Contains(test))                        
                        { 
                            test = randNum.Next(2, 6);
                        }

                        arrOrder[i] = test;
                        arrOrder[arrOrder.Length - 1] = 7;
                    }
                    //return arrOrder;
                    Console.WriteLine(string.Join(",", arrOrder));
        }


     

    }
    class PattyMaker
    {

    }
}
