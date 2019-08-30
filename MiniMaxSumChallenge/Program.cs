using static System.Console;
using static System.Convert;
using static System.Array;
using System.Linq;
using System;

namespace MiniMaxSumChallenge
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

                    aux[i] += arr[j];
                }
            }

            min = aux.Min();
            max = aux.Max();

            WriteLine($"{min} {max}");
        }

        static void Main(string[] args)
        {
            int[] arr = ConvertAll(ReadLine().Split(' '), arrTemp => ToInt32(arrTemp));

            miniMaxSum(arr);

            ReadKey();
        }
    }
}
