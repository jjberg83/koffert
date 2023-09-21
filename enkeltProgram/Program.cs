// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

// IDictionary<string, Array> dirtyBank = new Dictionary<string, Array>() 
// {
//     {"rungekutta", [[3],[5]]},
//     {"tyrannosaurus rex", [[12,14]]}
// };

// foreach(var kvp in dirtyBank)
// {
//     Console.WriteLine($"Nøkkel: {kvp.Key}, Verdi: {kvp.Value}");
// }

Dictionary<string, int[][]> dirtyBank = new Dictionary<string, int[][]>();

// Nøkkel er ord som skal gjøres dirty
// Første subarray er indekser på bokstaver som skal byttes ut
// Neste subarray er indekser på bokstaver som skal bytte plass med de i første subarray
dirtyBank["rungekutta"] = new int[][] {new int[] {3}, new int[] {5}};

readDictionary(dirtyBank);

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