using System;
using System.Linq;

namespace ChallengeMiniMaxSum
{
    class Program
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            //arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;

            //arr[0] = 5;
            //arr[1] = 5;
            //arr[2] = 5;
            //arr[3] = 5;
            //arr[4] = 5;

            Int64[] aux = new Int64[arr.Length];
            bool equals = false;
            long min = 0;
            long max = 0;
            int count = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    count--;
                }
                if (arr[i] == arr[i + count])
                {
                    equals = true;
                }
                else
                {
                    equals = false;
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (equals)
                    {
                        for (int k = 1; k < arr.Length; k++)
                        {
                            aux[i] += arr[j];
                        }
                        break;
                    }
                    if (arr[i] == arr[j])
                    {
                        continue;
                    }

                    //if (arr[i] >= 1 && arr[i] <= Math.Pow(10, 9))
                    //{
                    aux[i] += arr[j];
                    //}
                }
            }

            min = aux.Min();
            max = aux.Max();

            Console.WriteLine("{0} {1}", min, max);
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            miniMaxSum(arr);

            Console.ReadKey();
        }
    }
}
