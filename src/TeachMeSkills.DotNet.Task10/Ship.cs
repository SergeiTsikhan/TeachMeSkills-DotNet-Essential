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
    class Ship : Vehicle
    {
        private decimal _price;
        private double _speed;
        private DateTime _date;

        public Ship(decimal price, double speed, DateTime dateYear) : base(price, speed, dateYear)
        {
            _price = price;
            _speed = speed;
            _date = dateYear;
        }
        public int pasanger { get; set; }
        public string Port { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("This is ship ");
            Console.WriteLine($"Ship price {_price}");
            Console.WriteLine($"Ship speed {_speed}");
            Console.WriteLine($"Ship timecreate {_date}");
            Console.WriteLine($"Ship pasanger {pasanger} ");
            Console.WriteLine($"Ship port {Port} ");


        }

    }
}
