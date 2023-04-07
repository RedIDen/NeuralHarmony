using KeyNotes;
using NeuralHarmony.Data;
using NeuralHarmony.Layers;
using NeuralHarmony.Neurons;
using System.Text.Json;

#pragma warning disable CS8618

namespace NeuralHarmony
{
    // v1.0 - Majors and Minors only
    public class NeuralHarmonyNetwork
    {
        //private const string WeightsFilePath = "weights.json";
        private const string IsMajor = "IsMajor";
        private const string Fret = "Fret";
        private const string FromEnd = "FromEnd";

        private readonly Random random = new Random();
        private List<Layer> layers;

        // input: isMajor, chordNumberFromEnd, previousChordFret;
        public NeuralHarmonyNetwork()
        {
            layers = new List<Layer>(2);
            var inputLayer = new Layer();
            inputLayer.Add(new InputNeuron(IsMajor));
            layers.Add(inputLayer);

            var outputLayer = new Layer();
            outputLayer.Add(new Neuron($"1m", new List<float>(Enumerable.Repeat(0.5f, inputLayer.Count))));
            outputLayer.Add(new Neuron($"2dim", new List<float>(Enumerable.Repeat(0.5f, inputLayer.Count))));
            outputLayer.Add(new Neuron($"3", new List<float>(Enumerable.Repeat(0.5f, inputLayer.Count))));
            outputLayer.Add(new Neuron($"4m", new List<float>(Enumerable.Repeat(0.5f, inputLayer.Count))));
            outputLayer.Add(new Neuron($"5m", new List<float>(Enumerable.Repeat(0.5f, inputLayer.Count))));
            outputLayer.Add(new Neuron($"6", new List<float>(Enumerable.Repeat(0.5f, inputLayer.Count))));
            outputLayer.Add(new Neuron($"7", new List<float>(Enumerable.Repeat(0.5f, inputLayer.Count))));

            layers.Add(outputLayer);
        }

        public NeuralHarmonyNetwork(string weightsPath)
        {
            var a = ReadWeights(weightsPath);
            a.Wait();
        }

        public IEnumerable<string> GenerateHarmony(string key, int numberOfChords = 4)
        {
            key = key.ToUpper();
            if (!IsKeyValid(key))
            {
                yield return "Invalid key! Use only clear and '#' minor and major keys.";
                yield break;
            }

            bool isKeyMajor = !key.Contains('M');
            int previousChord = 0;

            for (int chordNumberFromEnd = numberOfChords; chordNumberFromEnd > 0; chordNumberFromEnd--)
            {
                (int number, string scale) = GenerateChordData(isKeyMajor, chordNumberFromEnd, previousChord);
                previousChord = number;
                yield return KeyNotesDictionary.GetKeyNote(key, number) + scale;
            }
        }

        private (int level, string scale) GenerateChordData(bool isKeyMajor, int chordNumberFromEnd, int previousChord)
        {
            foreach (var layer in this.layers)
            {
                foreach(var neuron in layer.Neurons)
                {
                    neuron.Value = 0;
                }
            }

            if (isKeyMajor)
            {
                this.layers[0].Neurons[0].Value = 1.0f;
            }

            string chordNumberString = $"{FromEnd}{chordNumberFromEnd}";
            string previousChordString = $"{Fret}{previousChord}";

            for (int i = 1; i < this.layers[0].Count; i++)
            {
                if (this.layers[0].Neurons[i].Name == chordNumberString || this.layers[0].Neurons[i].Name == previousChordString)
                {
                    this.layers[0].Neurons[i].Value = 1.0f;
                }
            }

            var values = this.layers[0].Neurons.Select(x => x.Value).ToList();

            foreach(var neuron in this.layers[1].Neurons)
            {
                ((Neuron)neuron).Calculate(values);
            }

            float sum = this.layers[1].Neurons.Select(x => x.Value).Sum();
            float randomNumber = this.random.NextSingle() * sum;
            float counter = 0.0f;

            foreach (var neuron in this.layers[1].Neurons)
            {
                counter += neuron.Value;
                if (counter >= randomNumber)
                {
                    string result = neuron.Name;
                    if (result.Length == 1)
                    {
                        return (int.Parse(result[0].ToString()), string.Empty);
                    }

                    return (int.Parse(result[0].ToString()), result[1..]);
                }
            }

            return (0, string.Empty);
        }

        private bool IsKeyValid(string key)
        {
            return KeyNotesDictionary.HasKey(key);
        }

        public async Task WriteWeights(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                await sw.WriteAsync(JsonSerializer.Serialize(this.layers, new JsonSerializerOptions() { 
                    WriteIndented = true,
                }));
            }
        }

        public async Task ReadWeights(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                this.layers = JsonSerializer.Deserialize<List<Layer>>(await sr.ReadToEndAsync())!;
            }
        }

        public void Train(IEnumerable<SongData> songsData)
        {
            foreach (var songData in songsData)
            {
                try
                {
                    if (!KeyNotesDictionary.HasKey(songData.Key))
                    {
                        continue;
                    }

                    AddData(songData);

                }
                catch
                {
                    throw;
                }
            }
        }

        private void AddData(SongData songData)
        {
            string key = songData.Key;
            int chords = songData.Harmony.Length;
            string[] harmony = songData.Harmony;
            string[] keyNotes = KeyNotesDictionary.GetAllKeyNotes(key);
            int previousChord = 0;

            for (int i = 0; i < chords; i++)
            {
                var note = keyNotes.FirstOrDefault(x => harmony[i].ToUpper().StartsWith(x));
                if (note is null)
                {
                    break;
                }

                int chordNumber = (Array.IndexOf(keyNotes, note) + 1);
                string chordData = chordNumber + harmony[i][note.Length..];

                AddInputNeuron($"{Fret}{previousChord}");
                AddInputNeuron($"{FromEnd}{chords - i}");

                AddNeuron(chordData);

                previousChord = chordNumber;
            }
        }

        private void AddInputNeuron(string name)
        {
            if (!this.layers[0].Neurons.Any(x => x.Name == name))
            {
                this.layers[0].Neurons.Add(new InputNeuron(name));
                foreach (var neuron in this.layers[1].Neurons)
                {
                    ((Neuron)neuron).Weights.Add(0.5f);
                }
            }
        }

        private void AddNeuron(string name)
        {
            if (!this.layers[1].Neurons.Any(x => x.Name == name))
            {
                this.layers[1].Neurons.Add(new Neuron(name, new List<float>(Enumerable.Repeat(0.5f, this.layers[0].Count))));
            }
        }
    }
}