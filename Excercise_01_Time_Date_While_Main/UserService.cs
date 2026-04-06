namespace CSharpExcercises;

public static class UserService
{
    // Class to manage greets, Method to return a greet with a name disclosed by user
    public static string GreetUser(string userName)
    {
        return $"Hello, {userName}";
    }
}