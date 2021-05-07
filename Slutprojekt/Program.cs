using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkomen till 21:an");

            string menuChoises = "0";

            while (menuChoises != "3") // Innehållet som finns i menyn.
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Spelets regler");
                Console.WriteLine("3. Avsluta programmet");
                menuChoises = Console.ReadLine();

            }

            Console.ReadLine();
        }
    }
}
