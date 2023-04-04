namespace PodawanieLiczników
{
    public class MediaCost
    {
        public float GasCost { get; set; }
        public float PradCost { get; set; }
        public float WodaCost { get; set; }
        public MediaCost()
        {
            this.WodaCost = 0;
            this.GasCost = 0;
            this.PradCost = 0;
        }
        public void WodaCallculate(float WodaDiff)
        {
            WodaDiff = (float)(WodaDiff * 13.67);
            this.WodaCost = WodaDiff;
        }
        public void GasCallculate(float GasDiff)
        {
             GasDiff = (float)(GasDiff * 3.67);
             this.GasCost = GasDiff;
        }

        public void PradCallculate(float PradDiff)
        {
            PradDiff = (float)(PradDiff * 1.67);
            this.PradCost = PradDiff;
        }

    }
}
