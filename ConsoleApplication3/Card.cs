using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Card
    {
        public Face faces { get; set; }
        public Suit suits { get; set; }

        public Card(Face face, Suit suit)
        {
            this.faces = face;
            this.suits = suit;
        }
    }
}
