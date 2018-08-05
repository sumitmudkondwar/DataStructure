using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface Iset
    {
        void Print();
    }
    
    public class Service : Iset
    {
        public void Print()
        {
            Console.WriteLine("Success...");
        }
    }

    public class ServiceNew : Iset
    {
        public void Print()
        {
            Console.WriteLine("Success new...");
        }
    }

    public class client
    {
        private Iset _set;
        public void run(Iset serv)
        {
            this._set = serv;
            Console.WriteLine("Start...");
            this._set.Print();
        }
    }
}
