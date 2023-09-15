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


		public string name
		{
			get { return _name!; }
			set { _name = value; }
		}
		public LinkedList<string> Playlists()
		{
            LinkedList<string> playlist = new LinkedList<string>();
            playlist.AddLast(name);
			return playlist;
		}
		public LinkedList<string> MetalCore(LinkedList<string> tracks)
		{
            LinkedList<string> metalCorePlaylist = new LinkedList<string>();
            foreach (var track in tracks)
			{
				metalCorePlaylist.AddLast(track);
			}
			return metalCorePlaylist;
		}
	}
}
