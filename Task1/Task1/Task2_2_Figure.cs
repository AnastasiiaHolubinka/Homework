using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    abstract class Figure
    {
        readonly int x;
        readonly int y;

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Draw();

    }
    class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("Class name's is 'Square'");
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("Class name's is 'Rectangle'");
        }
    }
}
