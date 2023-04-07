using NeuralHarmony;
using NeuralHarmony.Data;

var a = new NeuralHarmonyNetwork("weights.json");
// await a.WriteWeights("weights.json");
//await a.ReadWeights();

a.Train(new SongData[]
{
    new SongData ("Anus", "Penis", "Am", new string[]{ "Am", "Dm", "Emaj7"})
});

//Console.Write("Enter key: ");
//string key = Console.ReadLine()!;

//var notes = a.GenerateHarmony(key);

//Console.Write("Harmony example: ");
//Console.WriteLine(string.Join(" ", notes));