//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.
//Для каждого поля, создать свойство с двумя методами доступа.
//Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.

using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Address
    {
        public int index { get; set; }
        public string country { get; set; }

        public string city { get; set; }

        public string street { get; set; }
        public int house { get; set; }

        public int apartmen { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"You Addres:{street},{house},{apartmen}");
        }
    }
}
