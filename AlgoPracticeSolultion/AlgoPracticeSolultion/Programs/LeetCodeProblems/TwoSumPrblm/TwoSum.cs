using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPracticeSolultion
{
    class TwoSum
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 3, 3, 4 };
            var result = TwoSumFunction(nums, 6);
            Console.WriteLine($"{result[0]}\t {result[1]}");
            Console.ReadLine();
        }
        public static int[] TwoSumFunction(int[] nums, int target)
        {


            var sets = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var item = target - nums[i];
                if (sets.ContainsKey(item))
                {
                    return new int[] { i, sets[item] };
                }
                if (!sets.ContainsKey(nums[i]))
                {
                    sets.Add(nums[i], i);
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
