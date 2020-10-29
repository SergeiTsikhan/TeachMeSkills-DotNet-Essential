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
    class Vehicle
    {
        private decimal _price;
        private double _speed;
        private DateTime _dateYear;

        public Vehicle()
        {
        }

        public Vehicle(decimal price, double speed, DateTime dateYear)
        {
            _price = price;
            _speed = speed;
            _dateYear = dateYear;
        }
    }
}
