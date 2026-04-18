using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class GenreDictionary_103022400125
    {
        class GenreDictionary
        {
            public genreRoot genreRoot { get; set; }
        }

        class genreRoot
        {
            public String category { get; set; }
            public GenreInfo genreInfo { get; set; }
        }

        class GenreInfo
        {
            public String id { get; set; }
            public String name { get; set; }
            public String description { get; set; }
            public List<String> popularMovies { get; set; }
        }



        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("jurnal7_3_103022400125.json");

            //Deserialize file json menjadi object

            GenreDictionary info = JsonSerializer.Deserialize<GenreDictionary>(jsonString);
            GenreInfo genreInfo = info.genreRoot.genreInfo;

            Console.WriteLine(genreInfo.id);
            //Console.WriteLine(info.name);
            //Console.WriteLine( info.description);
            //Console.WriteLine("Created By: " + info.id);
            //Console.WriteLine("Movies : ");
            //foreach (var movie in watch.movies)
            //{
            //    Console.WriteLine($"{movie.id} {movie.title} {movie.year} - {movie.rating}");
            //}


        }
    }
}
