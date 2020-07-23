using System;
using System.IO;
using System.Threading;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArr;
            string userString = "AAAA";
            
            using (FileStream fstream = File.OpenRead(@$"D:\1.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                textArr = System.Text.Encoding.Default.GetString(array).Split('\n');
            }
            
            foreach (var variable in textArr)
            {
                Console.WriteLine(variable);
            }

            for (var i = 0; i <= textArr.Length-1; i++)
            {
                var i1 = i;
                new Thread(() => Search(textArr[i1], userString, i1+1)).Start();
            }
        }

        private static void Search(string initialData, string toFind, int stringNumber)
        {
                initialData = initialData.Replace("\r", "");
                if (initialData.Equals(toFind))
                {
                    Console.WriteLine(stringNumber);
                }
        }
    }
}