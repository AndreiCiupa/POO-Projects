using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playing_Card;

namespace Playing_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard card = new PlayingCard();

            Console.Write("Your card is: ");

            card.ExtragereCarte();

            Console.Write("\nYour cards meaning: ");

            card.Citire();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
