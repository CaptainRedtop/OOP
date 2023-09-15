using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Model
{
	internal class Track
	{
		private string _artist;
		private string _title;
		private string _album;

		LinkedList<string> tracks = new LinkedList<string>();
		
		public Track(string artist, string title, string album)
		{
			_artist = artist;
			_title = title;
			_album = album;
		}
		public LinkedList<string> Tracks()
		{
			tracks.AddLast("Bury Tomorrow - Gods and machines");
			tracks.AddLast("Lorna Shore - Pain Remains 1");
			tracks.AddLast("Lorna Shore - Pain Remains 2");
			tracks.AddLast("Lorna Shore - Pain Remains 3");
			tracks.AddLast("Caladan Brood - City of Azure Fire");
			tracks.AddLast("Annisokay = Human");
			tracks.AddLast("Humanity's Last Breath - Instill");
			tracks.AddLast("Currents - Let Me Leave");
			tracks.AddLast("Orbit Culture - From The Inside");
			tracks.AddLast("TesseracT - War Of Being");
			tracks.AddLast("Enterprise Earth - The World Without Us");
			tracks.AddLast("Bloodred Hourglass - In Lieu of Flowers");
			tracks.AddLast("Make Them Suffer - Doomswitch");
			tracks.AddLast("Oceans - If There's A God She Has Abandoned Us");
			tracks.AddLast("I Prevail - There's Fear In Letting Go");
			tracks.AddLast("CABAL - Magno Interitus");
			tracks.AddLast("Atlas - Ukko");
			tracks.AddLast("VOLA - Straight Lines");
			tracks.AddLast("Mephorash - Sanguinem");
			return tracks;
		}
	}
}
