namespace PodawanieLiczników
{
    public class Watter : Media
    {
        public const string FileName = "ListaWody.txt";
        public float watterDiff { get; set; }

        private List<float> watterList = new List<float>();
        public Watter(float Licznik)
        {
            MediaReader(Licznik); 

            using (var writer = File.AppendText(FileName))
            {
                var OstatniWpis = watterList.Last();
                if (Licznik > OstatniWpis)
                {
                    writer.WriteLine(Licznik);
                    this.watterDiff = Licznik - OstatniWpis;
                    GetAquaCost();
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
                    watterList.Add(nextLine);
                    line = reader.ReadLine();
                }
            }
        }
        public MediaCost GetAquaCost()
        {
            var MediaCost = new MediaCost();
            MediaCost.WatterCallculate(watterDiff);
            return MediaCost;
        }
    }
}
