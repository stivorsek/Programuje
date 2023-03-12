using Wyzwanie21dni;



namespace Wyzwanie21dni


{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, string wiek)
        {
            this.name = name;
            this.surname = surname;
            this.wiek = wiek;
        }
        public string name { get; set; }
        public string surname { get; set; }
        public string wiek { get; set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

        
    }
}
