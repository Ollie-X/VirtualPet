using static VirtualPet.Formatting;

namespace VirtualPet
{

	public static class Mechanics
	{
		public static string GetSpeciesFromConsole()
		{
			WriteLineIndented("What am I, a... ");
			WriteLineIndented("Dog, Cat, Fish, Frog, Bunny, Lizard, or Pig");
			WriteLineIndented("Please type a SPECIES and press ENTER! (You can !NOT! change this untill your pet dies or you restart.)");
			WriteIndented("SPECIES: ");

			var userInput = Console.ReadLine();

			while (!IsSpecies(userInput))
			{
				WriteLineIndented("This is NOT a Species. Please type a SPECIES and press ENTER! (You can !NOT! change this untill your pet dies\n \tor you restart.)");
				WriteIndented("SPECIES: ");
				userInput = Console.ReadLine();
			}

			return userInput!;
		}

		public static bool IsSpecies(string? value)
		{
			var isSpecies =
				"dog".Equals(value, StringComparison.OrdinalIgnoreCase) ||
				"cat".Equals(value, StringComparison.OrdinalIgnoreCase) ||
				"fish".Equals(value, StringComparison.OrdinalIgnoreCase) ||
				"turtle".Equals(value, StringComparison.OrdinalIgnoreCase) ||
				"bunny".Equals(value, StringComparison.OrdinalIgnoreCase) ||
				"lizard".Equals(value, StringComparison.OrdinalIgnoreCase) ||
				"pig".Equals(value, StringComparison.OrdinalIgnoreCase) ||
				"goat".Equals(value, StringComparison.OrdinalIgnoreCase);

			return isSpecies;
		}

		public static void ListenForAction(string species, string? name)
		{
			WriteLineIndented($"When you see ACTION you can type what you want to do. Type INFO for your pets information\n\tFEED to feed your pet");
			WriteIndented("ACTION: ");

			var action = "unknown";

			var userInput = Console.ReadLine();

			if (userInput != null)
			{
				action = userInput.ToUpper();
			}

			while (action != "QUIT")
			{
				switch (action)
				{
					case "INFO":
						DogStats(species, name);
						break;
					case "FEED":
						Feed(name);
						break;
					default:
						WriteIndented($"{userInput} is not an ACTION\n");
						break;
				}

				WriteIndented("ACTION: ");
				userInput = Console.ReadLine();
				if (userInput != null)
				{
					action = userInput.ToUpper();
				}
			}
		}

		public static void DogStats(string? species, string? name)
		{
			var isDog = "dog".Equals(species, StringComparison.OrdinalIgnoreCase);

			if (isDog)
			{
				WriteLineIndented($"{name}");
				WriteLineIndented($"{species}\tWeight: 72.5lbs\tSize: 23.5inch");
			}
			else
			{
				WriteLineIndented($"unknown INFO on {species}s");
			}
		}

		public static void Feed(string? name)
		{
			WriteLineIndented($"{name} says YUM! YUM!");
		}
	}
}