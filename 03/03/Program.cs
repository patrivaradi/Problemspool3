using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    /// <summary>
    /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. 
    /// Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul elementelor din vector  n = ");
            int n = int.Parse(Console.ReadLine());
            
            int[] v = new int[n];
            Console.WriteLine($"Introduceti {n} elemente in vector : ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int min = v[0], max=v[0];
            int pozmin = 0, pozmax = 0;
            for (int i = 0; i <= n; i++)
            {
                if (v[i] < min || v[i]==min)            //TODO something's wrong with this part...
                {
                    min = v[i];
                    pozmin = i;
                }
                else if (v[i] > max || v[i]==max) 
                { 
                    max = v[i];
                    pozmax = i;
                }
                
            }            
            Console.WriteLine($"Pozitia al cel mai mici element este {pozmin} \n iar pozitia celui mai mare element este {pozmax}");
            
            Console.ReadKey();
        }
    }
}
