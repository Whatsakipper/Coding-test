using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Deck
    {
        string[] suits = { "Spades", "Diamonds", "Clubs", "Hearts" };
        string[] rank = {"Ace" , "2" , "3" , "4" , "5" , "6" , "7" , "8" , "9" , "10" , "Jack" , "Queen" , "King"};
        public Card[] cards;
        public Deck()
        {
            cards = new Card[52];
        }

        /// <summary>
        /// Randomly shuffles the deck the cards.
        /// </summary>
        public void shuffle()
        {
            Random r = new Random();

            for (int c = cards.Length - 1; c > 0; --c)
            {
                int k = r.Next(c+ 1);
                Card temp = cards[c];
                cards[c] = cards[k];
                cards[k] = temp;
            }
        }

        /// <summary>
        /// Creates a new fresh deck.
        /// </summary>
        public void newDeck()
        {
            int c = 0;
            foreach (string s in suits)
            {
                foreach (string r in rank)
                {
                    cards[c] = new Card(r, s);
                    c++;
                }
            }
        }

        /// <summary>
        /// Displays the remaining cards in the deck. Takes in an integer which holds the current place in the deck.
        /// </summary>
        /// <param name="place"></param>
        public void printDeck(int place)
        {
            for (int j = place; j < 52; j++)
            {
                Console.WriteLine("{0} of {1}", cards[j].rank, cards[j].suit);
            }
        }

        /// <summary>
        /// Displays the current card at the top of the deck.
        /// </summary>
        /// <param name="place"></param>
        public void drawCard(int place)
        {
            Console.WriteLine("{0} of {1}", cards[place].rank, cards[place].suit);
        }
    }
}
