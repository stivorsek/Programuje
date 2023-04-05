namespace PodawanieLiczników
{
    public class MediaCost
    {
        public float gasCost { get; set; }
        public float pradCost { get; set; }
        public float watterCost { get; set; }
        public MediaCost()
        {
            this.watterCost = 0;
            this.gasCost = 0;
            this.pradCost = 0;
        }
        public void WatterCallculate(float watterDiff)
        {
            this.watterCost = (float)(watterDiff * 13.67);
        }
        public void GasCallculate(float gasDiff)
        {
             this.gasCost = (float)(gasDiff * 3.67);
        }

        public void ElectricityCallculate(float electricityDiff)
        {
            this.pradCost = (float)(electricityDiff * 1.67);
        }

    }
}
