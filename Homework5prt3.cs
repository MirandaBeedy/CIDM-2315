namespace Homework5prt3;

class Program
{
    static void Main(string[] args)
    {
        createAccount();
        Console.ReadKey(true);
    }

    public static bool checkAge(int birth_year)
    {
        int age=2025-birth_year;

        if (age>=18)
        return true;

        else
        return false;
    }

    public static void createAccount()
    {
        string userName, password, retypedPassword;

        int birthYear;

        Console.WriteLine("Enter a username:");
            userName=Console.ReadLine();

        Console.WriteLine("Enter a password:");
            password=Console.ReadLine();

        Console.WriteLine("Enter password again:");
            retypedPassword=Console.ReadLine();

        Console.WriteLine("Enter your birth year:");
            birthYear=Convert.ToInt32(Console.ReadLine());
            if(checkAge(birthYear))
                Console.WriteLine("Account has been created succesfully!");

            else
                Console.WriteLine("Account could not be created.");
    }
}
