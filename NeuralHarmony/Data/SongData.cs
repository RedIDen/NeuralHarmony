namespace NeuralHarmony.Data
{
    public class SongData
    {
        // not used, but added for ease of orientation
        public string? Name { get; set; }

        // not used, but added for ease of orientation
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
