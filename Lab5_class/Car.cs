using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Car
    {
        protected string model;
        protected string num;

        public Car() { }
        public Car(String model, String num)
        {
            this.model = model;
            this.num = num;
        }
        public void input()
        {
            Console.Write("Введите модель: ");
            this.model = Console.ReadLine();

            Console.Write("Введите номер: ");
            this.num = Console.ReadLine();
        }
        public void printAll()
        {
            Console.WriteLine("Модель: " + this.model + ", Номер: " + this.num + "\n");
        }
        public void changeNum(String num)
        {
            this.num = num;
        }
    }
    class Audi : Car
    {
        private int secret_num;
        public Audi(String model, String num, int secret_num) : base(model, num)
        {
            this.secret_num = secret_num;
        }
        new public void changeNum(String num)
        {
            this.num = num + "_Changed";
        }
        new public void printAll()
        {
            Console.WriteLine("Модель: " + this.model + ", Секретный номер: " + this.secret_num + ", Номер: " + this.num + "\n");
        }
    }
}
