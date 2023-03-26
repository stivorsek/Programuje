using System;
using Wyzwanie21dni;


Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Damian", "dzie");
employee.ScoreAdded += EmployeeScoreAdded;
employee.ScoreAdded += EmployeeScoreAdded;
employee.ScoreAdded += EmployeeScoreAdded;

void EmployeeScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("/////////////");
    Console.WriteLine("Dodano nową ocenę!!!");
    Console.WriteLine("//////////////");
}


employee.ScoreAdded -= EmployeeScoreAdded;
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Aby wyjść z menu wciśnij q");
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddScore(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}


var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Avg}");
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"MIN: {statistics.Min}");


