// See https://aka.ms/new-console-template for more information

//Product

string input1 = Console.ReadLine()!;
string input2 = Console.ReadLine()!;
int x = int.Parse(input1);
int y = int.Parse(input2);

int num = x * y;

Console.WriteLine($"Result: {num}");