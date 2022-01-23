using System;


namespace Lab5_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr1 = new Car("Audi", "123");
            Car cr2 = new Car("Audi", "321");
            cr1.printAll();
            cr2.printAll();
            cr2 = cr1;
            cr2.printAll();
            
        }
    }
}
