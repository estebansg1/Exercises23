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