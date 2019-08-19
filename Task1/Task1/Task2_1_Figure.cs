using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    abstract class Figure
{
    public abstract void Draw();

}
class Square : Figure
{
    public override void Draw()
    {
        Console.WriteLine("Class name's is 'Square'");
    }
}
class Rectangle : Figure
{
    public override void Draw()
    {
        Console.WriteLine("Class name's is 'Rectangle'");
    }
}
}
