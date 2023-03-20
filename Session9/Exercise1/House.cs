class House
{
    private int area;
    private Door door;

    public House(int area)
    {
        this.area = area;
        door = new Door();
    }

    public int Area
    {
        get { return area; }
        set { area = value; }
    }

    public Door GetDoor()
    {
        return door;
    }

    public void ShowData()
    {
        Console.WriteLine($"I am a house, my area is {area} m2");
    }
}

class SmallApartment : House
{
    public SmallApartment() : base(200)
    {}
}
