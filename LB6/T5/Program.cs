using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathFib = @"D:\Fib3.txt";
            var pathPrime = @"D:\Prime3.txt";

            using (var pstream = new StreamWriter(pathPrime, false, System.Text.Encoding.Default))
            {
                using var fstream = new StreamWriter(pathFib, false, System.Text.Encoding.Default);
                var thFib = new Thread(() => FibThread(fstream));
                thFib.Start();

                var thPrime = new Thread(() => PrimeThread(pstream));
                thPrime.Start();

                if (Console.ReadKey().KeyChar <= 0)
                {
                    thFib.Suspend();
                    thPrime.Suspend();
                }
            }

            string fibStr, primeStr;

            using (FileStream ps = new FileStream(pathPrime, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using FileStream fs = new FileStream(pathFib, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using var fstreamReaad = new StreamReader(fs);
                fibStr = fstreamReaad.ReadToEnd();

                using var pstreamReaad = new StreamReader(ps);
                primeStr = pstreamReaad.ReadToEnd();
            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PRIME");
            Console.ResetColor();

            Console.WriteLine(primeStr.Count(x => x == '\n') + 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("FIB");
            Console.ResetColor();

            Console.WriteLine(fibStr.Count(x => x == '\n') + 1);
        }

        public static bool IsPrime(int x)
        {
            for (int i = 2; i <= x / i; i++)
                if ((x % i) == 0)
                    return false;
            return true;
        }

        public static void PrimeThread(StreamWriter pstream)
        {
            try
            {
                int i = 0;
                while (true)
                {
                    if (IsPrime(i))
                    {
                        pstream.WriteLine(value: i);
                    }

                    i++;
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        public static void FibThread(StreamWriter fstream)
        {
            try
            {
                long first = 0;
                fstream.WriteLine($"{first} ");
                long second = 1;
                fstream.WriteLine($"{second} ");
                long sum = 0;
                while (true)
                {
                    sum = first + second;
                    fstream.WriteLine($"{sum} ");
                    first = second;
                    second = sum;
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
    }
}