using System;
using System.IO;

/*     
    * Takes as a command-line argument the path to a file containing one integer per line
    * For each integer in the file, output to the console a comma-delimited list of the integer's prime factors
    * The list of integers on each line of the output should multiply to produce the input integer
    * Include unit tests for the code(http://www.nunit.org preferred for .NET)
 */


namespace nexidiaprime
{
    class Program
    {
        public static int Main(string[] args)
        {
            // Test if input arguments were supplied:
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a filename");
                Console.WriteLine("Usage: Prime <file>");
                return 1;
            }

            string path = args[0];

            try
            {
                foreach (string line in File.ReadLines(path))
                {
                    long number = long.Parse(line);
                    var result = Prime.Findprimes(number);
                    string primes = string.Join(",", result);
                    Console.WriteLine(line + " has prime factors: " + primes);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            Console.Read();
            return 0;
        }
    }
}
