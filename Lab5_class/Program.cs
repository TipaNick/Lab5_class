using System;


namespace Lab5_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor[] inst = new Instructor[2];

            for (int i = 0; i < 2; i++)
            {
                inst[i] = new Instructor();
                inst[i].input();
            }
            for(int i = 0; i < 2; i++)
            {
                inst[i].printAll();
            }
        }
    }
}
