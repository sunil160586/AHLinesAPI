using AHLines.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class MoviesBLL
    {
        MoviesDAL moviesDAL = new MoviesDAL();

        public async Task<IEnumerable<dynamic>> GetLatestMovieNewsAndGossips()
        {
            return await moviesDAL.GetLatestMovieNewsAndGossips();
        }

        public async Task<IEnumerable<dynamic>> GetMovieNewsAndGossips()
        {
            return await moviesDAL.GetMovieNewsAndGossips();
        }

        public async Task<dynamic> GetMovieArticle(int articleId)
        {
            return await moviesDAL.GetMovieArticle(articleId);
        }

        public async Task<IEnumerable<dynamic>> GetMovieVideosAsync()
        {
            return await moviesDAL.GetMovieVideosAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestMovieAudios()
        {
            return await moviesDAL.GetLatestMovieAudios();
        }

        public async Task<IEnumerable<dynamic>> GetLatestMovieReviews()
        {
            return await moviesDAL.GetLatestMovieReviews();
        }

        public async Task<IEnumerable<dynamic>> GetMoviesReviews()
        {
            return await moviesDAL.GetMoviesReviews();
        }
    }
}