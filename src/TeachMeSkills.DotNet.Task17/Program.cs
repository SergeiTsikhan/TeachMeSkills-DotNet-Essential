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
/// <summary>
///Доделать возможность добавление продуктов как в зоопарке.
/// </summary>
     class Program
    {
        static void Main(string[] args)
        {
            var product = new Article("Monitor", "5 elemnt", 120);
            var product2 = new Article("Mouse", "5 elemnt", 10);
            var store = new Store();
            store.addProduct(product);
            store.addProduct(product2);
            store.showInfo();
            store.ChekInputUser();
            store.ChekUserInputID();
        }
    }
}
