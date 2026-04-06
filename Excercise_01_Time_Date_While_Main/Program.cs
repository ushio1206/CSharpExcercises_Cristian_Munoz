namespace CSharpExcercises;

public class Program
{
    private bool _isRunning = true;
    
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"Please select a option:)" +
                              "\t1. Show Hour" +
                              "\t2. Greeting" +
                              "\t3. Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine($"It's {TimeService.GetCurrentTime()}.");
                    break;
                case "2":
                    HandleGreeting();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Option not valid, try again");
                    break;
            }
        }
    }

    public static void HandleGreeting()
    {
        while (true)
        {
            Console.WriteLine("Please enter a name:");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid name, try again.");
            }
            else
            {
                Console.WriteLine(UserService.GreetUser(name));
                break;
            }
        }
    }
}