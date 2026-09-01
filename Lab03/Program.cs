using System.Collections;
using System.Runtime.Intrinsics.Arm;
/*
 * Student ID : 1690703812
 * Name       : Lab03
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level} / {MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCrit Muliplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");

            // Implicit Conversion: currentH (int) -->> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // (double)currentHpDouble = (int)currentHp
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // Calculate Percent -->> doble
            Console.WriteLine("\n----- Exact hp percent (no intege truncation) -----");
            double HpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {HpPercentExact}%");

            // Explicit Conversion Cast attackPower (float) -->> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int AttackPowerExplicit = (int)attackPower;
            Console.WriteLine($"Attack Power(int cast): {AttackPowerExplicit}");

            // Cast vs. Convert critMultiplier (double) -->> int
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int CritCast = (int)critMultiplier;
            Console.WriteLine($"Crit Mutiplier (int cast): {CritCast}");
            int CritConvert = (int)Math.Round(critMultiplier);
            Console.WriteLine($"Crit Multiplier (COnvert rounded): {CritConvert}");
        }
    }
}
