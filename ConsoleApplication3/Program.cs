using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.Make();
            deck.Display();
            Console.WriteLine();
            deck.Shuffled();
            deck.Display();
            Console.WriteLine();
            Card card = deck.Deal();
            Console.WriteLine("The top of card : {0} of {1}",card.suits,card.faces);
            deck.Deal();
            deck.Display();
        }
    }
}
