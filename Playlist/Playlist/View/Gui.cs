using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.View
{
	internal class Gui
	{
		public ConsoleKeyInfo MainMenu()
		{
			Console.WriteLine("================================================");
			Console.WriteLine("                    Playlist                    ");
			Console.WriteLine("================================================");
			Console.WriteLine();
			Console.WriteLine("1. Add song to tracklist");
			Console.WriteLine("2. Add song to playlist");
			Console.WriteLine("3. View playlist");
			Console.WriteLine("4. Exit");
			var key = Console.ReadKey();
			return key;
		}
	}
}
