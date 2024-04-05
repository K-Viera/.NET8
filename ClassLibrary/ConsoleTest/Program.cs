using ClassLibraryTest.Polymorphism;
using ClassLibraryTest.Generics;
using ClassLibraryTest;

List<ILogic> testOptions = [new PolymorphismLogic(),new GenericsLogic()];
while (true)
{
    Console.WriteLine("Please select an option:");
    int i = 1;
    foreach (var testOption in testOptions)
    {
        Console.WriteLine($"{i}. Option {testOption.Name}");
        i++;
    }

    // Read user input
    string input = Console.ReadLine();
    if (int.TryParse(input, out int choice))
    {
        if (choice <= testOptions.Count())
        {
            testOptions[choice - 1].ExecuteLogic();
        }
        else 
            Console.WriteLine("Invalid Option");
    }
    else
        Console.WriteLine("Invalid input. Please enter a number.");

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}


