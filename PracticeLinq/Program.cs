using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>();
            videoGames.Add("Final Fantasy VII");
            videoGames.Add("Castlevania: Symphony of the Night");
            videoGames.Add("World of Warcraft");
            videoGames.Add("StarCraft");
            videoGames.Add("Borderlands 2");
            videoGames.Add("Chrono Cross");
            videoGames.Add("Vampyr");
            videoGames.Add("Cyberpunk 2077");
            videoGames.Add("Super Mario Bros. 3");

            var byLength = videoGames.OrderBy(x => x);
            foreach (var game in byLength)
            {
                Console.WriteLine(game);
            }

        }
    }
}
