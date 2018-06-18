using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_module_11
{   
    /*
    Задача 11.3
    Создать структуру Book, содержащую поля Автор, Название, Количество страниц, Цена.
    Создать два конструктора (1-автор, название,  2- все четыре поля). 
    Создать два метода PrintBook, один из которых выводит полную информацию о книге, 
    второй - только автора и название.
    Создать массив из четырех книг, одну из которых инициализировать первым конструктором, 
	три остальных - с заданием параметров книги.
	Вывести их на экран, пользуясь сначала одним методом PrintBook, потом вторым.
	Отсортировать массив по цене. Вывести на экран.             
    */

    class Program
    {
        struct Book
        {
            string author;
            string title;
            int pageQuantity;
            int price;

            

            public Book(string bookAuthor, string bookTitle) : this()
            {
                author = bookAuthor;
                title = bookTitle;
            }

            public Book(string bookAuthor, string bookTitle, int bookPages, int bookPrice)
            {
                author = bookAuthor;
                title = bookTitle;
                pageQuantity = bookPages;
                price = bookPrice;
            }
                                        

            public void PrintBook()
            {
             Console.WriteLine($"{author} {title}");
            }

            public void PrintBook(Book book)
            {
                Console.WriteLine($"{author} {title} {pageQuantity} {price}");
            }
        }





        static void Main(string[] args)
        {
            int tempValue = int.MinValue;

            Book[] bookArray = new Book[4];
            bookArray[0] = new Book("auth1", "title1");
            bookArray[1] = new Book("auth2", "title2", 222, 45);
            bookArray[2] = new Book("auth3", "title3", 333, 1);
            bookArray[3] = new Book("auth4", "title4", 444, 4324);

            bookArray[0].PrintBook();

            for (int i = 1; i < bookArray.Length; i++)
            {
                bookArray[i].PrintBook(bookArray[i]);
            }

            


        }
    }
}
