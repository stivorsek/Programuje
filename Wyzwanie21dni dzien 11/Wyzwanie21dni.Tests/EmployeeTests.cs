
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

        
    }
}
