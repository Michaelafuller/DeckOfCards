using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards {get; set;} = new List<Card>();

        public Deck()
        {
            string[] suits = 
            {
                "Hearts",
                "Diamonds",
                "Spades",
                "Clubs"
            };

            Dictionary<int, string> FaceCardNames = new Dictionary<int, string>()
            {
                {1, "Ace"},
                {11, "Jack"},
                {12, "Queen"},
                {13, "King"}
            };

            foreach (string suit in suits)
            {
                for (int i = 1; i < 14; i++)
                {
                    string name = i.ToString();

                    if (FaceCardNames.ContainsKey(i))
                    {
                        name = FaceCardNames[i];
                    }

                    Card card = new Card(name, suit, i);
                    Cards.Add(card);
                }
            }

        }
        public void Print()
        {
            string PrintableDeck = "";

            foreach (Card card in Cards)
            {
                PrintableDeck += card + "";
            }
            Console.WriteLine(PrintableDeck);
        }

        public Card Deal()
        {
            Console.WriteLine($"The top card is {Cards[0]}.");
            Cards.RemoveAt(0);
            return Cards[0];
        }
    }
}