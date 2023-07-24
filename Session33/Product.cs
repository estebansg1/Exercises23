public class Product : Concept, ITaxable
{
    public string UnitMeasure { get; }
    public double Quantity { get; }

    public Product(string id, string description, decimal unitPrice, string unitMeasure, double quantity)
        : base(id, description, unitPrice)
    {
        UnitMeasure = unitMeasure;
        Quantity = quantity;
    }

    public decimal CalcTax()
    {
        return (decimal)(Quantity * 1.16);
    }
}