using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = args[0];
            var age  = int.Parse(args[1]);
            var isw  = bool.Parse(args[2]);
            var agep = 65;
            if (isw) {
                agep = 63;
            }
            var result = string.Format("{0}, тебе работать ещё {1}", 
                name,
                (agep-age)
                );
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
