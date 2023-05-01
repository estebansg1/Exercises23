
List<Car> cars = CarCollection.GetAllCars();

foreach (Car car in cars)
{
    Console.WriteLine("{0} {1} ({2}): {3} - {4} km", car.Brand, car.Model, car.Year, car.Type, car.Kilometers);
}