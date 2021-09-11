using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Model
{
    public class Favourite
    {

        public int FavId { get; set; }
        public decimal PersonalRating { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Poster { get; set; }
        public Movie movie { get; set; }

    }
}
