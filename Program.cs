using Task2;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CrocodileService crocodileService = new CrocodileService();

            crocodileService.CreateCrocodile("Gena", 500, 5.5, 25, "Male");
            crocodileService.CreateCrocodile("Alfred", 600, 6.0, 30, "Male");
            crocodileService.CreateCrocodile("Lizzy", 450, 4.8, 20, "Female");

            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Create a new crocodile");
                Console.WriteLine("2. Show all crocodiles");
                Console.WriteLine("3. Show crocodiles longer than a given length");
                Console.WriteLine("4. Show the oldest crocodile");
                Console.WriteLine("5. Show the heaviest crocodile");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter weight (kg): ");
                        double weight = double.Parse(Console.ReadLine());

                        Console.Write("Enter length (m): ");
                        double length = double.Parse(Console.ReadLine());

                        Console.Write("Enter age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Enter gender: ");
                        string gender = Console.ReadLine();

                        crocodileService.CreateCrocodile(name, weight, length, age, gender);
                        break;

                    case "2":
                        crocodileService.PrintAllCrocodiles();
                        break;

                    case "3":
                        Console.Write("Enter minimum length (m): ");
                        double minLength = double.Parse(Console.ReadLine());
                        crocodileService.PrintCrocodilesLongerThan(minLength);
                        break;

                    case "4":
                        crocodileService.PrintOldestCrocodile();
                        break;

                    case "5":
                        crocodileService.PrintHeaviestCrocodile();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}