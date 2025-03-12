internal class Program
{
    private static void Main(string[] args)
    {
      // syntax Console.WriteLine("Hello, World!!!");
      //  C# strick type
      // var is a good way to declare a variable
      var name = "Henry";
      Console.WriteLine($"Hello, {name}!!!");

      // Methods
      int a = 1;
      int b = 2;

      // int c = AddNumbers(1, 2, 3, 4);
      // Console.WriteLine(c);

      Console.WriteLine(IsEven(2));

    }

    // public static int AddNumbers(int a, int b = 5)
    // {
    //   return a + b;
    // }

    // public static int AddNumbers(params int[] integers)
    // {

    // }

    public static bool IsEven(int number)
    {
      if (number % 2 == 0) {
        return true;
      }
      return false;
    }
}
