using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Model
{
	internal class Track
	{
		LinkedList<string> metalCore = new LinkedList<string>();
		LinkedList<string> doom = new LinkedList<string>();
		LinkedList<string> rock = new LinkedList<string>();
		LinkedList<string> blackMetal = new LinkedList<string>();

		public LinkedList<string> MetalCore
		{
			get { return metalCore; }
			set { metalCore = value; }
		}
		public LinkedList<string> Doom
		{
			get { return doom; }
			set { doom = value; }
		}
		public LinkedList<string> Rock
		{
			get { return rock; }
			set { rock = value; }
		}
		public LinkedList<string> BlackMetal
		{
			get { return  blackMetal; }
			set { blackMetal = value; }
		}

		
		public LinkedList<string> MetalCoreTracks()
		{
			LinkedList<string> metalCoreTracks = new LinkedList<string>();

			metalCoreTracks.AddLast("Bury Tomorrow - Gods and machines");
			metalCoreTracks.AddLast("Annisokay = Human");
			metalCoreTracks.AddLast("Humanity's Last Breath - Instill");
			metalCoreTracks.AddLast("Currents - Let Me Leave");
			metalCoreTracks.AddLast("Orbit Culture - From The Inside");
			metalCoreTracks.AddLast("TesseracT - War Of Being");
			metalCoreTracks.AddLast("Enterprise Earth - The World Without Us");
			metalCoreTracks.AddLast("Bloodred Hourglass - In Lieu of Flowers");
			metalCoreTracks.AddLast("Make Them Suffer - Doomswitch");
			metalCoreTracks.AddLast("Oceans - If There's A God She Has Abandoned Us");
			metalCoreTracks.AddLast("I Prevail - There's Fear In Letting Go");
			metalCoreTracks.AddLast("Atlas - Ukko");
			metalCoreTracks.AddLast("VOLA - Straight Lines");
			return metalCoreTracks;
		}
		public LinkedList<string> DoomTracks()
		{
			LinkedList<string> doomTracks = new LinkedList<string>();

			return doomTracks;
		}
		public LinkedList<string> RockTracks()
		{
			LinkedList<string> rockTracks = new LinkedList<string>();

			return rockTracks;
		}
		public LinkedList<string> BlackMetalTracks()
		{
			LinkedList<string> blackMetalTracks = new LinkedList<string>();
			blackMetalTracks.AddLast("Lorna Shore - Pain Remains 1");
			blackMetalTracks.AddLast("Lorna Shore - Pain Remains 2");
			blackMetalTracks.AddLast("Lorna Shore - Pain Remains 3");
			blackMetalTracks.AddLast("Caladan Brood - City of Azure Fire");
			blackMetalTracks.AddLast("CABAL - Magno Interitus");
			blackMetalTracks.AddLast("Mephorash - Sanguinem");
			return blackMetalTracks;
		}
	}
}
