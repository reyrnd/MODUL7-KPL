using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class FilmFavorit_103022400132
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
        public double durationMinutes { get; set; }
        public bool isWatched { get; set; } 
        public FilmFavorit_103022400132(String title, String director, String year, String genre, double rating, double durationMinutes, bool isWatched)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.genre = genre;
            this.rating = rating;
            this.durationMinutes = durationMinutes;
            this.isWatched = true;
            
        }
        
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("jurnal7_1_103022400132.json");
            FilmFavorit_103022400132 flm = JsonSerializer.Deserialize<FilmFavorit_103022400132>(jsonString);

            Console.WriteLine($"title: {flm.title} \nDirector: {flm.director} \nYear: {flm.year} " +
                $"\nGenre: {flm.genre} \nrating: {flm.rating} \ndurationMinutes: {flm.durationMinutes} \nIswatched: {flm.isWatched}  ");
        }
    }
    
}
