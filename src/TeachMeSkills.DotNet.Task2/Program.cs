using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
//```

namespace TeachMeSkills.DotNet.Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            var title = new Title()
            {
                title = "C# Learning"
            };
            var author = new Author()
            {
                author = "Troelson"
            };
            var content = new Content()
            {
                content = "Very goog book.Very goog book.Very goog book." +
                "sVery goog book.Very goog book.Very goog book.Very goog book." +
                "Very goog book.Very goog book."
            };
            ResetColor(title, author, content);
        }

        /// <summary>
        /// Set color.
        /// </summary>
        static void ResetColor(Title title, Author author, Content content )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            title.Show();
            Console.ResetColor();
            Console.WriteLine("  ");
            Console.ForegroundColor = ConsoleColor.Red;
            author.Show();
            Console.ResetColor();
            Console.WriteLine("  ");
            Console.ForegroundColor = ConsoleColor.Green;
            content.Show();
            Console.ResetColor();
        }

    }
}
