using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
/// Создать классы Point и Figure. 
/// Класс Point должен содержать два целочисленных поля и одно строковое поле. 
/// Создать три свойства с одним методом доступа get. 
/// Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов. 
/// Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
/// Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; 
/// void PerimeterCalculator(), который рассчитывает периметр многоугольника. 
/// Написать программу, которая выводит на экран название и периметр многоугольника. 
/// </summary>
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 0, "Figure1");
            Point point2 = new Point(0, 2, "Figure1");
            Point point3 = new Point(3, 0, "Figure1");

            Figure figure1 = new Figure(new Point[] { point1, point2, point3 });
            figure1.PerimeterCalculator();
            Console.ReadKey();
        }
    }
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public string S { get; }
        public Point(int x, int y, string s)
        {
            X = x;
            Y = y;
            S = s;
        }
    }
    class Figure
    {
        string name;
        private List<Point> points;
        public double perimetr { get; }
        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }
        public Figure(Point[] args)
        {
            points = args.ToList<Point>();
            name = args[0].S;
        }
        public void PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 0; i < points.Count; i++)
            {
                sum += LengthSide(points[i], points[i == points.Count() - 1 ? 0 : i + 1]);
            }
            Console.WriteLine($"Периметр многоугольника {name}: {sum}");

        }
    }
}
