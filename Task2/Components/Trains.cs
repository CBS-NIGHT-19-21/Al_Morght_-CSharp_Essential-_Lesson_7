using System;

namespace Task2
{
    class Trains
    {
        Train[] trains;

        public Trains(int number)
        {
            trains = new Train[number];

            for (int i = 0; i < trains.Length; i++)
                trains[i] = trains[i].Edit();

            trains.Sort();
        }

        public int this[int index]
        {
            get
            {
                for (int i = 0; i < trains.Length; i++)
                    if (trains[i].Number == index)
                        return i;

                return 0;
            }
        }

        public int Lenght => trains.Length;

        public void Show(int index)
        {
            Console.WriteLine($"\nНомер поеза : № {trains[index].Number}.");
            Console.WriteLine($"Пункт назначегия: {trains[index].Destynation}.");
            Console.WriteLine($"Время отправления: {trains[index].Start}");
        }
    }
}
