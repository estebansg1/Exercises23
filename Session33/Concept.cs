public class Concept
{
    public string Id { get; }
    public string Description { get; }
    public decimal UnitPrice { get; }

    public Concept(string id, string description, decimal unitPrice)
    {
        Id = id;
        Description = description;
        UnitPrice = unitPrice;
    }
}