List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
        Console.WriteLine("--------------------------------------------------------------------------");
}


// 1 
// Use LINQ to find the first eruption that is in Chile and print the result.
Eruption? Chilie = eruptions.FirstOrDefault(e => e.Location == "Chile");
if (Chilie == null) 
{ 
    Console.WriteLine("No Eruptions in Chilie"); 
}
else 
{ 
    Console.WriteLine(Chilie); 
}
Console.WriteLine("--------------------------------------------------------------------------");


// 2 
// Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? Hawaii = eruptions.FirstOrDefault(e => e.Location == "Hawaiian");
if (Hawaii == null) 
{ 
    Console.WriteLine("No Hawaiian Is Eruption found."); 
}
else 
{ 
    Console.WriteLine(Hawaii); 
}
Console.WriteLine("--------------------------------------------------------------------------");


// 3
// Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."
Eruption? GreenLand = eruptions.FirstOrDefault(e => e.Location == "GreenLand");
if (GreenLand == null) 
{ 
    Console.WriteLine("No Greenland Eruption is found.");
}
else 
{ 
    Console.WriteLine(GreenLand); 
}
Console.WriteLine("--------------------------------------------------------------------------");


// 4
// Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption? NewZealand = eruptions.FirstOrDefault(e => e.Year > 1900 && e.Location == "New Zealand");
Console.WriteLine(NewZealand);
Console.WriteLine("--------------------------------------------------------------------------");


// 5
// Find all eruptions where the volcano's elevation is over 2000m and print them.
List<Eruption> TwoThousandMeters = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
TwoThousandMeters.ForEach(Console.WriteLine);
Console.WriteLine("--------------------------------------------------------------------------");

// 6
// Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
List<Eruption> LNames = eruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
LNames.ForEach(Console.WriteLine);
Console.WriteLine("--------------------------------------------------------------------------");


// 7
// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int HighestElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine(HighestElevation);
Console.WriteLine("--------------------------------------------------------------------------");


// 8
// Use the highest elevation variable to find and print the name of the Volcano with that elevation.
List<string> TallestValcano = eruptions.Where(e => e.ElevationInMeters == HighestElevation).Select(e => e.Volcano).ToList();
TallestValcano.ForEach(Console.WriteLine);
Console.WriteLine("--------------------------------------------------------------------------");


// 9
// Print all Volcano names alphabetically.
List<string> InOrder = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
InOrder.ForEach(Console.WriteLine);
Console.WriteLine("--------------------------------------------------------------------------");


// 10
// Print the sum of all the elevations of the volcanoes combined.
int ElevationSum = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine(ElevationSum);
Console.WriteLine("--------------------------------------------------------------------------");


// 11
// Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)
bool BigBoom = eruptions.Any(e => e.Year == 2000);
Console.WriteLine($"{BigBoom} Some Valconos Errupted in the year 2000");
Console.WriteLine("--------------------------------------------------------------------------");


// 12
// Find all stratovolcanoes and print just the first three (Hint: look up Take)
List <Eruption> ValStratovolcanoes = eruptions.Where(e => e.Type =="Stratovolcano").Take(3).ToList();
ValStratovolcanoes.ForEach(Console.WriteLine);
Console.WriteLine("--------------------------------------------------------------------------");


// 13
// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
List <Eruption> OldVal = eruptions.OrderBy(e => e.Volcano).Where(e => e.Year <= 1000).ToList();
OldVal.ForEach(Console.WriteLine);
Console.WriteLine("--------------------------------------------------------------------------");


// 14

// Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
List<string> OldValTwo = eruptions.OrderBy(e => e.Volcano).Where(e => e.Year <= 1000).Select(e => e.Location).ToList();
OldValTwo.ForEach(Console.WriteLine);
Console.WriteLine("--------------------------------------------------------------------------");