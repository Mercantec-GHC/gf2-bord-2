using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver;
public class RockPaperScissors
{
    public static void Run()
    {
        string[] choices = { "Rock", "Paper", "Scissors" };
        Random random = new Random();
        Console.WriteLine("chose your move (Rock, Paper or Scissors)");
        string playerchoice = Console.ReadLine();
        if (Array.IndexOf(choices, playerchoice) == -1) ;
        {
            Console.WriteLine("Invalid input, please chose Rock, Paper or Scissors");
            return;
        }
        int computerChoiceIndex = random.Next(0, 3);
        string computerChoice = choices[computerChoiceIndex];
        Console.WriteLine($"you chose: {playerchoice}");
        Console.WriteLine($"computer choice: {computerChoice}");
        if (playerchoice == computerChoice)
        {
            Console.WriteLine("it's a tie");
        }
        else if (
            (playerchoice == "Rock" && computerChoice == "Scissors") ||
            (playerchoice == "Paper" && computerChoice == "Rock") ||
            (playerchoice == "Scissors" && computerChoice == "Paper")
        )
        {
            Console.WriteLine("You win!!");
        }
        else
        {
            Console.WriteLine("You lose :(");
        }
    }
