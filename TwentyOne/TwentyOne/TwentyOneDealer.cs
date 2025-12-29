using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Deck
    {
        public object Cards { get; set; }
        public class TwentyOneDealer : Dealer
        {
            private List<Card> _hand = new List<Card>();
            public List<Card> Hand { get { return _hand; } set { _hand = value; } }
            public bool Stay { get; set; }
            public bool isBusted { get; set; }
            internal Deck Shuffle()
            {
                throw new NotImplementedException();
            }
        }
    }
}