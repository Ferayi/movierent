using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    interface IMovieRepo
    {
        IEnumerable<Movie> GetAll();
        Movie? GetById(Guid id);
        void Add(Movie movie);
        void Delete(Movie movie);
    }
}
