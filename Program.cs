using System;

namespace ConsoleApp_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1: Клас "Журнал"
            Journal journal1 = new Journal();
            journal1.NumberOfEmployees = 10;

            Journal journal2 = new Journal();
            journal2.NumberOfEmployees = 15;

            
            Console.WriteLine(journal1 == journal2); 
            Console.WriteLine(journal1 != journal2); 
            Console.WriteLine(journal1 > journal2);  
            Console.WriteLine(journal1 < journal2);  

            // Завдання 2: Клас "Магазин"
            Shop shop1 = new Shop();
            shop1.Area = 100;

            Shop shop2 = new Shop();
            shop2.Area = 150;

            
            Console.WriteLine(shop1 == shop2); 
            Console.WriteLine(shop1 != shop2);
            Console.WriteLine(shop1 > shop2);  
            Console.WriteLine(shop1 < shop2);  

            // Завдання 3: Додаток "Список книг до прочитання"
            BookList bookList = new BookList();
            bookList.AddBook("Book 1");
            bookList.AddBook("Book 2");
            bookList.AddBook("Book 3");

            Console.WriteLine(bookList.ContainsBook("Book 2")); 
        }
    }
}

