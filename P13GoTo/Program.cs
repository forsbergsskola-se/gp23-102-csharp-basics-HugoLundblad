// See https://aka.ms/new-console-template for more information

int num = Random.Shared.Next(100);

Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");

USER_TURN:

int x = int.Parse(Console.ReadLine());

if (x == num)
{
    Console.WriteLine("That's the number! Well played!");
}
else
{
    Console.WriteLine(x > num ? "Nope! My number is Smaller!" : "Nope! My number is Greater!");
    goto USER_TURN;
}