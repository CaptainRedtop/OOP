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
		Track tracks = new Track();
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
							AddTrack();
							break;
						}
					case ConsoleKey.D2:
						{
							AddTrackToPlaylist();
							break;
						}
					case ConsoleKey.D3:
						{
							ViewPlaylist();
							break;
						}
					case ConsoleKey.D4:
						{
							menu = false;
							break;
						}
				}
			}
		}
		public void AddTrack()
		{
			Track 
		}
		public void AddTrackToPlaylist()
		{

		}
		public void ViewPlaylist()
		{

		}
	}
}
