using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Välkomen till 21:an :)");

            int menuChoises = 0;

            string menuChoisesString = "";


            while (menuChoises != 3) // Innehållet som finns i menyn.
            {
                Console.WriteLine();
                Console.WriteLine("Välj ett alternativ!");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Spelets regler");
                Console.WriteLine("3. Avsluta programmet");
                menuChoisesString = Console.ReadLine();

                while (!int.TryParse(menuChoisesString, out menuChoises))       // Koden gör att den inte krashar om anvädaren inte följer instruktionerna.
                {
                    Console.WriteLine();
                    Console.WriteLine("Det där är inte ett giltigt svar. Försök igen!");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Ok, Jag väljer då: ");
                    Console.ForegroundColor = ConsoleColor.White;

                    menuChoisesString = Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
    }
}
