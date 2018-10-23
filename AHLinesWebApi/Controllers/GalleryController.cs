using AHLines.BusinessLogic;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/gallery")]
    public class GalleryController : ApiController
    {
        GalleryBLL galleryBLL = new GalleryBLL();

        [Route("celebrities/{celebrityType}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetCelebritiesGalleryAsync(string celebrityType)
        {
            IEnumerable<dynamic> celebritiesGallery = await galleryBLL.GetCelebritiesGalleryAsync(celebrityType);

            if (celebritiesGallery != null)
            {
                return Ok(celebritiesGallery);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("movies"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoviesGalleryAsync()
        {
            IEnumerable<dynamic> movieGalleries = await galleryBLL.GetMoviesGalleryAsync();

            if (movieGalleries != null)
            {
                return Ok(movieGalleries);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("events"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetEventsGalleryDynamic()
        {
            IEnumerable<dynamic> eventsGallery = await galleryBLL.GetEventsGalleryAsync();

            if (eventsGallery != null)
            {
                return Ok(eventsGallery);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("wallpapers"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetWallPapersGalleryAsync()
        {
            IEnumerable<dynamic> wallPapers = await galleryBLL.GetWallPapersGalleryAsync();

            if (wallPapers != null)
            {
                return Ok(wallPapers);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("actress/{actressId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetActressGalleryListAsync(int actressId)
        {
            IEnumerable<dynamic> actressGalleryList = await galleryBLL.GetActressGalleryListAsync(actressId);

            if (actressGalleryList != null)
            {
                return Ok(actressGalleryList);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("actor/{actorId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetActorGalleryListAsync(int actorId)
        {
            IEnumerable<dynamic> actorGalleryList = await galleryBLL.GetActorsGalleryListAsync(actorId);

            if (actorGalleryList != null)
            {
                return Ok(actorGalleryList);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("movie/{movieId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMovieGalleryListAsync(int movieId)
        {
            IEnumerable<dynamic> movieGalleryList = await galleryBLL.GetMovieGalleryListAsync(movieId);

            if (movieGalleryList != null)
            {
                return Ok(movieGalleryList);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("event/{eventId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetEventGalleryListAsync(int eventId)
        {
            IEnumerable<dynamic> eventGalleryList = await galleryBLL.GetEventGalleryListAsync(eventId);

            if (eventGalleryList != null)
            {
                return Ok(eventGalleryList);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("wallpaper/{wallpaperId}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetWallPaperGalleryListAsync(int wallPaperId)
        {
            IEnumerable<dynamic> wallPaperGalleryList = await galleryBLL.GetWallPaperGalleryListAsync(wallPaperId);

            if (wallPaperGalleryList != null)
            {
                return Ok(wallPaperGalleryList);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("celebrities/title/names/{celebrityType}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetCelebritiesTitleNamesAsync(string celebrityType)
        {
            IEnumerable<dynamic> celebritiesTitleNames = await galleryBLL.GetCelebritiesTitleNamesAsync(celebrityType);

            if (celebritiesTitleNames != null)
            {
                return Ok(celebritiesTitleNames);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("movies/title/names"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoviesTitleNamesAsync()
        {
            IEnumerable<dynamic> moviesTitleNames = await galleryBLL.GetMoviesTitleNamesAsync();

            if (moviesTitleNames != null)
            {
                return Ok(moviesTitleNames);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("events/title/names"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetEventsTitleNamesAsync()
        {
            IEnumerable<dynamic> eventsTitleNames = await galleryBLL.GetEventsTitleNamesAsync();

            if (eventsTitleNames != null)
            {
                return Ok(eventsTitleNames);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("celebritieslist/{celebrityType}/title/{title}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetCelebritiesListBasedOnTitleAsync(string celebrityType, string title)
        {
            IEnumerable<dynamic> celebritiesListBasedOnTitle = await galleryBLL.GetCelebritiesListBasedOnTitleAsync(celebrityType, title);

            if (celebritiesListBasedOnTitle != null)
            {
                return Ok(celebritiesListBasedOnTitle);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("movieslist/title/{title}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoviesListBasedOnTitleAsync(string title)
        {
            IEnumerable<dynamic> moviesListBasedOnTitle = await galleryBLL.GetMoviesListBasedOnTitleAsync(title);

            if (moviesListBasedOnTitle != null)
            {
                return Ok(moviesListBasedOnTitle);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("eventslist/title/{title}"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetEventsListBasedOnTitleAsync(string title)
        {
            IEnumerable<dynamic> eventsListBasedOnTitle = await galleryBLL.GetEventsListBasedOnTitleAsync(title);

            if (eventsListBasedOnTitle != null)
            {
                return Ok(eventsListBasedOnTitle);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}