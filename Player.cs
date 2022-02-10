using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name { get; set; }

        public List<Card> Hand { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public Card Draw(Deck deck)
        {
            Card dealtcard = deck.Deal();

            if (dealtcard != null)
            {
                Hand.Add(dealtcard);
            }
            return dealtcard;
        }

        public Card Discard(int i)
        {
            if (i < 0 || i >= Hand.Count)
            {
                return null;
            }
            Card cardToRemove = Hand[i];
            Hand.Remove(cardToRemove);
            return cardToRemove;
            }
        }
    }
