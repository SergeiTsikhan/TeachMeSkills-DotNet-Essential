using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
//Написать программу, выполняющую следующие действия: ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов); вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение).

namespace TeachMeSkills.DotNet.Task20
{
    class Program
    {
        public struct Train
        {
            public string nameOfPosition;
            public  int numberOfTrain;
            public  DateTime date;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input your train...");
            Train[] train =
            {
               new Train
               {
                   nameOfPosition =Console.ReadLine(),
                   numberOfTrain = Convert.ToInt32(Console.ReadLine()),
                   date =Convert.ToDateTime(Console.ReadLine()),
               },
                new Train
               {
                   nameOfPosition =Console.ReadLine(),
                   numberOfTrain = Convert.ToInt32(Console.ReadLine()),
                   date =Convert.ToDateTime(Console.ReadLine()),
               },

            };

            Console.WriteLine("Введите номер поезда...");
            string number = Console.ReadLine();
            foreach(var i in train)
            {
                if (i.numberOfTrain.ToString() == number)
                {
                    Console.WriteLine(train[int.Parse(number) - 1].nameOfPosition + " " + train[int.Parse(number) - 1].numberOfTrain + " " + train[int.Parse(number) - 1].date.ToLongDateString());
                }
                else
                {
                    Console.WriteLine("Not this train");
                }

            }
        }
    }

}
