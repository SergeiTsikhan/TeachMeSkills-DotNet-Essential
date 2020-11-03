using System;
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
    class Article
    {
        private string _productName;
        private string _scoreName;
        private decimal _cost;

        public Article(string productName, string scoreName, decimal cost)
        {
            _productName = productName;
            _scoreName = scoreName;
            _cost = cost;
        }
        public void ShowInformation()
        {
            Console.WriteLine($"Product name: {_productName}");
            Console.WriteLine($"Score name: {_scoreName}");
            Console.WriteLine($"Cost of product: {_cost}$");
        }
        public string Showproducname() => _productName;
    }
}
