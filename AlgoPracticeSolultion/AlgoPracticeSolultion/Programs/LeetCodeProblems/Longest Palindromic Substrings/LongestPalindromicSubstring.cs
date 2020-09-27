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

            var inputString = "asdcababaghjk";
            var hashedString = "#" + string.Join<char>("#", inputString) + "#";
            var length = Enumerable.Repeat(0, hashedString.Length + 1).ToArray();
            int right = 0, center = 0, i = 0, maxIndex = 0;
            while (i < hashedString.Length)
            {
                if (i < right) length[i] = Math.Min(length[2 * center - i], right - i);
                while (i - length[i] - 1 >= 0 && i + length[i] + 1 < hashedString.Length && hashedString[i + length[i] + 1] == hashedString[i - length[i] - 1]) length[i]++;

                if (i + length[i] > right)
                {
                    center = i;
                    right = i + length[i];
                }
                if (length[i] > length[maxIndex]) { maxIndex = i; }
                i++;
            }

            var result = hashedString.Substring((maxIndex - length[maxIndex]), (length[maxIndex] * 2 + 1)).Replace("#", "");
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
