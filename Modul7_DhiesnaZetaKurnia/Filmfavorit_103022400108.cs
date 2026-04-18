using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Modul7_DhiesnaZetaKurnia
{
    internal class Ambamovie_103022400108
    {
        class film
        {
            public string title { get; set; }
            public string year { get; set; }
            public string genre { get; set; }
            public int rating { get; set; }
            public string director { get; set; }
            public int durationMinutes { get; set; }
            public bool isWatched { get; set; }

            public film(string title, string year,string genre,string director)
            {
                this.title = title;
                this.year = year;
                this.genre = genre;
                this.director = director;
                this.durationMinutes = durationMinutes;
                this.isWatched = isWatched;
            }
        }

        public static void ReadJSON()
        {
            string JSONstring = File.ReadAllText("C:\\Users\\PRAKTIKAN\\MODUL7-KPL\\Modul7_DhiesnaZetaKurnia\\jurnal7_1_103022400108.json");
            film flm = JsonSerializer.Deserialize<film>(JSONstring);
            Console.WriteLine($"title: {flm.title},tahun: {flm.year},direktor: {flm.director},genre: {flm.genre},durasi: {flm.durationMinutes},ditonton: {flm.isWatched}");
        }
    }
}
