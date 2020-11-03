using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
//Написать программу, которая выводит на экран основные арифметические операции.


namespace TeachMeSkills.DotNet.Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = default;
            Console.WriteLine(res.Sum(2,3));
            Console.WriteLine(res.Minus(30,20));
            Console.WriteLine(res.Multiplay(2,2));
            Console.WriteLine(res.Devided(12,2));

        }
    }
    public static class Calculator
    {
        public static int Sum(this int sum, int x, int y) => sum = x + y;
        public static int Minus(this int minus, int x, int y) => minus = x - y;
        public static int Multiplay(this int mult, int x, int y) => mult = x * y;

        public static int Devided(this int div, int x, int y) => div = x / y;

    }
}
