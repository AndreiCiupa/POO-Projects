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
            int n = int.Parse(Console.ReadLine());
            mystack<int> stiva = new mystack<int>(n);

            stiva.Push(567);
            stiva.Push(568);
            stiva.Push(569);
            stiva.Pop();
            stiva.Clear();
        }
    }

}
