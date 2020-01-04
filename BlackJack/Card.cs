using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public enum Suit
    {
        hearts,
        diamonds,
        spades,
        clubs
    } 

    public enum CardType
    {
        ace,
        nine,
        ten,
        jack,
        queen,
        king
    }

    internal class Card
    {
        public string name;
        public Suit suit;
        public CardType cardType;
        public int score;

        public Card(string _name, Suit _suit, CardType _cardType, int _score)
        {
            this.name = _name;
            this.suit = _suit;
            this.cardType = _cardType;
            this.score = _score;
        }
        public override string ToString()
        {
            return $"{name}  ---  {score}pkt \r\n";
        }
    }
}
