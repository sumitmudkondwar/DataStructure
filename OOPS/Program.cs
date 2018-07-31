using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassB();
            Console.WriteLine(obj.Method1());
        }
    }

    public class ClassA
    {
        public virtual int Method1()
        {
            return 1;
        }
    }

    public class ClassB : ClassA
    {
        public override int Method1()
        {
            return 2;
        }
    }
}
