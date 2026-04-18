using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class FilmFavorit_103022400087()
    {
        class Film
        {
            public String title { get; set; }
            public String director { get; set; }
            public String year { get; set; }
            public String genre { get; set; }
            public double rating { get; set; }
            public double durationMinutes { get; set; }
            public bool isWatched { get; set; }

            public Film(String title, String director, String year, String genre, double rating, double durationMinutes, bool isWatched)
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
            String jsonString = File.ReadAllText("D:\\MODUL7-KPL\\jurnal7_1_103022400087.json");

            Film flm = JsonSerializer.Deserialize<Film>(jsonString);
            Console.WriteLine($"Title Film: {flm.title}");
            Console.WriteLine($"Director: {flm.director}");
            Console.WriteLine($"Year: {flm.year}");
            Console.WriteLine($"Genre: {flm.genre}");
            Console.WriteLine($"Rating: {flm.rating}");
            Console.WriteLine($"Durasi: {flm.durationMinutes}");
            Console.WriteLine($"Status: {flm.isWatched}");
        }

    }
}
