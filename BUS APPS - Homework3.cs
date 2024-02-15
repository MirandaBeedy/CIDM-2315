namespace Homework3;

class Program
{
    static void Main(string[] args)
 {
        Console.WriteLine("Enter a prime number: ");
        var n = int.Parse(Console.ReadLine());
        var prime = true;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(n + " is not a prime number");
            }
        }
        if (n % 2 == 0)
        {
            Console.WriteLine(n + " is a prime number");
        }
    }
}