using System;


namespace _10.CubeProperties
{

    class Program
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            string param = Console.ReadLine();
            switch (param)
            {
                case "face":
                    Console.WriteLine($"{ReturnCubeFace(input):F2}");
                    break;
                case "space":
                    Console.WriteLine($"{ReturnCubeSpace(input):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{ReturnCubeVolume(input):F2}");
                    break;
                case "area":
                    Console.WriteLine($"{ReturnCubeArea(input):F2}");
                    break;
            }
        }




        static double ReturnCubeArea(double x)
        {
            double volume = Math.Pow((x), 2) * 6;
            return volume;
        }




        static double ReturnCubeVolume(double x)
        {
            double volume = Math.Pow(x, 3);
            return volume;
        }




        static double ReturnCubeSpace(double x)
        {
            double volume = Math.Sqrt(3 * (Math.Pow(x, 2)));
            return volume;
        }




        static double ReturnCubeFace(double x)
        {
            double face = Math.Sqrt(2 * (Math.Pow(x, 2)));
            return face;
        }
    }

}