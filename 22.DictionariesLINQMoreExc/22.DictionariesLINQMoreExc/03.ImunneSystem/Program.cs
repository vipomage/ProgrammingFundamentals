using System;
using System.Collections.Generic;

namespace _03.ImunneSystem
{
    class Program
    {
        static void Main()
        {
            List<string> virusesDealtWith = new List<string>();
            int hp = int.Parse(Console.ReadLine());
            int initialHP = hp;
            string virus = Console.ReadLine();
            while ( !string.Equals(virus, "end", StringComparison.Ordinal) )
            {
                int virusStrenght = 0;
                int timeToDefeat = 0;

                for ( int i = 0; i < virus.Length; i++ )
                {
                    virusStrenght += virus[i];
                    if ( i == virus.Length - 1 )
                    {
                        virusStrenght /= 3;
                    }
                }
                if ( !virusesDealtWith.Contains(virus) )
                {
                    timeToDefeat = virusStrenght * virus.Length;
                    //VirusStrenght
                }
                if ( virusesDealtWith.Contains(virus) )
                {
                    timeToDefeat = ( virusStrenght * virus.Length ) / 3;
                }
                //IF Lost the Fight
                if ( timeToDefeat > hp )
                {
                    Console.WriteLine($"Virus {virus}: {virusStrenght} => {timeToDefeat} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                if ( timeToDefeat < hp )
                {
                    //IF Defeated Virus
                    Console.WriteLine($"Virus {virus}: {virusStrenght} => {timeToDefeat} seconds\n" +
                                      $"{virus} defeated in {timeToDefeat / 60:F0}m {timeToDefeat % 60}s.");
                    hp = hp - timeToDefeat;
                    Console.WriteLine($"Remaining health: {hp}");
                    virusesDealtWith.Add(virus);
                    double regainHp = hp * 0.20;
                    hp += (int)regainHp;
                    if ( hp > initialHP )
                    {
                        hp = initialHP;
                    }
                }
                virus = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {hp}");
        }
    }
}
