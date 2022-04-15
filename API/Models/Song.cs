using System;

namespace API.Models
{
    public class Song
    {
        // auto implemented properties
        public int SongID {get; set;}
        public string? SongTitle {get; set;}
        public DateTime SongTimestamp {get; set;}
        public string? Deleted {get; set;}
        public string? Favorited {get; set;}

        public override string ToString() // overriding the ToString for the song class to include all properties of the class
        {
            return SongTitle + " (ID: " + SongID + ", Added " + SongTimestamp + ")";
        }

        public string ToFile(){
            return SongID + "#" + SongTitle + "#" + SongTimestamp + "#" + Deleted;
        }

    }
}