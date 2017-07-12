using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.CommandInterpreter
{
    class File
    {
        public string Pathname { get; set; }
        public string FileName { get; set; }
        public string Size { get; set; }
        public string Extension { get; set; }

        public List<string> FolderList => Pathname.Split('\\').ToList();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(?<root>[A-z0-9]+)\\(?<filename>\w+.(?<extension>\w+));(?<size>\d+)",
                RegexOptions.IgnoreCase);
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, File> fileDictionary = new Dictionary<string, File>();


            for ( int i = 0; i < n; i++ )
            {
                string input = Console.ReadLine();
                MatchCollection collection = Regex.Matches(input, $"{pattern}");

                foreach ( Match match in collection )
                {
                    var root = match.Groups["root"].Value;
                    var filename = match.Groups["filename"].Value;
                    var extension = match.Groups["extension"].Value;
                    var size = match.Groups["size"].Value;
                    var pathname = match.Groups["root"].ToString().Split('\\');

                    if ( fileDictionary.ContainsKey(root) && fileDictionary[root].FileName == filename )
                    {
                        fileDictionary[root].Size = size;
                    }
                    fileDictionary[root] = new File()
                    {
                        FileName = filename,
                        Extension = extension,
                        Size = size,
                        Pathname = root
                        
                    };

                    

                }
            }
            string[] querry = Console.ReadLine().Split();

            if ( fileDictionary.Any(d => d.Key.Split('\\').Any(a=>a == querry[2]) && d.Value.Extension == querry[0]) )
            {
                foreach ( var keyValuePair in fileDictionary
                    .Where(d => d.Key.Split('\\').Any(a=>a ==querry[2] && d.Value.Extension ==querry[0]))
                    .OrderByDescending(kp => kp.Value.Size)
                    .ThenBy(fn => fn.Value.FileName))
                {
                    Console.WriteLine($"{keyValuePair.Value.FileName} - {keyValuePair.Value.Size} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}