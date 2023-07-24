public class Service : Concept, ITaxable
{
    public Service(string id, string description, decimal unitPrice)
        : base(id, description, unitPrice)
    {
    }
    public decimal CalcTax()
    {
        return 1.0m * 1.10m;
    }
}