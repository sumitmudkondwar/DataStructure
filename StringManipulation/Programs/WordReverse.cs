using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Programs
{
    /// <summary>
    /// this class is to reverse the words of a string
    /// e.g.
    /// Input: "Hi I am Sumit!"
    /// Output: "Sumit! am I Hi"
    /// </summary>
    public class WordReverse
    {
        public void SentenceReverse()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Eneter the String:");

            Console.ForegroundColor = ConsoleColor.Yellow;

            string s = Console.ReadLine();

            string[] a = s.Split(' ');

            Array.Reverse(a);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Reverse String is:");

            for (int i = 0; i <= a.Length - 1; i++)

            {

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write(a[i] + "" + ' ');

            }

            Console.ReadKey();
        }
    }

    public abstract class Myclass
    {
        public static void Mehotd1()
        {

        }
    }
}
