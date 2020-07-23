using System;

namespace T3
{
    public class Team
    {
        public int FightersCount { get; set; }
        public string Alias { get; set; }

        public Team(int fightersCount, string alias)
        {
            this.FightersCount = fightersCount;
            this.Alias = alias;
        }
        
        public bool IsAlive()
        {
            return FightersCount > 0;
        }

        public void AddFighters()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Количество бойцов {Alias} увеличилось, теперь их {FightersCount += new Random().Next(0,10)}"); 
            Console.ResetColor();
        }

        public void GetDamage(int damage)
        {
            FightersCount -= damage;
            Console.ForegroundColor = ConsoleColor.Red;
            if (this.IsAlive())
                Console.WriteLine($"Команде {this.Alias} нанесли атаку, теперь их {FightersCount}");
            else
                Console.WriteLine($"Команде {this.Alias} нанесли атаку, теперь их 0");
            Console.ResetColor();
        }

        public void DoAtack(Team enemy)
        {
            int damage = new Random().Next(0, 10);
            
            Console.WriteLine($"Команда {this.Alias} атакует на {damage} урона команду {enemy.Alias}");
            enemy.GetDamage(damage);
        }
    }
}