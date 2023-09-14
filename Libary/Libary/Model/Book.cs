using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.Model
{
	public class Book
	{
		List<string> books = new List<string>();

		public List<string> BookList()
		{
			books.Add("Harry Flopper");
			books.Add("Doctor Normal");
            books.Add("The Witch");
            books.Add("Ocean Wars");
            books.Add("How To Train Your Child");
            books.Add("Eating Healthy");
            books.Add("Been there, Done that");
            books.Add("Tarot Guide");
            books.Add("Satanic Bible");
            return books;
		}
	}
}
