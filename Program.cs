// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("enter  the first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter the second number");
int num2 = int.Parse(Console.ReadLine());
for (int x = num1; x < num2; x++)
{
    int z = the_perfect(x);
    if (x == z)
    {
        Console.WriteLine(x);
    }
}
static int the_perfect(int p)
{
    int all = 0;
    for (int i = 1; i < p; i++)
    {
        if (p % i == 0)
        {
            all = all + i;
        }

    }
    return all;
}

