using System;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = (Console.ReadLine());
            string sByteOf  = String.Empty;
            string byteOf   = String.Empty;
            string shortOf  = String.Empty;
            string uShortOf = String.Empty;
            string intOf    = String.Empty;
            string uIntOf   = String.Empty;
            string longOf   = String.Empty;

            try
            {
                sbyte sSbyteData = sbyte.Parse(input);
                sByteOf = "* sbyte\n";
            }
            catch (Exception)
            {
            }
            try
            {
                byte byteData = byte.Parse(input);
                byteOf = "* byte\n";
            }
            catch (Exception)
            {
            }
            try
            {
                short shortData = short.Parse(input);
                shortOf = "* short\n";
            }
            catch (Exception)
            {
            }
            try
            {
                ushort ushortData = ushort.Parse(input);
                uShortOf = "* ushort\n";
            }
            catch (Exception)
            {
            }
            try
            {
                int intData =  int.Parse(input);
                intOf = "* int\n";
            }
            catch (Exception)
            {
            }
            try
            {
                uint uintData =  uint.Parse(input);
                uIntOf = "* uint\n";
            }
            catch (Exception)
            {
            }
            try
            {
                long ulongData = long.Parse(input);
                longOf = "* long\n";
            }
            catch (Exception)
            {
            }
            try
            {
                long.Parse(input);
                Console.WriteLine($"{input} can fit in:");
                Console.Write(sByteOf);
                Console.Write(byteOf);
                Console.Write(shortOf);
                Console.Write(uShortOf);
                Console.Write(intOf);
                Console.Write(uIntOf);
                Console.Write(longOf);
            }
            catch (Exception)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}