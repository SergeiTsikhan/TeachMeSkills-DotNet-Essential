﻿//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создайте класс Printer.
//В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов,
//и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
//выводились разными цветами.
//Обязательно используйте приведение типов.

using System;

namespace TeachMeSkills.DotNet.Task12
{
    class printBlue : Printer
    {
        public printBlue(string color) : base(color)
        {
        }

        public override void Print(string color)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(color);
        }
   

    }
}
