using System;
using System.Collections.Generic;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Article, содержащий следующие закрытые поля: название товара;
//название магазина, в котором продается товар; стоимость товара в BYN.
//Создать класс Store, содержащий закрытый массив элементов типа Article.
//Обеспечить следующие возможности: вывод информации о товаре по номеру с помощью индекса;
//вывод на экран информации о товаре, название которого введено с клавиатуры,
//если таких товаров нет, выдать соответствующее сообщение;
//Написать программу, вывода на экран информацию о товаре.


namespace TeachMeSkills.DotNet.Task17
{
    class Store
    {
        private List<Article> products = new List<Article>();
        public void addProduct(Article product)
        {
            products.Add(product);
        }
        public void delProduct(Article product)
        {
            products.Remove(product);
        }
        public void showInfo()
        {
            foreach(var product in products)
            {
                 product.ShowInformation();
            }
        }
        public string InputName()
        {
            Console.WriteLine("Input product name: ");
            string name = Console.ReadLine();
            return name;
        }
        public string InputID()
        {
            Console.WriteLine("Input product code: ");
            string name = Console.ReadLine();
            return name;
        }
        public void ChekUserInputID()
        {
            int chek = 0;
            string nameproduct = InputID();
            var massiv = products.ToArray();
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i.ToString().ToLower() == nameproduct.ToLower())
                {
                    var product = massiv[i];
                    product.ShowInformation();
                    chek = 1;
                    break;
                }
            }
            if (chek == 0)
                Console.WriteLine("Element not found");

        }
        public void ChekInputUser()
        {
            int chek = 0;
            string productname = InputName();
            foreach (var product in products)
            {
                product.Showproducname();
                if (product.Showproducname().ToLower() == productname.ToLower())
                {
                    product.ShowInformation();
                    chek = 1;
                    break;
                }
            }
            if (chek == 0)
                Console.WriteLine("Element not found");
        }

    }
}
