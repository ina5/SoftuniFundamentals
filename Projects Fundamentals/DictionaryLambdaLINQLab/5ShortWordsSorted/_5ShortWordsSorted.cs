using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ShortWordsSorted
{
    class _5ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
              .Split(".,:;()[]\"'!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
          .Where(w => w.Length < 5)
          .OrderBy(w => w)
          .Select(w => w.ToLower())
          .Distinct()
          .ToList();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
