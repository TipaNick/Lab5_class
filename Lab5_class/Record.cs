using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Record
    {
		Kursant kurs;
		Instructor inst;
		Manager manag;
		string time;
		Car cr;

		public Record() { }
		public Record(Kursant kurs, Instructor inst, Manager manag, String time, Car cr)
		{
			this.kurs = kurs;
			this.inst = inst;
			this.manag = manag;
			this.time = time;
			this.cr = cr;
		}
		public void input()
		{
			this.kurs.input();
			this.inst.input();
			this.manag.input();
			Console.Write("Your time: ");
			this.time = Console.ReadLine();
			this.cr.input();
		}
		public void printAll()
		{
			Console.WriteLine("Record: \n");
			this.kurs.printAll();
			this.inst.printAll();
			this.manag.printAll();
			Console.WriteLine("Time: " + this.time + "\n");
			this.cr.printAll();
		}
	}
}
