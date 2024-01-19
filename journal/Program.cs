using System;

class Program
{
	static void Main(string[] args)
	{
		Journal journalName = new Journal();
		string filename = "";

		while (true)
		{
			int option;

			Console.WriteLine("Select an entry (1-5:\n");

			Console.WriteLine("1. Write a new entry");
			Console.WriteLine("2. Display the journal");
			Console.WriteLine("3. Save journal to file");
			Console.WriteLine("4. Load journal from file");

			option = Console.ReadLine();

			switch (option)
			{
				case "1":
					WriteEntry(journalName);
					break;
				case "2":
					journalName.DisplayAll();
					break;
				case "3":
					SaveEntriesToFile(journalName, filename);
					break;
				case "4":
					break;
				default:
					break;
			}
		}
	}

	static void WriteEntry(Journal journalName)
	{
		Entry new_entry = new Entry();

		Console.WriteLine("Enter your entry below (Press Return/Enter to end)\n");

		new_entry._entryText = Console.ReadLine();

		journalName.AddEntry(new_entry);
	}

	static void SaveEntriesToFile(Journal journalName, string filename)
	{
		if (filename == "")
		{
			Console.Write("Enter your filename (without an extension): ");
			filename = Console.ReadLine();
			filename += ".txt";
		}
		
		journalName.SaveToFile(filename);
	}
}


