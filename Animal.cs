namespace VirtualPet
{
	public class Animal 
	{
		public string Trick(string species, string? name)
		{
			return $"{name} the {species} is doing a TRICK!\n";
		}

		public string Stats(string species, string? name)
		{
			return $"these are the stats of {name} the species\n";
		}

		public string Feed(string? name)
		{
			return $"{name} says YUM! YUM!\n";
		}
	}
}