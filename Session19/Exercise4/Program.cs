using System;

Square square = GetSquareDimensionsFromUser();
CalculateSquareProperties(ref square);
DisplaySquareProperties(square);

static Square GetSquareDimensionsFromUser()
{
    Square square = new Square(); // Inicializar la variable square

    Console.WriteLine("Input the dimensions of the Square (equal length and breadth):");

    Console.Write("Length: ");
    square.Length = Convert.ToInt32(Console.ReadLine());

    Console.Write("Breadth: ");
    square.Breadth = Convert.ToInt32(Console.ReadLine());

    return square;
}

static void CalculateSquareProperties(ref Square square)
{
    square.Perimeter = 2 * (square.Length + square.Breadth);
    square.Area = square.Length * square.Breadth;
}

static void DisplaySquareProperties(Square square)
{
    Console.WriteLine("\nPerimeter and Area of the square:");
    Console.WriteLine($"Length: {square.Length} Breadth: {square.Breadth}");
    Console.WriteLine($"Perimeter: {square.Perimeter} Area: {square.Area}");
}
