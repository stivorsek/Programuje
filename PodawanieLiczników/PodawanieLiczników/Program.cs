using PodawanieLiczników;
using System.ComponentModel;

Console.WriteLine("Witaj w programie do przeliczania opłat za wodę, gaz oraz prąd");
Console.WriteLine("Poniżej wpisz swoje imie");
var imie = Console.ReadLine();
Console.WriteLine("Poniżej wpisz swoje nazwisko");
var nazwisko = Console.ReadLine();

var occupant = new Occupant(imie, nazwisko);
while (true)
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Proszę wybrać za co chcesz poznac opłatę");
    Console.WriteLine("1)Opłata za gaz");
    Console.WriteLine("2)Opłata za wodę");
    Console.WriteLine("3)Opłata za prąd");
    Console.WriteLine("Lub wybierz 'q' aby wyjść z programu");
    var media = Console.ReadLine();
    if (media == "q")
    {
        break;
    }
    try
    {
        occupant.ChoseMedia(media);
    }
    catch (Exception e) 
    { 
        Console.WriteLine($"Error:{e.Message}");
    }
}



