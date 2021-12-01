using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Kursant
    {
        static int count = 0;
        string fio;
        int age;
        string phone;
        string email;
        string category;

        public Kursant() { count++; }

        public Kursant(string fio, int age, string phone, string email, string category)
        {
            this.fio = fio;
            this.age = age;
            this.phone = phone;
            this.email = email;
            this.category = category;
            count++;
        }

        public void input()
        {
            Console.Write("Введите имя: ");
            this.fio = Console.ReadLine();
            Console.Write("Введите возраст: ");
            try
            {
                this.age = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Неправильный ввод.");
            }
            if (this.age < 16)
            {
                try
                {
                    throw new Exception("Возраст мал");
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

            Console.Write("Введите телефон: ");
            this.phone = Console.ReadLine();
            Console.Write("Введите почту: ");
            this.email = Console.ReadLine();
            Console.Write("Введите категорию: ");
            this.category = Console.ReadLine();
        }

        public void printAll()
        {
            Console.WriteLine("Имя: " + this.fio + ", Возраст: " + this.age + ", Телефон: " + this.phone
            + ", Email: " + this.email + ", Категория: " + category + "\n");
        }
        public void lvlUp(int num)
        {
            this.age += num;
        }

        public static void print_count()
        {
            Console.WriteLine("Всего студентов: " + count + "\n");
        }
    }
}
