using Microsoft.VisualBasic;

internal class Program
{
  private static void Main(string[] args)
  {
    // strings
   string name = "Henry";
   string name2 = "Henry1";
   string greeting = $"Hello, {name}";
   Console.WriteLine(greeting);
   var comparision = string.Equals(name, name2);
   Console.WriteLine(comparision);

   string nameSpace = string.Empty;

   var isNullOrEmpty = string.IsNullOrEmpty(nameSpace);
   Console.WriteLine(isNullOrEmpty);

   var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nameSpace);
   Console.WriteLine(isNullOrWhiteSpace);
  }

  // string equality Equals



}
