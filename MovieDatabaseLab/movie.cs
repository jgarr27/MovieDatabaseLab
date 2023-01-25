using MovieDatabaseLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    public class movie
    {
        //properties
        public string Title { get; set; }
        public string Genre { get; set; }
        //constructor
        public movie(string _title, string _genre)
        {
            Title = _title;
            Genre = _genre;
        }
        //method
     

    }
}

