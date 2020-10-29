//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.
namespace TeachMeSkills.DotNet.Task3
{
    class Point
    {
        public int _point1;
        public int _point2;
        public string _name1;

        public Point(int point1, int point2, string name)
        {
            _point1 = point1;
            _point2 = point2;
            _name1 = name;
        }

        public int MyProperty { get;  }
        public int MyProperty2 { get; }
        public int MyProperty3 { get;  }
    }
}
