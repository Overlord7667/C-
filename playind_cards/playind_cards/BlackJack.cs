using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playind_cards
{
    class BlackJack
    {
        Deck_of_Cards deck;
        public List<Card> Table { get; private set; }
        public int Score { get; private set; }

        public BlackJack()
        {
            deck = new Deck_of_Cards();
            Table = new List<Card>();
            Score = 0;
            deck.Shuffle();
        }

        public void GetCard()
        {
            Table.Add(deck.GetCard());
            ChangeScore();
        }

        public void ChangeScore()
        {
            Score = 0;
            int count = 0;
            foreach(Card card in Table)
            {
                if (card.Nominal != 1)
                {
                    Score += card.Nominal < 10 ? card.Nominal : 10;
                }
                else
                    count++;
            }
                for (int i = 0; i < count; i++)
                {
                    if (Score + 11 <= 21)
                        Score += 11;
                    else
                        Score++;
                }
        }
    }
}
