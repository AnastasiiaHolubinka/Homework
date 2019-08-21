<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Task1_4_Rectangle
    {
        
        public static double ab(double x0, double y0)
        {
            double a = x0 - y0;
            if (a < 0) return a * (-1);
            else return a;
        }
        public static double Perimeter(double x, double y, double x1, double y1)
        {
            double p = 0.0;
            double a = ab(x, x1);
            double b = ab(y, y1);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Помилка. Це не прямокутник");
                return p;
            }

            else
                return 2 * (a + b);
        }
        public static double Square(double x, double y, double x1, double y1)
        {
            double s = 0.0;
            double a = ab(x, x1);
            double b = ab(y, y1);
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Помилка. Це не прямокутник");
                return s;
            }
            return (a * b);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Task1_4_Rectangle
    {
        
        public static double ab(double x0, double y0)
        {
            double a = x0 - y0;
            if (a < 0) return a * (-1);
            else return a;
        }
        public static double Perimeter(double x, double y, double x1, double y1)
        {
            double p = 0.0;
            double a = ab(x, x1);
            double b = ab(y, y1);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Помилка. Це не прямокутник");
                return p;
            }

            else
                return 2 * (a + b);
        }
        public static double Square(double x, double y, double x1, double y1)
        {
            double s = 0.0;
            double a = ab(x, x1);
            double b = ab(y, y1);
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Помилка. Це не прямокутник");
                return s;
            }
            return (a * b);
        }
    }
}
>>>>>>> cd72095c50cb1866cdb75d3278afa06980eaee6f
