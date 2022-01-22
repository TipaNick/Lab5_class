using System;


namespace Lab5_class
{
    class Program
    {
        delegate void Message();
        static void Main(string[] args)
        {
            Message mes;            
            mes = Hello;
            mes();

            void Hello() => Console.WriteLine("Hello Viktor Sergeevich");

        }
    }
}
