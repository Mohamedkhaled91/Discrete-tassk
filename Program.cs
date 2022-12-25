// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("enter the first number");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter the second number");
int n2 = int.Parse(Console.ReadLine());

 for(int x = n1;x<=n2;x++)
{
    if (x<=1)
    {
        continue;
    }
    else
    {
        int y = 0;
        for(int i =2;i<x; i++)
        {
            if(x%i==0)
            {
                y = 1;
                break;
            }

        }
        if(y==0)
        {
            Console.WriteLine(x);
        }
    }


}
