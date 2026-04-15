namespace Project_11.Models
{
    public class MovieService
    {
        public readonly List<Movie> _movies;
        public int nextId = 1;

        public MovieService()
        {
            _movies = new List<Movie>();

            AddMovie(new Movie { Title = "В погоні за щастям", Genre = "Драма", Year = 2014 });
            AddMovie(new Movie { Title = "Захар Беркут", Genre = "Історичний", Year = 2019 });
         
        }

        public Movie? GetMovieById(int id)
        {
            return _movies.FirstOrDefault(m => m.Id == id);
        }

        public List<Movie> GetAllMovies()
        {
            return _movies;
        }

        public List<Movie> Filter(string? genre, int? year)
        {
            IEnumerable<Movie> movies = _movies;
            if (!string.IsNullOrWhiteSpace(genre))
            {
                movies = movies.Where(m => m.Genre != null && m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));
            }
            if (year.HasValue)
            {
                movies = movies.Where(m => m.Year == year.Value);
            }
            return movies.ToList();
        }
        public void AddMovie(Movie movie)
        {
            movie.Id = nextId++;
            _movies.Add(movie);
        }
        public void UpdateMovie(Movie updatedMovie)
        {
            var existingMovie = GetMovieById(updatedMovie.Id);
            if (existingMovie != null)
            {
                existingMovie.Title = updatedMovie.Title;
                existingMovie.Genre = updatedMovie.Genre;
                existingMovie.Year = updatedMovie.Year;
            }
        }
        public void DeleteMovie(int id)
        {
            var movie = GetMovieById(id);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
        }

        public List<string> GetAllGenres()
        {
            return _movies.Select(m => m.Genre).Distinct().OrderBy(g => g).ToList();
        }

        public List<int> GetAllYears()
        {
            return _movies.Select(m => m.Year).Distinct().OrderByDescending(y=>y).ToList();
        }

    }
}
