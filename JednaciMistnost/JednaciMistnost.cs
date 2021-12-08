namespace JednaciMistnost
{
    internal class JednaciMistnost
    {
        private int pocetLidi;
        private string hlaska;

        public int PocetLidi
        {
            get => pocetLidi;
            set
            {
                if (value >= 0 && value <= 5)
                {
                    pocetLidi = value;
                    hlaska = $"Počet osob v jednací místnosti: {value}";
                }
                else if (value < 0)
                {
                    hlaska = "Jednací místnost je volná.";
                }
                else
                {
                    hlaska = "Jednací místnost je obsazena.";
                }
            }
        }

        public JednaciMistnost(int pocetLidi)
        {
            PocetLidi = pocetLidi;
        }

        public override string ToString()
        {
            return hlaska;
        }
    }
}
