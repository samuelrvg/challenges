using static System.Console;
using static System.Convert;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CompareTheTripletsChallenge
{
    class Program
    {
        // Complete the
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int pontosAlice = 0;
            int pontosBob = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    pontosAlice += 1;
                }
                if (a[i] < b[i])
                {
                    pontosBob += 1;
                }
            }

            return new List<int>() { pontosAlice, pontosBob };
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => ToInt32(aTemp)).ToList();

            List<int> b = ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
