
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