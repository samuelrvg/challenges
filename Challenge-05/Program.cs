using System;

namespace Challenge_05
{
    class Program
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arrx)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 0;
            arr[3] = -1;
            arr[4] = -1;

            decimal positivos = 0m;
            decimal negativos = 0m;
            decimal zero = 0m;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    positivos += arr[i];
                }
                else if(arr[i] < 0)
                {
                    negativos += arr[i];
                }
                else
                {
                    zero = 1;
                }
            }

            Console.WriteLine(positivos / arr.Length);
            Console.WriteLine(Math.Abs(negativos / arr.Length));
            Console.WriteLine(zero / arr.Length);

        }

        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            //plusMinus(null);

            //Console.ReadKey();
        }
    }
}
