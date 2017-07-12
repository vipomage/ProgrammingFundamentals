using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number     = int.Parse(Console.ReadLine());
            int day        = int.Parse(Console.ReadLine());
            int month      = int.Parse(Console.ReadLine());
            int year       = int.Parse(Console.ReadLine());
            int hour       = int.Parse(Console.ReadLine());
            int minutes    = int.Parse(Console.ReadLine());
            double size    = double.Parse(Console.ReadLine());
            int horizontal = int.Parse(Console.ReadLine());
            int vertical   = int.Parse(Console.ReadLine());
            string orientation = String.Empty;
            string actualSize = String.Empty;;

            if (size <1000)
            {
                actualSize = "B";
            } //B
            if (size >=1000 && size <=999999)
            {
                size = size /1000;
                actualSize = "KB";
            } //KB
            if (size >999999)
            {
                size = size / 1000000D;
                actualSize = "MB";
            } //MB

            if (horizontal == vertical)  
            {
                orientation = "square";
            } //SQUARE
            if (horizontal > vertical)
            {
                orientation = "landscape";
            }//LANDSCAPE
            if (vertical > horizontal)
            {
                orientation = "portrait";
            }//PORTRAIT
            
            Console.WriteLine($"Name: DSC_{number:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {size}{actualSize}");
            Console.WriteLine($"Resolution: {horizontal}x{vertical} ({orientation})");
        }
    }
}