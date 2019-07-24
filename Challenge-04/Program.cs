using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(int[,] arr)
    {
        //var array = new int[3, 3];
        //array[0, 0] = 5;
        //array[0, 1] = 8;
        //array[0, 2] = 10;

        //array[1, 0] = 9;
        //array[1, 1] = 6;
        //array[1, 2] = 7;

        //array[2, 0] = 2;
        //array[2, 1] = 3;
        //array[2, 2] = 1;

        int rank = arr.Rank;
        int diagonalPrimaria = 0;
        int diagonalSecundaria = 0;
        for (int i = 0; i <= rank; i++)
        {
            if (arr[i, i] == arr[i, i])
            {
                diagonalPrimaria += arr[i, i];
            }
            if (arr[i, rank - i] == arr[i, rank - i])
            {
                diagonalSecundaria += arr[i, rank - i];
            }
        }

        int result = 0;
        if(diagonalPrimaria > diagonalSecundaria)
        {
            result = diagonalPrimaria - diagonalSecundaria;
        }
        else
        {
            result = diagonalSecundaria - diagonalPrimaria;
        }

        return result;
    }

}

namespace Challenge_04
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();
            int[,] arr2 = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i][j] <= 100 && arr[i][j] >= -100)
                    {
                        arr2[i, j] = arr[i][j];
                    }
                    else
                    {
                        arr[i][j] = 99;
                    }
                }
            }

            int result = Result.diagonalDifference(arr2);

            Console.WriteLine(result);
            Console.ReadKey();

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
