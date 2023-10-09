// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please pass me a seed (integer).");

int seedInput = int.Parse(Console.ReadLine());
Random random = new Random(seedInput);

Console.WriteLine("Three integers between 0.0 and 0.5:");

Console.WriteLine(random.Next(0, 5));
Console.WriteLine(random.Next(0, 5));
Console.WriteLine(random.Next(0, 5));

Console.WriteLine("Three numbers between 0.0 and 0.5:");

Console.WriteLine(random.NextDouble() * 0.5);
Console.WriteLine(random.NextDouble() * 0.5);
Console.WriteLine(random.NextDouble() * 0.5);

Console.WriteLine("Three numbers between 0.2 and 0.7:");

Console.WriteLine(random.NextDouble() * 0.5 + 0.2);
Console.WriteLine(random.NextDouble() * 0.5 + 0.2);
Console.WriteLine(random.NextDouble() * 0.5 + 0.2);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");

double critInput = double.Parse(Console.ReadLine());
int i = 5;

while (i >= 1)
{
    double roll = random.NextDouble();
    bool crit = roll < critInput;
    if (crit)
    {
        Console.WriteLine("Crit");
    }
    else
    {
        Console.WriteLine("No Crit");
    }
    i--;
}

