using System;

namespace VirtualPet
{
	public class Animal 
	{
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }

		public Animal(string name)
		{
			Name = name;
			DateOfBirth = DateTime.Now;
		}

		public string Trick(string species)
		{
			return $"{Name} the {species} is doing a TRICK!\n";
		}

		public string Stats(string species)
		{
			return $"{Name} the {species} was born on {DateOfBirth}\n";
		}

		public string Feed()
		{
			return $"{Name} says YUM! YUM!\n";
		}
	}
}