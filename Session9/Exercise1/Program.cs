using System;

class House
{
    private int area;
    private Door _door;

    public House(int area)
    {
        this.area = area;
    }

    public int Area
    {
        get { return area; }
        set { area = value; }
    }

    public Door GetDoor()
    {
        return _door;
    }

    public void ShowData()
    {
        Console.WriteLine($"I am a house, my area is {area} m2");
    }
}

class SmallApartment : House
{
    public SmallApartment() : base(50)
    {
    }
}

class Door
{
    private string _color = "Green";

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public void ShowData()
    {
        Console.WriteLine($"I am a door, my color is {_color} ");
    }
}

class Person
{
    private string _name;
    private House _house;

    public Person(string name, House house)
    {
        _name = name;
        _house = house;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public House House
    {
        get { return _house; }
        set { _house = value; }
    }

    public void ShowData()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write("House: ");
        _house.ShowData();
        Console.Write("Door: ");
        _house.GetDoor().ShowData();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SmallApartment apartment = new SmallApartment();
        Person person = new Person("Esteban", apartment);
        person.ShowData();
    }
}
