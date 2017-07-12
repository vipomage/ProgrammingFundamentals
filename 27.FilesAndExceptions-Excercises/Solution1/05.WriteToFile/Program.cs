using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText("sample_text.txt").Split(new []{'.',',','!','?',':'});

            //foreach (string s in text.SkipWhile(c=>c == "."||c==","||c=="!"||c=="?"||c==":"))
            //{
                
            //}
          
            string[] output = new string[64];
            output = text.SkipWhile(c => c == "." || c == "," || c == "!" || c == "?" || c == ":").ToArray();
            File.WriteAllText("output.txt", string.Join("", output));
            
        }
    }
}
