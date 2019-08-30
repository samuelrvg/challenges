using static System.Console;
using static System.Convert;

namespace StaircaseChallenge
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            string simbolo = "#";
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    arr[i] += simbolo;
                }
            }

            int countSpace = arr.Length;
            for (int i = n - 2; i <= n; i--)
            {
                arr[i] = arr[i].PadLeft(countSpace, ' ');

                if (i == 0)
                    break;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                WriteLine(arr[i]);
            }
        }

        static void Main(string[] args)
        {
            int n = ToInt32(ReadLine());

            staircase(n);

            ReadKey();
        }
    }
}
