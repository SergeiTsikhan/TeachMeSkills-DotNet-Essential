﻿//```
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
//и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к BYN – public Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из BYN в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в BYN.
//```

namespace TeachMeSkills.DotNet.Task5
{
    enum Valut
    {
        usd = 1,
        eur = 2,
        rub = 3,
        byn = 4,
    }
}
