using AHLines.BusinessLogic;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/movies")]
    public class MoviesController : ApiController
    {
        MoviesBLL moviesBLL = new MoviesBLL();

        [Route("movienewsandgossips/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestMovieNewsAndGossips()
        {
            IEnumerable<dynamic> latestMovieNewsAndGossips = await moviesBLL.GetLatestMovieNewsAndGossips();

            if (latestMovieNewsAndGossips != null)
            {
                return Ok(latestMovieNewsAndGossips);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("videos"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMovieVideosAsync()
        {
            IEnumerable<dynamic> movieVideos = await moviesBLL.GetMovieVideosAsync();

            if (movieVideos == null)
            {
                return InternalServerError();
            }

            return Ok(movieVideos);
        }

        [Route("audios"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestMovieAudios()
        {
            IEnumerable<dynamic> latestMovieAudios = await moviesBLL.GetLatestMovieAudios();

            if (latestMovieAudios != null)
            {
                return Ok(latestMovieAudios);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("movienewsandgossips"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMovieNewsAndGossips()
        {
            IEnumerable<dynamic> movieNewsAndGossips = await moviesBLL.GetMovieNewsAndGossips();

            if (movieNewsAndGossips != null)
            {
                return Ok(movieNewsAndGossips);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("{articleId:int}"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetMovieArticle(int articleId)
        {
            dynamic movieArticle = await moviesBLL.GetMovieArticle(articleId);

            if (movieArticle != null)
            {
                return Ok(movieArticle);
            }
            else
            {
                return InternalServerError();
            }
        }        

        [Route("reviews/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestMoviesReviews()
        {
            IEnumerable<dynamic> moviesReviews = await moviesBLL.GetLatestMovieReviews();

            if (moviesReviews != null)
            {
                return Ok(moviesReviews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("reviews"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoviesReviews()
        {
            IEnumerable<dynamic> moviesReviews = await moviesBLL.GetMoviesReviews();

            if (moviesReviews != null)
            {
                return Ok(moviesReviews);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}