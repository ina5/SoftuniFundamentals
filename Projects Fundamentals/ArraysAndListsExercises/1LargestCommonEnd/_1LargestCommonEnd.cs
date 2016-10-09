using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1LargestCommonEnd
{
    class _1LargestCommonEnd
    {
        static void Main(string[] args)
        {
            var words1 = Console.ReadLine().Split(' ').ToList();
            var words2 = Console.ReadLine().Split(' ').ToList();
            var count = 0;

            if (words1.Count == words2.Count)
            {
                for (int i = 0; i < words1.Count; i++)
                {
                    if (words1[i] == words2[i])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = words1.Count - 1; i >= 0; i--)
                {
                    if (words1[i] == words2[i])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
               
                    if (words1.Count > words2.Count)
                    {
                 //   1 обратен цикъл и на по-дългия лист в елементите добавям разликата на дължините
                    }
              }
            Console.WriteLine(count);

        }
    }
}
