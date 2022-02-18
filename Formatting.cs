using static System.Console;

namespace VirtualPet
{
    public static class Formatting
	{
		public static void WriteLineIndented(string value)
        {
            WriteLine($"\t{value}");
        }

        public static void WriteIndented(string value)
        {
            Write($"\t{value}");
        }
	}
}