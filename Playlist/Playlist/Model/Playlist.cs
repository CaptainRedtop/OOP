using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Model
{
	internal class Playlist
	{
		Track track = new Track();
		private string? _name;

		LinkedList<string> playlist = new LinkedList<string>();

		public string name
		{
			get { return _name!; }
			set { _name = value; }
		}
		public LinkedList<string> Playlists()
		{
			playlist.AddLast(name);
			return playlist;
		}
	}
}
