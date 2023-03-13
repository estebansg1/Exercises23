using System;

class ScreenText
{
    private int x, y;
    private string text;

    public ScreenText(int x, int y, string text)
    {
        this.x = x;
        this.y = y;
        this.text = text;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(text);
    }
}

class CenteredText : ScreenText
{
    public CenteredText(int y, string text) : base(0, y, text)
    {
    }

    public new int X
    {
        get { return base.X; }
        set { /* ignore X value */ }
    }

    public new void Display()
    {
        Console.SetCursorPosition((Console.WindowWidth - Text.Length) / 2, Y);
        Console.Write(Text);
    }
}

class FramedText : CenteredText
{
    private int startingRow;

    public FramedText(int startingRow, string text) : base(startingRow + 1, text)
    {
        this.startingRow = startingRow;
    }

    public new void Display()
    {
        int leftMargin = (Console.WindowWidth - Text.Length) / 2;
        Console.SetCursorPosition(leftMargin, startingRow);
        Console.Write(new string('-', Text.Length + 2));
        base.Display();
        Console.SetCursorPosition(leftMargin, startingRow + 2);
        Console.Write(new string('-', Text.Length + 2));
    }
}

class Program
{
    static void Main(string[] args)
    {
        ScreenText screenText = new ScreenText(2, 2, "Hello, world!");
        CenteredText centeredText = new CenteredText(5, "Hello, world is centered");
        FramedText framedText = new FramedText(10, "Hello, world is framed");

        screenText.Display();
        centeredText.Display();
        framedText.Display();
    }
}
