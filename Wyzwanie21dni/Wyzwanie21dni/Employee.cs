
using System;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks.Sources;

namespace Wyzwanie21dni
{
    public class Employee : Person
    {

        private List<float> score = new List<float>();
        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {

        }

        public void AddScore(float number)
        {
            if (number >= 0 && number <= 100)
            {
                this.score.Add(number);
            }
            else
            {
                throw new Exception("To High score");
            }
        }
        public void AddScore(char number)
        {
            switch (number)
            {
                case 'A':
                case 'a':
                    this.score.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.score.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.score.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.score.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.score.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }

        }
        public void AddScore(string number)
        {
            if (float.TryParse(number, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                throw new Exception("U can only put a b c d e letters or 0-100 value");
            }

        }
        public void AddScore(double number)
        {
            float score = (float)number;

        }
        public Statistics GetStatistics()
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

            switch (statistics.Avg)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;

                case var A when A >= 60:
                    statistics.AverageLetter = 'B';
                    break;

                case var Avg when Avg >= 40:
                    statistics.AverageLetter = 'C';
                    break;

                case var Avg when Avg >= 20:
                    statistics.AverageLetter = 'D';
                    break;

                case var Avg when Avg > 0:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
