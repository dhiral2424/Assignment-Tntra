int x = 20;
int y = 18;
if (x > y)
{
    Console.WriteLine("x is greater than y");
}
else
{
    Console.WriteLine("y is greater than X.");
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("this is for loop");

int j = 0;
while (j < 5)
{
    Console.WriteLine(j);
    j++;
}
Console.WriteLine("This is While Loop");

int day = 5;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}