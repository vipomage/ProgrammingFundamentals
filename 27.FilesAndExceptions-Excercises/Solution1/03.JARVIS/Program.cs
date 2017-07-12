using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static _03.JARVIS.Jarvis;
using static _03.JARVIS.Jarvis.Arms;

namespace _03.JARVIS
{
    class Jarvis
    {
        public class Head : Jarvis
        {
            public int EnergyReq { get; set; }

            public int IntelligenceQuality { get; set; }

            public string Skin { get; set; }

            public bool Active = false;
        }

        public class Torso : Jarvis
        {
            public int EnergyReq { get; set; }

            public decimal CpuSizeDecimal { get; set; }

            public string HousingMaterial { get; set; }

            public bool Active = false;
        }

        public class Arms : Jarvis

        {
            public class LeftArm : Arms
            {
                public int EnergyReq { get; set; }

                public int Length { get; set; }

                public int FingersCount { get; set; }

                public bool Active = false;
            }

            public class RightArm : Arms
            {
                public int EnergyReq { get; set; }

                public int Length { get; set; }

                public int FingersCount { get; set; }

                public bool Active = false;
            }
        }

        public class Legs : Jarvis
        {
            public class LeftLeg : Legs
            {
                public int EnergyReq { get; set; }

                public int Strenght { get; set; }

                public int Speed { get; set; }

                public bool Active = false;
            }

            public class RightLeg : Legs
            {
                public int EnergyReq { get; set; }

                public int Strenght { get; set; }

                public int Speed { get; set; }

                public bool Active = false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            long availableEnergy = long.Parse(Console.ReadLine());

            Head head = new Head();
            LeftArm armsLeft = new LeftArm();
            RightArm armsRight = new RightArm();
            Legs.LeftLeg legsLeft = new Legs.LeftLeg();
            Legs.RightLeg legsRight = new Legs.RightLeg();
            Torso torso = new Torso();

            while ( true )
            {
                string[] input = Console.ReadLine().Split();
                if ( input[0].ToLower() == "assemble!" )
                {
                    break;
                }
                if ( input[0].ToLower() == "head" )
                {
                    head.EnergyReq = int.Parse(input[1]);
                    head.IntelligenceQuality = int.Parse(input[2]);
                    head.Skin = input[3].ToString();
                    head.Active = true;
                }
                else if ( input[0].ToLower() == "torso" )
                {
                    torso.EnergyReq = int.Parse(input[1]);
                    torso.CpuSizeDecimal = decimal.Parse(input[2]);
                    torso.HousingMaterial = input[3].ToString();
                    torso.Active = true;

                }
                else if ( input[0].ToLower() == "arm" )
                {
                    if ( armsLeft.EnergyReq <= int.Parse(input[1]) )
                    {
                        armsLeft.EnergyReq = int.Parse(input[1]);
                        armsLeft.Length = int.Parse(input[2]);
                        armsLeft.FingersCount = int.Parse(input[3]);
                        armsLeft.Active = true;
                    }
                    else
                    {
                        armsRight.EnergyReq = int.Parse(input[1]);
                        armsRight.Length = int.Parse(input[2]);
                        armsRight.FingersCount = int.Parse(input[3]);
                        armsRight.Active = true;
                    }
                }
                else if ( input[0].ToLower() == "leg" )
                {
                    if ( legsLeft.EnergyReq <= int.Parse(input[1]) )
                    {
                        legsLeft.EnergyReq = int.Parse(input[1]);
                        legsLeft.Strenght = int.Parse(input[2]);
                        legsLeft.Speed = int.Parse(input[3]);
                        legsLeft.Active = true;
                    }
                    else
                    {
                        legsRight.EnergyReq = int.Parse(input[1]);
                        legsRight.Strenght = int.Parse(input[2]);
                        legsRight.Speed = int.Parse(input[3]);
                        legsRight.Active = true;
                    }
                }

            }
            List<Arms> arms = new List<Arms>() { armsLeft, armsRight };
            List<Legs> legs = new List<Legs>() { legsLeft, legsRight };

            long energyConsumption =
                head.EnergyReq +
                torso.EnergyReq +
                armsLeft.EnergyReq +
                armsRight.EnergyReq +
                legsLeft.EnergyReq +
                legsRight.EnergyReq;

            if ( energyConsumption > availableEnergy )
            {
                Console.WriteLine("We need more power!");
            }
            else if ( !head.Active && !torso.Active && !legsLeft.Active && !legsRight.Active && !armsLeft.Active && !armsRight.Active )
            {
                Console.WriteLine("We need more parts!");
            }
            else
            {
                Console.WriteLine("Jarvis");
                Console.WriteLine("#Head:\n" +
                                  $"###Energy consumption: {head.EnergyReq}\n" +
                                  $"###IQ: {head.IntelligenceQuality}\n" +
                                  $"###Skin material: {head.Skin}");
                Console.WriteLine("#Torso:\n" +
                                  $"###Energy consumption: {torso.EnergyReq}\n" +
                                  $"###Processor size: {torso.CpuSizeDecimal:F1}\n" +
                                  $"###Corpus material: {torso.HousingMaterial}");

                foreach ( var leg in legs.OrderBy(x => x) )
                {
                    Console.WriteLine("###Arm:\n" +
                                      $"###Energy consumption: {leg}");
                }

            }
        }
    }
}
