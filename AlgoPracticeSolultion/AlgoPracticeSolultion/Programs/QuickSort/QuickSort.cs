using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void DoQuickSort(int[] arrs, int lb, int ub)
        {
            if (lb < ub)
            {
                int parIndex = DoPartition(arrs, lb, ub);
                DoQuickSort(arrs, lb, parIndex - 1);
                DoQuickSort(arrs, parIndex + 1, ub);

            }
        }

        static int DoPartition(int[] arrs, int lb, int ub)
        {
            var pivot = lb;

            while (lb < ub)
            {
                while (lb < ub && arrs[lb] <= arrs[pivot]) lb++;
                while (arrs[ub] > arrs[pivot]) ub--;
                if (lb < ub)
                {
                    int temp = arrs[lb];
                    arrs[lb] = arrs[ub];
                    arrs[ub] = temp;
                }
            }

            int temp1 = arrs[pivot];
            arrs[pivot] = arrs[ub];
            arrs[ub] = temp1;

            return ub;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            var number = int.Parse(Console.ReadLine());
            int[] arrs = new int[number];
            var rand = new Random(100);
            for (int i = 0; i < number; i++) arrs[i] = rand.Next() % 100;
            DoQuickSort(arrs, 0, number - 1);
            for (int i = 0; i < number; i++) Console.Write($"{arrs[i]}\t");
            Console.ReadLine();
        }
    }
}
