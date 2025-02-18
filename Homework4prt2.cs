namespace Homework4prt2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a shape (left or right):");
        string shape = Console.ReadLine();

        if (shape.ToLower () == "right")
        {
            PrintRightTriangle(N);
        }
        else if (shape.ToLower () == "left")
        {
            PrintLeftTriangle(N);
        }
        else
        {
            Console.WriteLine("Invalid Shape. Enter 'left' or 'right'.");
        }

        static void PrintLeftTriangle(int N)
        {
            Console.WriteLine($"N is: {N}, Shape is: Left");

            for (int i = 1; i <= N; i++)
            {
                for (int h = 1; h <= i; h++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            static void PrintRightTriangle(int N)
            {
                Console.WriteLine($"N is: {N}, Shape is: Right");

                for (int i = 1; i <= N; i++)
                {
                    for (int h = 1; h <= N - i; h++)
                    {
                        Console.Write("");
                    }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }               
                Console.WriteLine();
                }
            }
        }    
    }
}    
