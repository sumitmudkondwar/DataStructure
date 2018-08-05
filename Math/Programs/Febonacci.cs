using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Programs
{
    public class Febonacci
    {
        public void Print(int numb)
        {
            int first = 0;
            int second = 1;
            int temp = 0;
            string output = string.Empty;

            if (numb > 0)
            {
                while (numb > 0)
                {
                    if (output.Equals(string.Empty))
                    {
                        output = output + " " + first + " " + second;
                    }
                    else
                    {
                        output = output + " " + second;
                    }

                    //0 1 1 2 3 5 8 13 
                    temp = second;
                    second = first + second;
                    first = temp;

                    numb--;
                }
            }

            Console.WriteLine(output);
        }

        public void print1()
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Enter the Limit : ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= count; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();
        }
    }
}
