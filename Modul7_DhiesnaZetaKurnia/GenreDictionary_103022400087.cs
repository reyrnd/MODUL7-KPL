using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class GenreDirectory_103022400087
    {
        class GenreDirectory
        {
            public String category { get; set; }
        }
        class genreInfo
        {
            public String id { get; set; }
            public String name { get; set; }
            public String description { get; set; }
            public List<String> popularMovies { get; set; }
        }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\MODUL7-KPL\\jurnal7_1_103022400087.json");
            GenreDirectory gnr = JsonSerializer.Deserialize<GenreDirectory>(jsonString);


        }
    }

}