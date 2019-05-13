using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Card
    {
        public string rank { get; }
        public string suit { get; }

        public Card (string nRank, string nSuit)
        {
            rank = nRank;
            suit = nSuit;
        }
    }
}
