using System;

namespace Stack
{
    class mystack<s>
    {
        int capacitate;
        s[] stiva;
        int top = -1;

        public mystack(int n)
        {
            capacitate = n;
            stiva = new s[capacitate];
        }

        public void Push(s Element)
        {
            // Verifica daca Stiva este plina
            if (top == capacitate)
            {
                Console.WriteLine("Stiva este plina!");
            }
            else
            {
                // Adauga element in stiva
                top = top + 1;
                stiva[top] = Element;
                Console.WriteLine($"Elementul {Element} introdus in Stiva!");
            }           
        }

        public void Pop()
        {
            s ElementSters;

            if (!(top <= 0))
            {
                ElementSters = stiva[top];
                top = top - 1;
                Console.WriteLine($"Elementul {ElementSters} a fost sters din Stiva!");
            }
           else Console.WriteLine("Stiva este goala!");
        }

        public void Clear()
        {
            s ElementSters;

            for (int i=0; i < capacitate; i++)
            {
                if (!(top <= 0))
                {
                    ElementSters = stiva[top];
                    top = top - 1;
                }
            }
            Console.WriteLine("Stiva este goala!");
        }
    }
}