using Microsoft.VisualBasic;

internal class Program
{
  private static void Main(string[] args)
  {

    try {
      DateTime.Parse("asdf");

    } catch (Exception e)
    {
      Console.WriteLine($"Something went wrong {e.Message}");
    }






  }
}

