namespace Homework2;

class Program
 {
    Console.WriteLine("Please input an letter grade: ");
    string letter = Console.ReadLine();
    switch(letter){
        case "A":
            Console.WriteLine("GPA is 4.");
            break;
        case "B":
            Console.WriteLine("GPA is 3.");
            break;
        case "C":
            Console.WriteLine("GPA is 2.");
            break;
        case "D":
            Console.WriteLine("GPA is 1.");
            break;
        case "F":
            Console.WriteLine("GPA is 0.");
            break;
        default:
            Console.WriteLine("Wrong Letter Grade!");
            break;
    }
  }
}