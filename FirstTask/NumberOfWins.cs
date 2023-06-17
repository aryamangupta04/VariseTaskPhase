using System;
class Wins
{
    static void Main()
    {
        Console.WriteLine("Enter the points required to qualify\n ");
        int pointsRequired = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of matches\n ");
        int numMatches = Convert.ToInt32(Console.ReadLine());
        int minWins = CalculateMinWins(pointsRequired, numMatches);
        Console.WriteLine("Minimum number of wins required to qualify: " + minWins);
    }
    static int CalculateMinWins(int pointsRequired, int numMatches)
    {
        int winsNeeded = (pointsRequired - (numMatches * 1)) / 2;
        return Math.Max(winsNeeded, 0);
    }
}
