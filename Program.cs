
int age = 25;               
long population = 7800000000L; 

float pi = 3.14F;           
double gravity = 9.81;      

char grade = 'A';           

string message = "Hello"; 


bool isStudent = false;     

// Output the variables
Console.WriteLine("Age : " + age);
Console.WriteLine("World Population : " + population);
Console.WriteLine("Value of Pi : " + pi);
Console.WriteLine("Earth Gravity : " + gravity);
Console.WriteLine("Grade : " + grade);
Console.WriteLine("Message : " + message);
Console.WriteLine("Is Student : " + isStudent);


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



Console.Write("Enter a number to calculate its factorial: ");
int number =5; 
long factorial = 1; 

for (int i = 1; i <= number; i++)
{
    factorial *= i; 
}

Console.WriteLine($"Factorial of {number} is: {factorial}");
