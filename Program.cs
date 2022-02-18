using static VirtualPet.Formatting;
using static VirtualPet.Mechanics;

namespace VirtualPet
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WriteLineIndented("\n\tHello, I'm your Virtual Pet!\n");
            var petSpecies = GetSpeciesFromConsole();

            WriteLineIndented("I need a NAME. Please type a NAME and press ENTER!");
            WriteIndented("NAME: ");
            var petName = Console.ReadLine();

            WriteLineIndented($"Thank you, I will now be a {petSpecies}, know as {petName}.\n");

            ListenForAction(petSpecies, petName);
        }
    }
}