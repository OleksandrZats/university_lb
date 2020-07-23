using System;
using System.Threading;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            var team1 = new Team(new Random().Next(50, 100), "Juki");
            var team2 = new Team(new Random().Next(50, 100), "Pauki");

            Console.WriteLine("Команды:\n" +
                              $"{team1.Alias} - {team1.FightersCount} бойцов\n" +
                              $"{team2.Alias} - {team2.FightersCount} бойцов\n");
            
            new Thread(() => {
                while (team1.IsAlive() && team2.IsAlive())
                {
                    team1.AddFighters();
                    team1.DoAtack(team2);
                }

                if (team1.IsAlive())
                {
                    Console.WriteLine($"{team1.Alias} одержал победу");
                }
                else
                {
                    Console.WriteLine($"{team1.Alias} поражен гневом команды {team2.Alias}");
                }
            }).Start();
            
            new Thread(() => {
                while (team1.IsAlive() && team2.IsAlive())
                {
                    team2.AddFighters();
                    team2.DoAtack(team1);
                }

                if (team2.IsAlive())
                {
                    Console.WriteLine($"{team2.Alias} одержал победу");
                }
                else
                {
                    Console.WriteLine($"{team2.Alias} поражен гневом команды {team1.Alias}");
                }
            }).Start();
            
        }
    }
}