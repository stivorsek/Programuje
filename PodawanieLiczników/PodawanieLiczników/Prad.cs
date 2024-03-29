﻿namespace PodawanieLiczników
{
    public class Prad : Media
    {
        public const string FileName = "ListaPradu.txt";
        public float pradDiff { get; set; }

        private List<float> PradList = new List<float>();
        public Prad(float Licznik)
        {
            
            MediaReader(Licznik);
            using (var writer = File.AppendText(FileName))
            {
                var OstatniWpis = PradList.Last();
                if (Licznik > OstatniWpis)
                {
                    writer.WriteLine(Licznik);
                    this.pradDiff = Licznik - OstatniWpis;
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
                    PradList.Add(nextLine);
                    line = reader.ReadLine();
                }
            }
        }
        public MediaCost GetMediaCost()
        {
            var MediaCost = new MediaCost();
            MediaCost.PradCallculate(pradDiff);
            return MediaCost;
        }
    }

}