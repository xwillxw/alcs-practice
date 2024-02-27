using System;
using Internal;

class Program {
    static void Main() {
        Console.WriteLine("The new word?");
        string NewWord = Console.ReadLine();
        Console.WriteLine("Your guess?");
        string UserWordGuess = Console.ReadLine();

        if (UserWordGuess = NewWord) {
            Console.WriteLine("CORRECT");
        }
        else {
            Console.WriteLine("INCORRECT");
        }
    }
}