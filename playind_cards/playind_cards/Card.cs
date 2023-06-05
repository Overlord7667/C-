using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playind_cards
{
    class Card
    {
        public string Suit { get; private set; }
        public int Nominal { get; private set; }
        public bool IsShirt { get; private set; }
        public Bitmap Front { get; private set; }
        public Bitmap Back { get; private set; }
        public Card (string suit, int nominal, Bitmap front, Bitmap back)
        {
            Suit = suit;
            Nominal = nominal;
            Front = front;
            Back = back;
            IsShirt = false;
        }
        public void Reverse()
        {
            IsShirt = !IsShirt;
        }

    }
}
