namespace KeyNotes
{
    public static class KeyNotesDictionary
    {
        private static readonly Dictionary<string, string[]> notes = new Dictionary<string, string[]>()
        {
            { "C", new string[] { "C", "D", "E", "F", "G", "A", "H" } },
            { "CM", new string[] { "C", "D", "D#", "F", "G", "G#", "A#" } },
            { "C#", new string[] { "C#", "D#", "E#", "F#", "G#", "A#", "H#" } },
            { "C#M", new string[] { "C#", "D#", "E", "F#", "G#", "A", "H" } },
            { "D", new string[] { "D", "E", "F#", "G", "A", "H", "C#" } },
            { "DM", new string[] { "D", "E", "F", "G", "A", "A#", "C" } },
            { "D#", new string[] { "D#", "E#", "F##", "G#", "A#", "H#", "C##" } },
            { "D#M", new string[] { "D#", "E#", "F#", "G#", "A#", "H", "C#" } },
            { "E", new string[] { "E", "F#", "G#", "A", "H", "C#", "D#" } },
            { "EM", new string[] { "E", "F#", "G", "A", "H", "C", "D" } },
            { "F", new string[] { "F", "G", "A", "A#", "C", "D", "E" } },
            { "FM", new string[] { "F", "G", "G#", "A#", "C", "C#", "D#" } },
            { "F#", new string[] { "F#", "G#", "A#", "H", "C#", "D#", "E#" } },
            { "F#M", new string[] { "F#", "G#", "A", "H", "C#", "D", "E" } },
            { "G", new string[] { "G", "A", "H", "C", "D", "E", "F#" } },
            { "GM", new string[] { "G", "A", "A#", "C", "D", "D#", "F" } },
            { "G#", new string[] { "G#", "A#", "H#", "C#", "D#", "E#", "F##" } },
            { "G#M", new string[] { "G#", "A#", "H", "C#", "D#", "E", "F#" } },
            { "A", new string[] { "A", "H", "C#", "D", "E", "F#", "G#" } },
            { "AM", new string[] { "A", "H", "C", "D", "E", "F", "G" } },
            { "A#", new string[] { "A#", "H#", "C##", "D#", "E#", "F##", "G##" } },
            { "A#M", new string[] { "A#", "H#", "C#", "D#", "E#", "G", "G#" } },
            { "H", new string[] { "H", "C#", "D#", "E", "F#", "G#", "A#" } },
            { "HM", new string[] { "H", "C", "D", "E", "F#", "G", "A" } }
        };

        public static bool HasKey(string key)
        {
            return notes.ContainsKey(key.ToUpper());
        }

        public static string[] GetAllKeyNotes(string key)
        {
            return notes[key.ToUpper()];
        }

        public static string GetKeyNote(string key, int noteNumber)
        {
            if (noteNumber < 1)
            {
                throw new ArgumentException("Note number must be 1 or more.");
            }

            return GetAllKeyNotes(key)[(noteNumber - 1) % 7];
        }

        public static int GetNoteNumber(string key, string note)
        {
            int number = Array.IndexOf(GetAllKeyNotes(key), note.ToUpper());

            if (number == -1)
            {
                throw new ArgumentException($"There is no {note} note in the {key} key.");
            }

            return number + 1;
        }
    }
}