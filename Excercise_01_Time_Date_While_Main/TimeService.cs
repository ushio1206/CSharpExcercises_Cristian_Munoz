namespace CSharpExcercises;

public static class TimeService
{
    // Class to manage time and date, Method to return formatted Hour and Minutes.
    public static string GetCurrentTime()
    {
        DateTime time = DateTime.Now;

        return $"{time.Hour}:{time.Minute:D2}";
    }
}