using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPracticeSolultion
{
    class LognSubStrWithoutReptChars
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var set = new HashSet<char>();
            int lowerPointer = 0, upperPointer = 0, maxLength = 0;
            var strLength = str.Length;

            while (upperPointer < strLength)
            {
                if (!set.Contains(str[upperPointer]))
                {
                    set.Add(str[upperPointer]);
                    maxLength = Math.Max(set.Count, maxLength);
                    upperPointer++;
                }
                else
                {
                    set.Remove(str[lowerPointer]);
                    lowerPointer++;
                }
            }
            //return maxLength;
            Console.WriteLine($"{maxLength}");
            Console.ReadLine();
        }
    }
}
