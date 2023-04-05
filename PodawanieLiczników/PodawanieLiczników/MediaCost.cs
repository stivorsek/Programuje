namespace PodawanieLiczników
{
    public class MediaCost
    {
        public float gasCost { get; set; }
        public float pradCost { get; set; }
        public float wodaCost { get; set; }
        public MediaCost()
        {
            this.wodaCost = 0;
            this.gasCost = 0;
            this.pradCost = 0;
        }
        public void WodaCallculate(float wodaDiff)
        {
            wodaDiff = (float)(wodaDiff * 13.67);
            this.wodaCost = wodaDiff;
        }
        public void GasCallculate(float gasDiff)
        {
             gasDiff = (float)(gasDiff * 3.67);
             this.gasCost = gasDiff;
        }

        public void PradCallculate(float pradDiff)
        {
            pradDiff = (float)(pradDiff * 1.67);
            this.pradCost = pradDiff;
        }

    }
}
