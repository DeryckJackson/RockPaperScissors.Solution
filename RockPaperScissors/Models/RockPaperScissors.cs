namespace RockPaperScissors.Models
{
  public class Game
  {
    public static string DetectWinner(string player1, string player2)
    {
      if (player1 == player2) 
      {
        return "Draw";
      }
      else if (player1 == "rock" && player2 == "scissors")
      {
        return "Player 1 Win";
      }
      

      return "dummy data so compiler doesn't complain";
    }
  }
}