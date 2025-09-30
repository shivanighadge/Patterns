Console.WriteLine("------------------ Pattern 1 ------------------");

int n = 5;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("------------------ Pattern 2 ------------------");

for (int i = 5; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("------------------ Pattern 2 ------------------");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 6 - i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("------------------ Pattern 3 ------------------");
for (int i = 1; i <= n; i++)
{
    for (int s = i; s <= n - 1; s++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
    {
        Console.Write(" " + j);
    }
    Console.WriteLine();
}

