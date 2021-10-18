using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Instructor
    {
        string fio;
        int age;
        string phone;
        string email;
        int exp;

		public Instructor() { }

		public Instructor(String fio, int age, String phone, String email, int exp)
		{
			this.fio = fio;
			this.age = age;
			this.phone = phone;
			this.email = email;
			this.exp = exp;
		}

		public void input()
		{
			Console.Write("Your name: ");
			this.fio = Console.ReadLine();
			Console.Write("Your age: ");
			this.age = Convert.ToInt32(Console.ReadLine());

			Console.Write("Your phone: ");
			this.phone = Console.ReadLine();

			Console.Write("Your email: ");
			this.email = Console.ReadLine();

			Console.Write("Your expirience: ");
			this.exp = Convert.ToInt32(Console.ReadLine());
		}

		public void printAll()
		{
			Console.WriteLine("Name: " + this.fio + ", Age: " + this.age + ", Phone: "
				+ this.phone + ", Email: " + this.email + ", Expirience: " + exp + "\n");
		}

		public void lvlUp(int num)
		{
			this.exp += num;
		}
	}
}
