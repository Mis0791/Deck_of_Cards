using System;

namespace DeckofCards
{
    public class Card
    {
        public string Name { get; set; } 
        public int Value { get; set; }
        public string Suit { get; set; }

        public Card(string n, int v, string s) {
            Name = n;
            Value = v;
            Suit = s;
        }

        public override string ToString(){
            return $"{Name} of {Suit}";
        }
    }
}

// if it's static it belongs to the class 
