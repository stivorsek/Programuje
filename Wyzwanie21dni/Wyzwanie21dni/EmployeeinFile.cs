namespace Wyzwanie21dni
{
    internal class EmployeeinFile : EmployeeBase
    {

        public delegate void ScoreAddedDelegate(object sender, EventArgs args);

        public event ScoreAddedDelegate ScoreAdded;

        private const string FileName = "Grades.txt";
        public EmployeeinFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddScore(float number)
        {
            using (var writer = File.AppendText(FileName))
            {

                if (number >= 0 && number <= 100)
                {
                    writer.WriteLine(number);
                    if (ScoreAdded != null)
                    {
                        ScoreAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("To High score");
                }
            }
        }

        public override void AddScore(double number)
        {
            float score = (float)number;
        }

        public override void AddScore(string number)
        {
            if (float.TryParse(number, out float result))
            {
                this.AddScore(result);
            }
            else if (char.TryParse(number, out char resol))
            {
                this.AddScore(resol);

            }
            else
            {
                throw new Exception("U can only put a b c d e letters or 0-100 value");
            }
        }

        public override void AddScore(char number)
        {
            switch (number)
            {
                case 'A':
                case 'a':
                    AddScore(100);
                    break;
                case 'B':
                case 'b':
                    AddScore(80);
                    break;
                case 'C':
                case 'c':
                    AddScore(60);
                    break;
                case 'D':
                case 'd':
                    AddScore(40);
                    break;
                case 'E':
                case 'e':
                    AddScore(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }

        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var count = 1;
            if (File.Exists(FileName))
            {

                using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.Max = Math.Max(statistics.Max, number);
                        statistics.Min = Math.Min(statistics.Min, number);
                        statistics.Avg += number;
                        count++;
                        line = reader.ReadLine();
                    }

                }
            }

                statistics.Avg /= count;
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
