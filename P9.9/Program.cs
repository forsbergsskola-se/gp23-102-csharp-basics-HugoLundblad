// See https://aka.ms/new-console-template for more information

//Hypotenuse

string input1 = Console.ReadLine()!;
string input2 = Console.ReadLine()!;
int x = int.Parse(input1);
int y = int.Parse(input2);

int z = (x * x) + (y * y) ;
var hypo = Math.Sqrt(z);

Console.WriteLine($"Hypotenuse: {hypo}");