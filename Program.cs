internal class Program
{
  private static void Main(string[] args)
  {
    // build-in types
    // Datetime
    Console.WriteLine(DateTime.Now);
    // If you're using DateTime.UtcNow, you're using the current date and time in UTC (Coordinated Universal Time). Avoid using DateTime.Now in pretty much all cases for production code.
    Console.WriteLine(DateTime.UtcNow);

    // string is mutable
    string name = "Henry";
    name = name.ToUpper();
    Console.WriteLine(name);
  }

}
