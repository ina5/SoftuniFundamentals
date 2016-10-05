using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10RemoveNegativesAndReverse
{
    class _10RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listResult = new List<int>();
            nums.Reverse();
            for (int item = 0; item < nums.Count; item++)
            {
                if (nums[item] >= 0)
                {
                    listResult.Add(nums[item]);
                }
            }
            if (listResult.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ", listResult));


        }
    }
}
