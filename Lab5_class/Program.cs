using System;


namespace Lab5_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Record rec = new Record();
            Kursant kurs = new Kursant("Чел", 12, "+79123", "pa@mail.ru", "B");
            rec.printAll();
            rec += kurs;
            rec.printAll();

        }
    }
}
