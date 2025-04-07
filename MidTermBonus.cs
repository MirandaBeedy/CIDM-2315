using System;

class HumanPlayer
{
    private int points; // the points that the human player has

    // constructor used to set human player’s initial points
    public HumanPlayer(int initial)
    {
        points = initial;
    }

    // return the points of human player
    public int GetPoints()
    {
        return points;
    }

    // human player increase 5 points
    public void WinRound()
    {
        points += 5;
    }

    // human player decrease 5 points
    public void LoseRound()
    {
        points -= 5;
    }

    // human player select a shape from Rock, Paper, or Scissors
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
        int decision = random.Next(3); // generates 0, 1, or 2
        switch (decision)
        {
            case 0: return "Rock";
            case 1: return "Paper";
            case 2: return "Scissors";
            default: return "Rock"; // default case
        }
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
        // Create a human player with initial points
        HumanPlayer humanPlayer = new HumanPlayer(5);
        // Create a computer player
        ComputerPlayer computerPlayer = new ComputerPlayer();

        while (humanPlayer.GetPoints() > 0)
        {
            // Print current points of human player
            Console.WriteLine($"Your points: {humanPlayer.GetPoints()}");

            // Get human player's decision
            string humanChoice = humanPlayer.HumanDecision();
            string computerChoice = computerPlayer.ComputerDecision();

            // Display computer's choice
            Console.WriteLine($"Computer chose: {computerChoice}");

            // Determine the winner
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

            // Check if player wants to continue
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