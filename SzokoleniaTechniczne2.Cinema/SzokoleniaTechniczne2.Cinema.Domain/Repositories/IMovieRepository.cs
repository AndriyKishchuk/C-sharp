using SzokoleniaTechniczne2.Cinema.Domain.Entities;

namespace SzokoleniaTechniczne2.Cinema.Domain.Repositories
{
    public interface IMovieRepository
    {
        Task<Movie> GetByIdAsync(long id);

        Task<IEnumerable<Movie>> GetAllAsync();
        Task<IEnumerable<MovieCategory>> GetMovieCategoriesAsync();

        Task<bool> IsMovieExistAsync(string name, int year);

        Task<bool> IsSeanceExistAsync(DateTime seanceDate);

        Task AddAsync(Movie movie);
        Task UpdateAsync(Movie movie);
        Task<Movie> GetSeanceDetailAsync(int movieId);
        Task<List<Seance>> GetSeancesByMovieIdAsync(long movieId);
        Task RemoveAsync(Movie movie);

    }
}
