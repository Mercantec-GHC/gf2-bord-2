using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver;
public class RockPaperScissors
{
    public static void Run()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Velkommen til Sten, Saks, Papir!");
        Console.WriteLine("Se opgaven her - https://mercantec.notion.site/sten-saks-papir");
        Game();
    }

    public static void Game()
    {
        string Pcchoice = "Rock";
        string PlayerChoise = GetPlayerChoice();
    }

    public static string GetPlayerChoice()
    {
        Console.WriteLine("Chose Rock, Paper or Scissors");
        string Playerchoice = Console.ReadLine();
        switch (Playerchoice)
        {
            case "Rock":
                return "Rock";
                break;
            case "Paper":
                return "Paper";
                break ;
            case "Scissors":
                return "Scissors";
                break;
            default:
                GetPlayerChoice();
                return "";
                break;
        }
        

        
        
    }
    public static void CompareResults()
    {
        //Implementer metoden til at sammenligne resultaterne her
    }  

}

