
namespace Task2
{
    struct Train
    {
        string destynation, start;
        int number;

        public Train(int number, string destynation, string start)
        {
            this.number = number;
            this.destynation = destynation;
            this.start = start;
        }

        public int Number { get { return number; } }

        public string Destynation { get { return destynation; } }

        public string Start { get { return start; } }
    }
}
