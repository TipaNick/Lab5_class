using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Record
    {
		Kursant kurs = new Kursant();
		Instructor inst = new Instructor();
		Manager manag = new Manager();
		string time;
		Car cr = new Car();

		public Record() { }
		public Record(Kursant kurs, Instructor inst, Manager manag, String time, Car cr)
		{
			this.kurs = kurs;
			this.inst = inst;
			this.manag = manag;
			this.time = time;
			this.cr = cr;
		}

		public static Record operator +(Record rec1, Kursant kurs1)
        {
			rec1.kurs = kurs1;
			return rec1;
        }


		public void input()
		{
			this.kurs.input();
			this.inst.input();
			this.manag.input();
			Console.Write("Введите время: ");
			this.time = Console.ReadLine();
			this.cr.input();
		}
		public void printAll()
		{
			Console.WriteLine("Запись: \n");
			this.kurs.printAll();
			this.inst.printAll();
			this.manag.printAll();
			Console.WriteLine("Время: " + this.time + "\n");
			this.cr.printAll();
		}
	}
}
