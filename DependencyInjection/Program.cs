using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            client cn = new client();
            cn.run(new Service());
            Console.ReadKey();
        }
    }
}
