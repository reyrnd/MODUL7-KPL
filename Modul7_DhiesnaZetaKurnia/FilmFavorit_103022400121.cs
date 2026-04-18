using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class FilmFavorit_103022400121
    {
        class Film
        {
            public string title { get; set; }
            public string director { get; set; }
            public string year { get; set; }
            public string genre { get; set; }

            public int rating { get; set; }
            public int durationMinutes { get; set; }
            public bool isWatched { get; set; }
            public Film(String title, String director, String year, String genre, int rating, int durationMinutes, bool isWatched)
            {
                this.title = title;
                this.director = director;   
                this.year = year;
                this.genre = genre;
                this.rating = rating;
                this.durationMinutes = durationMinutes;
                this.isWatched = isWatched;
            }
        }


        public static void ReadJSON()
        {
            string JSONstring = File.ReadAllText("D:\\MODUL7-KPL\\Modul7_DhiesnaZetaKurnia\\jurnal7_1_103022400121.json");
            Film film = JsonSerializer.Deserialize< Film>(JSONstring);
            Console.WriteLine($"Judul {film.title} direktor {film.director} tahun {film.year} genre {film.genre} rating {film.year} durasi {film.durationMinutes} sudah ditonton {film.isWatched}");
        }
    }
}
