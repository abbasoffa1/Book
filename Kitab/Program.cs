using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitab
{
    class Program
    {

        static void Main(string[] args)
        {   Book kitab3 = new Book(150, "Pablo Escobaro`nun Hikayesi");

            Book kitab2 = new Book(300, "Little Prince");

            Console.WriteLine("Emirler: 1. Kitab Elave edin   2. Kitabi oxuyun");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim ==1)
            {
                Console.WriteLine("Xahish Olunur kitab Elave edin: (Sehfe Sayi, Adi) ");
                int addingBookPage = Convert.ToInt32(Console.ReadLine());
                string addingBookName = Console.ReadLine();

                if (addingBookPage != null && addingBookName != String.Empty)
                {
                    Book kitab = new Book(addingBookPage, addingBookName);
                }
            }
            else if (secim == 2)
            {
                Console.WriteLine("Hansi Kitabi Secmek Isteyirsiniz?");
                int BookCount = 1;
                foreach (var item in Book.books)
                {
                    
                    Console.Write(" "+ BookCount +"."); item.BookName();
                    BookCount++;
                }

                int selection = Convert.ToInt32(Console.ReadLine());

                foreach (var item in Book.books)
                {
                    if (selection != null)
                    {
                        int select = selection - 1;
                        

                    }
                }

            }

 

        }
    }
    class Book
    {
        public static List<Book> books = new List<Book> { };
        private int PageNumber;
        private string Name;
        public Book( int _pageNumber,string _name)
        {
            PageNumber = _pageNumber;
            Name = _name;
            //Console.WriteLine("Kitab Elave olundu. \r\nSehfe sayi: {0} \r\nKitab adi: {1}", PageNumber, Name);
            books.Add(this);
        }
        public void BookName()
        {
            Console.WriteLine("{0}", Name);
        }
       
    }
}
