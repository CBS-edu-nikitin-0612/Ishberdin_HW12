using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
/// Создать класс с именем Address. 
/// В теле класса требуется создать поля: index, country, city, street, house, apartment. 
/// Для каждого поля, создать свойство с двумя методами доступа. 
/// Создать экземпляр класса Address. 
/// В поля экземпляра записать информацию о почтовом адресе. 
/// Выведите на экран значения полей, описывающих адрес.
/// </summary>
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Address adress = new Address();
            adress.Index = "109012";
            adress.Country = "Россия";
            adress.City = "Москва";
            adress.Street = "Манежная";
            adress.House = "2-10";
            adress.Apartment = "";
            adress.Show();
            Console.ReadKey();
        }
    }
    class Address
    {
        private string index, country, city, street, house, apartment;
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public void Show()
        {
            Console.WriteLine($"{Country}, {City}, ул.{Street}, д.{House} {Apartment} * {Index}");
        }
    }
}
