using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    internal class Deck
    {
        #region Cards
        //ace
        Card aceOfHearts = new Card("As kier", Suit.hearts, CardType.ace, 11);
        Card aceOfSpades = new Card("As pik", Suit.spades, CardType.ace, 11);
        Card aceOfDiamonds = new Card("As karo", Suit.diamonds, CardType.ace, 11);
        Card aceOfClubs = new Card("As trefl", Suit.clubs, CardType.ace, 11);

        //nine
        Card nineOfHearts = new Card("Dziewiątka kier", Suit.hearts, CardType.nine, 0);
        Card nineOfSpades = new Card("Dziewiątka pik", Suit.spades, CardType.nine, 0);
        Card nineOfDiamonds = new Card("Dziewiątka karo", Suit.diamonds, CardType.nine, 0);
        Card nineOfClubs = new Card("Dziewiątka trefl", Suit.clubs, CardType.nine, 0);

        //ten
        Card tenOfHearts = new Card("Dziesiątka kier", Suit.hearts, CardType.ten, 10);
        Card tenOfSpades = new Card("Dziesiątka pik", Suit.spades, CardType.ten, 10);
        Card tenOfDiamonds = new Card("Dziesiątka karo", Suit.diamonds, CardType.ten, 10);
        Card tenOfClubs = new Card("Dziesiątka trefl", Suit.clubs, CardType.ten, 10);

        //jack
        Card jackOfHearts = new Card("Walet kier", Suit.hearts, CardType.jack, 2);
        Card jackOfSpades = new Card("Walet pik", Suit.spades, CardType.jack, 2);
        Card jackOfDiamonds = new Card("Walet karo", Suit.diamonds, CardType.jack, 2);
        Card jackOfClubs = new Card("Walet trefl", Suit.clubs, CardType.jack, 2);

        //queen
        Card queenOfHearts = new Card("Królowa kier", Suit.hearts, CardType.queen, 3);
        Card queenOfSpades = new Card("Królowa pik", Suit.spades, CardType.queen, 3);
        Card queenOfDiamonds = new Card("Królowa karo", Suit.diamonds, CardType.queen, 3);
        Card queenOfClubs = new Card("Królowa trefl", Suit.clubs, CardType.queen, 3);

        //king
        Card kingOfHearts = new Card("Król kier", Suit.hearts, CardType.king, 4);
        Card kingOfSpades = new Card("Król pik", Suit.spades, CardType.king, 4);
        Card kingOfDiamonds = new Card("Król karo", Suit.diamonds, CardType.king, 4);
        Card kingOfClubs = new Card("Król trefl", Suit.clubs, CardType.king, 4);
        #endregion

        public List<Card> deckOfCards = new List<Card>();
        public List<Card> currentlyUsedDeckOfCards;
        public List<Card> wylosowane;
        public Deck()
        {
            currentlyUsedDeckOfCards = deckOfCards;
            wylosowane = new List<Card>();
            deckOfCards.Add(aceOfHearts);
            deckOfCards.Add(aceOfSpades);
            deckOfCards.Add(aceOfDiamonds);
            deckOfCards.Add(aceOfClubs);

            deckOfCards.Add(nineOfHearts);
            deckOfCards.Add(nineOfSpades);
            deckOfCards.Add(nineOfDiamonds);
            deckOfCards.Add(nineOfClubs);

            deckOfCards.Add(tenOfHearts);
            deckOfCards.Add(tenOfSpades);
            deckOfCards.Add(tenOfDiamonds);
            deckOfCards.Add(tenOfClubs);

            deckOfCards.Add(jackOfHearts);
            deckOfCards.Add(jackOfSpades);
            deckOfCards.Add(jackOfDiamonds);
            deckOfCards.Add(jackOfClubs);

            deckOfCards.Add(queenOfHearts);
            deckOfCards.Add(queenOfSpades);
            deckOfCards.Add(queenOfDiamonds);
            deckOfCards.Add(queenOfClubs);

            deckOfCards.Add(kingOfHearts);
            deckOfCards.Add(kingOfSpades);
            deckOfCards.Add(kingOfDiamonds);
            deckOfCards.Add(kingOfClubs);
        }
        
        public Card RandomCard(List<Card> list)
        {
            Shuffle(list);
            Card cardwylosowana = null;
            try
            {
                cardwylosowana = list.ElementAtOrDefault(0);
            }
            catch
            {
                MessageBox.Show("Koniec kart w talii!");
            }
            return cardwylosowana;

        }

        void Shuffle(List<Card> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                Card value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        int suma;
        public int CountPoints(List<Card> list)
        {
            suma = 0;
            foreach (var item in list)
            {
                suma += item.score;
            }
            return suma;
        }

    }
}
