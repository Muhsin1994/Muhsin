using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_point
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("Min value= {0} Max val= {1}", flMin, flMax);
            float flvar = 1F / 3;
            double dlvar = 1D / 3;
            decimal dcvar = 1M / 3;
            Console.WriteLine("float val={0}\ndouble value={1}\ndeciamal value ={2}", flvar, dlvar, dcvar);
            Console.ReadKey();

        }
    }
}
