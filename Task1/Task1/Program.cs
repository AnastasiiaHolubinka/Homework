using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            bool exit = true;
            Console.WriteLine("Виберiть:" +
                "\nВихiд - 0;" +
                "\nTask1_1_Rectangle - 1;" +
                "\nTask1_2_Rectangle - 2;" +
                "\nTask1_3_Circle - 3;" +
                "\nTask1_4.1_Rectangle - 41;" +
                "\nTask1_4.2_Circle - 42;" +
                "\nTask1_5_ComplexNumber - 5;\n" +
                "\nTask2_1: Унаслiдування - 6;" +
                "\nTask2_2: Унаслiдування - 7;" +
                "\nTask2_3: Унаслiдування - 8;" +
                "\nTask2_3: Унаслiдування - 9;\n");
            while (exit)
            {
                try
                {
                    Console.WriteLine("\nВиберiть опцiю");
                    i = Convert.ToInt32(Console.ReadLine());
                    switch(i)
                    {
                        case 0:
                            {
                                exit = false;
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("Введiть координати лiвого верхнього кута:");
                                Console.WriteLine("Введiть x:");
                                double x = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть y:");
                                double y= Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть координати правого нижнього кута:");
                                Console.WriteLine("Введiть x1:");
                                double x1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть y1:");
                                double y1 = Convert.ToDouble(Console.ReadLine());
                                Task1_1_Rectangle React = new Task1_1_Rectangle(x, y, x1, y1);
                                Console.WriteLine("Периметр: " + React.Perimeter());
                                Console.WriteLine("Площа: " + React.Square());
                                break;
                            }
                        case 2:
                            {
                                Task1_2_Rectangle React1 = new Task1_2_Rectangle();
                                Console.WriteLine("Введiть координати лiвого верхнього кута:");
                                Console.WriteLine("Введiть x:");
                                React1.x = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть y:");
                                React1.y = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть координати правого нижнього кута:");
                                Console.WriteLine("Введiть x1:");
                                React1.x1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть y1:");
                                React1.y1 = Convert.ToDouble(Console.ReadLine());
                                React1.Reac();
                                Console.WriteLine("Периметр: " + React1.perimeter);
                                Console.WriteLine("Площа: " + React1.square);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Введiть радiус: ");
                                double r = Convert.ToDouble(Console.ReadLine());
                                Task1_3_Circle circ = new Task1_3_Circle();
                                Console.WriteLine("Довжина кола: " + circ.C(r));
                                Console.WriteLine("Площа круга: " + circ.S(r));
                                break;
                            }
                        case 41:
                            {
                                Console.WriteLine("Введiть координати лiвого верхнього кута:");
                                Console.WriteLine("Введiть x:");
                                double x = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть y:");
                                double y = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть координати правого нижнього кута:");
                                Console.WriteLine("Введiть x1:");
                                double x1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть y1:");
                                double y1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Периметр: " + Task1_4_Rectangle.Perimeter(x, y, x1, y1));
                                Console.WriteLine("Площа: " + Task1_4_Rectangle.Square(x, y, x1, y1));
                                break;
                            }
                        case 42:
                            {
                                Console.WriteLine("Введiть радiус: ");
                                double r = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Довжина кола: " + Task1_4_Circle.C(r));
                                Console.WriteLine("Площа круга: " + Task1_4_Circle.S(r));
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Введiть число: ");
                                Console.WriteLine("Введiть дiйсне число:");
                                double re = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть уявне число:");
                                double im = Convert.ToDouble(Console.ReadLine());
                                Task1_5_ComplexNumber a = new Task1_5_ComplexNumber(re, im);
                                Console.WriteLine("Введiть число: ");
                                Console.WriteLine("Введiть дiйсне число:");
                                re = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введiть уявне число:");
                                im = Convert.ToDouble(Console.ReadLine());
                                Task1_5_ComplexNumber b = new Task1_5_ComplexNumber(re, im);
                                Task1_5_ComplexNumber mul = a * b;
                                Task1_5_ComplexNumber div = a / b;
                                Console.WriteLine("(" + a.real + " + " + a.imaginary + "i) * (" + b.real + " + " + b.imaginary + "i) = (" + mul.real + " + " + mul.imaginary + "i)");
                                Console.WriteLine("(" + a.real + " + " + a.imaginary + "i) / (" + b.real + " + " + b.imaginary + "i) = (" + Math.Round(div.real,2) + " + " + Math.Round(div.imaginary,2) + "i)");
                                break;
                             }
                        case 6:
                            {

                                Task2_1.Rectangle R = new Task2_1.Rectangle();
                                R.Draw();
                                Task2_1.Square S = new Task2_1.Square();
                                S.Draw();
                                break;
                            }
                        case 7:
                            {

                                Task2_2.Rectangle R = new Task2_2.Rectangle(1, 2);
                                R.Draw();
                                Task2_2.Square S = new Task2_2.Square(1, 2);
                                S.Draw();
                                break;
                            }
                        case 8:
                            {
                                Task2_3.Figure F = new Task2_3.Figure(1, 2);
                                F.Draw();
                                Task2_3.Rectangle R = new Task2_3.Rectangle(1, 2);
                                R.Draw();
                                Task2_3.Square S = new Task2_3.Square(1, 2);
                                S.Draw();
                                break;
                            }
                        case 9:
                            {
                                Task2_4.IDrawable[] ID = new Task2_4.IDrawable[3];
                                ID[0] = new Task2_4.Figure(1, 2);
                                ID[1] = new Task2_4.Rectangle(1, 2);
                                ID[2] = new Task2_4.Square(1, 2);
                                DrawAll(ID);
                                break;
                            }
                        default: break;
                    }

                }

                catch (FormatException e)
                {
                    Console.WriteLine(e + "\nПомилка. Введiть правильнi данi");
                }
            }
        }
        public static void DrawAll(Task2_4.IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i].Draw();
        }
    }
}
