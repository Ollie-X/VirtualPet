using static VirtualPet.Formatting;

namespace VirtualPet
{
	public static class Mechanics
	{
		public static string GetSpeciesFromConsole()
		{
			WriteLineIndented("What am I, a... ");
			WriteLineIndented("Dog, Cat, Fish, Turtle, Bunny, Lizard, Pig, Goat, or Hepe");
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

		private static string[] _allowedPetTypes = new[] { "dog", "cat", "fish", "turtle", "bunny", "lizard", "pig", "goat","Hepe" };

		public static bool IsSpecies(string? value) => _allowedPetTypes.Contains(value, StringComparer.OrdinalIgnoreCase);

		public static void ListenForAction(string species, string? name)
		{
			WriteLineIndented($"When you see ACTION you can type what you want to do. Type INFO for your pets information\n\tFEED to feed your pet");
			WriteIndented("ACTION: ");

			var userInput = Console.ReadLine();
			var action = userInput != null ? userInput.ToUpper() : "unknown";
			var animal = new Animal();

			while (action != "QUIT")
			{
				switch (action)
				{
					case "INFO":
						WriteIndented(animal.Stats(species, name));
						break;
					case "FEED":
						WriteIndented(animal.Feed(name));
						break;
					case "TRICK":
						WriteIndented(animal.Trick(species, name));
						break;
					default:
						WriteIndented($"{userInput} is not an ACTION\n");
						break;
				}

				WriteIndented("ACTION: ");

				userInput = Console.ReadLine();
				action = userInput != null ? userInput.ToUpper() : "unknown";
			}
		}
	}
}