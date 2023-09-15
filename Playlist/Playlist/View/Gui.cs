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
			Console.WriteLine("1. Add song to playlist");
			Console.WriteLine("2. View playlist");
			Console.WriteLine("3. Exit");
			var key = Console.ReadKey();
			return key;
		}
		public void ViewPlaylist(LinkedList<string> tracks)
		{
			Console.Clear();
			foreach (var track in tracks)
			{
				Console.WriteLine(track);
			}
			Console.ReadKey();
		}
	}
}
