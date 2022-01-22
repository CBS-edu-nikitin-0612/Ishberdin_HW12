using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.Требуется: 
/// Создать класс с именем Rectangle. В теле класса создать два поля, описывающие длины сторон double side1, side2. 
/// Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов. 
/// Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator(). 
/// Создать два свойства double Area и double Perimeter с одним методом доступа get. 
/// Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. 
/// </summary>
namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
           // string input;
            double side1, side2;

            side1 = Convert.ToDouble(Console.ReadLine());
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle Form = new Rectangle(side1, side2);
            Console.WriteLine(Form.Perimeter);
            Console.WriteLine(Form.Area);
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        private double side1, side2;

        public double Area => AreaCalculator();
        public double Perimeter => PerimeterCalculator();

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        private double AreaCalculator() { return side1 * side2; }
        private double PerimeterCalculator() { return (side1 + side2) * 2; }
    }
}
