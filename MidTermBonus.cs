using System;

class HumanPlayer
{
    private int points;

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Choose Rock, Paper, or Scissors:");
        return Console.ReadLine();
    }
}

class ComputerPlayer
{
    private Random random = new Random();

    // The computer player randomly picks up a shape from Rock, Paper, or Scissors
    public string ComputerDecision()
    {
        int decision = random.Next(3);
        switch (decision)
        {
            case 0: return "Rock";
            case 1: return "Paper";
            case 2: return "Scissors";
            default: return "Rock";
        }
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer humanPlayer = new HumanPlayer(5);
        
        ComputerPlayer computerPlayer = new ComputerPlayer();

        while (humanPlayer.GetPoints() > 0)
        {
            Console.WriteLine($"Your points: {humanPlayer.GetPoints()}");

            string humanChoice = humanPlayer.HumanDecision();
            string computerChoice = computerPlayer.ComputerDecision();

            Console.WriteLine($"Computer chose: {computerChoice}");

            if (humanChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("It's a tie! No points awarded.");
            }
            else if ((humanChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Scissors")) ||
                     (humanChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Rock")) ||
                     (humanChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Paper")))
            {
                Console.WriteLine("You win this round!");
                humanPlayer.WinRound();
            }
            else
            {
                Console.WriteLine("You lose this round.");
                humanPlayer.LoseRound();
            }

            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgain = Console.ReadLine();
            if (!playAgain.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }

        Console.WriteLine("Game over! Your final points: " + humanPlayer.GetPoints());
    }
}
