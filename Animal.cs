
namespace VirtualPet
{
	public class Animal 
	{
		public string Name { get; set; }

		public Animal(string name)
		{
			Name = name;
		}

		public string Trick(string species)
		{
			return $"{Name} the {species} is doing a TRICK!\n";
		}

		public string Stats(string species)
		{
			return $"these are the stats of {Name} the species\n";
		}

		public string Feed()
		{
			return $"{Name} says YUM! YUM!\n";
		}
	}
}