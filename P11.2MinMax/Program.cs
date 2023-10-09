// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

if (x >= y && x >= z)
{
    int high = x;
    if (y < z)
    {
        int mid = z;
        int low = y;
        Console.WriteLine($"{low}, {high}");
    }
    else
    {
        int mid = y;
        int low = z;
        Console.WriteLine($"{low}, {high}");
    }
}
else if (y >= x && y >= z)
{
    int high = y;
    if (x < z)
    {
        int mid = z;
        int low = x;
        Console.WriteLine($"{low}, {high}");
    }
    else
    {
        int mid = x;
        int low = z;
        Console.WriteLine($"{low}, {high}");
    }
}
else
{
    int high = z;
    if (x < y)
    {
        int mid = z;
        int low = x;
        Console.WriteLine($"{low}, {high}");
    }
    else
    {
        int mid = x;
        int low = z;
        Console.WriteLine($"{low}, {high}");
    }
}


Console.WriteLine("A");
Console.WriteLine("A");