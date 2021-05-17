using System;
using rockpaperscissors.Model;

namespace rockpaperscissors
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Clear();
      Console.WriteLine("Do you want to play rock, paper, scissors? (Y/N)");
      char choice = Console.ReadKey().KeyChar;
      bool replay = false;
      bool playGame = false;
      Console.WriteLine("");
      if (choice == 'y')
      {
        Console.Clear();
        Console.WriteLine("Let's Play!");
        playGame = true;
        while (playGame == true || replay == true)
        {
          Game game = new Game();
          Console.WriteLine("Choose your weapon!  R = Rock, P = Paper, S = Scissors (R/P/S)");
          char weaponChoice = Console.ReadKey().KeyChar;
          Console.WriteLine("");
          if (weaponChoice == 'r')
          {
            Console.WriteLine("You choose Rock!");
          }
          if (weaponChoice == 'p')
          {
            Console.WriteLine("You choose Paper!");
          }
          if (weaponChoice == 's')
          {
            Console.WriteLine("You choose Scissors!");
          }

          //   else
          //   {
          //     Console.WriteLine("I don't know what that is... try again.");
          //   }
        }
      }
      else if (choice == 'n')
      {
        Console.WriteLine("Ok!  Another time then.  Have a good day!");
      }
      else
      {
        Console.WriteLine("That is not even an option, try again....");
      }
    }
  }
}
