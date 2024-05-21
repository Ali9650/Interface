namespace Playlist
{
    internal class Program
    {
        static void Main()
        {
            Playlist playlist = new Playlist();
            playlist.AddSong(new Song
            {
                Title = "Beatiful Things",
                Artist = "Benson Boone",
                Duration = new TimeSpan(0, 4, 0),
                MusicGenre = MusicGenre.Pop
            });
            playlist.GetAllSongsByGenre(MusicGenre.Pop);
        }
    }
}
