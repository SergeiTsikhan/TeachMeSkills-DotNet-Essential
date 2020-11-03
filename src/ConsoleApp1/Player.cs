//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создайте 2 интерфейса IPlayable и IRecodable.
//В каждом из интерфейсов создайте по 3 метода void Play()
// void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
//Написать программу, которая выполняет проигрывание и запись.

using System;

namespace ConsoleApp1
{

    class Player : IPlayable, IRecodable
    {
        public string station { get; set; } = "Unknown";
        public void Pause()
        {
            station = "Pause";
            Console.WriteLine($"Player now: {station}");
        }

        public void Play()
        {
            station = "Play";
            Console.WriteLine($"Player now: {station}");
        }

        public void Record()
        {
            station = "Record";
            Console.WriteLine($"Player now: {station}");
        }

        public void Stop()
        {
            station = "Record";
            Console.WriteLine($"Player now: {station}");
        }
    }
}
