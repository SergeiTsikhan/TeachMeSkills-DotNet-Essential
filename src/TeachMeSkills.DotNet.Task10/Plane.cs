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
    class Plane:Vehicle
    {
        private decimal _price;
        private double _speed;
        private DateTime _date;
        public Plane(decimal price, double speed, DateTime dateYear) : base(price, speed, dateYear)
        {
            _price = price;
            _speed = speed;
            _date = dateYear;
        }

        public int hieght { get; set; }
        public int sumOfPasanger { get; set; }

        public void showPlaneInfo()
        {
            Console.WriteLine("This is plane");
            Console.WriteLine($"Price Plane {_price}$");
            Console.WriteLine($"Speed Plane {_speed}");
            Console.WriteLine($"Date Plane {_date}");
            Console.WriteLine($"Height Plane {hieght}");
            Console.WriteLine($"SumofPasanger Plane {sumOfPasanger}");
        }

    }
}
