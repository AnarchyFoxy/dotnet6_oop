using Biblioteka;
using static System.Console;

Jednostka asta = new();
WriteLine(asta.ToString());

asta.nazwisko = "Astryda Malinowska";
asta.data_urodzenia = new System.DateTime(1992, 03, 16);

WriteLine(format: "{0} urodziła się w {1:dddd, d MMMM yyyy}",
    arg0: asta.nazwisko,
    arg1: asta.data_urodzenia);

// Output:
// Astryda Malinowska urodziła się w Monday, 16 March 1992

Jednostka gazela = new()
{
    nazwisko = "Gazela Migała",
    data_urodzenia = new DateTime(1999, 8, 23)
};

WriteLine(format: "{0} urodziła się {1:d MMM yy}",
    arg0: gazela.nazwisko,
    arg1: gazela.data_urodzenia);
// Output:
// Gazela Migała urodziła się 23 Aug 99