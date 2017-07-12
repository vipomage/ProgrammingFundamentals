using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }

        public string Make { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> TruckList = new List<Vehicle>();
            List<Vehicle> CarList = new List<Vehicle>();

            while ( true )
            {
                string[] input = Console.ReadLine().Split();

                if ( input[0].ToLower() == "end" )
                {
                    break;
                }

                if ( input[0].ToLower() == "truck" )
                {
                    Vehicle truck = new Vehicle()
                    {
                        Type = "Truck",
                        Make = input[1],
                        Color = input[2],
                        Horsepower = int.Parse(input[3])
                    };
                    TruckList.Add(truck);
                }
                if ( input[0].ToLower() == "car" )
                {
                    Vehicle car = new Vehicle()
                    {
                        Type = "Car",
                        Make = input[1],
                        Color = input[2],
                        Horsepower = int.Parse(input[3])
                    };
                    CarList.Add(car);
                }
            }
            while ( true )
            {
                string modelData = Console.ReadLine();
                if ( modelData.ToLower() == "close the catalogue" )
                {
                    break;
                }

                foreach ( Vehicle truck in TruckList.Where(ty => ty.Make == modelData) )
                {
                    Console.WriteLine(
                        $"Type: {truck.Type}\nModel: {truck.Make}\nColor: {truck.Color}\nHorsepower: {truck.Horsepower}");
                }
                foreach ( Vehicle car in CarList.Where(ty => ty.Make == modelData) )
                {
                    Console.WriteLine(
                        $"Type: {car.Type}\nModel: {car.Make}\nColor: {car.Color}\nHorsepower: {car.Horsepower}");
                }
            }
            if ( CarList.Count == 0 )
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {CarList.Select(hp => hp.Horsepower).Average():F2}.");
            }
            if ( TruckList.Count == 0 )
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {TruckList.Select(hp => hp.Horsepower).Average():F2}.");
            }
        }
    }
}
