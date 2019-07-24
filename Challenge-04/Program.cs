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

    public static int diagonalDifference(List<List<int>> arr)
    {
        var array = new int[3, 3];
        array[0, 0] = 5;
        array[0, 1] = 8;
        array[0, 2] = 10;

        array[1, 0] = 9;
        array[1, 1] = 6;
        array[1, 2] = 7;

        array[2, 0] = 2;
        array[2, 1] = 3;
        array[2, 2] = 1;

        //int rank = array.Rank;
        var rank = (int)Math.Sqrt(arr.Count - 1);
        int diagonalDireitaParaEsquerda = 0;
        int diagonalEsquerdaParaDireita = 0;
        for (int i = 0; i <= rank; i++)
        {
            if (array[i, i] == array[i, i])
            {
                diagonalDireitaParaEsquerda += array[i, i];
            }
            if (array[i, rank - i] == array[i, rank - i])
            {
                diagonalEsquerdaParaDireita += array[i, rank - i];
            }
        }

        return diagonalDireitaParaEsquerda - diagonalEsquerdaParaDireita;
    }

}

namespace Challenge_04
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            int result = Result.diagonalDifference(null);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
