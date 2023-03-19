
using System;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks.Sources;

namespace Wyzwanie21dni
{
    public class Employee
    {

        private List<float> score = new List<float>();
        public Employee()
        {
        }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
     
        }
        public string name { get; set; }
        public string surname { get; set; }


        public void AddScore(float number)
        {
            if (number >= 0 && number <= 100)
            {
                this.score.Add(number);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Error : Input is biggger then 100 or lower then 0");
                Console.WriteLine();
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
                    this.score.Add(0);
                    break;
            }

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
                    Console.WriteLine("testr");
                    break;

                case var Avg when Avg >= 40:
                    statistics.AverageLetter = 'C';
                    break;

                case var Avg when Avg >= 20:
                    statistics.AverageLetter = 'D';
                    break;

                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
       
        

        public void AddScore(string number)
        {
            if (float.TryParse(number, out float result))
            {
                this.AddScore(result);
            }

        }
        public void AddScore(double number)
        {
            float score = (float)number;

        }
    }
}
