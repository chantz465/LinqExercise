using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqMethods
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            var games = new List<string>() { "bioshock", " God Of War", "Call Of Duty", "Lego Star Wars" };
            games.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }

    }
}
