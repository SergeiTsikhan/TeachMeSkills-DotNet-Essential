﻿using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс User, содержащий информацию о пользователе
//(логин, имя, фамилия, возраст, дата заполнения анкеты).
//Поле дата заполнения анкеты должно быть проинициализировано только один раз
//(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.


namespace TeachMeSkills.DotNet.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(DateTime.Now, "Valera2002", "Valera", "Khaletkiy", 22);
            user.GetInfo();
        }
    }
}
