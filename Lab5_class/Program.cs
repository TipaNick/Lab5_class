using System;


namespace Lab5_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr1 = new Car("Benz", "112");
            Audi cr2 = new Audi("Audi", "321", 777);
            cr2.printAll();
        }
    }
}
