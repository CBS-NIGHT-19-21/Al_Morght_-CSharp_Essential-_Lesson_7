using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int request;

            Trains trains = new Trains(8);

            //for (int i = 0; i < trains.Lenght; i++) // - Проверка сортировки по порядку в массиве.
            //    trains.Show(i);

            Console.Write("Укажите номер искомого поезда: ");
            request = int.Parse(Console.ReadLine());
            
            if (trains[request] >= 0)
                trains.Show(trains[request]);
            else
                Console.WriteLine($"\nПоезда с номером {request} нет в базе.");

            Console.ReadKey();
        }
    }
}
