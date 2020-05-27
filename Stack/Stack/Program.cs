using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace Stiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());

            mystack<int> stiva = new mystack<int>(n);

            stiva.Push(567);
            stiva.Push(568);
            stiva.Push(569);
            stiva.Pop();
            stiva.Clear();

            Console.Write("\nIntroduceti un numar: ");
            int m = int.Parse(Console.ReadLine());

            mystack<char> stiva2 = new mystack<char>(n);

            stiva.Push('a');
            stiva.Push('b');
            stiva.Push('c');
            stiva.Pop();
            stiva.Clear();
        }
    }

}
