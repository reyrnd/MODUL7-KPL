using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class GenreDictionary_103022400121
    {
        class GenreDictionary
        {
            public string category {  get; set; }
            public List <genreinfo> genre {  get; set; }
        }

        class genreinfo
        {
            public int id { get; set; }
            public string name { get; set; }
            public string desciption { get; set; }
            public List <String> popularMovies { get; set; }

            public static void ReadJSON()
            {
                string jsonString = File.ReadAllText("D:\\MODUL7-KPL\\Modul7_DhiesnaZetaKurnia\\bin\\Debug\\net10.0\\jurnal7_3_103022400121.json");
                GenreDictionary info = JsonSerializer.Deserialize<GenreDictionary>(jsonString);
                 
            }
        }
    }
}
