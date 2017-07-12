using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Bottom => Top + Height;
        public double Right => Left + Width;

        internal class Program
        {
            public static bool Inside(Rectangle r2, Rectangle r1)
            {
                return ( ( r1.Left <= r2.Left ) && ( r1.Right >= r2.Right ) && ( r1.Top <= r2.Top ) && ( r1.Bottom >= r2.Bottom ) );
            }

            static void Main()
            {
                Rectangle r1 = ReadRectangle();
                Rectangle r2 = ReadRectangle();

                Console.WriteLine(Inside(r1, r2) ? "Inside" : "Not inside");
            }

            private static Rectangle ReadRectangle()
            {
                string[] input = Console.ReadLine().Split();
                Rectangle r = new Rectangle();
                r.Top = ( double.Parse(input[0]) );
                r.Left = ( double.Parse(input[1]) );
                r.Width = ( double.Parse(input[2]) );
                r.Height = ( double.Parse(input[3]) );
                return r;
            }
        }
    }
}
