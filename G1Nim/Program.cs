// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Nim!");
int matchNum = 24;

Console.WriteLine($"{new string ('|', matchNum)} ({matchNum})");
NEW_ROUND:
Console.WriteLine("How many matches do you want to draw? (1-3)");
USER_INPUT:
int userInput = int.Parse(Console.ReadLine());

if (userInput > 3 || userInput < 1) //BONUS point out if 1 left and user enters 3
{
    Console.WriteLine("Please choose a valid number. (1-3)");
    goto USER_INPUT;
}

matchNum -= userInput;
if (matchNum < 1)
{
    Console.WriteLine("You lose.");
    goto GAME_OVER;
}

Console.WriteLine($"{new string('|', matchNum)} ({matchNum})");
if (matchNum > 3)
{
    int aiDraw = Random.Shared.Next(1, 4);
    Console.WriteLine($"The AI draws {aiDraw} matches.");
    matchNum -= aiDraw;
}
else
{
    if (matchNum == 3)
    {
        int aiDraw = 2;
        Console.WriteLine($"The AI draws {aiDraw} matches.");
        matchNum -= aiDraw;
    }
    else
    {
        int aiDraw = 1;
        Console.WriteLine($"The AI draws {aiDraw} matches.");
        matchNum -= aiDraw;
    }
}

if (matchNum < 1)
{
    Console.WriteLine("You win!");
    goto GAME_OVER;
}

Console.WriteLine($"{new string('|', matchNum)} ({matchNum})");
goto NEW_ROUND;

GAME_OVER: ;



// Console.WriteLine($"{matches} ({matchNum})");





// var match = string.Empty + '|';