using static System.Console;
using static System.Array;
using static System.Convert;
using System.Linq;
using System.IO;

namespace Challenge_01
{
    class Program
    {
        /*
         * Complete the simpleArraySum function below.
         */
        static int simpleArraySum(int[] ar)
        {
            /*
             * Write your code here.
             */
            return ar.Sum();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = ToInt32(ReadLine());

            int[] ar = ConvertAll(ReadLine().Split(' '), arTemp => ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
