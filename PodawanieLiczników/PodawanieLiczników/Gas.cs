namespace PodawanieLiczników
{
    public class Gas : Media
    {
        public const string FileName = "ListaGazu.txt";
        public float gasDiff { get; set; }

        private List<float> GasList = new List<float>();
        public Gas(float Licznik)
        {
                MediaReader(Licznik);
                using (var writer = File.AppendText(FileName))
                {
                    var OstatniWpis = GasList.Last();
                    if (Licznik > OstatniWpis)
                    {
                        writer.WriteLine(Licznik);
                        this.gasDiff = Licznik - OstatniWpis;
                        GetGasConst();
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
                    GasList.Add(nextLine);
                    line = reader.ReadLine();
                }
            }
        }
        public MediaCost GetGasConst()
        {
            var GasConst = new MediaCost();
            GasConst.GasCallculate(gasDiff);
            return GasConst;
            
        }

    }
}
