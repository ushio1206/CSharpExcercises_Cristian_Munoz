namespace CSharpExcercises;

public static class TimeService
{
    public static string GetCurrentTime()
    {
        DateTime time = DateTime.Now;

        return $"{time.Hour}:{time.Minute:D2}";
    }
}