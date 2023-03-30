namespace Wyzwanie21dni
{
    public class Statistics
    {
        public float Min { get; set; }

        public float Max { get; set; }
        public float Sum { get; set; }
        public float Count { get; set; }

        public float Avg 
        { 
            get 
            {
                return this.Sum/this.Count;
            } 
        }
        public char AverageLetter 
        { get
            {
                switch (this.Avg)
                {
                    case var Avg when Avg >= 80:
                        return 'A';
                    case var Avg when Avg >= 60:
                        return 'B';
                    case var Avg when Avg >= 40:
                        return 'C';
                    case var Avg when Avg >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Sum = 0;
            this.Count = 0;
            
        }

        public void AddScore (float score) 
        {
            this.Count++; 
            this.Sum += score;
            this.Min = Math.Min(this.Min, score);
            this.Max = Math.Max(this.Max, score);
        }

    }
}
