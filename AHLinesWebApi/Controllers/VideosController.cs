using AHLines.BusinessLogic;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/videos")]
    public class VideosController : ApiController
    {
        VideosBLL videosBLL = new VideosBLL();

        [Route("latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestVideosAsync()
        {
            IEnumerable<dynamic> latestVideos = await videosBLL.GetLatestVideosAsync();

            if (latestVideos == null)
            {
                return InternalServerError();
            }

            return Ok(latestVideos);
        }

        [Route("political"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetPoliticalVideosAsync()
        {
            IEnumerable<dynamic> politicalVideos = await videosBLL.GetPoliticalVideosAsync();

            if (politicalVideos == null)
            {
                return InternalServerError();
            }

            return Ok(politicalVideos);
        }

        [Route("movies"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoviesVideosAsync()
        {
            IEnumerable<dynamic> moviesVideos = await videosBLL.GetMoviesVideosAsync();

            if (moviesVideos == null)
            {
                return InternalServerError();
            }

            return Ok(moviesVideos);
        }

        [Route("sports"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetSportsVideosAsync()
        {
            IEnumerable<dynamic> sportsVideos = await videosBLL.GetSportsVideosAsync();

            if (sportsVideos == null)
            {
                return InternalServerError();
            }

            return Ok(sportsVideos);
        }

        [Route("others"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetOtherVideosAsync()
        {
            IEnumerable<dynamic> otherVideos = await videosBLL.GetOtherVideosAsync();

            if (otherVideos == null)
            {
                return InternalServerError();
            }

            return Ok(otherVideos);
        }

        [Route("latest/{videoId}"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetLatestVideoDetailsBasedOnIdAsync(int videoId)
        {
            dynamic videoDetails = await videosBLL.GetLatestVideoDetailsBasedOnIdAsync(videoId);

            if (videoDetails == null)
            {
                return InternalServerError();
            }

            return Ok(videoDetails);
        }

        [Route("latest/remaining/{videoId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetRemainingLatestVideosAsync(int videoId)
        {
            IEnumerable<dynamic> remainingLatestVideos = await videosBLL.GetRemainingLatestVideosAsync(videoId);

            if (remainingLatestVideos == null)
            {
                return InternalServerError();
            }

            return Ok(remainingLatestVideos);
        }

        [Route("political/{videoId}"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetPoliticalVideoDetailsBasedOnIdAsync(int videoId)
        {
            dynamic videoDetails = await videosBLL.GetPoliticalVideoDetailsBasedOnIdAsync(videoId);

            if (videoDetails == null)
            {
                return InternalServerError();
            }

            return Ok(videoDetails);
        }

        [Route("political/remaining/{videoId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetRemainingPoliticalVideosAsync(int videoId)
        {
            IEnumerable<dynamic> remainingPoliticalVideos = await videosBLL.GetRemainingPoliticalVideosAsync(videoId);

            if (remainingPoliticalVideos == null)
            {
                return InternalServerError();
            }

            return Ok(remainingPoliticalVideos);
        }

        [Route("movies/{videoId}"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetMovieVideoDetailsBasedOnIdAsync(int videoId)
        {
            dynamic movieDetails = await videosBLL.GetMovieVideoDetailsBasedOnIdAsync(videoId);

            if (movieDetails == null)
            {
                return InternalServerError();
            }

            return Ok(movieDetails);
        }

        [Route("movies/remaining/{videoId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetRemainingMoviesVideosAsync(int videoId)
        {
            IEnumerable<dynamic> remainingMoviesVideos = await videosBLL.GetRemainingMoviesVideosAsync(videoId);

            if (remainingMoviesVideos == null)
            {
                return InternalServerError();
            }

            return Ok(remainingMoviesVideos);
        }

        [Route("sports/{videoId}"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetSportsVideoDetailsBasedOnIdAsync(int videoId)
        {
            dynamic videoDetails = await videosBLL.GetSportsVideoDetailsBasedOnIdAsync(videoId);

            if (videoDetails == null)
            {
                return InternalServerError();
            }

            return Ok(videoDetails);
        }

        [Route("sports/remaining/{videoId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetRemainingSportsVideosAsync(int videoId)
        {
            IEnumerable<dynamic> remainingSportsVideos = await videosBLL.GetRemainingSportsVideosAsync(videoId);

            if (remainingSportsVideos == null)
            {
                return InternalServerError();
            }

            return Ok(remainingSportsVideos);
        }

        [Route("others/{videoId}"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetOtherVideoDetailsBasedOnIdAsync(int videoId)
        {
            dynamic videoDetails = await videosBLL.GetOtherVideoDetailsBasedOnIdAsync(videoId);

            if (videoDetails == null)
            {
                return InternalServerError();
            }

            return Ok(videoDetails);
        }

        [Route("others/remaining/{videoId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetRemainingOtherVideosAsync(int videoId)
        {
            IEnumerable<dynamic> remainingOtherVideos = await videosBLL.GetRemainingOtherVideosAsync(videoId);

            if (remainingOtherVideos == null)
            {
                return InternalServerError();
            }

            return Ok(remainingOtherVideos);
        }

        [Route("sports/more"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoreSportsVideosAsync()
        {
            IEnumerable<dynamic> moreSportsVideos = await videosBLL.GetMoreSportsVideosAsync();

            if (moreSportsVideos == null)
            {
                return InternalServerError();
            }

            return Ok(moreSportsVideos);
        }

        [Route("political/more"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMorePoliticalVideosAsync()
        {
            IEnumerable<dynamic> morePoliticalVideos = await videosBLL.GetMorePoliticalVideosAsync();

            if (morePoliticalVideos == null)
            {
                return InternalServerError();
            }

            return Ok(morePoliticalVideos);
        }

        [Route("movies/more"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoreMoviesVideosAsync()
        {
            IEnumerable<dynamic> moreMoviesVideos = await videosBLL.GetMoreMoviesVideosAsync();

            if (moreMoviesVideos == null)
            {
                return InternalServerError();
            }

            return Ok(moreMoviesVideos);
        }
    }
}