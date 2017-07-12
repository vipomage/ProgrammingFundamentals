using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ExtractSentencesByKeyword
{
    public static void Main()
    {
        var pattern = @"(\S.+?[.!?])(?=\s+|$)";
      
        var word = Console.ReadLine();
        var wordPattern = @"\b" + word + @"\b";
        var inputText = Console.ReadLine();

        Regex wordRegex = new Regex(wordPattern);

        Regex regex = new Regex(pattern);
        MatchCollection sentencesMatches = regex.Matches(inputText);

        foreach (Match sentence in sentencesMatches)
        {
            var sentenceStr = sentence.Value;
            var isWordInSentence = wordRegex.IsMatch(sentenceStr);

            if (isWordInSentence)
            {
                sentenceStr = sentenceStr.Remove(sentenceStr.Length - 1);
                Console.WriteLine(sentenceStr);
            }
        }
    }
}


//TODO http://regexr.com/3g99s
