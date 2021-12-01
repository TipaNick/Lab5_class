using System;


namespace Lab5_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Kursant kurs1 = new Kursant();
            kurs1.input();
            kurs1.printAll();
            Kursant kurs2 = new Kursant();
            Kursant.print_count();
        }
    }
}
