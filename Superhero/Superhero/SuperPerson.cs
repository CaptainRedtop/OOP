using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
	public class SuperPerson
	{
		private string _publicName;
		private string _powers;
		private string _costume;
		private string _civilJob;
		private string _childhoodDrama;
		private bool _hero;

		public string PublicName
		{ 
			get { return _publicName; } 
			set { _publicName = value; }
		}
		public string Powers
		{
			get { return _powers; }
			set { _powers = value; }
		}
		public string Costume
		{
			get { return _costume; }
			set { _costume = value; }
		}
		public string CivilJob
		{
			get { return _civilJob; }
			set { _civilJob = value; }
		}
		public string ChildhoodDrama
		{
			get { return _childhoodDrama; }
			set { _childhoodDrama = value; }
		}
		public bool Hero
		{
			get { return _hero; }
			set { _hero = value; }
		}


	}
}
