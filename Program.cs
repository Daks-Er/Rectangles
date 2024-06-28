namespace Rectangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangles rect1 = new Rectangles();
            Rectangles rect2 = new Rectangles();

            Console.WriteLine("Координаты 1-го прямоугольника: " + rect1);
            Console.WriteLine("Координаты 2-го прямоугольника: " + rect2);
            Console.WriteLine();

            Console.WriteLine("Периметр 1-го прямоугольника равен " + rect1.Perimeter());
            Console.WriteLine();

            Console.WriteLine("Площадь 1-го прямоугольника равна " + rect1.Square());
            Console.WriteLine("Площадь 2-го прямоугольника равна " + rect2.Square());
            Console.WriteLine();

            Console.WriteLine("Прямоугольник с наибольшей площадью: " + Rectangles.CompareSquares(rect1, rect2));
        }
    }
}
