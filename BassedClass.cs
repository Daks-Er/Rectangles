using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    //1) Создать базовый класс с четырьмя целыми полями. Разработать два
    //   конструктора: первый – без параметров – заполняет поля случайными
    //   данными; второй – с четырьмя параметрами – конструктор копирования.
    //   Перегрузить метод ToString() для формирования строки из полей класса.

    internal class BassedClass
    {
        protected int x1, y1, x2, y2;

        public BassedClass()
        {
            Random rand = new Random();
            x1 = rand.Next(-101, 1);
            y1 = rand.Next(0, 101);
            x2 = rand.Next(0, 101);
            y2 = rand.Next(-101, 1);
        }

        public BassedClass(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override string ToString()
        {
            return $"(x1 = {x1}; y1 = {y1}; x2 = {x2}; y2 = {y2})";
        }

        public int X1
        {
            get
            {
                return x1;
            }
        }
        public int Y1
        {
            get
            {
                return y1;
            }
        }
        public int X2
        {
            get
            {
                return x2;
            }
        }
        public int Y2
        {
            get
            {
                return y2;
            }
        }
    }
}
