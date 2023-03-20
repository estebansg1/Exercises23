


class Program
{
    static void Main(string[] args)
    {
        SmallApartment apartment = new SmallApartment();
        Person person = new Person("Esteban", apartment);
        person.ShowData();
    }
}
