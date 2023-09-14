// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input triangle size.");
TRIANGLE_VALID:
int userInput = int.Parse(Console.ReadLine());
if (userInput < 2)
{
    Console.WriteLine("Try a larger number.");
    goto TRIANGLE_VALID;
}
TRIANGLE_GEN:
if (userInput > 0)
{
    Console.WriteLine($"{new string ('#', userInput)}");
    userInput--;
    goto TRIANGLE_GEN;
}