using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataStructures.Program;

namespace DataStructures
{
    internal class TVShow
    {
        public string Title = "Untitled";
        public int releaseYear;
        public double Price;
        public MovieRating Rating;

        public TVShow(string title, int releaseYear, double price, MovieRating rating)
        {
            this.Title = title;
            this.releaseYear = releaseYear;
            this.Price = price;
            this.Rating = rating;
        }

        public override string ToString()
        {
            return Title += " (" + releaseYear + ") Rated " + Rating + " £" + Price.ToString("0.00");
        }
    }
}
