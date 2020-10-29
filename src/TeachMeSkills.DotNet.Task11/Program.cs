using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создайте класс DocumentWorker.
//В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
//Тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".
//Создайте производный класс ProDocumentWorker.
//Переопределите соответствующие методы, при переопределении методов выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт".
//Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
//Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате".
//В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
//Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.

namespace TeachMeSkills.DotNet.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput();
        }
        static void UserInput()
        {
            Console.WriteLine("Input Key");
            int key;
            string keystring = Console.ReadLine();
            bool chek = int.TryParse(keystring, out key);
            if(chek)
            {
                if (keystring.Length < 8)
                {
                    var prodocument = new ProDocument();
                    prodocument.ShowInfo1();
                }
                else
                {
                    var expertdocument = new ExpertDocumentWorker();
                    expertdocument.ShowInfo2();
                }

            }
            else
            {
                var simpledocument = new DocumentWorker();
                simpledocument.ShowDelegate();

            }

        }
    }
}
