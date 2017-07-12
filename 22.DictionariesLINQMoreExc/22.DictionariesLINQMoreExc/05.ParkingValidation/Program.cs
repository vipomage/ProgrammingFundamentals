using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParkingValidation
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> usersPlates = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for ( int i = 0; i < n; i++ )
            {
                string[] input = Console.ReadLine().Split();

                if ( input[0] == "register" )
                {
                    bool uniqueUser = true;
                    bool validLicense = true;
                    bool freePlate = true;
                    string user = input[1];
                    string plate = input[2];

                    if ( usersPlates.ContainsKey(user) )
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {usersPlates[user]}");
                        uniqueUser = false;
                    }
                    else if ( plate[0] < 65 || plate[0] > 90 || plate[1] < 65 || plate[1] > 90 || plate[6] < 65 ||
                             plate[6] > 90 || plate[7] < 65 || plate[7] > 90
                             || plate[2] > 57 || plate[3] > 57 || plate[4] > 57 || plate[5] > 57 )
                    {
                        //TODO FIX PLATE CHECK
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                        validLicense = false;
                    }
                    else if ( usersPlates.Values.Contains(plate) )
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                        freePlate = false;
                    }
                    if ( freePlate && uniqueUser && validLicense )
                    {
                        usersPlates[user] = plate;
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                }
                if ( input[0] == "unregister" )
                {
                    string user = input[1];

                    if ( !usersPlates.Keys.Contains(user) )
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        usersPlates.Remove(user);
                        Console.WriteLine($"user {user} unregistered successfully");
                    }
                }
            }
            foreach ( var usersPlate in usersPlates )
            {
                Console.WriteLine($"{usersPlate.Key} => {usersPlate.Value}");
            }
        }
    }
}
