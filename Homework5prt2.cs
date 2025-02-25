namespace Homework4;

class Program
{
    static int FindLargest(int num1, int num2, int num3, int num4)
    {
        int largest = num1;
        if (num2 > largest) largest = num2;
        if (num3 > largest) largest = num3;
        if (num4 > largest) largest = num4;
        return largest;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter a second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter a third number:");
        int num3 = int.Parse(Console.ReadLine());

        Console.Write("Enter a fourth number:");
        int num4 = int.Parse(Console.ReadLine());

        int largest = FindLargest(num1, num2, num3, num4);
        Console.WriteLine("The largest number is:" + largest);

    }
}  