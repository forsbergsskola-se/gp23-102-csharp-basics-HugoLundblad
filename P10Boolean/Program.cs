// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");

string input = Console.ReadLine()!;

int age = int.Parse(input);
bool isChild = age <= 12;
bool isTeenager = age <= 19 && !isChild;
bool isGrownup = age > 19;

Console.WriteLine($"You are a child: {isChild}");
Console.WriteLine($"You are a teenager: {isTeenager}");
Console.WriteLine($"You are a grown-up: {isGrownup}");