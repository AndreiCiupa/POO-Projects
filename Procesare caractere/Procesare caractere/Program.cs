using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Procesare_caractere
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StreamReader r = new StreamReader("TextFile1.txt");*/

            StreamReader r = new StreamReader(Console.ReadLine());

            string s = r.ReadToEnd();
            Console.WriteLine(s);

            int l = File.ReadAllLines("TextFile1.txt").Length;

            /*string s = Console.ReadLine();*/

            Console.WriteLine("\nNumarul de caractere introduse este: " + CharNr(s) + ".");
            Console.WriteLine("\nNumarul de vocale introduse este: " + VowelsNr(s) + ".");
            Console.WriteLine("\nNumarul de consoane introduse este: " + ConsonantsNr(s) + ".");
            Console.WriteLine("\nNumarul de randuri ale textului citit este: " + l + ".\n");

            Console.ReadKey();
        }

        private static int ConsonantsNr(string s)
        {
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                Convert.ToChar(s[i]);
                if (s[i] == 'b' || s[i] == 'c' || s[i] == 'd' || s[i] == 'f' || s[i] == 'g' || s[i] == 'h' || s[i] == 'j' ||
                    s[i] == 'k' || s[i] == 'l' || s[i] == 'm' || s[i] == 'n' || s[i] == 'p' || s[i] == 'q' || s[i] == 'r' ||
                    s[i] == 's' || s[i] == 't' || s[i] == 'v' || s[i] == 'w' || s[i] == 'x' || s[i] == 'y' || s[i] == 'z')
                {
                    c++;
                }
            }
            return c;
        }

        private static int VowelsNr(string s)
        {
            int v = 0;
            for (int i = 0; i < s.Length; i++)
            {
                Convert.ToChar(s[i]);
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    v++;
                }
            }
            return v;
        }

        private static int CharNr(string s)
        {
            int n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                {
                    n++;
                }
            }
            return n;
        }
    }
}
