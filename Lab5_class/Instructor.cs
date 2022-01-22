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
			this.Age = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите телефон: ");
			this.phone = Console.ReadLine();

			Console.Write("Введите email: ");
			this.email = Console.ReadLine();

			Console.Write("Введите опыт работы: ");
			this.exp = Convert.ToInt32(Console.ReadLine());
		}
		public int Age
		{
			set
			{
				if (value < 1 || value > 120)
					Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
				else
					age = value;
			}
			get { return age; }
			
		}

		public void printAll()
		{
			Console.WriteLine("Имя: " + this.fio + ", Возраст: " + this.age + ", Телефон: "
				+ this.phone + ", Email: " + this.email + ", Опыт работы: " + exp + "\n");
		}

		public void lvlUp(ref int num)
		{
			num++;
			this.exp += num;
		}

		public void get_exp(int exp_old, int exp_new, out int result)
        {
			result = exp_new + exp_old;
        }
	}
}
