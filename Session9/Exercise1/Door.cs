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
