using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPracticeSolultion
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetMedianOfTwoSortedArrayOf(new int[] { 1, 3, 5, 7, 9, 11 }, new int[] { 2, 4, 6, 8, 10, 12 });
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }
        static double GetMedianOfTwoSortedArrayOf(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length < secondArray.Length)
            {
                return GetMedianOfTwoSortedArrayOf(secondArray, firstArray);
            }
            int lowerBound = 0, higherBound = secondArray.Length;
            int sArrayPartioningPoint = (lowerBound + higherBound) / 2;
            int fArrayPartioningPoint = (firstArray.Length + secondArray.Length + 1) / 2 - sArrayPartioningPoint;
            int secondArrayFirstHalfMaxValue = sArrayPartioningPoint == 0 ? int.MinValue : secondArray[sArrayPartioningPoint - 1],
                firstArrayFirstHalfMaxValue = fArrayPartioningPoint == 0 ? int.MinValue : firstArray[fArrayPartioningPoint - 1],
                secondArraySecondHalfMinValue = sArrayPartioningPoint == secondArray.Length ? int.MaxValue : secondArray[sArrayPartioningPoint],
                firstArraySecondHalfMinValue = fArrayPartioningPoint == firstArray.Length ? int.MaxValue : firstArray[fArrayPartioningPoint];


            while (lowerBound <= higherBound)
            {
                if (firstArrayFirstHalfMaxValue <= secondArraySecondHalfMinValue && secondArrayFirstHalfMaxValue <= firstArraySecondHalfMinValue)
                {
                    if ((firstArray.Length + secondArray.Length) % 2 == 0)
                        return (double)(Math.Max(firstArrayFirstHalfMaxValue, secondArrayFirstHalfMaxValue) + Math.Min(firstArraySecondHalfMinValue, secondArraySecondHalfMinValue)) / 2;
                    return Math.Max(firstArrayFirstHalfMaxValue, secondArrayFirstHalfMaxValue);

                }
                else if (secondArrayFirstHalfMaxValue > firstArraySecondHalfMinValue)
                {
                    higherBound--;
                }
                else
                {
                    lowerBound++;
                }

                sArrayPartioningPoint = (lowerBound + higherBound) / 2;
                fArrayPartioningPoint = (firstArray.Length + secondArray.Length + 1) / 2 - sArrayPartioningPoint;
                secondArrayFirstHalfMaxValue = sArrayPartioningPoint == 0 ? int.MinValue : secondArray[sArrayPartioningPoint - 1];
                firstArrayFirstHalfMaxValue = fArrayPartioningPoint == 0 ? int.MinValue : firstArray[fArrayPartioningPoint - 1];
                secondArraySecondHalfMinValue = sArrayPartioningPoint == secondArray.Length ? int.MaxValue : secondArray[sArrayPartioningPoint];
                firstArraySecondHalfMinValue = fArrayPartioningPoint == firstArray.Length ? int.MaxValue : firstArray[fArrayPartioningPoint];
            }
            throw new InvalidOperationException();
        }
    }
}
