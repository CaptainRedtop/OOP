﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Controller
{
	internal class Controller
	{
		//Making all planets and inserting most of them in a list
		View.View gui = new View.View();
		List<Model.Planets> planets = new List<Model.Planets>() {
			{ new Model.Planets("Mercury", 0.330f, 4879, 5427, 3.7f, 1407.6f, 4222.6f, 57.9f, 88.0f, 47.4f, 167, 0, false) },
			//{ new Model.Planets("Venus", 4.87f, 12104, 5243, 8.9f, -5832.5f, 2832.0f, 108.2f, 224.7f, 35.0f, 464, 0, false) },
			{ new Model.Planets("Earth", 5.97f, 12756, 5514, 9.8f, 23.9f, 24.0f, 149.6f, 365.2f, 29.8f, 15, 1, false) },
			{ new Model.Planets("Mars", 0.642f, 6792, 3933, 3.7f, 24.6f, 24.7f, 227.9f, 687.0f, 24.1f, -65, 2, false) },
			{ new Model.Planets("Jupiter", 1898f, 142984, 1326, 23.1f, 9.9f, 9.9f, 778.6f, 4331f, 13.1f, -110, 67, true) },
			{ new Model.Planets("Saturn", 568f, 120536, 687, 9.0f, 10.7f, 10.7f, 1433.5f, 10747f, 9.7f, -140, 62, true) },
			{ new Model.Planets("Uranus", 86.8f, 51118, 1271, 8.7f, -17.2f, 17.2f, 2872.5f, 30589f, 6.8f, -195, 27, true) },
			{ new Model.Planets("Neptune", 102f, 49528, 1638, 11.0f, 16.1f, 16.1f, 4495.1f, 59.8f, 5.4f, -200, 14, true) },
			{ new Model.Planets("Pluto", 0.0146f, 2370, 2095, 0.7f, -153.3f, 153.3f, 5906.4f, 90.56f, 4.7f, -225, 5, false) }
		};
		Model.Planets Venus = new Model.Planets("Venus", 4.87f, 12104, 5243, 8.9f, -5832.5f, 2832.0f, 108.2f, 224.7f, 35.0f, 464, 0, false);
		Model.Planets Pluto = new Model.Planets("Pluto", 0.0146f, 2370, 2095, 0.7f, -153.3f, 153.3f, 5906.4f, 90.56f, 4.7f, -225, 5, false);
		public void StartController()
		{
			gui.GUI(planets);
			AddVenus();
			RemovePluto();
			AddPluto();
			gui.GUI(planets);
			MeanTemperature();
			PlanetDiameter();
			RemoveAll();
			

        }
		public void AddVenus()
		{
			planets.Insert(1, Venus);
		}
		public void RemovePluto()
		{
			planets.Remove(planets.Last());
		}
		public void AddPluto()
		{
			planets.Add(Pluto);
		}
		
		public void MeanTemperature()
		{
			//Finding all plantest with a mean temperature under 0
			List<Model.Planets> planetsUnder0 = new List<Model.Planets>();

			foreach (Model.Planets planetLow in planets)
			{
				if (planetLow._meanTemperature < 0)
				{
					planetsUnder0.Add(planetLow);
				}
			}
			gui.LowMeanTemp(planetsUnder0);
		}
		public void PlanetDiameter()
		{
            //Finding all plantest with a diameter above 10000km but below 50000km
            List<Model.Planets> planetDiameter = new List<Model.Planets>();

            foreach (Model.Planets planet in planets)
            {
                if (planet._diameter > 10000 && planet._diameter < 50000)
                {
                    planetDiameter.Add(planet);
                }
            }
			gui.PlanetDiameter(planetDiameter);
        }
		public void RemoveAll()
		{
			planets.Clear();
			gui.LastList(planets);
		}
	}
}
