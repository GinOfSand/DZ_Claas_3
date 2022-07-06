using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Claas_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original");
            int[] m1 = { 1, 2, 3, 2, 5, 2, -4 };
            foreach (int i in m1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Filter");
            int[] m2 = { 1, 2 };
            foreach (int i in m2) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Result");
            foreach (int i in MassFiltr.MF_mass(m1, m2)) { 
                Console.Write(i+" "); 
            }
            Console.WriteLine();
        }
    }
}
