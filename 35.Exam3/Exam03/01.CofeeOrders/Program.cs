using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CofeeOrders
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal grandTotal = 0;
            for ( int i = 0; i < n; i++ )
            {
                decimal pricepCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDateTime = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int monthDays = DateTime.DaysInMonth(orderDateTime.Year, orderDateTime.Month);
                decimal capsuleCount = decimal.Parse(Console.ReadLine());
                var total = ( monthDays * capsuleCount ) * pricepCapsule;
                grandTotal += total;
                Console.WriteLine($"The price for the coffee is: ${total:F2}");
            }
            Console.WriteLine($"Total: ${grandTotal:F2}");
        }
    }
}
class Order
{
    public decimal PricePerCapsule { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int CapsulesCount { get; set; }

    public decimal TotalPriceDecimal => DateTime.DaysInMonth(DeliveryDate.Year, DeliveryDate.Month) * CapsulesCount * PricePerCapsule;
}
//List<Order> orders = new List<Order>();
//int n = int.Parse(Console.ReadLine());
//decimal grandTotal = 0;
//for (int i = 0; i <n; i++)
//{
//    Order order = new Order()
//    {
//        PricePerCapsule = decimal.Parse(Console.ReadLine()),
//        DeliveryDate = DateTime.ParseExact(Console.ReadLine(),"{0:dd}/M/yyyy",CultureInfo.InvariantCulture),
//        CapsulesCount = int.Parse(Console.ReadLine())
//    };
//    orders.Add(order);
//    Console.WriteLine($"The price for the coffee is: ${order.TotalPriceDecimal}");
//    grandTotal += order.TotalPriceDecimal;
//}

//Console.WriteLine($"Total: ${grandTotal}");