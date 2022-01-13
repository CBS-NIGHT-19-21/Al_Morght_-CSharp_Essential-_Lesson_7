using System;

namespace Task1
{
    struct Notebook
    {
        string model, manufacture;
        int cost;

        public Notebook(string md, string mf, int ct)
        {
            model = md;
            manufacture = mf;
            cost = ct;
        }

        public void Show()
        {
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Производство: {manufacture}");
            Console.WriteLine($"Стоимость: {cost} USD");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook note = new Notebook("BMW E34","BMW Motors", 5000);

            note.Show();

            Console.ReadKey();
        }
    }
}
