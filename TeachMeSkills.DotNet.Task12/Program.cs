using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создайте класс Printer.
//В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов,
//и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
//выводились разными цветами.
//Обязательно используйте приведение типов.

namespace TeachMeSkills.DotNet.Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var print = new printBlue("Blue");
            print.Print("Blue");
            Console.ResetColor();
            var print1 = new PrintGreen("Green");
            print.Print("Green");
            Console.ResetColor();



            Console.ReadKey();
        }
    }
}
