using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.
//Для каждого поля, создать свойство с двумя методами доступа.
//Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.


namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myhouse = new Address()
            {
                index = Convert.ToInt32(Console.ReadLine()),
                country = Console.ReadLine(),
                city = Console.ReadLine(),
                street = Console.ReadLine(),
                house = Convert.ToInt32(Console.ReadLine()),
                apartmen = Convert.ToInt32(Console.ReadLine()),
            };

            myhouse.ShowInfo();
        }
    }
}
