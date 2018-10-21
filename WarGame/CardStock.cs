using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class CardStock
    {
        private static Random random = new Random();
        private List<Card> cards;
        public CardStock()
        {
            cards = new List<Card>();
            for (int i = 0; i < 13; i++)
            {
                cards[i] = new Card { Color = E_Color.BLACK, Number = i + 1 };
                cards[i+13] = new Card { Color = E_Color.RED, Number = i + 1 };
            }
            shuffle(cards);
        }

        private void shuffle(List<Card> cards)
        {
            //use random
            throw new NotImplementedException();
        }
    }
}
