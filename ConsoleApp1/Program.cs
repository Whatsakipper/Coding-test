using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.newDeck();
            int topCard = 0;
            bool loop = true;
            string input;

            while (loop)
            {
                Console.WriteLine(Environment.NewLine + "N – get a new deck – display confirmation message that a new deck was created");
                Console.WriteLine("S – shuffle the current deck – display confirmation message that the current deck was shuffled");
                Console.WriteLine("D – draw next card from current deck and display it on the console");
                Console.WriteLine("R – display on the console all of the cards remaining in the deck");
                Console.WriteLine("Q – quit the application");

                input = Console.ReadLine();

                if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    myDeck.newDeck();
                    Console.WriteLine("New deck created.");
                    topCard = 0;
                }

                if (input.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    myDeck.shuffle();
                    Console.WriteLine("Deck has been shuffled");
                }
                
                if (input.Equals("D", StringComparison.OrdinalIgnoreCase))
                {
                    if(topcard < 52)
                    {
                    myDeck.drawCard(topCard);
                    topCard++;
                    }
                    else
                    Console.WriteLine(“No more cards are left in the deck.”);
                }

                if (input.Equals("R", StringComparison.OrdinalIgnoreCase))
                {
                    myDeck.printDeck(topCard);
                }

                if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    loop = false;
                }
            }
        }
    }
}
