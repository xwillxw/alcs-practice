using System;
using Internal;

class Program {
    

    static void Main() {
        int noOfGamesInMatch = 0;
        int noOfGamesPlayed = 0;
        int playerOneScore = 0;
        int playerTwoScore = 0;
        char playerOneWinsGame = 'N';
        Console.WriteLine("How many games?");
        try {
            noOfGamesInMatch = Int32.Parse(Console.ReadLine());
        }
        catch {
            Console.WriteLine("Failed to parse input");
        }
        for (noOfGamesPlayed = 0; noOfGamesPlayed < noOfGamesInMatch; noOfGamesPlayed++) {
            Console.WriteLine("Did player one win? [Y/N]");
            try {
                playerOneWinsGame = char.Parse(Console.ReadLine().ToUpper());
            }
            catch {
                Console.WriteLine("Failed to parse input");
            }
            if (playerOneWinsGame == 'Y') {
                playerOneScore++;
            }
            else {
                playerTwoScore++;
            }
        }
        Console.WriteLine(playerOneScore);
        Console.WriteLine(playerTwoScore);
    }
}