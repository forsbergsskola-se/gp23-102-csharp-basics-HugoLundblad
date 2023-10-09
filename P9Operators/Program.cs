// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number of seconds.");

string input = Console.ReadLine()!;

double inputD = Convert.ToDouble(input); 
int inputI = (int) inputD;

int days = inputI / 86400;
int daysRem = inputI % 86400;

int hours = daysRem / 3600;
int hoursRem = daysRem % 3600;

int minutes = hoursRem / 60;

int seconds = hoursRem % 60;

Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");
Console.WriteLine($"{days}.{hours}:{minutes}:{seconds}");

double daysD = inputD / 86400;
Console.WriteLine($"In total, that's {daysD} days.");