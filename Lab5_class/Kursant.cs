using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Kursant
    {
        string fio;
        int age;
        string phone;
        string email;
        string category;

        public Kursant() { }

        public Kursant(string fio, int age, string phone, string email, string category)
        {
            this.fio = fio;
            this.age = age;
            this.phone = phone;
            this.email = email;
            this.category = category;
        }

        public void input()
        {
            Console.Write("Введите имя: ");
            this.fio = Console.ReadLine();
            Console.Write("Введите возраст: ");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите телефон: ");
            this.phone = Console.ReadLine();
            Console.Write("Введите почту: ");
            this.email = Console.ReadLine();
            Console.Write("Введите категорию: ");
            this.category = Console.ReadLine();
        }

        public void printAll()
        {
            Console.WriteLine("Name: " + this.fio + ", Age: " + this.age + ", Phone: " + this.phone
            + ", Email: " + this.email + ", Category: " + category + "\n");
        }
        public void lvlUp(int num)
        {
            this.age += num;
        }
    }
}
