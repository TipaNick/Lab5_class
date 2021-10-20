using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Car
    {
        string model;
        string num;

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
}
