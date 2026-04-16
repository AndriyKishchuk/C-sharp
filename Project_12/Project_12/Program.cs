using System;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> playlist = new()
        {
            { 1, "Bohemian Rhapsody - Queen" },
            { 2, "Hotel California - Eagles" },
            { 3, "Stairway to Heaven - Led Zeppelin" },
            { 4, "Smells Like Teen Spirit - Nirvana" },
            { 5, "Imagine - John Lennon" },
            { 6, "Yesterday - The Beatles" },
            { 7, "Sweet Child O' Mine - Guns N' Roses" },
            { 8, "Billie Jean - Michael Jackson" },
            { 9, "Comfortably Numb - Pink Floyd" },
            { 10, "Nothing Else Matters - Metallica" }
        };

        Queue<int> lastplayed = new();
        Random random = new();
        int songId;

        Console.WriteLine("Welcome to the Music Player!");
        Console.WriteLine($"In this playlist, you have {playlist.Count} songs \n");

        while (true)
        {
            Console.WriteLine("Please Enter to play a song or 'q' to quit: ");
            string? input = Console.ReadLine();
            if (input?.Trim().Equals("q", StringComparison.OrdinalIgnoreCase) == true)
            {
                break;
            }

            do
            {
              songId = random.Next(1, playlist.Count + 1);
            } while (lastplayed.Contains(songId));

            Console.WriteLine($"Now playing: {playlist[songId]}");
            lastplayed.Enqueue(songId);
            if (lastplayed.Count > 5)
            {
                lastplayed.Dequeue();
            }
            Console.WriteLine($"Last {lastplayed.Count} played songs:");
            foreach (int id in lastplayed)
            {
                Console.WriteLine($"- {playlist[id]}");
            }
        }
        Console.WriteLine("Thank you for using the Music Player. Goodbye!");
    }
}