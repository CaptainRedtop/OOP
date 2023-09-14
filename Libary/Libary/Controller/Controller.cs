using Libary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.Controller
{
	public class Controller
	{
		View.View gui = new View.View();
        Book book = new Book();
        public Stack<string> userBooks = new Stack<string>();
		public void Menu()
		{
            List<string> books = book.BookList();
			bool menu = true;
			while (menu == true)
			{
                Console.Clear();
				var key = gui.Menu();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            RentBooks(books);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            ScanBooks();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            menu = false;
                            break;
                        }
                }
            }
		}
        public void RentBooks(List<string> books)
        {
            string rentBook = gui.RentBooks(books);

            userBooks.Push(rentBook);
            books.Remove(rentBook);
        }
        public void ScanBooks()
        {
                gui.ScanBooks(userBooks);
        }
    }
}
