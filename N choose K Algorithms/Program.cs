using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_choose_K_Algorithms
{
    internal class Program
    {
        static int numberofpossiblecombination(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;

            }
            else
            {
                return numberofpossiblecombination(n-1,k)+ numberofpossiblecombination(n-1,k-1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(numberofpossiblecombination(10, 2));
            Console.ReadLine();
        }
    }
}
