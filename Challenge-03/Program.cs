using static System.Console;
using static System.Convert;
using static System.Array;
using System.Linq;
using System.IO;

namespace VeryBigSumChallenge
{
    class Program
    {
        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            return ar.Sum();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = ToInt32(ReadLine());

            if (arCount >= 1 && arCount <= 10)
            {
                long[] ar = ConvertAll(ReadLine().Split(' '), arTemp => ToInt64(arTemp))
                ;
                long result = aVeryBigSum(ar);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
