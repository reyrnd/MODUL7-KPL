using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class Watchlist_103022400087
    {
        class Watchlist
        {
            public String watchlistName { get; set; }
            public String createdBy { get; set; }
            public List<Movie> movies { get; set; }

        }

        class Movie
        {
            public String id { get; set; }
            public String title { get; set; }
            public int year { get; set; }
            public String genre { get; set; }
            public double rating { get; set; }

            public Movie(String id, String title, int year, String genre, double rating)
            {
                this.id = id;
                this.title = title;
                this.year = year;
                this.genre = genre;
                this.rating = rating;
            }
        }


        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\MODUL7-KPL\\jurnal7_2_103022400087.json");

            //Deserialize file json menjadi object
            Watchlist watch = JsonSerializer.Deserialize<Watchlist>(jsonString);
            Console.WriteLine("Watchlist Name: " + watch.watchlistName);
            Console.WriteLine("Created By: " + watch.createdBy);

            Movie mv = JsonSerializer.Deserialize<Movie>(jsonString);
            Console.WriteLine("Movies : ");
            foreach (var movie in watch.movies)
            {
                Console.WriteLine($"{movie.id} {movie.title} {movie.year} - {movie.rating}");
            }


        }
    }
}