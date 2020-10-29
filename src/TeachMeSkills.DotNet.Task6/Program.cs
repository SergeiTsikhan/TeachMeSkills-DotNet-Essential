using System;
using TeachMeSkills.DotNet.Task6.Logic;
//```
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс Employee.
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
//Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор.
//```

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Employee("Vadim", "Ivashuk")
            { 
                function=Function.BA,
            };
            manager.GetInfo();
        }
    }
}
