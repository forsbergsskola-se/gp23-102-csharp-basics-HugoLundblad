// See https://aka.ms/new-console-template for more information

//BMI

Console.WriteLine("Input Weight");
string input1 = Console.ReadLine()!;
Console.WriteLine("Input Height");
string input2 = Console.ReadLine()!;
int x = int.Parse(input1);
int y = int.Parse(input2);

int bmi = x / (y * y);

Console.WriteLine($"BMI: {bmi}");