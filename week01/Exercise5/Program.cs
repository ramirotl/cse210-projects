using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = GetUserName();
        int favNumber = GetUserFavNumber();
        int squareNum = SquareNumber(favNumber);
        DisplayResult(name, squareNum);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int GetUserFavNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int favNumber = int.Parse(input);
        return favNumber;
    }
    static int SquareNumber(int favNumber)
    {
        int squareNum = favNumber * favNumber;
        return squareNum;
    }
    static void DisplayResult(string name, int squareNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNum}");
    }
}