using System;

namespace DeckofCards
{
    public class PLayer
    {
        public string Nmae { get; set; }
        public List<Card> InHand { get; set; }

        public Play(string n){
            Name = n;
            InHand = new List<Card>();
        }

        public void AddCardToHand(Card c){
            InHand.Add(c);
        }
    }
}