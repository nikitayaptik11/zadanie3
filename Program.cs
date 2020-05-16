using System;

namespace Zadanie3

{
    class Program
    {
        static void Zadanie1()
        {

            double[] mas = new double[] { 10, -3, -5, 2, 5 };
            double d = double.MaxValue;
            int index = 0;
            for (int i = 0; i < mas.Length; ++i)
            {
                double temp = Math.Abs(mas[i]);
                if (d > temp)
                {
                    d = temp;
                    index = i;
                }
            }
            Console.WriteLine(index);





        }
        static void Zadanie2(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -10 + rand.Next() % 20;
                Console.Write(arr[i] + " | ");
            }
            Console.WriteLine();

            int t = 0;
            int k = 0;

            Console.Write("Уникальные элементы: ");

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                        t = arr[j];
                    }
                }

                if (count == 1)
                {
                    Console.Write(t + " | ");
                    k++;
                }
                else t = 0;
            }
            if (k == 0) Console.WriteLine("Нет уникальных элементов");
            Console.WriteLine("\n");
        }


        static void Zadanie3(int[] arr)
        {
            Random rand = new Random();

            int[] arr1 = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -10 + rand.Next() % 20;
                Console.Write(arr[i] + " | ");
            }
            Console.WriteLine();
            Console.Write("Положительные элементы: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0) arr1[i] = arr[i];
                else continue;
                Console.Write(arr1[i] + " | ");
            }
            Console.WriteLine();
        }




        static void Main(string[] args)
        {
            int[] arr = new int[10];
            // 1
            Console.WriteLine("Первое: ");
            Zadanie1();
            //2
            Console.WriteLine("Второе: ");
            Zadanie2(arr);

            //3
            Console.WriteLine("Третье: ");
            Zadanie3(arr);
        }
    }



}