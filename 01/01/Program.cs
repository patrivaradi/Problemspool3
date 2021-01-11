using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul elementelor din vector  n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v=new int[n];
            Console.WriteLine($"Introduceti {n} elemente in vector : ");
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                v[i]=int.Parse(Console.ReadLine());
                suma = suma + v[i];
            }
            Console.WriteLine($"Suma elementelor din vectorul din {n} elemente este  = {suma}");
            Console.ReadKey();
        }
    }
}
