namespace PodawanieLiczników
{
    public class Woda
    {
        public const string FileName = "ListaWody.txt";

        private List<float> WodaList = new List<float>();
        public Woda(float Licznik)
        {
            this.WodaList.Add(Licznik);
        }


    }
}
