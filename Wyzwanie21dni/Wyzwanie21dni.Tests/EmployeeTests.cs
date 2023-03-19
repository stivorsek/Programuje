
using System.ComponentModel.DataAnnotations;

namespace Wyzwanie21dni.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void minValue()
        {
            var employee = new Employee("Damian", "Dzieciol");
            employee.AddScore(1);
            employee.AddScore(8);
            var stat = employee.GetStatistics();

            Assert.GreaterOrEqual(stat.Max, 5);

        }


        [Test]
        public void maxValue()
        {
            var employee = new Employee("Damian", "Dzieciol");
            employee.AddScore(1);
            employee.AddScore(8);
            var stat = employee.GetStatistics();

            Assert.LessOrEqual(0, stat.Min);

        }


        [Test]
        public void avgValue()
        {
            var employee = new Employee("Damian", "Dzieciol");
            employee.AddScore(1);
            employee.AddScore(8);
            var stat = employee.GetStatistics();

            Assert.AreNotEqual(stat.Min, stat.Avg);

        }
        [Test]
        public void swithWithScoresInCharsA()
        {
            var employee = new Employee("Damian", "Dzieciol");
            employee.AddScore(80);
            employee.AddScore(96);
            var stat = employee.GetStatistics();

            Assert.AreEqual(stat.AverageLetter, 'A');

        }

        [Test]
        public void swithWithScoresInCharsB()
        {
            var employee = new Employee("Damian", "Dzieciol");
            employee.AddScore(60);
            employee.AddScore(66);
            var stat = employee.GetStatistics();

            Assert.AreEqual(stat.AverageLetter, 'B');

        }

        [Test]
        public void swithWithScoresInCharsC()
        {
            var employee = new Employee("Damian", "Dzieciol");
            employee.AddScore(40);
            employee.AddScore(66);
            var stat = employee.GetStatistics();

            Assert.AreEqual(stat.AverageLetter, 'C');

        }

        [Test]
        public void swithWithScoresInCharsD()
        {
            var employee = new Employee("Damian", "Dzieciol");
            employee.AddScore(10);
            employee.AddScore(66);
            var stat = employee.GetStatistics();

            Assert.AreEqual(stat.AverageLetter, 'D');

        }

        [Test]
        public void swithWithScoresInCharsE()
        {
            var employee = new Employee("Damian", "Dzieciol");
            employee.AddScore(10);
            employee.AddScore(16);
            var stat = employee.GetStatistics();

            Assert.AreEqual(stat.AverageLetter, 'E');

        }

    }
}
