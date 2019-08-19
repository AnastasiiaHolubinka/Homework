using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1_2_Rectangle
    {
        public double x { get; set; }
        public double y { get; set; }
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double perimeter { get; set; }
        public double square { get; set; }

        public Task1_2_Rectangle()
        {
            x = 0.0;
            y = 0.0;
            x1 = 0.0;
            y1 = 0.0;
            perimeter = 0.0;
            square = 0.0;
        }
        public Task1_2_Rectangle(double x, double y, double x1, double y1)
        {
            this.x = x;
            this.y = y;
            this.x1 = x1;
            this.y1 = y1;
        }

        public double ab(double x0, double y0)
        {
            double a = x0 - y0;
            if (a < 0) return a * (-1);
            else return a;
        }
               
        public double Perimeter()
        {
            double p = 0.0;
            double a = ab(this.x, this.x1);
            double b = ab(this.y, this.y1);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Помилка. Це не прямокутник");
                return p;
            }

            else
                return 2 * (a + b);
        }

        public double Square()
        {
            double s = 0.0;
            double a = ab(this.x, this.x1);
            double b = ab(this.y, this.y1);
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Помилка. Це не прямокутник");
                return s;
            }
            return (a * b);
        }
        public void Reac()
        {
            perimeter = this.Perimeter();
            square = this.Square();
        }
    }
}
