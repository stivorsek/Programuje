
using System;
using System.Threading.Tasks.Sources;

namespace Wyzwanie21dni
{
    public class Employee
    {

        private List<float> score = new List<float>();
        public Employee(string name, string surname/*, string wiek*/)
        {
            this.name = name;
            this.surname = surname;
            //this.wiek = wiek;
        }
        public string name { get; set; }
        public string surname { get; set; }
        //public string wiek { get; set; }

        // public float Result
        // {
        //     get
        //     {
        //         return this.score.Sum();
        //     }
        //
        // }

        public void AddScore(float number)
        {
            if (number >= 0 && number <= 100)
            {
                this.score.Add(number);
            }
            else
            {
                Console.WriteLine("Nieprawidlowa Wartosc");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.score[index]);
                statistics.Min = Math.Min(statistics.Min, this.score[index]);
                statistics.Avg += this.score[index];
                index++;
            } while (index < this.score.Count);

            statistics.Avg /= this.score.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var score in this.score)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Avg += score;

            }

            statistics.Avg /= this.score.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            for (int index = 0; index < this.score.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, this.score[index]);
                statistics.Min = Math.Min(statistics.Min, this.score[index]);
                statistics.Avg += this.score[index];
            }

            statistics.Avg /= this.score.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            while (index < this.score.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.score[index]);
                statistics.Min = Math.Min(statistics.Min, this.score[index]);
                statistics.Avg += this.score[index];

                index++;
            }


            statistics.Avg /= this.score.Count;
            return statistics;
        }

        public void AddScore(string number)
        {
            if (float.TryParse(number, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                Console.WriteLine("This is not float");
            }

        }
        public void AddScore(double number)
        {
            float score = (float)number;

        }
    }
}
