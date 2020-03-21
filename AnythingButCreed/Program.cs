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

            //    Make sure that some of the songs are from the band Creed.If you're not familiar with the band, consider yourself lucky and make up some songs. It's not worth googling.

            //4.Once the set is populated with 12 instances of song, use Linq to filter the `allSongs` list for songs where the artist is **not * *Imagine Dragons.Set `goodSongs` equal to the filtered result.
            //5.Loop to print out all the good songs:

            var song1 = new Song("Dolly Parton", "9 to 5");
            var song2 = new Song("Queen", "We Will Rock You");
            var song3 = new Song("Imagine Dragons", "Believer");
            var song4 = new Song("Billy Joel", "Uptown Girl");
            var song5 = new Song("Rick Springfield", "Jessie's Girl");
            var song6 = new Song("Kansas", "Carry on my Wayward Son");
            var song7 = new Song("Coin", "Talk Too Much");
            var song8 = new Song("Whitney Houston", "Higher Love");
            var song9 = new Song("Fountains of Wayne", "Stacy's Mom");
            var song10 = new Song("Bob Seger", "Night Moves");
            var song11 = new Song("The Killers", "Mr. Brightside");
            var song12 = new Song("ABBA", "Dancing Queen");

            var allSongs = new List<Song>(){ song1, song2, song3, song4, song5, song6, song7, song8, song9, song10, song11, song12 };

            var goodSongs = allSongs.Where(song => !song.Artist.StartsWith("Imagine")).Select(song => song);

        }

    }
}
