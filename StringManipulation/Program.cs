using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using StringManipulation.Programs;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();

            years.Add(1990);
            years.Add(1991);
            years.Add(1992);
            years.Add(1993);
            years.Add(1994);
            years.Add(1995);

            IEnumerable<int> ienum = (IEnumerable<int>)years;

        }
    }
}
