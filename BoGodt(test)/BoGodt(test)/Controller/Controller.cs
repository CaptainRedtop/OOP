using BoGodt_test_.Model;
using BoGodt_test_.Model.Apartment;
using BoGodt_test_.Model.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Controller
{
	/// <summary>
	/// Main controller
	/// </summary>
	internal class Controller
	{
		NumberOfApartments NumberOfApartments = new NumberOfApartments();
		MakeApartmentsController apartmentsController = new MakeApartmentsController();
		View.Gui gui = new View.Gui();
		internal void StartController()
		{
			bool menu = true;
			List<Apartment> apartments = apartmentsController.MakeApartment();
			NumberOfApartments.WriteNumberOfApartments(apartments);
			while (menu)
			{
				ConsoleKeyInfo key = gui.Menu();
				ConsoleKeyInfo key2;
				switch (key.Key)
				{
					case ConsoleKey.D1:
						{
							key2 = gui.RenovateApartmentMenu();
							RenovateApartment(key2);
							break;
						}
					case ConsoleKey.D2:
						{
							int[] numApartments = NumberOfApartments.ReadNumberOfApartments();
							gui.ShowNumberOfApartment(numApartments);
							break;
						}
					case ConsoleKey.D3:
						{
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
		internal void RenovateApartment(ConsoleKeyInfo key)
		{
			switch (key.Key)
			{
				case ConsoleKey.D1:
					{
						ConsoleKeyInfo key2 = gui.RenovateApartment();
						RenovateChoice(key2);
						break;
					}
			}
		}
		internal void RenovateChoice(ConsoleKeyInfo key)
		{
			switch (key.Key)
			{
				case ConsoleKey.D1:
					{
						AddKitchen();
						break;
					}
			}
		}
		/// <summary>
		/// Adding window
		/// </summary>
		internal void AddWindow()
		{
			ConsoleKeyInfo key = gui.AddWindow();
			switch (key.Key)
			{
				case ConsoleKey.D1:
					{
						break;
					}
			}

		}
		internal void AddKitchen()
		{
			OneRoomApartment oneRom = new OneRoomApartment(true);
		}
	}
}
