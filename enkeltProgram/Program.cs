// See https://aka.ms/new-console-template for more information

IDictionary<string, int> something = new Dictionary<string, int>() 
{
    {"rungekutta", 35},
    {"tyrannosaurus rex", 1214}
};

foreach(var kvp in something)
{
    Console.WriteLine($"Nøkkel: {kvp.Key}, Verdi: {kvp.Value}");
}