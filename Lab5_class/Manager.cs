using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Manager
    {
        string fio;
        int age;
        string phone;

        public Manager() { }
        public Manager(String fio, int age, String phone)
        {
            this.fio = fio;
            this.age = age;
            this.phone = phone;
        }
        public void input()
        {
            Console.Write("Введите имя: ");
            this.fio = Console.ReadLine();
            Console.Write("Введите возраст: ");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите телефон: ");
            this.phone = Console.ReadLine();
        }
        public void printAll()
        {
            Console.WriteLine("Имя: " + this.fio + ", Возраст: "
                + this.age + ", Телефон: " + this.phone + "\n");
        }
        public void lvlUp(int num)
        {
            this.age += num;
        }
    }
}
