namespace JednaciMistnost
{
    internal class MeetingRoom
    {
        private int peopleCount;
        private string message;

        public int PeopleCount
        {
            get => peopleCount;
            set
            {
                if (value >= 0 && value <= 5)
                {
                    peopleCount = value;
                    message = $"Počet osob v jednací místnosti: {value}";
                }
                else if (value < 0)
                {
                    message = "Jednací místnost je volná.";
                }
                else
                {
                    message = "Jednací místnost je obsazena.";
                }
            }
        }

        public MeetingRoom(int peopleCount)
        {
            PeopleCount = peopleCount;
        }

        public override string ToString()
        {
            return message;
        }
    }
}
