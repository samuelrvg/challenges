using System;

namespace ChallengeStaircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            string simbolo = "#";
            string[] vet = new string[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    vet[i] += simbolo;
                }
            }

            int countSpace = vet.Length;
            for (int i = n - 2; i <= n; i--)
            {

                vet[i] = vet[i].PadLeft(countSpace, ' ');
                //countSpace += 1;

                if (i == 0)
                    break;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
