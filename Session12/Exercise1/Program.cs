using System;

// A: Count X letter
List<string> inputList = new List<string> { "Example", "Hello", "xD", "Esteban", "box"};
int count = CountLetter(inputList);
Console.WriteLine($"Number of strings containing the letter 'x': {count}");

//B: Calculate circle circumference
double radius = 5.0;
double circumference = CalculateCircumference(radius);
Console.WriteLine($"Circumference of the circle withc radius {radius}: {circumference}");

//C: Count spaces in a string
string inputString = "This is an exam ple";
int spaceCount = CountSpace(inputString);
Console.WriteLine($"Number of spaces in the string: {spaceCount}");

//D: Swap two integer values
int a = 21;
int b = 12;
Console.WriteLine($"Before swap: a = {a}, b = {b}");
Swap(ref a, ref b);
Console.WriteLine($"After swap: a = {a}, b = {b}");

//A.
static int CountLetter(List<string> strings)
{
    int count = 0;

    foreach (string s in strings)
    {
        if (s.Contains('x'))
        {
            count++;
        }
    }
    return count;
}

//B
static double CalculateCircumference(double radius)
{
    return 2 * Math.PI * radius;
}

//C
static int CountSpace(string input)
{
    int count = 0;

    foreach(char c in input)
    {
        if(c == ' ')
        {
            count++;
        }
    }
    
    return count;
}

//D
static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}