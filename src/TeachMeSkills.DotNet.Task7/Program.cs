using System;
//Используя Visual Studio, создайте проект по шаблону Console Application
//Требуется: Создать класс Invoice.
//В теле класса создать три поля int account, string customer, string provider,
//которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.


namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input article(X7,X8,X10,X11,X12):");
            Console.WriteLine("Input quantity: ");
            var byer = new Invoice(1, "Vasiliy", "5 Element")
            {
                article = Console.ReadLine().ToUpper(),
                quantity = Convert.ToInt32(Console.ReadLine()),
            };
            byer.GetInfo();



        }
    }
}
