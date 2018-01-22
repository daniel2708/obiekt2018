using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sportowiec> sport = new List<Sportowiec>();
            sport.Add(new Biegacz("Daniel", 'x', 13));
            sport.Add(new Biegacz("Tomek", 'y', 14));
            sport.Add(new Biegacz("Janek", 'z', 11));
            sport.Add(new Biegacz("Łukasz", 'u', 44));
            foreach (var element in sport)
            {
                Console.WriteLine(element);
            }
            for (int i = 0; i < sport.Count; i++)
            {
                Console.WriteLine(sport[i]);
            }
            sport.Reverse();
        }
    }
}
