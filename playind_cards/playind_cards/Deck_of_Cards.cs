using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playind_cards
{
    class Deck_of_Cards
    {
        List<Card> cards;
        string[] names;
        public int Count { get; private set; }
        public Deck_of_Cards()
        {
            cards = new List<Card>();
            names = new string[4] { "♥", "♦", "♣", "♠" };
            GenerateDeck();
            Count = cards.Count();
        }
        void GenerateDeck()
        {
            int count = 0;
            for (int j = 0; j < 4; j++)
            for (int i = 0; i < 13; i++)
            {
                {
                    string path = "D:\\cards\\Card\\image_part_0";
                    if (count + 1 < 10)
                        path += "0";
                    path += (count + 1).ToString() + ".jpg";
                    cards.Add(new Card(names[j],
                        i + 1,
                        new Bitmap(path),
                        new Bitmap("D:\\cards\\Card\\back.jpg")
                        ));
                    count++;
                }
            }
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i= 0; i<Count;i++)
            {
                int index = rnd.Next(Count);

                Card tmp = cards[i];
                cards[i] = cards[index];
                cards[index] = tmp;
            }
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
            Count = cards.Count;
        }
        public Card GetCard()
        {
            if (Count - 1 >= 0)
            {
                Card tmp = cards[Count - 1];
                cards.RemoveAt(Count - 1);
                Count = cards.Count;
                return tmp;
            }
            else
                return null;
        }
    }
}
