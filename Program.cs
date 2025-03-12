internal class Program
{
  private static void Main(string[] args)
  {
    // build-in types
    // int[]  arrayOfIntegers = [1, 2, 3, 4, ];
    // // Console.WriteLine(arrayOfIntegers.Length);


    // foreach( char character in "Hello World!")
    // {
    //   Console.Write(character);
    // }
    // Tuple
    var personInfo = (Age: 30, Name: "Alice", IsEmployed: true);
    Console.WriteLine(personInfo.Age);
    Console.WriteLine(personInfo.Name);
    Console.WriteLine(personInfo.IsEmployed);


    // var employeeType = EmployeeType.Developer;
    // Console.WriteLine(employeeType);
    foreach( var e in Enum.GetValues(typeof(EmployeeType)))
    Console.WriteLine(e);
  }
  // Enums
  enum EmployeeType
  {
    Manager = 2,
    Developer = 3,
    Designer = 4,
    Supervisor = 5,
    Worker = 6,
  }

}
