using System;

namespace _01.SweetDesert
{
    class Program
    {
        static void Main()
        {
            decimal availableCash = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal portions = guests;
            while ( portions % 6 != 0 )
            {
                portions++;
            }
            decimal count = portions / 6;
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());


            decimal expenses = count * ( ( 2 * bananaPrice ) + ( 4 * eggsPrice ) + ( 0.2M * berriesPrice ) );


            if ( expenses > availableCash )
            {
                Console.WriteLine(
                    $"Ivancho will have to withdraw money - he will need {Math.Abs(availableCash - expenses):F2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {expenses:F2}lv.");
            }
        }
    }
}
