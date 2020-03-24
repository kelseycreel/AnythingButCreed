using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {

        static void Main(string[] args)
        {
            //2.Define a List, named `goodSongs`, that will hold instances of `Song`.
            //3.Define a List, named `allSongs`, that contains 12 instances of `Song`.
            //4.Once the set is populated with 12 instances of song, use Linq to filter the `allSongs` list for songs where the artist is **not * *Imagine Dragons.Set `goodSongs` equal to the filtered result.
            //5.Loop to print out all the good songs:

            var allSongs = new List<Song>()
            { 
                new Song("Dolly Parton", "9 to 5"), 
                new Song("Queen", "We Will Rock You"), 
                new Song("Imagine Dragons", "Believer"),
                new Song("Billy Joel", "Uptown Girl"),
                new Song("Rick Springfield", "Jessie's Girl"),
                new Song("Kansas", "Carry on my Wayward Son"),
                new Song("Coin", "Talk Too Much"),
                new Song("Whitney Houston", "Higher Love"),
                new Song("Fountains of Wayne", "Stacy's Mom"),
                new Song("Bob Seger", "Night Moves"),
                new Song("The Killers", "Mr. Brightside"),
                new Song("ABBA", "Dancing Queen"),
            };

            var goodSongs = allSongs.Where(song => !song.Artist.StartsWith("Imagine"));

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Name} by {song.Artist} is a good song.");
            }

        }

    }
}
