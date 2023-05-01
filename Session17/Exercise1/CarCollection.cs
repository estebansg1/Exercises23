public static class CarCollection
{
    public static List<Car> GetAllCars()
    {
        List<Car> cars = new List<Car>();

        cars.Add(new Car { Brand = "Toyota", Model = "Corolla", Year = 2018, Type = "Standard", Kilometers = 30000 });
        cars.Add(new Car { Brand = "Honda", Model = "Civic", Year = 2020, Type = "Manual", Kilometers = 15000 });
        cars.Add(new Car { Brand = "Ford", Model = "Mustang", Year = 2015, Type = "Standard", Kilometers = 50000 });
        cars.Add(new Car { Brand = "Chevrolet", Model = "Camaro", Year = 2019, Type = "Manual", Kilometers = 25000 });
        cars.Add(new Car { Brand = "Mazda", Model = "CX-5", Year = 2021, Type = "Standard", Kilometers = 10000 });

        return cars;
    }
}