using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participantsList = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songList = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, List<string>> performerAwards = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> outputDictionary = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while ( input.ToLower() != "dawn" )
            {
                string[] userSongNAward = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if ( performerAwards.ContainsKey(userSongNAward[0]) && participantsList.Contains(userSongNAward[0]) &&
                    songList.Contains(userSongNAward[1]) )
                {
                    performerAwards[userSongNAward[0]].Add(userSongNAward[2]);
                }
                else if ( !performerAwards.ContainsKey(userSongNAward[0]) &&
                         participantsList.Contains(userSongNAward[0]) && songList.Contains(userSongNAward[1]) )
                {
                    performerAwards[userSongNAward[0]] = new List<string> { userSongNAward[2] };
                }

                input = Console.ReadLine();
            }

            //

            foreach ( KeyValuePair<string, List<string>> valuePair in performerAwards )
            {
                outputDictionary[valuePair.Key] = performerAwards[valuePair.Key].Distinct().ToList();
            }
            //


            foreach ( List<string> performerAwardsValue in performerAwards.Values )
            {
                performerAwardsValue.Sort();
            }
            if ( performerAwards.Values.Count == 0 )
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach ( KeyValuePair<string, List<string>> performerAward in performerAwards
                    .OrderByDescending(a => a.Value.Distinct().Count()).ThenBy(a => a.Key) )
                {
                    Console.WriteLine(
                        $"{performerAward.Key}: {performerAward.Value.Distinct().Count()} awards \n--{string.Join("\n--", performerAward.Value.Distinct())}");
                }
            }
        }
    }
}
//TODO ORDER THE DICTIONARY
//TODO Print "No awards" if nessesary