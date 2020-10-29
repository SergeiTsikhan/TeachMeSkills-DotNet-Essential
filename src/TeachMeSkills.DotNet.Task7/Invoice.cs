using System;
using System.Collections.Generic;
using System.Text;
//Используя Visual Studio, создайте проект по шаблону Console Application
//Требуется: Создать класс Invoice.
//В теле класса создать три поля int account, string customer, string provider,
//которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.


namespace TeachMeSkills.DotNet.Task7
{
    class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private readonly string _provider;
        private readonly int  _nds= 18;
        private Iphone _iphone = Iphone.Unknown;
        private int _sumNoNds;
        private int _sumWithNds;




        public Invoice(int account, string customer, string provider)
        {
            _account = account;//счет
            _customer = customer;//Покупатель
            _provider = provider;//Поставщик
        }

        private string _article;//Изделие
        private int _quantity;// Количество


        public int quantity { get; set; }
        public string  article { get; set; }

        public void GetQuantity()
        {
            _quantity = quantity;
        }
        public void GetArticle()
        {
            _article = article;
        }

        public void jobWithArticle()
        {
           _sumNoNds = SwtithArticle() * _quantity;
           _sumWithNds = _sumNoNds - _sumNoNds / 100 * _nds;
        }

        public int SwtithArticle()
        {
            return article switch
            {
                "X7"=>(int)Iphone.X7,
                "X8"=>(int)Iphone.X8,
                "X10"=>(int)Iphone.X10,
                "X11"=>(int)Iphone.X11,
                "X12"=>(int)Iphone.X12,
                _=>(int)Iphone.Unknown
            };
        }

        public void GetInfo()
        {
            GetQuantity();
            GetArticle();
            jobWithArticle();

            Console.WriteLine($"Number of accaunt:{_account}");
            Console.WriteLine($"You:{_customer}");
            Console.WriteLine($"Provider:{_provider} ");
            Console.WriteLine($"Producte:{_article}");
            Console.WriteLine($"Quantity:{_quantity}");
            Console.WriteLine($"Sum wit NDS:{_sumNoNds}");
            Console.WriteLine($"Sum with NDS:{_sumWithNds}");


        }

    }
}
