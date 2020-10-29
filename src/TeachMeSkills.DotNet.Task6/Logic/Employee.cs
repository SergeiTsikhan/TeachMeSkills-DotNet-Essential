using System;
using System.Collections.Generic;
using System.Text;
//```
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс Employee.
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
//Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор.
//```

namespace TeachMeSkills.DotNet.Task6.Logic
{
    class Employee
    {
        private string _name;
        private string _sername;
        private double _functionvisnalog;
        private readonly double _nalogProcent = 18;
        public Function function { get; set; }
        public Employee(string name, string sername)
        {
            _name = name;
            _sername = sername;
        }
        public void GetFunctinalcWithNalog()
        {
            _functionvisnalog = (int)function /100 * _nalogProcent;
        }



        public void GetInfo()
        {
            GetFunctinalcWithNalog();
            Console.WriteLine($"Your name:{_name}");
            Console.WriteLine($"Your sername:{_sername}");
            Console.WriteLine($"Your functional:{function} ");
            Console.WriteLine($"Your money:{(int)function}");
            Console.WriteLine($"Your money with nalog:{(int)function - _functionvisnalog}");
            Console.WriteLine($"Your nalog:{_nalogProcent}");

        }
    }
}
