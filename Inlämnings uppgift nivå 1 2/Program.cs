using System;

namespace inlämningsUppgift_._nivå1_._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal");
            string str= Console.ReadLine();
            int tal= int.Parse(str);
            while(tal !=0)
            {
                Console.WriteLine("Fel, gissa igen:");
                str = Console.ReadLine();
                tal = int.Parse(str);
            }
            Console.WriteLine("Grattis! Du gissade rätt!");
        }
    }
}