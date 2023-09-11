namespace Superhero
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SuperPerson superPerson1 = new SuperPerson();

			superPerson1.PublicName = "Clark Joseph Kent";
			superPerson1.CivilJob = "Journalist";
			superPerson1.Powers = "Flight";
			superPerson1.Costume = "Spandex and cape";
			superPerson1.ChildhoodDrama = "Lost parents, race and planet";
			superPerson1.Hero = true;

			Console.Write(superPerson1.PublicName);
			Console.ReadKey();
			
		}
	}
}