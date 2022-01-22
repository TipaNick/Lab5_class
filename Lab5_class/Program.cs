using System;


namespace Lab5_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int old_exp = 6;
            int new_exp = 1;
            int result;
            Instructor inst = new Instructor();
            inst.get_exp(old_exp, new_exp, out result);
            Console.WriteLine($"Результат: {result}");

        }
    }
}
