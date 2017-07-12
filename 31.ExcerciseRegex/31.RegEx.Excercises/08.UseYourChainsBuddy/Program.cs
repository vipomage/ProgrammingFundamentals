using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var patternText = @"(<p>)(?<text>.*?)(<\/p>)";
            var patternToSpace = @"[^a-z0-9]";
            var inputText = Console.ReadLine();
            List<string> extractedText = new List<string>();
            List<string> decryptedText = new List<string>();

            MatchCollection textMatches = Regex.Matches(inputText, patternText);

            foreach ( Match text in textMatches )
            {
                var textStr = text.Value;
                textStr = textStr.Substring(3);
                textStr = textStr.Substring(0, textStr.Length - 4);
                textStr = Regex.Replace(textStr, patternToSpace, " ");
                textStr = Regex.Replace(textStr, @"\s+", " ");
                //Console.WriteLine(textStr);
                extractedText.Add(textStr);
            }

            foreach ( var text in extractedText )
            {
                var textArr = text.ToList();
                StringBuilder sb = new StringBuilder();

                foreach ( var ch in textArr )
                {
                    if ( 'a' <= ch && ch <= 'm' )
                    {
                        sb.Append((char)( ch + 13 ));
                    }
                    else if ( 'n' <= ch && ch <= 'z' )
                    {
                        sb.Append((char)( ch - 13 ));
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }

                decryptedText.Add(sb.ToString());
            }

            foreach ( var item in decryptedText )
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}