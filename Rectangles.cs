using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    //2) Класс «Прямоугольник на плоскости со сторонами, параллельными
    //   координатным осям». Наследует базовый класс. Первые два числа
    //   обозначают координаты левого верхнего, следующие два — координаты
    //   правого нижнего углов прямоугольника.
    //   Переопределить вывод. Методы: а) периметр; б) площадь; в) выбор из двух
    //   прямоугольников прямоугольника с наибольшей площадью.

    internal class Rectangles : BassedClass
    {
        public Rectangles(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }

        public Rectangles() : base() { }

        public int Perimeter()
        {
            int res = 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
            return res;
        }

        public int Square()
        {
            int x, y;
            x = Math.Abs(x1 - x2);
            y = Math.Abs(y1 - y2);
            return (x * y);
        }

        public static Rectangles CompareSquares(Rectangles rectangle1, Rectangles rectangle2)
        {
            return rectangle1.Square() > rectangle2.Square() ? rectangle1 : rectangle2;
        }
    }
}
