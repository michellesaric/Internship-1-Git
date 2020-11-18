using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            string asti = "Da";
            while (asti == "Da")
            {
                Console.WriteLine("Upišite neki broj:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Upišite neki drugi broj:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Uneseni brojevi su: " + a + " i " + b);
                Console.WriteLine("Unesite jedan znak za matematicku operaciju:");
                char c = char.Parse(Console.ReadLine());
                if (c == '+')
                {
                    d = a + b;
                    Console.WriteLine("Rezultat je " + d);
                }
                else if (c == '-')
                {
                    d = a - b;
                    Console.WriteLine("Rezultat je " + d);
                }
                else if (c == '*')
                {
                    d = a * b;
                    Console.WriteLine("Rezultat je " + d);
                }
                else if (c == '/')
                {
                    if (b == '0')
                        Console.WriteLine("Noup, nemoguća radnja, rezultat bi bio beskonacno.");
                    double e = (double)a / b;
                    Console.WriteLine("Rezultat je " + e);
                }
                else
                    Console.WriteLine("Krivo upisan znak.");
                Console.WriteLine("Zelite li nastaviti dalje? Upisite Da ili Ne");
                asti = Console.ReadLine();
            }
        }
    }
}
