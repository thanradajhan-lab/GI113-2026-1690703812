/*
 * Student ID : 1690703812
 * Name       : Lab02
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System;
using System.Runtime.CompilerServices;
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHP = 240;
            int currentHP = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHP} / {maxHP}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHP * 100 / maxHP;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            currentHP = currentHP - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE ===== ");
            Console.WriteLine($"HP: {currentHP} / {maxHP}");
            hpPercent = currentHP * 100 / maxHP;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            // Lab02 Part B
            string TankerName = "Barron";
            char TankerRank = 'B';
            int TankerLevel = 89;
            float Defense = 180.0f;
            double TankerCritMultiplier = 1.75;
            bool IsTanker = true;

            string FighterName = "Andrew";
            char FighterRank = 'A';
            int FighterLevel = 95;
            float Stamina = 170.5f;
            double FighterCritMultiplier = 1.75;
            bool IsFighter = true;

            string NecromancerName = "Saiko";
            char NecromancerRank = 'S';
            int NecromancerLevel = 99;
            float Mana = 200.0f;
            double NecromancerCritMultiplier = 1.75;
            bool IsNecromancer = true;

            string HealerName = "Matthew";
            char HealerRank = 'D';
            int HealerLevel = 84;
            float HealingPower = 150.5f;
            double HealerCritMultiplier = 1.75;
            bool IsHealer = true;

            Console.WriteLine("===== HUNTER GAME =====");

            Console.WriteLine("===== Tanker =====");
            Console.WriteLine($"Name: {TankerName}");
            Console.WriteLine($"Rank: {TankerRank}");
            Console.WriteLine($"Level: {TankerLevel}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Crit Multiplier: {TankerCritMultiplier}");
            Console.WriteLine($"Is Player: {IsTanker}");

            Console.WriteLine("===== Fighter =====");
            Console.WriteLine($"Name: {FighterName}");
            Console.WriteLine($"Rank: {FighterRank}");
            Console.WriteLine($"Level: {FighterLevel}");
            Console.WriteLine($"Stamina: {Stamina}");
            Console.WriteLine($"Crit Multiplier: {FighterCritMultiplier}");
            Console.WriteLine($"Is Player: {IsFighter}");

            Console.WriteLine("===== Necromancer =====");
            Console.WriteLine($"Name: {NecromancerName}");
            Console.WriteLine($"Rank: {NecromancerRank}");
            Console.WriteLine($"Level: {NecromancerLevel}");
            Console.WriteLine($"Rank: {NecromancerRank}");
            Console.WriteLine($"Mana: {Mana}");
            Console.WriteLine($"Crit Multiplier: {NecromancerCritMultiplier}");
            Console.WriteLine($"Is Player: {IsNecromancer}");

            Console.WriteLine("===== Healer =====");
            Console.WriteLine($"Name: {HealerName}");
            Console.WriteLine($"Rank: {HealerRank}");
            Console.WriteLine($"Level: {HealerLevel}");
            Console.WriteLine($"Power: {HealingPower}");
            Console.WriteLine($"Crit Multiplier: {HealerCritMultiplier}");
            Console.WriteLine($"Is Player: {IsHealer}");

        }
    }
}