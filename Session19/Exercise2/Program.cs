Point2D[] points = new Point2D[1000];

Console.WriteLine("Enter data for the first point:");
points[0] = GetDataFromUser();

Console.WriteLine("\nEnter data for the second point:");
points[1] = GetDataFromUser();

Console.WriteLine("\nContent of the first point:");
DisplayData(points[0]);

Console.WriteLine("\nContent of the second point:");
DisplayData(points[1]);

static Point2D GetDataFromUser()
{
    Point2D point = new Point2D();

    Console.Write("Enter the x coordinate: ");
    point.X = Convert.ToInt16(Console.ReadLine());

    Console.Write("Enter the y coordinate: ");
    point.Y = Convert.ToInt16(Console.ReadLine());

    Console.Write("Enter the red value (0-255): ");
    point.R = Convert.ToByte(Console.ReadLine());

    Console.Write("Enter the green value (0-255): ");
    point.G = Convert.ToByte(Console.ReadLine());

    Console.Write("Enter the blue value (0-255): ");
    point.B = Convert.ToByte(Console.ReadLine());

    return point;
}

static void DisplayData(Point2D point)
{
    Console.WriteLine($"X: {point.X}");
    Console.WriteLine($"Y: {point.Y}");
    Console.WriteLine($"R: {point.R}");
    Console.WriteLine($"G: {point.G}");
    Console.WriteLine($"B: {point.B}");
}