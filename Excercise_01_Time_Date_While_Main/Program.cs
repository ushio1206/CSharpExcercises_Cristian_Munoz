namespace CSharpExcercises;

public class Program
{
    // Make a dictionary to get methods out of while and save them to access later
    private static Dictionary<string, Action> CreateActions(Action stop)
    {
        return new Dictionary<string, Action>()
        {
            {"1", ShowHour},
            {"2", HandleGreeting },
            {"3", stop}
        };
    }

    public static void Main(string[] args)
    {
        Run();
    }

    private static void Run()
    {
        bool isRunning = true;

        var actions = CreateActions(() =>
        {
            Console.WriteLine
            isRunning = false;
        });

        while (isRunning)
        {
            ShowMenu();

            string option = Console.ReadLine() ?? "";

            if (actions.TryGetValue(option, out var action))
            {
                action();
            }
            else
            {
                Console.WriteLine("Option not valid. Please try again.");
            }


        }
    }

    // Method to handle a greeting
    private static void HandleGreeting()
    {
        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("Please enter a name:");
            string name = Console.ReadLine();

            // Validate if "name" is null or empty and continue if not.
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid name, try again.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(UserService.GreetUser(name));
                Console.WriteLine();
                valid = true;
            }
        }
    }

    // Method to show current hour got from Class TimeService
    private static void ShowHour()
    {
        Console.WriteLine($"It's {TimeService.GetCurrentTime()}.");
        Console.WriteLine();
    }

    // Method to Show the initial Menu, not select options, just show options.
    private static void ShowMenu()
    {
        Console.WriteLine($"Please select an option:");
        Console.WriteLine("1. Show Hour");
        Console.WriteLine("2. Greeting");
        Console.WriteLine("3. Exit");
        Console.WriteLine();
    }


}