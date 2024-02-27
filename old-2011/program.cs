using System;
using Internal;

class Program {
    static void Main() {

        string[] Names;
        Names[0] = "Ben";
        Names[1] = "Thor";
        Names[2] = "Zoe";
        Names[3] = "Kate";
        int Max =  4;
        int Current = 1;
        bool Found = false;

        Console.WriteLine("What player are you looking for?");
        string PlayerName = Console.ReadLine();
        while (Found == false && Current <= Max) {
            if (Names[Current] == PlayerName) {
                Found = true;
            }
            else {
                Current++;
            }
        }
    }
}