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
