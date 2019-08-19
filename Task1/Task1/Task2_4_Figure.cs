using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    interface IDrawable
    {
        void Draw();
    }
    class Figure : IDrawable
    {
        readonly int x;
        readonly int y;

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
            Console.WriteLine("Class name's is 'Figure'");
        }
    }
    class Square : Figure, IDrawable
    {
        public Square(int x, int y)
            : base(x, y) { }
        public void Draw()
        {
            Console.WriteLine("Class name's is 'Square'");
        }
    }
    class Rectangle : Figure, IDrawable
    {
        public Rectangle(int x, int y)
            : base(x, y) { }
        public void Draw()
        {
            Console.WriteLine("Class name's is 'Rectangle'");
        }
    }

}