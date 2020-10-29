//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс Vehicle.
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

using System;

namespace TeachMeSkills.DotNet.Task10
{
    class Car : Vehicle
    {
        private Guid _weenNomer;
        private decimal _price;
        private double _speed;
        private DateTime _date;

        public Car(Guid weenNomer, decimal price, double speed, DateTime date)
        {
            _weenNomer = weenNomer;
            _price = price;
            _speed = speed;
            _date = date;
        }

        public string Color { get; set; }
        public int MaxSpeed { get; set; }

        public void ShowInfoAboutCar()
        {
            Console.WriteLine("This is car.");
            Console.WriteLine($"Your weenNomer:{_weenNomer} ");
            Console.WriteLine($"Car color:{Color}");
            Console.WriteLine($"Speed {_speed}");
            Console.WriteLine($"Date create {_date}");
            Console.WriteLine($"Max speed {MaxSpeed}");
        }

    }
}
