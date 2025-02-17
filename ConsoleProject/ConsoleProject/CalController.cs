using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class CalController
    {
        Calculater CAL;
        public CalController()
        {
            CAL = new Calculater();
        }

        public int Add(int a, int b)
        {
            return CAL.Add(a, b);
        }
    }
}
