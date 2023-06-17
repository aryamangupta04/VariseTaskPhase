using System;

class Trailing
{
    static void Main()
    {
        Console.WriteLine("Enter the value for n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(TrailingZeroes(n));
    }

    static int TrailingZeroes(int n)
    {
        int zeroes = 0;
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        string x = Convert.ToString(fact);
        for (int i = 0; i < x.Length; i++)
        {
            if (fact % 10 == 0)
            {
                zeroes++;
                fact = fact / 10;
            }
            else
            {
                break;
            }
        }

        return zeroes;
    }
    //this program will not be able to give the trailing zeroes for 15! and 20!
//because of the data type used
}
