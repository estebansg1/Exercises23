public class CenteredText : ScreenText
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
