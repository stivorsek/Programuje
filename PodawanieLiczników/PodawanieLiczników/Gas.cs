namespace PodawanieLiczników
{
    public class Gas
    {
        public const string FileName = "ListaGazu.txt";
        private List<float> gasList = new List<float>();
        public Gas(float Licznik) 
        {
            this.gasList.Add(Licznik);
        }


    }
}
