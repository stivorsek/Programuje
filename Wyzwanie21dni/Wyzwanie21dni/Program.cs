using Wyzwanie21dni;


var employee = new Employee("Damian", "Dzieciol");

employee.AddScore("11");
employee.AddScore("10");
employee.AddScore(12);
employee.AddScore(2);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor(); 
var statistics3 = employee.GetStatisticsWithWhile();



Console.WriteLine($"Average: {statistics.Avg:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine($"Average: {statistics2.Avg:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine($"Average: {statistics3.Avg:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

















































//User user1 = new User("Damian","111");
//User user2 = new User("Ewa", "111");
//User user3 = new User("Zuzia", "111");
//User user4 = new User("Adam", "111");
//User user5 = new User("Karol", "111");
//User user6 = new User("Tadeusz", "111");
//Employee Employee1 = new Employee("Damian", "dz");
//Employee Employee2 = new Employee("Damian", "dz");
//Employee Employee3 = new Employee("Damian", "dz");

//Employee1.AddScore(5);
//Employee1.AddScore(2);
//Employee1.AddScore(3);
//Employee1.AddScore(4);
//Employee1.AddScore(5);

//Employee2.AddScore(5);
//Employee2.AddScore(1);
//Employee2.AddScore(2);
//Employee2.AddScore(1);
//Employee2.AddScore(1);

//Employee3.AddScore(2);
//Employee3.AddScore(2);
//Employee3.AddScore(2);
//Employee3.AddScore(2);
//Employee3.AddScore(7);

//var resultUser1 = Employee1.Result;
//var resultUser2 = Employee2.Result;
//var resultUser3 = Employee3.Result;
//Console.WriteLine(resultUser1);
//Console.WriteLine(resultUser2);
//Console.WriteLine(resultUser3);

//List<Employee> employees = new List<Employee> { Employee1, Employee2, Employee3 };
//int maxResult = -1;
//Employee EmployerWithMaxResult = null;


//foreach (var employee in employees)
//{
//  if (employee.Result > maxResult)
//   {
//       EmployerWithMaxResult = employee;
//    }
//}
//Console.WriteLine("Imie " + EmployerWithMaxResult.name);
//Console.WriteLine("Nazwisko " + EmployerWithMaxResult.surname);
//Console.WriteLine("Lat: " + EmployerWithMaxResult.wiek);
//Console.WriteLine(EmployerWithMaxResult.Result);


























//user1.AddScore(5);
//user1.AddScore(6);
//var result = user1.Result;
//Console.WriteLine(result);





























































//using static System.Runtime.InteropServices.JavaScript.JSType;

//int[] grades = new int[365];

//List<string> dayOfWeek = new List<string>();

//dayOfWeek.Add("Poniedziałek");
//dayOfWeek.Add("Wtorek");
//dayOfWeek.Add("Środa");
//dayOfWeek.Add("Czwartek");
//dayOfWeek.Add("Piątek");
//dayOfWeek.Add("Sobota");
//dayOfWeek.Add("Niedziela");
//Console.WriteLine(dayOfWeek[2]);

//string[] dayOfWeek2 = { "", "", "", "srdoa", "", "", "" };
//Console.WriteLine(dayOfWeek2[3]);


//var number = Console.ReadLine();
//string numberInStirng = number.ToString();
//char[] letters = numberInStirng.ToCharArray();

//var number0 = 0;
//var number1 = 0;
//var number2 = 0;
//var number3 = 0;
//var number4 = 0;
//var number5 = 0;
//var number6 = 0;
//var number7 = 0;
//var number8 = 0;
//var number9 = 0;
//foreach (char c in letters)
//{
//    if (c == '0') { number0++; }
//    if (c == '1') { number1++; }
//    if (c == '2') { number2++; }
//    if (c == '3') { number3++; }
//    if (c == '4') { number4++; }
//    if (c == '5') { number5++; }
//    if (c == '6') { number6++; }
//    if (c == '7') { number7++; }
//    if (c == '8') { number8++; }
//    if (c == '9') { number9++; }
//    Console.WriteLine(number4);
//}
//Console.WriteLine("0 => " + number0);
//Console.WriteLine("1 => " + number1);
//Console.WriteLine("2 => " + number2);
//Console.WriteLine("3 => " + number3);
//Console.WriteLine("4 => " + number4);
//Console.WriteLine("5 => " + number5);
//Console.WriteLine("6 => " + number6);
//Console.WriteLine("7 => " + number7);
//Console.WriteLine("8 => " + number8);
//Console.WriteLine("9 => " + number9);



//foreach (var day in dayOfWeek)
//{
//    Console.WriteLine(day);
//}



//for (int i=0; i<dayOfWeek.Count; i=i+2)
//{
//    Console.WriteLine(dayOfWeek[i]);
//}















































//var number1 = 11;
//var number2 = 10;

// ==
// !=
// <
// >
// <=
// >=

//var name = "Damian";
//var plec = "Mężczyzna";
//var age = 15;

//bool isActive = true;

//if (plec == "Kobieta" && age < 30)
//{
//   Console.WriteLine("Kobieta poniżej 30 lat");
//}
//
//else if (name == "Ewa")
//{
//    Console.WriteLine(name);
//    if (age == 33)
//    {
//       Console.WriteLine(", lat " + age);
//    }

//}
//else if (age < 18)
//{
//    Console.Write("Niepłnoletni");
//    if (!(plec == "Kobieta"))
//    {
//        Console.Write(" Mężczyzna");
//    }
//}

// &&
// ||
// !















































//liczby calkowite

//int myAge2 = 120;
//int myAge3 = myAge2 + 5;
//Console.WriteLine(myAge3);
//int myVar = -5;
//uint myVar2 = uint.MaxValue;

// liczby zmiennoprzecinkowe\
//float myNumber = float.MaxValue;
//double myVar3 = double.MaxValue;

// zmienne tekstowe
//string name = "Damian";
//string surname = "Dzieciol";
//string results = name + " " + surname + " "+myAge2;
//Console.WriteLine(results);
//char myVar4 = 'a';
//var result2 = name.ToArray();

// zmienna logiczna
//bool isActive = false;
//isActive = true;
//var isValid = 5 > 6;
//Console.WriteLine(isValid);
