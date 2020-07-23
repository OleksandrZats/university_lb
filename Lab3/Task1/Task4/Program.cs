using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator Refr1 = new Refrigerator();

            for (;;)
            {
                Console.Write("Холодильник работает в режиме:");
                if (Refr1.GetCurrentMode() == (OperatingModes) 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(Refr1.GetCurrentMode());
                Console.ResetColor();
                Console.WriteLine("Для переключения режима введите его номер и нажмите ENTER");
                Console.WriteLine("  0. Off " +
                                  "\n  1. On " +
                                  "\n  2. Mode2 " +
                                  "\n  3. Mode3 " +
                                  "\n  4. Mode4 ");
                int ModeNumber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (ModeNumber + 1 > Enum.GetNames(typeof(OperatingModes)).Length)
                {
                    Console.WriteLine("Неверный номер, повторите попытку");
                }
                else
                {
                    Refr1.SetMode((OperatingModes) ModeNumber);
                }
            }
        }
    }
}