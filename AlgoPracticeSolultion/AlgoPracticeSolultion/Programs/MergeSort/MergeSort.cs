using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MergeSortPractice
{
    class Program
    {
        static int[] elements, tempSortedArray;
        static void MergeSort(int lowerBound, int upperBound)
        {
            if (lowerBound < upperBound)
            {
                var middlePoint = (lowerBound + upperBound) / 2;
                MergeSort(lowerBound, middlePoint);
                MergeSort(middlePoint + 1, upperBound);
                Merge(lowerBound, middlePoint, upperBound);
            }
        }

        static void Merge(int lowerBound, int middlePoint, int upperBound)
        {
            int firstHalfIndex = lowerBound, secondHalfIndex = middlePoint + 1, tempArrayIndex = lowerBound;
            while (firstHalfIndex <= middlePoint && secondHalfIndex <= upperBound)
            {
                if (elements[firstHalfIndex] < elements[secondHalfIndex])
                    tempSortedArray[tempArrayIndex++] = elements[firstHalfIndex++];
                else
                    tempSortedArray[tempArrayIndex++] = elements[secondHalfIndex++];
            }

            while (firstHalfIndex <= middlePoint)
                tempSortedArray[tempArrayIndex++] = elements[firstHalfIndex++];

            while (secondHalfIndex <= upperBound)
                tempSortedArray[tempArrayIndex++] = elements[secondHalfIndex++];

            for (int i = lowerBound; i <= upperBound; i++)
                elements[i] = tempSortedArray[i];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Elements");
            var elementNumbers = int.Parse(Console.ReadLine());
            var rand = new Random(100);
            elements = new int[elementNumbers];
            tempSortedArray = new int[elementNumbers];
            for (int i = 0; i < elementNumbers; i++)
            {
                elements[i] = rand.Next() % 10;
            }
            MergeSort(0, elementNumbers - 1);
            for (int i = 0; i < elementNumbers; i++) Console.WriteLine($"\t{tempSortedArray[i]}");
            Console.ReadLine();
        }
    }
}
