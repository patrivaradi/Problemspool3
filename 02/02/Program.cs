using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        /// <summary>
        /// Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. 
        /// Daca k nu apare in vector rezultatul va fi -1.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul elementelor din vector  n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea k = ");
            int k = int.Parse(Console.ReadLine());
            int poz = 0;
            int[] v = new int[n];
            Console.WriteLine($"Introduceti {n} elemente in vector : ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());                
            }
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == k)
                {
                    poz = i;
                    break;
                }
                else poz = -1;
            }
            if (poz == -1)
                Console.WriteLine($"{poz}");
            else Console.WriteLine($"Prima pozitie pe care apare {k} este pozitia {poz}.");
            Console.ReadKey();
        }
    }
}
