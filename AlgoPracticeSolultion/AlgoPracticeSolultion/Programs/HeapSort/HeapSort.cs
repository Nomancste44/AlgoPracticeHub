using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void SortHeap(int[] arrs)
        {
            int length = arrs.Length;
            for (int i = length / 2 - 1; i >= 0; i--) heapify(arrs, i, length);

            for (int i = length - 1; i > 0; i--)
            {
                int temp = arrs[0];
                arrs[0] = arrs[i];
                arrs[i] = temp;
                heapify(arrs, 0, i);
            }
        }

        static void heapify(int[] arrs, int index, int length)
        {
            int maxElement = index;
            int leftChild = index * 2 + 1, rightChild = index * 2 + 2;
            if (length > leftChild && arrs[maxElement] < arrs[leftChild]) { maxElement = leftChild; }
            if (length > rightChild && arrs[maxElement] < arrs[rightChild]) { maxElement = rightChild; }
            if (maxElement != index)
            {
                int temp = arrs[index];
                arrs[index] = arrs[maxElement];
                arrs[maxElement] = temp;
                heapify(arrs, maxElement, length);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Elements");
            int number = int.Parse(Console.ReadLine());
            int[] arrs = new int[number];
            var aRand = new Random(100);
            for (int i = 0; i < number; i++)
            {
                arrs[i] = aRand.Next() % 10;
            }
            SortHeap(arrs);
            for (int i = 0; i < number; i++) Console.Write($"{arrs[i]}\t");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
