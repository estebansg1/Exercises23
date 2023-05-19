public struct Fighter
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public Category Category
    {
        get
        {
            if (Weight < 112)
                return Category.Flyweight;
            else if (Weight < 118)
                return Category.Bantamweight;
            else if (Weight < 126)
                return Category.Featherweight;
            else if (Weight < 135)
                return Category.Lightweight;
            else if (Weight < 147)
                return Category.Welterweight;
            else if (Weight < 160)
                return Category.Middleweight;
            else if (Weight < 175)
                return Category.LightHeavyweight;
            else
                return Category.Heavyweight;
        }
    }
}