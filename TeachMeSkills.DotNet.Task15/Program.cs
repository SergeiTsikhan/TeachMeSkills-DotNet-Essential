using System;
using System.Linq;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
//Вывести наибольшее значение массива, наименьшее значение массива,
//общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.

namespace TeachMeSkills.DotNet.Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            var massiv = new int[] { 1, 23, 4, 5, 6, 7, 78, 9, 9, 12, 13, 3, 4 };
            var res = massiv.Max();
            var res2 = massiv.Min<int>();
            var res3 = massiv.Sum();
            var res4 = massiv.Average();
            Console.WriteLine($"Max element: {res}");
            Console.WriteLine($"Min element: {res2}");
            Console.WriteLine($"Sum element: {res3}");
            Console.WriteLine($"Average element:{res4}");
            Console.WriteLine($"Not good element:");
            var result = massiv.GroupBy(n => n % 2 == 1);

            foreach (var x in result)
            {
                Console.WriteLine(x);
                foreach(var z in x)
                {
                    Console.WriteLine(z);
                }
            }


        }
    }
}
