using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Task1_4_Circle
    {
        const double pi = 3.14159;

       public static double S(double r)
        {
            return pi * r * r;
        }
       public static double C(double r)
        {
            return 2 * pi * r;
        }
    }
}
