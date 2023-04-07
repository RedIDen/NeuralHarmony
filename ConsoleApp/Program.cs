using NeuralHarmony;
using NeuralHarmony.Data;

var a = new NeuralHarmonyNetwork("weights.json");
//await a.ReadWeights();

a.Learn(1f, new SongData[]
{
    new SongData("С сердцами людей", "RDPE", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("С сердцами людей", "RDPE", "Am", new string[] { "Dm", "G", "C", "Am" }),
    new SongData("Can't Stop the Feeling!", "Justin Timberlake", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("Shut Up and Dance", "Walk the Moon", "C", new string[] { "C", "G", "Am", "F" }),
    new SongData("I Will Wait", "Mumford & Sons", "C", new string[] { "C", "G", "Dm", "Am" }),
    new SongData("All of Me", "John Legend", "C", new string[] { "C", "Em", "Am", "F" }),
    new SongData("Count On Me", "Bruno Mars", "C", new string[] { "C", "G", "Am", "Em" }),
    new SongData("Lose You To Love Me", "Selena Gomez", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("The Climb", "Miley Cyrus", "C", new string[] { "C", "G", "Am", "F" }),
    new SongData("Uptown Funk", "Mark Ronson ft. Bruno Mars", "C", new string[] { "C", "Dm7", "G7", "C7" }),
    new SongData("We Found Love", "Rihanna ft. Calvin Harris", "C", new string[] { "C", "Am7", "F", "G" }),
    new SongData("Use Somebody", "Kings of Leon", "C", new string[] { "C", "G", "Am", "Em" }),
        new SongData("С сердцами людей", "RDPE", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("С сердцами людей", "RDPE", "Am", new string[] { "Dm", "G", "C", "Am" }),
    new SongData("Can't Stop the Feeling!", "Justin Timberlake", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("Shut Up and Dance", "Walk the Moon", "C", new string[] { "C", "G", "Am", "F" }),
    new SongData("I Will Wait", "Mumford & Sons", "C", new string[] { "C", "G", "Dm", "Am" }),
    new SongData("All of Me", "John Legend", "C", new string[] { "C", "Em", "Am", "F" }),
    new SongData("Count On Me", "Bruno Mars", "C", new string[] { "C", "G", "Am", "Em" }),
    new SongData("Lose You To Love Me", "Selena Gomez", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("The Climb", "Miley Cyrus", "C", new string[] { "C", "G", "Am", "F" }),
    new SongData("Uptown Funk", "Mark Ronson ft. Bruno Mars", "C", new string[] { "C", "Dm7", "G7", "C7" }),
    new SongData("We Found Love", "Rihanna ft. Calvin Harris", "C", new string[] { "C", "Am7", "F", "G" }),
    new SongData("Use Somebody", "Kings of Leon", "C", new string[] { "C", "G", "Am", "Em" }),
        new SongData("С сердцами людей", "RDPE", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("С сердцами людей", "RDPE", "Am", new string[] { "Dm", "G", "C", "Am" }),
    new SongData("Can't Stop the Feeling!", "Justin Timberlake", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("Shut Up and Dance", "Walk the Moon", "C", new string[] { "C", "G", "Am", "F" }),
    new SongData("I Will Wait", "Mumford & Sons", "C", new string[] { "C", "G", "Dm", "Am" }),
    new SongData("All of Me", "John Legend", "C", new string[] { "C", "Em", "Am", "F" }),
    new SongData("Count On Me", "Bruno Mars", "C", new string[] { "C", "G", "Am", "Em" }),
    new SongData("Lose You To Love Me", "Selena Gomez", "C", new string[] { "C", "Am", "F", "G" }),
    new SongData("The Climb", "Miley Cyrus", "C", new string[] { "C", "G", "Am", "F" }),
    new SongData("Uptown Funk", "Mark Ronson ft. Bruno Mars", "C", new string[] { "C", "Dm7", "G7", "C7" }),
    new SongData("We Found Love", "Rihanna ft. Calvin Harris", "C", new string[] { "C", "Am7", "F", "G" }),
    new SongData("Use Somebody", "Kings of Leon", "C", new string[] { "C", "G", "Am", "Em" }),
    new SongData("Hallelujah", "Jeff Buckley", "Am", new string[] { "Am", "F", "C", "G"}),
    new SongData("Torn", "Natalie Imbruglia", "Am", new string[] { "Am", "F", "C", "G"}),
    new SongData("Mad World", "Tears for Fears", "Am", new string[] { "Am", "Em", "G", "D"}),
    new SongData("The A Team", "Ed Sheeran", "Am", new string[] { "Am", "F", "C", "G"}),
    new SongData("Sweet Child O' Mine", "Guns N' Roses", "Am", new string[] { "Am", "C", "D", "G"}),
    new SongData("Creep", "Radiohead", "Am", new string[] { "Am", "F", "C", "G"}),
    new SongData("Human", "Rag'n'Bone Man", "Am", new string[] { "Am", "F", "C", "G"}),
    new SongData("Knockin' on Heaven's Door", "Bob Dylan", "Am", new string[] { "Am", "G", "F", "C"}),
    new SongData("Stay with Me", "Sam Smith", "Am", new string[] { "Am", "F", "C", "G"}),
    new SongData("I Will Survive", "Gloria Gaynor", "Am", new string[] { "Am", "Dm", "G", "C"}),
    new SongData("Tears in Heaven", "Eric Clapton", "Em", new string[] { "Em", "D", "C", "G" }),
    new SongData("The A Team", "Ed Sheeran", "Em", new string[] { "Em", "C", "G", "D" }),
    new SongData("Knockin' on Heaven's Door", "Bob Dylan", "Em", new string[] { "G", "D", "Am", "C" }),
    new SongData("Wish You Were Here", "Pink Floyd", "Em", new string[] { "Em", "G", "D", "A" }),
    new SongData("Blackbird", "The Beatles", "Em", new string[] { "Em", "G", "A7sus4", "A7" }),
    new SongData("Wonderwall", "Oasis", "Em", new string[] { "Em7", "G", "D", "A7sus4" }),
    new SongData("Everybody Hurts", "R.E.M.", "Em", new string[] { "Em", "G", "D", "C" }),
    new SongData("Nothing Else Matters", "Metallica", "Em", new string[] { "Em", "G", "D", "C" }),
    new SongData("Boulevard of Broken Dreams", "Green Day", "Em", new string[] { "Em", "G", "D", "A" }),
    new SongData("Fade to Black", "Metallica", "Em", new string[] { "Em", "G", "D", "C" }),

    //new SongData("Shape of You", "Ed Sheeran", "C#", new string[] { "C#m", "H", "F#", "G#m" }),
    //new SongData("Hello", "Adele", "A", new string[] { "A", "F#m", "D", "E" }),
    //new SongData("Billie Jean", "Michael Jackson", "F#", new string[] { "F#", "G#m", "A#m", "H" }),
    //new SongData("Wonderwall", "Oasis", "G", new string[] { "G", "D", "Am", "C", "G", "D", "Am" }),
    //new SongData("Hotel California", "Eagles", "Hm", new string[] { "Hm", "F#", "A", "E", "G", "D", "Em", "F#", "Hm", "F#", "A", "E" }),
    //new SongData("Hallelujah", "Jeff Buckley", "C", new string[] { "C", "Am", "F", "G", "C", "G", "Am", "F", "G", "C" }),
    //new SongData("Wonderwall", "Oasis", "G", new string[] { "Em", "G", "D", "A" }),
    //new SongData("Blowin' in the Wind", "Bob Dylan", "G", new string[] { "G", "C", "D" }),
    //new SongData("Stand By Me", "Ben E. King", "A", new string[] { "A", "F#m", "D", "E" }),
    //new SongData("Brown Eyed Girl", "Van Morrison", "G", new string[] { "G", "C", "D", "G" }),
    //new SongData("La Bamba", "Ritchie Valens", "C", new string[] { "C", "F", "G" }),
    //new SongData("Every Breath You Take", "The Police", "G", new string[] { "G", "D", "Em", "C" }),
    //new SongData("Redemption Song", "Bob Marley", "G", new string[] { "G", "Em", "C", "D" }),
    //new SongData("I'm Yours", "Jason Mraz", "Hb", new string[] { "Hb", "F", "Gm", "Eb" }),
    //new SongData("Perfect", "Ed Sheeran", "G", new string[] { "G", "Em", "C", "D" }),
    //new SongData("Happy Birthday", "Patty Hill and Mildred J. Hill", "C", new string[] { "C", "F", "G", "C" }),
    //new SongData("Hey Jude", "The Beatles", "C", new string[] { "C", "G", "Am", "F", "C", "G", "C" }),
    //new SongData("Tears in Heaven", "Eric Clapton", "A", new string[] { "A", "E", "F#m", "D", "A", "E" }),
    //new SongData("Yellow", "Coldplay", "C", new string[] { "C", "G", "Am", "F" }),
    //new SongData("Let Her Go", "Passenger", "G", new string[] { "G", "D", "Em", "C" }),
    //new SongData("Can't Help Falling in Love", "Elvis Presley", "C", new string[] { "C", "Em", "Am", "F", "C", "G" }),
    //new SongData("The Scientist", "Coldplay", "Hb", new string[] { "Hb", "Gm", "Eb", "F" }),
    //new SongData("Jolene", "Dolly Parton", "G", new string[] { "G", "Em", "C", "D" }),
    //new SongData("House of the Rising Sun", "Traditional", "Am", new string[] { "Am", "C", "D", "F", "Am", "C", "E", "E" }),
    //new SongData("Free Fallin'", "Tom Petty", "D", new string[] { "D", "A", "Hm", "G" }),
    //new SongData("Stairway to Heaven", "Led Zeppelin", "Am", new string[] { "Am", "G", "D", "F", "C", "G", "Am" }),
    //new SongData("Tears In Heaven", "Eric Clapton", "Am", new string[] { "Am", "F", "G", "C" }),
    //new SongData("A Horse With No Name", "America", "Am", new string[] { "Am", "Em", "F", "C" }),
    //new SongData("What's Up", "4 Non Blondes", "Am", new string[] { "Am", "F", "G", "Dm" }),
    //new SongData("Wish You Were Here", "Pink Floyd", "Am", new string[] { "Am", "G", "D", "C" }),
    //new SongData("Perfect", "Ed Sheeran", "Am", new string[] { "Am", "F", "C", "G" }),
    //new SongData("The Joker", "Steve Miller Band", "Am", new string[] { "Am", "G", "D", "F" }),
    //new SongData("Every Breath You Take", "The Police", "Am", new string[] { "Am", "F", "G", "Em" }),
    //new SongData("American Woman", "The Guess Who", "Am", new string[] { "Am", "D", "G", "F" }),
    //new SongData("Every Rose Has Its Thorn", "Poison", "Am", new string[] { "Am", "F", "C", "G" }),
    //new SongData("Stairway to Heaven", "Led Zeppelin", "Am", new string[] { "Am", "G", "F", "C" }),
    //new SongData("Some Nights", "fun.", "C", new string[] { "C", "G", "Am", "F" }),
    //new SongData("Take Me to Church", "Hozier", "C", new string[] { "C", "Am", "F", "G" }),
    //new SongData("Can't Stop the Feeling!", "Justin Timberlake", "C", new string[] { "C", "Am", "F", "G" }),
    //new SongData("Shut Up and Dance", "Walk the Moon", "C", new string[] { "C", "G", "Am", "F" }),
    //new SongData("I Will Wait", "Mumford & Sons", "C", new string[] { "C", "G", "Am", "Em" }),
    //new SongData("All of Me", "John Legend", "C", new string[] { "C", "G", "Am", "F" }),
    //new SongData("Count On Me", "Bruno Mars", "C", new string[] { "C", "G", "Am", "F" }),
    //new SongData("Lose You To Love Me", "Selena Gomez", "C", new string[] { "C", "Am", "F", "G" }),
    //new SongData("The Climb", "Miley Cyrus", "C", new string[] { "C", "G", "Am", "F" }),
    //new SongData("Uptown Funk", "Mark Ronson ft. Bruno Mars", "C", new string[] { "C", "Dm", "G", "F" }),
    //new SongData("We Found Love", "Rihanna ft. Calvin Harris", "C", new string[] { "C", "G", "Am", "F" }),
    //new SongData("Use Somebody", "Kings of Leon", "C", new string[] { "C", "G", "Am", "F" }),


});

Console.Write("Enter key: ");
string key = Console.ReadLine()!;


Console.WriteLine("Some harmony examples: ");

for (int i = 0; i < 5; i++)
{
    var notes = a.GenerateHarmony(key);
    Console.WriteLine("  " + string.Join(" ", notes));
}

await a.WriteWeights("weights.json");