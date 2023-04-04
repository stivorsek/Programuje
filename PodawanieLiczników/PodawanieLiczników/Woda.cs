namespace PodawanieLiczników
{
    public class Woda : Media
    {
        public const string FileName = "ListaWody.txt";
        public float WodaDiff { get; set; }

        private List<float> WodaList = new List<float>();
        public Woda(float Licznik)
        {
            MediaReader(Licznik); 

            using (var writer = File.AppendText(FileName))
            {
                var OstatniWpis = WodaList.Last();
                if (Licznik > OstatniWpis)
                {
                    writer.WriteLine(Licznik);
                    this.WodaDiff = Licznik - OstatniWpis;
                    GetMediaCost();
                }
                else
                {
                    throw new Exception("Podany wpis jest niższy o ostatniego wpisz go ponownie");
                }
            }
        }
        public override void MediaReader(float Licznik)
        {
            if (!File.Exists(FileName))
            {

                File.WriteAllText(FileName, "0");

            }
            using (var reader = File.OpenText(FileName))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var nextLine = float.Parse(line);
                    WodaList.Add(nextLine);
                    line = reader.ReadLine();
                }
            }
        }
        public MediaCost GetMediaCost()
        {
            var MediaCost = new MediaCost();
            MediaCost.WodaCallculate(WodaDiff);
            return MediaCost;
        }
    }
}
