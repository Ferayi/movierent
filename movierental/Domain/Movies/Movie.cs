using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;


namespace Domain.Movies
{
    public class Movie
    {
       


        public Guid MovieID { get; private set; }
        public string MovieTitle { get; private set; }
        public string MovieReleaseDate { get; private set; }
        public MovieGenreEnum MovieGenre { get; private set; }
        public decimal MovieRating { get; private set; }
        public int MoviePrice { get; private set; }
        public DateTime MovieAddedDate { get; private set; }
        public int MovieDaysInDisplay { get; private set; }
        public int MovieStock { get; private set; }
       
        

        public Movie(string MovieTitle, string MovieReleaseDate, MovieGenreEnum MovieGenre, decimal MovieRating, int MoviePrice, DateTime MovieAddedDate, int MovieDaysInDisplay, int MovieStock)
        {
            this.MovieID = Guid.NewGuid();
            this.MovieTitle = MovieTitle;
            this.MovieReleaseDate = MovieReleaseDate;
            this.MovieGenre = MovieGenre;
            this.MovieRating = MovieRating;
            this.MoviePrice = MoviePrice;
            this.MovieAddedDate = MovieAddedDate;
            this.MovieDaysInDisplay = MovieDaysInDisplay;
            this.MovieStock = MovieStock;
        }
        public bool IsAvailable()
        {
            return MovieStock > 0;
        }
        public bool IsInDisplay()
        {
            return DateTime.UtcNow <= MovieAddedDate.AddDays(MovieDaysInDisplay);
        }

     




    }
}
