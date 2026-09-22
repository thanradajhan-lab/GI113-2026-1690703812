/*
 * Student ID : 169070812
 * Name       : Assignment01
 * Section    : 129D
 * No.        : 7
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Identity V";

            var SurvivalName = "Lydia Jones";
            var SurvivalAlias = "Emily Dyer";
            int SurvivalAge = 32;
            char SurvivalGender = 'F';
            float SurvivalBirthYear = 1867.0f;
            double SurvivalBirthMonth = 3.0;
            string SurvivalBirthDay = "March 17th, 1867";
            string SurvivalCareer = "Doctor";
            string SurvivalNationality = "British";
            string SurvivalSerialNO = "4-0-4";
            bool isSurvival = true;

            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                       ..                              .:*-           ");
            Console.WriteLine("                                                       .*-       ... ..   -..-%@=    -..***+..        ");
            Console.WriteLine("                                                      .#@@:       ....*.-.. .%@@@#.    .:**#*******+. ");
            Console.WriteLine("    .-#.                                               .++.         .*.*=...@@@-.*#.   .**********+.. ");
            Console.WriteLine("   -%**%#-......        ... ...-==::##%@*..*@@@@@@@@@#+....*==+-...=@=.=*.%@@@+=:.#-  .*##******-.    ");
            Console.WriteLine(" .*.==::%@@@=.-%+.-#@@@#..#@@@@*.+#-=@@=+.-...:@@@..%-.=@@=.@@@@@@@@:@.:=*%@@%.:*+. ..+#**#***-.      ");
            Console.WriteLine("  :%:.-.%%@@.. .@@@...=@@=.%@%  ... .@@=:*.=. .@@# ...#@@@+.  =@%#:=.%@..+@@@=.     .*#*****-.        ");
            Console.WriteLine("   .....+@@@%.  -@@=   -@@*:@@....:..#@=.*:#  .@@#.   *@#.    #@@.   .##.-@@%.    .:***#**+.          ");
            Console.WriteLine("        .+@%#=.  .@%. .@@@:.@@@*+:...+@= .@#. .@%.   .@@.     =@#.   ..@:@@@*:.  .+###**#:.           ");
            Console.WriteLine("         .#@%*.  .=*. +@%. .%@-    .-:+.  =@:  -#+   .#=.     +@.     .@@@@#*#. .+*##*::.             ");
            Console.WriteLine("           @@%:.   ::.#*.  .*@@:-=+#..=. .:@#. .-@.  .%@.+.  .@.      .@@@:+***:=#**+:.               ");
            Console.WriteLine("           .%@#*.  .#@#.  .%*::..... .:  .......+@.  .=-=-..-@@*.    .=@#...+*###**=-.                ");
            Console.WriteLine("           .-@.=*#@+-.                         .@+.            .--  .#@@.    +****+.                  ");
            Console.WriteLine("             +.                                .%*                 .@@@.     .***:                    ");
            Console.WriteLine("                                               .*.                .:%..       .:.                     ");
            Console.WriteLine("                                               .%                 -=                                  ");
            Console.WriteLine("                                               ..               .=                                    ");
            Console.WriteLine("                                                                                                      ");

            Console.WriteLine();
            Console.WriteLine("                 { PROFILE }                ");
            Console.WriteLine();
            Console.WriteLine($" ⇢ Name        : {SurvivalName,-32}        ");
            Console.WriteLine($" ⇢ Alias       : {SurvivalAlias,-32}       ");
            Console.WriteLine($" ⇢ Age         : {SurvivalAge,-32}         ");
            Console.WriteLine($" ⇢ Gender      : {SurvivalGender,-32}      ");
            Console.WriteLine($" ⇢ Birth Year  : {SurvivalBirthYear,-32}   ");
            Console.WriteLine($" ⇢ Birth Month : {SurvivalBirthMonth,-32}  ");
            Console.WriteLine($" ⇢ Birth Day   : {SurvivalBirthDay,-32}    ");
            Console.WriteLine($" ⇢ Career      : {SurvivalCareer,-32}      ");
            Console.WriteLine($" ⇢ Nationality : {SurvivalNationality,-32} ");
            Console.WriteLine($" ⇢ Serial No.  : {SurvivalSerialNO,-32}    ");
            Console.WriteLine($" ⇢ Playable    : {isSurvival,-32}          ");
            Console.WriteLine();

            double SurvivalAgeAsDouble = SurvivalAge;
            Console.WriteLine($"Age as double (implicit): {SurvivalAgeAsDouble}");

            int birthYearTruncated = (int)SurvivalBirthYear;
            int birthYearRounded = Convert.ToInt32(SurvivalBirthYear);

            Console.WriteLine($"Birth Year cast (truncates) : {birthYearTruncated}");
            Console.WriteLine($"Birth Year Convert (rounds) : {birthYearRounded}");
        }
    }
}