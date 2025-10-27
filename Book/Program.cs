using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            SetTitle(title);
            SetAuthor(author);
            SetPrice(price);
        }

        public void SetTitle(string title)
        {
            if (title == null || title.Trim().Length < 3)
            {
                Console.WriteLine("Грешка: Заглавието трябва да съдържа поне 3 символа!");
            }
            else
            {
                this.title = title;
            }
        }

        public void SetAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Грешка: Авторът не може да бъде празен!");
            }
            else
            {
                this.author = author;
            }
        }

        public void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                Console.WriteLine("Грешка: Цената трябва да е положителна стойност!");
            }
            else
            {
                this.price = price;
            }
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Книга: \"{title}\" от {author} - {price:F2} лв.");
        }
    }

}
