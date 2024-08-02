using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    internal class MesaLibrary
    {

        public Book[] books;

        public MesaLibrary()
        {
            books = new Book[5];
            books[0] = new Book() { bookName = "Yüzüklerin Efendisi", bookAuthor = "J.R.R Tolkein", bookType = "roman", bookPrice = 13.99 };
            books[1] = new Book() { bookName = "Bir Ömür Nasıl Yaşanır", bookAuthor = "İlber Ortaylı", bookType = "otobiyografi", bookPrice = 7.9 };
            books[2] = new Book() { bookName = "Diyet", bookAuthor = "Ömer Seyfettin", bookType = "roman", bookPrice = 2 };
            books[3] = new Book() { bookName = "Death Note", bookAuthor = "Tsugumi Ooba", bookType = "manga", bookPrice = 3 };
            books[4] = new Book() { bookName = "Kavgam", bookAuthor = "Adolf Hitler", bookType = "otobiyografi", bookPrice = 99 };

        }
        public void LibraryBookList()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"***{i+1}***");
                Console.WriteLine($"{books[i].bookName}\n{books[i].bookAuthor}\n{books[i].bookType}\n{books[i].bookPrice}$");
                Console.WriteLine(" ");
            }

        }
        public void ListByType(string p_type)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].bookType == p_type)
                {
                    Console.WriteLine($"{books[i].bookName}\n{books[i].bookAuthor}\n{books[i].bookType}\n{books[i].bookPrice}$");
                }
            }
        }
        public void AddBook(Book p_book)
        {
            Book[] gecici = new Book[books.Length+1];
            Array.Copy(books, gecici, books.Length);
            gecici[gecici.Length-1] = p_book;
            books = gecici;


        }
    }
}
