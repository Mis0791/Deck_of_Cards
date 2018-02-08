using System;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            deck.PrintAllCards();
            Card c = deck.DrawCard();
        }
    }
}
