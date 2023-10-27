int playerGuess, computerRoll;

playerGuess = computerRoll = 0;

Random random = new();

Console.WriteLine("Hello. This is a guessing game, but with numbers.");

Console.WriteLine("The computer will think of a number, and you will have to guess it.");

Console.WriteLine("Enter in a number, 1 through 9.");

Console.ReadKey(true);

computerRoll = random.Next(1, 10);

    if (playerGuess < computerRoll)
    {
        Console.WriteLine("Too low. Try again.");
    }
    else if (playerGuess > computerRoll)
    {
        Console.WriteLine("Too high. Try again.");
    }
    else
    {
        Console.WriteLine("You guessed correctly.");
    }
