using System;
using System.Linq;


//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: создать метод расширения для целочисленного массива,
//который сортирует элементымассива по возрастанию.


namespace TeachMeSkills.DotNet.Task18
{
    class Program
    {
        static void Main(string[] args)
       {
            var massiv1 = new int[] { 5, 2, 1, 4, 5, 1 };
            int[] res = massiv1.CharCount();
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
    public static class StringExtension
    {
        public static int[] CharCount(this int[]mas)
        {
            Array.Sort(mas);
            return mas;
        }
    }
}
