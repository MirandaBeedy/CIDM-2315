namespace Homework3prt2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Assing a int value to N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for (int h = 0; h < N; h++)
            {
                 Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}
