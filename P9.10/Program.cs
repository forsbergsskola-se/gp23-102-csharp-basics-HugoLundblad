// See https://aka.ms/new-console-template for more information

//SecondsToMinutes

Console.WriteLine("Give me a number of seconds.");

string input = Console.ReadLine()!;
int num = int.Parse(input);

int minutes = num / 60;

int seconds = num % 60;

Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");