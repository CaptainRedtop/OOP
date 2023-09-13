using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Model
{
    internal class Planets
    {
		private string _name;
        private float _mass;
        private int _diameter;
        private short _density;
        private float _gravity;
        private float _rotationPeriod;
        private float _lengthOfDay;
        private float _distanceFromSun;
        private float _orbitalPeriod;
        private float _orbitalVelocity;
        private short _meanTemperature;
        private byte _numberOfMoons;
        private bool _ringSystem;

		public Planets(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthOfDay, float distanceFromSun, float orbitalPeriod, float orbitalVelocity, short meanTemperature, byte numberOfMoons, bool ringSystem)
		{
			_name = name;
			_mass = mass * 1024;
			_diameter = diameter;
			_density = density;
			_gravity = gravity;
			_rotationPeriod = rotationPeriod;
			_lengthOfDay = lengthOfDay;
			_distanceFromSun = distanceFromSun * 106;
			_orbitalPeriod = orbitalPeriod;
			_orbitalVelocity = orbitalVelocity;
			_meanTemperature = meanTemperature;
			_numberOfMoons = numberOfMoons;
			_ringSystem = ringSystem;
		}
		
		public override string ToString()
		{
			string data = "Name:" + _name;
			data +=	"\nMass: " + _mass.ToString() + "kg";
			data += "\nDiameter: " + _diameter.ToString() + "km";
			data += "\nDensity: " + _density.ToString() + "kg/m3";
			data += "\nGravity: " + _gravity.ToString() + "m/s2";
			data += "\nRotation Period: " + _rotationPeriod.ToString() + "hours";
			data += "\nLength of Day: " + _lengthOfDay.ToString()+ "hours";
			data += "\nDistance from Sun: " + _distanceFromSun.ToString() + "km";
			data += "\nOrbital Period: " + _orbitalPeriod.ToString() + "days";
			data += "\nOrbital Velocity: " + _orbitalVelocity.ToString() + "km/s";
			data += "\nMean Temperature: " + _meanTemperature.ToString() + "C";
			data += "\nNumber of Moons: " + _numberOfMoons.ToString();
			data += "\nRing System?: " + _ringSystem.ToString();
			return data;
		}

	}
}
