using System;
class EasterEgssBattle
{
    static void Main()
    {
      int playerOneEggs = int.Parse(Console.ReadLine());
      int playerTwoEggs = int.Parse(Console.ReadLine());

        while (true)
        {
          string winner = Console.ReadLine();

          if (winner == "one")
            {
              playerTwoEggs--;
              if (playerTwoEggs < 1)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playerOneEggs} eggs left.");
                    return;
                }
            }
            else if (winner == "two")
            {
                playerOneEggs--;
                if (playerOneEggs < 1)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwoEggs} eggs left.");
                    return;
                }
            }
            else if (winner == "End")
            {
                Console.WriteLine($"Player one has {playerOneEggs} eggs left.");
                Console.WriteLine($"Player two has {playerTwoEggs} eggs left.");
                return;
            }
        }
    }
}

