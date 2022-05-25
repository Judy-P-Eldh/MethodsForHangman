// See https://aka.ms/new-console-template for more information


int count = 10;

static int CountDown(int count)
{
    for (int i = 10; i > 0; i--)
    {
        Console.WriteLine(i.ToString());
        Console.WriteLine(count);
    }
    return count;
    
}

