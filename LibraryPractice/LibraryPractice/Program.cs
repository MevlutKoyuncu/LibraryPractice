using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MesaLibrary ms = new MesaLibrary();
            string devam = "e";
            while (devam == "e")
            {


                Console.WriteLine("MESA Kütüphanesine Hoşgeldiniz ");

                Console.WriteLine("1) Kitap Listesi");
                Console.WriteLine("2) Tür Aratma");
                Console.WriteLine("3) Kitap Ekleme");
                Console.WriteLine("Lütfen yapmak istedğiniz işelemi seçini ");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    ms.LibraryBookList();
                }
                else if (secim == "2")
                {
                    //for (int i = 0; i < ms.books.Length; i++)
                    //{
                    //    for (int j = 0; j < ms.books.Length; j++)
                    //    {
                    //        if (ms.books[i + j].bookType != ms.books[j].bookType)
                    //        {
                    //            Console.WriteLine(ms.books[j].bookType);
                    //        }
                    //    }

                    //}
                    Console.WriteLine("Aratmak istediğiniz türü giriniz");
                    string type = Console.ReadLine();
                    ms.ListByType(type);
                }
                else if (secim == "3")
                {
                    Book newbook = new Book();
                    Console.WriteLine("Kitap adı giriniz = ");
                    newbook.bookName = Console.ReadLine();
                    Console.WriteLine("Kitap yazarı giriniz = ");
                    newbook.bookAuthor = Console.ReadLine();
                    Console.WriteLine("Kitap türü giriniz = ");
                    newbook.bookType = Console.ReadLine();
                    Console.WriteLine("Kitap fiyatı giriniz = ");
                    newbook.bookPrice = Convert.ToDouble(Console.ReadLine());
                    ms.AddBook(newbook);

                    Console.WriteLine("Kitap ekleme sekmesi");
                }
                else
                {
                    Console.WriteLine("Yanlış bir seçim yaptınız");
                }
                Console.WriteLine("İşleme devam edecek misiniz? e/h");
                devam = Console.ReadLine();
            }
        }
    }
}
