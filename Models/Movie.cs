using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Models
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease {  get; set; }
        public string Genre { get; set; }

        public Movie(int id,string name,int year,string genre)
        {
            Id = id;
            Name = name;
            YearOfRelease = year;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nRelease Year:{YearOfRelease}\nGenre:{Genre}\n";
        }
        public static Movie AddNewMovie(int id,string name,int year,string genre)
        {
            return new Movie(id,name,year,genre);
        }

    }
}
