using System;

public class ScreenText
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
