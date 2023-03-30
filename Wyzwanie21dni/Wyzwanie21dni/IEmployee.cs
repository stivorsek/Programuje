using static Wyzwanie21dni.EmployeeBase;

namespace Wyzwanie21dni
{
    public interface IEmployee
    {
        string name { get; }
        string surname { get; }

        void AddScore(float number);

        void AddScore(double number);

        void AddScore(string number);

        void AddScore(char number);

        event ScoreAddedDelegate ScoreAdded;
        Statistics GetStatistics();

    }
}
