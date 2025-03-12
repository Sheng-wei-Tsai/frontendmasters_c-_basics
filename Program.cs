using Microsoft.VisualBasic;

internal class Program
{
  private static void Main(string[] args)
  {
    // if statements
   int age = 18;
   if(age >= 18)
   {
    Console.WriteLine("You are an adult");
   }
   // switch statement
  //  int day = 3;
  //  switch(day)
  //  {
  //    case 1:
  //    Console.WriteLine("Monday");
  //    break;
  //    case 2:
  //    Console.WriteLine("Tuesday");
  //    break;
  //    case 3:
  //    Console.WriteLine("Wednesday");
  //    break;
  //    case 4:
  //    Console.WriteLine("Thursday");
  //    break;
  //    case 5:
  //    Console.WriteLine("Friday");
  //    break;
  //    case 6:
  //    Console.WriteLine("Saturday");
  //    break;
  //    case 7:
  //    Console.WriteLine("Sunday");
  //    break;
  //    default:
  //    Console.WriteLine("Invalid day");
  //    break;
  //  }

  // switch expression
    int day = 3;
    string dayName = day switch
  {
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    5 => "Friday",
    6 => "Saturday",
    7 => "Sunday",
    _ => "Invalid day"
  };

    // Console.WriteLine(dayName);
    // loop
      //for or foreach
    //   for(int i = 0; i < 5; i++)
    // {
    //   Console.WriteLine(i);
    // }
    // while loop
    // while(true)
    // {
    //   break;
    // }
    int[] arr = [1, 2, 3, 4, 5];
    foreach(var value in arr)
    {
      // Console.WriteLine(value);
    }

    // continue
    for (int i = 0; i < 10; i++)
    {
      if(i == 5)
      {
        continue;
      }
      Console.WriteLine(i);
    }






  }
}

