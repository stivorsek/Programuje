using Wyzwanie21dni;


Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var keyBreak = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Aby wyjść z menu wciśnij l");
    if (keyBreak == "l")
    {
        break;
    }
    employee.AddScore(keyBreak);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Avg}");
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"MIN: {statistics.Min}");


