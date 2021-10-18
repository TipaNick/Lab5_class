using System;


namespace Lab5_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Record rec = new Record();
            rec.input();
            rec.printAll();
        }
    }
}
