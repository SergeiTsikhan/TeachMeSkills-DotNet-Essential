using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс Vehicle.
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

namespace TeachMeSkills.DotNet.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(Guid.NewGuid(),120,220,DateTime.Now)
            {
                Color = "Blue",
                MaxSpeed = 220,
            };

            var ship = new Ship(200, 120, DateTime.Now)
            {
                pasanger = 120,
                Port = "Zimbabve"
            };

            var plane = new Plane(600, 1200, DateTime.Now)
            {
                hieght = 120,
                sumOfPasanger = 80
            };

            car.ShowInfoAboutCar();
            Console.WriteLine("========");
            ship.ShowInfo();
            Console.WriteLine("========");
            plane.showPlaneInfo();

        }
    }
}
