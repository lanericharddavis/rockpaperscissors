using System;

namespace rockpaperscissors.Model
{
  public class Game
  {
    public int number { get; set; }
    // public string PlayerChoice { get; set; }

    public Game()
    {
      //   List<string> options = new List<string>() { "rock", "paper", "scissors" };
      Random rdm = new Random();
      number = rdm.Next(0, 3);
    }
  }
}