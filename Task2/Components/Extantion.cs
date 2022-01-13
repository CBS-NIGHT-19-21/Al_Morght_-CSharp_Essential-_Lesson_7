using System;

namespace Task2
{
    static class Extantion
    {
        public static Train[] Sort(this Train[] trains)
        {
            Train[] temp = new Train[1];

            for (int i = 0; i < trains.Length - 1; i++)
                for (int j = i + 1; j < trains.Length; j++)
                    if (trains[i].Number > trains[j].Number)
                    {
                        temp[0] = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp[0];
                    }

            return trains;
        }

        public static Train Edit(this Train instance)
        {
            Console.Write("Укажите номер поезда: ");
            int Number = int.Parse(Console.ReadLine());

            Console.Write("Укажите место назначения поезда: ");
            string Destynation = Console.ReadLine();

            Console.Write("Укажите время отправления поезда: ");
            string Start = Console.ReadLine();

            Console.WriteLine(" ");

            Train train = new Train(Number, Destynation, Start);

            return train;
        }
    }
}
