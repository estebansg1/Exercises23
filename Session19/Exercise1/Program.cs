Point2D point1 = new Point2D();
Point2D point2 = new Point2D();

Console.WriteLine("Enter data for point 1:");
Console.Write("X coordinate: ");
point1.X = short.Parse(Console.ReadLine());
Console.Write("Y coordinate: ");
point1.Y = short.Parse(Console.ReadLine());
Console.Write("Red color: ");
point1.R = byte.Parse(Console.ReadLine());
Console.Write("Green color: ");
point1.G = byte.Parse(Console.ReadLine());
Console.Write("Blue color: ");
point1.B = byte.Parse(Console.ReadLine());

Console.WriteLine("Enter data for point 2:");
Console.Write("X coordinate: ");
point2.X = short.Parse(Console.ReadLine());
Console.Write("Y coordinate: ");
point2.Y = short.Parse(Console.ReadLine());
Console.Write("Red color: ");
point2.R = byte.Parse(Console.ReadLine());
Console.Write("Green color: ");
point2.G = byte.Parse(Console.ReadLine());
Console.Write("Blue color: ");
point2.B = byte.Parse(Console.ReadLine());

Console.WriteLine("Point 1:");
Console.WriteLine($"X: {point1.X}, Y: {point1.Y}, Color (R,G,B): ({point1.R},{point1.G},{point1.B})");
Console.WriteLine("Point 2:");
Console.WriteLine($"X: {point2.X}, Y: {point2.Y}, Color (R,G,B): ({point2.R},{point2.G},{point2.B})");