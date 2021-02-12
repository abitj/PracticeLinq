using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidGames = new List<string> { "Hades", "Spider-Man", "Among Us", "Animal Crossing", "Call of Duty" };
            vidGames.Sort();
            Console.WriteLine(string.Join(",", vidGames));
        }
    }
}
