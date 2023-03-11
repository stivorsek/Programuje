var number1 = 11;
var number2 = 10;

// ==
// !=
// <
// >
// <=
// >=

var name = "Damian";
var plec = "Mężczyzna";
var age = 15;

bool isActive = true;

if (plec == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa")
{
    Console.WriteLine(name);
    if (age == 33)
    {
        Console.WriteLine(", lat " + age);
    }

}
else if (age < 18)
{
    Console.Write("Niepłnoletni");
    if (!(plec == "Kobieta"))
    {
        Console.Write(" Mężczyzna");
    }
}

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
