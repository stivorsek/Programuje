namespace PodawanieLiczników
{
    public class Prad
    {
        public const string FileName = "ListaPradu.txt";

        private List<float> PradList = new List<float>();
        public Prad(float Licznik)
        {
            PradReader(Licznik);
            using (var writer = File.AppendText(FileName))
            {
                var OstatniWpis = PradList.Last();
                if (Licznik > OstatniWpis)
                {
                    writer.WriteLine(Licznik);

                }
                else
                {
                    throw new Exception("Podany wpis jest niższy o ostatniego wpisz go ponownie");
                }
            }
        }

        public void PradReader( float Licznik)
        {
            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var nextLine = float.Parse(line);
                        PradList.Add(nextLine);
                        line = reader.ReadLine();
                    }
                }
            }
        }
}
    
}