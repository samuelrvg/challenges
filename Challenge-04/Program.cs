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
        //OLD
        //int rank = arr.Rank;
        //int diagonalPrimaria = 0;
        //int diagonalSecundaria = 0;
        //for (int i = 0; i <= rank; i++)
        //{
        //    if (arr[i, i] == arr[i, i])
        //    {
        //        if (arr[i, i] < 0)
        //        {
        //            var menorQueZero = arr[i, i] * -1;
        //            diagonalPrimaria += menorQueZero;
        //        }
        //        else
        //        {
        //            diagonalPrimaria += arr[i, i];
        //        }
        //    }
        //    if (arr[i, rank - i] == arr[i, rank - i])
        //    {
        //        diagonalSecundaria += arr[i, rank - i];
        //    }
        //}

        //int result = 0;
        //if (diagonalPrimaria > diagonalSecundaria)
        //{
        //    result = diagonalPrimaria - diagonalSecundaria;
        //}
        //else
        //{
        //    result = diagonalSecundaria - diagonalPrimaria;
        //}

        //return result;

        int rank = (int)Math.Sqrt(arr.Length) - 1;
        int[] vetorPrimario = new int[rank + 1];
        int countVetorPrimario = 0;

        int[] vetorSecundario = new int[rank + 1];
        int countVetorSecundario = 0;

        for (int i = 0; i <= arr.Length; i++)
        {

            if (arr[i, i] == arr[i, i])
            {
                vetorPrimario[countVetorPrimario] = arr[i, i];
                countVetorPrimario++;
            }
            if (arr[i, rank - i] == arr[i, rank - i])
            {
                vetorSecundario[countVetorSecundario] = arr[i, rank - i];
                countVetorSecundario++;
            }

            if (i == rank)
            {
                break;
            }
        }

        int result = 0;
        result = vetorPrimario.Sum() - vetorSecundario.Sum();

        return result >= 0 ? result : result * -1;
    }

    public static int diagonalDifferenceTest()
    {
        //var array = new int[3, 3];
        //array[0, 0] = 11;
        //array[0, 1] = 2;
        //array[0, 2] = 4;

        //array[1, 0] = 4;
        //array[1, 1] = 5;
        //array[1, 2] = 6;

        //array[2, 0] = 10;
        //array[2, 1] = 8;
        //array[2, 2] = -12;

        var array = new int[4, 4];
        array[0, 0] = -1;
        array[0, 1] = 1;
        array[0, 2] = -7;
        array[0, 3] = -8;

        array[1, 0] = -10;
        array[1, 1] = -8;
        array[1, 2] = -5;
        array[1, 3] = -2;

        array[2, 0] = 0;
        array[2, 1] = 9;
        array[2, 2] = 7;
        array[2, 3] = -1;

        array[3, 0] = 4;
        array[3, 1] = 4;
        array[3, 2] = -2;
        array[3, 3] = 1;

        int rank = (int)Math.Sqrt(array.Length) -1;
        int[] vetorPrimario = new int[rank +1];
        int countVetorPrimario = 0;

        int[] vetorSecundario = new int[rank +1];
        int countVetorSecundario = 0;

        for (int i = 0; i <= array.Length; i++)
        {

            if (array[i, i] == array[i, i])
            {
                vetorPrimario[countVetorPrimario] = array[i, i];
                countVetorPrimario++;
            }
            if (array[i, rank - i] == array[i, rank - i])
            {
                vetorSecundario[countVetorSecundario] = array[i, rank - i];
                countVetorSecundario++;
            }

            if (i == rank)
            {
                break;
            }
        }

        int result = 0;
        result = vetorPrimario.Sum() - vetorSecundario.Sum();

        return result >= 0 ? result : result *-1;
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
            int[,] arr2 = new int[n, n];

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
