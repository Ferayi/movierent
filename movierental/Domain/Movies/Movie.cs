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
       
        

        public Movie(string movieTitle, string movieReleaseDate, MovieGenreEnum movieGenre, decimal movieRating, int moviePrice, DateTime movieAddedDate, int movieDaysInDisplay, int movieStock)
        {
            MovieID = Guid.NewGuid();
            MovieTitle = movieTitle;
            MovieReleaseDate = movieReleaseDate;
            MovieGenre = movieGenre;
            MovieRating = movieRating;
            MoviePrice = moviePrice;
            MovieAddedDate = movieAddedDate;
            MovieDaysInDisplay = movieDaysInDisplay;
            MovieStock = movieStock;
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
