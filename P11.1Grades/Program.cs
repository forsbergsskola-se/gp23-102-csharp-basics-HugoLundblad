// See https://aka.ms/new-console-template for more information

Console.WriteLine("Numerical score:");

int score = int.Parse(Console.ReadLine());

if (score < 60)
{
    Console.WriteLine("F");
}
else if (score <= 69)
{
    Console.WriteLine("D");
} 
else if (score <= 79)
{
    Console.WriteLine("C");
} 
else if (score <= 89)
{
    Console.WriteLine("B");
} 
else {
    Console.WriteLine("A");
}