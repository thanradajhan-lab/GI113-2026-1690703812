/*
 * Student ID : 1690703812
 * Name       : Lab05
 * Section    : 129D
 * No.        : 7
 * Course     : GI113 Computer Programming (GI)
 */

using System.Diagnostics;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("==>> Hunter Gate <<==");
            Console.WriteLine("Hero vs. Monster -- Fight Damage Calculator");


            // Hero stats input
            Console.Write("Hero health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);


            // Monster stats input
            Console.Write("Monster health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);


            // Input vaidation / output
            bool heroStatValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monStatValid = monHpOk || monAtkOk || monDefOk;

            Console.WriteLine($"\nHERO STAT: {heroStatValid}");
            Console.WriteLine($"MONSTER STAT: {monStatValid}");


            // bool AllStatOk = heroStatValid & Arithmetic ( + )
            
            // Compound Assinm & arithmetic ( + )
            int potionHeal = 5;

            heroHp = potionHeal;

            //heroHp = herohp + potionHeal;
            Console.WriteLine($"\nHero drink a potion, heals {potionHeal} Hp. Hero HP: {heroHp}");


            //Normol Attack RPG Stylr combat ATK > DEF ถึงจะมี Damage ต่อศัตรู
            int normaldmg = Math.Max( 0,heroAtk - monsterDef);


            //power attack
            
            //random critical attack
            Random rng = new Random();
            int critRoll = rng.Next(1, 101);
            bool isCrit = critRoll <= 25;
           
            int critDmg = normaldmg + Convert.ToInt32(isCrit) * normaldmg;
            Console.WriteLine($"Crit roll {critRoll}. Critical Hit: {isCrit}");
            Console.WriteLine($"If critical hit player would deal {critDmg} DMG!!");
            Console.WriteLine();
        }
    }
}
