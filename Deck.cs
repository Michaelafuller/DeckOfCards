using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards {get; set;} = new List<Card>();

        public Deck()
        {
            Reset();
            Shuffle();
        }

        public Deck Reset()
        {
            Cards = new List<Card>();
            
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
            return this;
        }

        public Deck Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {                
                int randomIndex = rand.Next(Cards.Count);
                Card temp = Cards[i];

                Cards[i] = Cards[randomIndex];
                Cards[randomIndex] = temp;

            }

            return this;
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
            if (Cards.Count > 0){
                Card topCard = Cards[Cards.Count-1];
                Cards.Remove(topCard);
                return topCard;
            }
            return null;
        }
    }
}