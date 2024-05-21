

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Playlist
{
    internal class Playlist
    {

        private Song[] songs;
        public Song[] Songs { get => songs; }

        public Playlist()
        {
            songs = new Song[0];
        }
        public void GetAllSongsByGenre(MusicGenre musicGenre)
        {
            foreach (var song in songs)
            {
                if (song.MusicGenre == musicGenre)
                    song.GetDetails();
            }
        }

        public void AddSong(Song song)
        {
            Array.Resize(ref songs, songs.Length + 1);
            songs[songs.Length - 1] = song;
        }
    }
}

        
        
        