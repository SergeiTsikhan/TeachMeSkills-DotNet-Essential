//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс User, содержащий информацию о пользователе
//(логин, имя, фамилия, возраст, дата заполнения анкеты).
//Поле дата заполнения анкеты должно быть проинициализировано только один раз
//(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.

using System;

namespace TeachMeSkills.DotNet.Task8
{
    class User
    {
        private readonly DateTime _date;

        public User(DateTime date, string login, string name, string serName, int age)
        {
            _date = date;
            Login = login;
            Name = name;
            SerName = serName;
            Age = age;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public string SerName { get; set; }
        public int Age { get; set; }


        public void GetInfo()
        {
            Console.WriteLine($"Your name:{Name}");
            Console.WriteLine($"Your sername:{SerName}");
            Console.WriteLine($"Your age:{Age}");
            Console.WriteLine($"Your login:{Login}");
            Console.WriteLine($"Date time now:{_date}");
        }

    }
}
