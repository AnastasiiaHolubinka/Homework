using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class AvtoRun
    {
        public static void Run()
        {
            Console.WriteLine("\nTask1(Лекцiя 1): ");

            double x = 10;
            double y = 1;
            Console.WriteLine("Координати лiвого верхнього кута: (" + x + ", " + y + ")");

            double x1 = 5;
            double y1 = -8;
            Console.WriteLine("Kоординати правого нижнього кута: (" + x1 + ", " + y1 + ")");
            Task1_1_Rectangle React = new Task1_1_Rectangle(x, y, x1, y1);
            Console.WriteLine("Периметр: " + React.Perimeter());
            Console.WriteLine("Площа: " + React.Square());

            Console.WriteLine("\nTask2(Лекцiя 1): ");

            Task1_2_Rectangle React1 = new Task1_2_Rectangle();

            React1.x = 5;
            React1.y = 5;
            Console.WriteLine("Координати лiвого верхнього кута: (" + React1.x + ", " + React1.y + ")");
            Console.WriteLine("Введiть координати правого нижнього кута: ");
            React1.x1 = -2;
            React1.y1 = -3;
            Console.WriteLine("Kоординати правого нижнього кута: (" + React1.x1 + ", " + React1.y1 + ")");
            React1.Reac();
            Console.WriteLine("Периметер прямокутника: " + React1.perimeter);
            Console.WriteLine("Площа прямокутника: " + React1.square);

            Console.WriteLine("\nTask3(Лекцiя 1): ");

            Task1_3_Circle circ = new Task1_3_Circle();

            double r = 5;
            Console.WriteLine("Pадiус кола: " + r);
            if (r <= 0) { Console.WriteLine("Коло/круг з '" + r + "' радiусом не iснує"); }
            else
            {
                Console.WriteLine("Довжина кола: " + circ.C(r));
                Console.WriteLine("Площа круга: " + circ.S(r));
            }

            Console.WriteLine("\nTask4(Лекцiя 1): ");

            x = 10;
            y = 1;
            Console.WriteLine("Координати лiвого верхнього кута: (" + x + ", " + y + ")");

            x1 = 5;
            y1 = -8;
            Console.WriteLine("Kоординати правого нижнього кута: (" + x1 + ", " + y1 + ")");
            Console.WriteLine("Периметер прямокутника: " + Task1_4_Rectangle.Perimeter(x, y, x1, y1));
            Console.WriteLine("Площа прямокутника: " + Task1_4_Rectangle.Square(x, y, x1, y1));

            r = 5;
            Console.WriteLine("Pадiус кола: " + r);
            if (r <= 0) { Console.WriteLine("Коло/круг з '" + r + "' радiусом не iснує"); }
            else
            {
                Console.WriteLine("Довжина кола: " + Task1_4_Circle.C(r));
                Console.WriteLine("Площа круга: " + Task1_4_Circle.S(r));
            }

            Console.WriteLine("\nTask5(Лекцiя 1): ");

            r = 10;
            double i = 1;
            Console.WriteLine("Комплексне число: " + r + " + i" + i);
            Task1_5_ComplexNumber a = new Task1_5_ComplexNumber(r, i);

            r = 2;
            i = 3;
            Console.WriteLine("Комплексне число: " + r + " + i" + i);
            Task1_5_ComplexNumber b = new Task1_5_ComplexNumber(r, i);
            Task1_5_ComplexNumber c = a * b;
            Task1_5_ComplexNumber d = a / b;
            Console.WriteLine("(" + a.real + " + " + a.imaginary + "i) * (" + b.real + " + " + b.imaginary + "i) = (" + c.real + " + " + c.imaginary + "i)");
            Console.WriteLine("(" + a.real + " + " + a.imaginary + "i) / (" + b.real + " + " + b.imaginary + "i) = (" + Math.Round(d.real, 2) + " + " + Math.Round(d.imaginary, 2) + "i)");

            Console.WriteLine("\nTask1(Лекцiя 2): ");

            Task2_1.Rectangle R = new Task2_1.Rectangle();
            R.Draw();
            Task2_1.Square S = new Task2_1.Square();
            S.Draw();

            Console.WriteLine("\nTask2(Лекцiя 2): ");

            Task2_2.Rectangle R1 = new Task2_2.Rectangle(1, 2);
            R1.Draw();
            Task2_2.Square S1 = new Task2_2.Square(1, 2);
            S1.Draw();

            Console.WriteLine("\nTask3(Лекцiя 2): ");

            Task2_3.Figure F = new Task2_3.Figure(1, 2);
            F.Draw();
            Task2_3.Rectangle R2 = new Task2_3.Rectangle(1, 2);
            R2.Draw();
            Task2_3.Square S2 = new Task2_3.Square(1, 2);
            S2.Draw();

            Console.WriteLine("\nTask4(Лекцiя 2): ");

            Task2_4.IDrawable[] ID = new Task2_4.IDrawable[3];
            ID[0] = new Task2_4.Figure(1, 2);
            ID[1] = new Task2_4.Rectangle(1, 2);
            ID[2] = new Task2_4.Square(1, 2);
            Program.DrawAll(ID);

            Console.WriteLine("\nTask1(Лекцiя 3): ");

            Persons Persons_ = new Persons();
            Console.WriteLine(Persons_.PrintOutNameAge());

            Console.WriteLine("\nTask2(Лекцiя 3): ");

            Persons Persons_1 = new Persons();
            Persons_1.addTwo();
            Console.WriteLine(Persons_1.PrintOutPhoneNumber());

            Console.WriteLine("\nTask3(Лекцiя 3): ");

            int N = 1000;
            Console.WriteLine("Kiлькiсть елементiв списку: " + N);
            int n = 4;
            Console.WriteLine("Kiлькiсть знакiв в елементi: " + n);
            RandomS RS = new RandomS(N, n);
            Console.WriteLine("Було створено :" + N + ";\nПiсля оптимiзацiї: " + RS.Clean() + ";");
            while (true)
            {
                int pageNumber = 3;
                Console.WriteLine("Cторiнка: " + pageNumber);

                Console.WriteLine(RS.DisplayPage(pageNumber));
                break;
            }

        }
    }
}
