using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class SQLMovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        private readonly IWebHostEnvironment _env;

        public SQLMovieRepository(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movies;
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.Find(id);
        }

        public Movie AddMovie(Movie newMovie)
        {
            _context.Movies.Add(newMovie);
            _context.SaveChanges();
            return newMovie;
        }
        public Movie EditMovie(Movie changedMovie)
        {
            var movie = _context.Movies.Attach(changedMovie);
            movie.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return changedMovie;
        }

        public Movie DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie.PosterPath != null)
            {
                string path = Path.Combine(_env.WebRootPath, "images", movie.PosterPath);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(path);
            }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return movie;
        }
    }
}
