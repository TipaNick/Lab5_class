using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_class
{
    class Car : ICloneable
    {
        protected string model;
        protected string num;

        public Car() { }
        public Car(String model, String num)
        {
            this.model = model;
            this.num = num;
        }
        public object Clone()
        {
            return new Car(model, num);
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
    public interface ICloneable
    {
        object Clone();
    }
    class Audi : Car, ICloneable
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
        override public string ToString()
        {
            return ("Модель: " + this.model + ", Номер: " + this.num + ", Секретный номер: " + this.secret_num + "\n");
        }
        //Мелкое копирование
        public object Clone()
        {
            return new Audi(model, num, secret_num);
        }
    }
}
