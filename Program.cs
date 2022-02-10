    using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            // deck.Print();
            // Console.WriteLine(deck.Deal());

            Player mike = new Player("Mike");
            Console.WriteLine(mike.Draw(deck));
            Console.WriteLine(mike.Hand.Count);
            
        
        }
    }
}
