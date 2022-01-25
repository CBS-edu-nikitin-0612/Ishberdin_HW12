using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
/// Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show(). 
/// Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
/// Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание. 
/// </summary>
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.author.Value = "Пушкин";
            book1.title.Value = "Мороз и солнце";
            book1.content.Value = "Мороз и солце день чудесный\n" +
                "Еще ты дремлешь...";
            book1.Show();

            Console.ReadKey();
        }
    }
    class Parametr
    {
        public string Value { get; set; }
        public void Show() { Console.WriteLine(Value + "\n"); }
    }
    class Book
    {
        public Title title = null;
        public Author author;
        public Content content;
        public class Title : Parametr { }
        public class Author : Parametr { }
        public class Content : Parametr { }
        public Book()
        {
            title = new Title();
            author = new Author();
            content = new Content();
        }
        public void Show()
        {
            title.Show();
            content.Show();
            author.Show();
        }
    }
}
