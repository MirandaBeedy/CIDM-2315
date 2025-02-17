namespace Homework2prt2;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Input the first number:");
      int num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Input the second number:");
      int num2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Input the third number:");
      int num3 = int.Parse(Console.ReadLine());

      int smallest = num1;

      if (num2 < smallest)
      {
        smallest = num2 ;
      }

      if (num3 < smallest)
      {
        smallest = num3;
      }

    Console.WriteLine("The smallest number is: " + smallest);
    }
}
