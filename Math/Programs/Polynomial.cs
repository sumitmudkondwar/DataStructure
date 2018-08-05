using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Programs
{
    public class Polynomial
    {
        public int GetPolynomial(int num)
        {
            int result = 0;
            int reminder = 0;

            while (num > 0)
            {
                reminder = num % 10;
                result = result * 10 + reminder;
                num = num / 10;
            }

            return result;
        }
    }
}
