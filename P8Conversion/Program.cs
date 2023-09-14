    // See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number.");

string input = Console.ReadLine()!;

double d = Convert.ToDouble(input); 

Console.WriteLine(d);

int i = (int) d;

Console.WriteLine(i);

int number = int.Parse(input);

Console.WriteLine(number);