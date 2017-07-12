using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndretAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> itemPrice = new Dictionary<string, decimal>();
            Dictionary<string, Dictionary<string, int>> costumers = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                itemPrice[input[0]] = decimal.Parse(input[1]);
            }

            string[] strings = Console.ReadLine().Split(new[] {'-', ','}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (strings[0] != "end of clients")
            {
                Dictionary<string, int> tempDictionary = new Dictionary<string, int>();
                tempDictionary[strings[1]] = int.Parse(strings[2]);
                costumers[strings[0]] = tempDictionary;
                strings = Console.ReadLine().Split(new[] {'-', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            decimal totalBill = 0;
            foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair in costumers.Reverse())

            {

                foreach (KeyValuePair<string, int> valuePair in keyValuePair.Value)
                {
                    string orderType = valuePair.Key;
                    if (itemPrice.ContainsKey(orderType))
                    {
                        Console.WriteLine($"{keyValuePair.Key}");
                        int orders = valuePair.Value;
                        decimal price = itemPrice[orderType];
                        decimal sum = price * orders;
                        Console.WriteLine($"-- {valuePair.Key} - {valuePair.Value}");
                        Console.WriteLine($"Bill: {sum:F2}");
                        totalBill += sum;
                    }
                }
            }
            Console.WriteLine($"Total bill: {totalBill}");
        }
    }

    class Costumer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Orders = new Dictionary<string, int>();

        public Costumer(string name, Dictionary<string, int> orders)
        {
            Name = name;
            Orders = orders;
        }
    }
}
