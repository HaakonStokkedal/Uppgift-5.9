using System;

namespace Uppgift_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[1000];
            string val = "";

            while (val != "n")
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("Skriv in ett namn");
                    namn[i] = Console.ReadLine();

                    Console.WriteLine("Vill du skriva in ett till namn? (svara med j eller n)");
                    val = Console.ReadLine();
                    if (val == "n")
                    {
                        i = 1000;
                    }
                }
            }
            Console.WriteLine("Skriv in ett namn du vill veta antalet av");
            string namn2 = Console.ReadLine();
            int antal = 0;
            for (int i = 0; i < namn.Length; i++)
            {
                if (namn2.CompareTo(namn[i]) == 0)
                    antal++;
            }
            Console.WriteLine($"{namn2} förekommer {antal} gånger.");
            Console.ReadKey();
        }
    }
}