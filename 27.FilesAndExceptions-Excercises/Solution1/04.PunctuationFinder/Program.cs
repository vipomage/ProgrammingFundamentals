using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PunctuationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> outpuList = new List<string>();
            List<string> words = File.ReadAllText("sample_text.txt").Split().ToList();

            foreach (string word in words)
            {
                
            if (word.Contains("."))
            {
                outpuList.Add(word[word.IndexOf('.')].ToString());
            }
            if (word.Contains(","))
            {
                outpuList.Add(word[word.IndexOf(',')].ToString());
                }
            if (word.Contains("!"))
            {
                outpuList.Add(word[word.IndexOf('!')].ToString());
                }
            if (word.Contains("?"))
            {
                outpuList.Add(word[word.IndexOf('?')].ToString());
                }
            if (word.Contains(":"))
            {
                outpuList.Add( word[word.IndexOf(':')].ToString() );
                }
            }
            File.WriteAllText("output.txt",string.Join(", ",outpuList));
        }
    }
}
