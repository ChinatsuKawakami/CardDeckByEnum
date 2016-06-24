using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Deck:List<Card>
    {
        public void Make()
        {
            this._create();
        }
        private void _create()
        {
           foreach(Suit su in Enum.GetValues(typeof(Suit)))
           {
               foreach(Face fa in Enum.GetValues(typeof(Face)))
               {

                   this.Add(new Card(fa,su));
               }
           }
        }//close _create

        public void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Card                   +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            foreach(Card card in this)
            {
            
            Console.WriteLine("+ Card is {0} of {1}",card.suits,card.faces);
            
          
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }//close Display

        public void Shuffled()
        {
            int currentCard = 0;
            int numberOfCard = this.Count;
            Random ram = new Random();
            for(currentCard=0;currentCard<numberOfCard;currentCard++)
            {
                int randomIndex = ram.Next(0,numberOfCard);
                Card temp = this[currentCard];
                this[currentCard] = this[randomIndex];
                this[randomIndex] = temp;
            } 
        }//close Shuffled

        public Card Deal()
        {
            Card returnCard = this[0];
            if(this.Count >0)
            {
                this.RemoveAt(0);
            }
            return returnCard;
        }//close Deal()
    }
}
