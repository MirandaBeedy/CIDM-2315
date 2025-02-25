namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 9;
        int num2 = 2;

        int largest = FindLargest(num1, num2);
        Console.WriteLine($"The largest number between {num1} and {num2} is: {largest}");
    }

    static int FindLargest(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }

        else
        {
            return num2;
        }
    }
}