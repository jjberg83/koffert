// See https://aka.ms/new-console-template for more information


// Nøkkel er ord som skal gjøres dirty
// Første subarray er indekser på bokstaver som skal byttes ut
// Neste subarray er indekser på bokstaver som skal bytte plass med de i første subarray
Dictionary<string, int[][]> dirtyBank = new Dictionary<string, int[][]>();
dirtyBank["rungekutta"] = new int[][] {new int[] {3,6}, new int[] {5,9}};
dirtyBank["tyrannosaurus rex"] = new int[][] {new int[] {12}, new int[] {14}};

// Console.WriteLine(dirtyBank["ole"]);



// readDictionary(dirtyBank);

int[][] sjekkVerdi;
var sjekk = dirtyBank.TryGetValue("rungekutt", out sjekkVerdi);
Console.WriteLine(sjekk);
// foreach(var subarray in sjekkVerdi)
// {
//     foreach (var tall in subarray)
//     {
//         Console.Write(tall + ",");
//     }
//     Console.Write("  -  ");
    
// }

void readDictionary(Dictionary<string, int[][]> theDict)
{
    foreach (var kvp in theDict)
    {
        Console.Write($"{kvp.Key}: ");
        int[][] theArray = kvp.Value;

        foreach (var subarray in theArray)
        {
            Console.Write(" Subarray:");
            foreach (var tall in subarray)
            {
                Console.Write(tall);
            }
        }

        Console.WriteLine();
    }
}