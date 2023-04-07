namespace NeuralHarmony.Data
{
    public class SongData
    {
        public string? Name { get; set; }

        public string? Author { get; set; }

        public string Key { get; set; }

        public string[] Harmony { get; set; }

        public SongData(string name, string author, string key, string[] harmony)
        {
            this.Name = name;
            this.Author = author;
            this.Key = key;
            this.Harmony = harmony;
        }
    }
}
