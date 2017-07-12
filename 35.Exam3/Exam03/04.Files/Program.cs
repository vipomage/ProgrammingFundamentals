using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Files
{
    class Files
    {
        static void Main(string[] args)
        {

            var pathCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, double>> rootAndFiles = new Dictionary<string, Dictionary<string, double>>();

            for ( double i = 0; i < pathCount; i++ )
            {
                var inputLine = Console.ReadLine();
                var splitedBySemicolon = inputLine.Split(';');
                var size = double.Parse(splitedBySemicolon[1]);
                var splitedByDash = splitedBySemicolon[0].Split('\\');
                var root = splitedByDash.First();
                var fileWithExt = splitedByDash.Last();
                // var splitedByDot = fileWithExt.Split('.').ToList();
                // var fileExt = splitedByDot.Last();
                // splitedByDot.RemoveAt(splitedByDot.Count - 1);
                // var fileName = string.Join("", splitedByDot);

                if ( !rootAndFiles.ContainsKey(root) )
                {
                    rootAndFiles[root] = new Dictionary<string, double>();
                }

                if ( !rootAndFiles[root].ContainsKey(fileWithExt) )
                {
                    rootAndFiles[root][fileWithExt] = 0;
                }

                rootAndFiles[root][fileWithExt] = size;
            }

            var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var searchedExt = commands.First();
            var inRoot = commands.Last();

            if ( !rootAndFiles.ContainsKey(inRoot) )
            {
                Console.WriteLine("No");
                return;
            }

            var searchInRoot = rootAndFiles[inRoot];

            Dictionary<string, double> searchedExtInRoot = new Dictionary<string, double>();

            foreach ( var file in searchInRoot )
            {
                var fileNameExt = file.Key;
                var fileSize = file.Value;
                var splitedFile = fileNameExt.Split('.').ToList();
                var fileExt = splitedFile.Last();
                splitedFile.RemoveAt(splitedFile.Count - 1);
                var fileName = string.Join("", splitedFile);

                if ( fileExt == searchedExt )
                {
                    searchedExtInRoot[fileNameExt] = fileSize;
                }
            }

            if ( searchedExtInRoot.Count == 0 )
            {
                Console.WriteLine("No");
                return;
            }

            foreach ( var file in searchedExtInRoot.OrderByDescending(f => f.Value).ThenBy(f => f.Key) )
            {
                var fileNameExt = file.Key;
                var fileSize = file.Value;
                Console.WriteLine($"{fileNameExt} - {fileSize} KB ");
            }
        }
    }
}