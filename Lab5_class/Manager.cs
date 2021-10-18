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
            Console.Write("Your name: ");
            this.fio = Console.ReadLine();
            Console.Write("Your age: ");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your phone: ");
            this.phone = Console.ReadLine();
        }
        public void printAll()
        {
            Console.WriteLine("Name: " + this.fio + ", Age: "
                + this.age + ", Phone: " + this.phone + "\n");
        }
        public void lvlUp(int num)
        {
            this.age += num;
        }
    }
}
