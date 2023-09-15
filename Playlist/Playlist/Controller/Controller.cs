using Playlist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Controller
{
	internal class Controller
	{
		Track track = new Track();
		Model.Playlist playlist = new Model.Playlist();
		View.Gui gui = new View.Gui();
		public void StartController()
		{
			bool menu = true;
			while (menu == true)
			{
				Console.Clear();
				var key = gui.MainMenu();
				switch (key.Key)
				{
					case ConsoleKey.D1:
						{
							AddTrackToPlaylist();
							break;
						}
					case ConsoleKey.D2:
						{
							ViewPlaylist();
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
		public void AddTrackToPlaylist()
		{
			
		}
		public void ViewPlaylist()
		{
			gui.ViewPlaylist(playlist.MetalCore(track.MetalCoreTracks()));
		}
	}
}
