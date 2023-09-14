using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.View
{
	public class View
	{
		public ConsoleKeyInfo Menu()
		{
			Console.WriteLine("==============================================");
			Console.WriteLine("                    Libary                    ");
            Console.WriteLine("==============================================");
			Console.WriteLine();
			Console.WriteLine("What do you want to do?\n");
			Console.WriteLine("1. Get books");
			Console.WriteLine("2. Scan Books");
			Console.WriteLine("3. Exit");
			var key = Console.ReadKey();
			return key;
        }
		public string RentBooks(List<string> books)
		{
			while (true)
			{
                Console.Clear();
                Console.WriteLine("You can rent the following books:\n");
                foreach (var book in books)
				{
					Console.WriteLine(book);
				}
				Console.WriteLine();
				Console.WriteLine("Enter the name of a book you want to rent:");
				string rentBook = Console.ReadLine();
				if (books.Contains(rentBook))
				{
                    return rentBook;
                }
				else
				{
					Console.WriteLine("Book does not exist");
					Console.ReadKey();
				}
			}
		}
		public void ScanBooks(Stack<string> userBooks)
		{
			for (int i = 0; i <= userBooks.Count + 1; i++)
			{
                Console.Clear();
                Console.Write("Scanning book");
				for (int x = 0; x < 3;  x++)
				{
					Thread.Sleep(1000);
					Console.Write(". ");
				}
				Console.WriteLine();
				Console.WriteLine("Book scanned: " +  userBooks.Peek());
				userBooks.Pop();
				Thread.Sleep(2000);
            }
			Console.WriteLine("Done scanning...");
			Console.ReadKey();
		}
	}
}
