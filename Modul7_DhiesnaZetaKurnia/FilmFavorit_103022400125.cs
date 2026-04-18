using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class FilmFavorit_103022400125
    {
        class Film
        {
            public String title { get; set; }
            public String director { get; set; }
            public String year { get; set; }
            public String genre { get; set; }
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
            String jsonString = File.ReadAllText("D:\\Modul7_DhiesnaZetaKurnia\\Modul7_DhiesnaZetaKurnia\\jurnal7_1_103022400125.json");

            //Deserialize file json menjadi object
            Film flm = JsonSerializer.Deserialize<Film>(jsonString);

            Console.WriteLine($"title: {flm.title} \nDirector: {flm.director} \nYear: {flm.year} " +
                $"\nGenre: {flm.genre} \nrating: {flm.rating} \ndurationMinutes: {flm.durationMinutes} \nIswatched: {flm.isWatched}  ");
        }
    }
}
