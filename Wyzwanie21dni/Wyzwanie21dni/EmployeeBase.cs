namespace Wyzwanie21dni
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void ScoreAddedDelegate();
        public event ScoreAddedDelegate ScoreAdded;
        public EmployeeBase(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string name { get; private set; }

        public string surname { get; private set; }
        public abstract void AddScore(float number);

        public abstract void AddScore(double number);


        public abstract void AddScore(string number);


        public abstract void AddScore(char number);

        public abstract Statistics GetStatistics();
    }
}
