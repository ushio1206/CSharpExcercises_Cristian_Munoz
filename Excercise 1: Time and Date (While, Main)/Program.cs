namespace CSharpExcercises;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"Please Select a option:\t1. Show Hour\t2.Greeting\t3. Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine($"It's {TimeService.GetCurrentTime()}.");
                    break;
                case "2":
                    while (true)
                    {
                        Console.WriteLine("Please enter a name:");
                        string name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Name not valid");
                        }
                        else
                        {
                            Console.WriteLine(UserService.GreetUser(name));
                            break;
                        }
                    }
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Option not valid, try again");
                    break;
            }
        }
    }
}