using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {

            int menuChoises = 0;
            string menuChoisesString = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Välkomen till 21:an :)");

            while (menuChoises != 3) // Innehållet som finns i menyn.
            {
                Console.WriteLine();
                Console.WriteLine("Välj ett alternativ!");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Spelets regler");
                Console.WriteLine("3. Avsluta programmet");
                Console.ForegroundColor = ConsoleColor.Magenta;
                menuChoisesString = Console.ReadLine();

                while (!int.TryParse(menuChoisesString, out menuChoises))       // Koden gör att den inte krashar om anvädaren inte följer instruktionerna.
                {
                    Console.WriteLine();
                    setWritelineColor("Det där är inte ett giltigt svar. Försök igen!", ConsoleColor.Red);

                    /*Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Ok, Jag väljer då: ");*/
                    setWritelineColor("Ok, Jag väljer då: ", ConsoleColor.Cyan);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    menuChoisesString = Console.ReadLine();
                }

                Console.WriteLine();

                // Använder mig av en switch istället för flera "if"
                switch (menuChoisesString)
                {
                    case "1":
                        startGame();
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine("När du är färdig drar datorn kort till den har");
                        Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;
                    default:

                        /*Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR!!!");*/
                        setWritelineColor("ERROR!!!", ConsoleColor.Red);
                        Console.WriteLine("Du har inte valt någon av alternativen 1 - 3!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
            }

            Console.ReadLine();
        }

        static void startGame()
        {
            int aiPoints = 0;
            int playerPoints = 0;
            Random random = new Random();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nu kommer två kort dras per spelare");
            aiPoints += random.Next(1, 11);
            playerPoints += random.Next(1, 11);

            string cardChoises = "";

            while (cardChoises != "n" && playerPoints <= 21)
            {
                Console.WriteLine($"Din poäng: {playerPoints}");
                Console.WriteLine($"Datorns poäng: {aiPoints}");
                Console.WriteLine("Vill du ha ett till kort? (j/n)");
                cardChoises = Console.ReadLine();
            }

            Console.ReadLine();
        }

        public static void setWritelineColor(string txt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(txt);
        }
    }
}
