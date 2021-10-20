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
			Console.Write("Введите имя: ");
			this.fio = Console.ReadLine();
			Console.Write("Введите возраст: ");
			this.age = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите телефон: ");
			this.phone = Console.ReadLine();

			Console.Write("Введите email: ");
			this.email = Console.ReadLine();

			Console.Write("Введите опыт работы: ");
			this.exp = Convert.ToInt32(Console.ReadLine());
		}

		public void printAll()
		{
			Console.WriteLine("Имя: " + this.fio + ", Возраст: " + this.age + ", Телефон: "
				+ this.phone + ", Email: " + this.email + ", Опыт работы: " + exp + "\n");
		}

		public void lvlUp(int num)
		{
			this.exp += num;
		}
	}
}
