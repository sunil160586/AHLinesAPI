using AHLines.BusinessLogic;
using AHLines.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        HomeBLL homeBLL = new HomeBLL();

        [Route("bannerslides"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetBannerPhotos()
        {
            IEnumerable<dynamic> bannerPhotos = await homeBLL.GetBannerPhotosAsync();

            if (bannerPhotos != null)
            {
                return Ok(bannerPhotos);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("latest/news/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetLatestBreakingNewsAsync()
        {
            dynamic latestBreakingNews = await homeBLL.GetLatestBreakingNewsAsync();

            if (latestBreakingNews != null)
            {
                return Ok(latestBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("latest/news"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestNewsAsync()
        {
            IEnumerable<dynamic> latestNews = await homeBLL.GetLatestNewsAsync();

            if (latestNews != null)
            {
                return Ok(latestNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("latest/news/more"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoreLatestNewsAsync()
        {
            IEnumerable<dynamic> moreLatestNews = await homeBLL.GetMoreLatestNewsAsync();

            if (moreLatestNews != null)
            {
                return Ok(moreLatestNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("fashionandlifestyle/news/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetFashionAndLifeStyleBreakingNews()
        {
            dynamic fashionAndLifeStyleBreakingNews = await homeBLL.GetFashionAndLifeStyleBreakingNews();

            if (fashionAndLifeStyleBreakingNews != null)
            {
                return Ok(fashionAndLifeStyleBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("fashionandlifestyle/news/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetFashionAndLifeStyleLatestNews()
        {
            IEnumerable<dynamic> fashionAndLifeStyleLatestNews = await homeBLL.GetFashionAndLifeStyleLatestNews();

            if (fashionAndLifeStyleLatestNews != null)
            {
                return Ok(fashionAndLifeStyleLatestNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("trending/news/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetTrendingBreakingNews()
        {
            dynamic trendingBreakingNews = await homeBLL.GetTrendingBreakingNews();

            if (trendingBreakingNews != null)
            {
                return Ok(trendingBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("trending/news/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestTrendingNews()
        {
            IEnumerable<dynamic> latestTrendingNews = await homeBLL.GetLatestTrendingNews();

            if (latestTrendingNews != null)
            {
                return Ok(latestTrendingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("trending/news/more"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMoreTrendingNews()
        {
            IEnumerable<dynamic> moreTrendingNews = await homeBLL.GetMoreTrendingNews();

            if (moreTrendingNews != null)
            {
                return Ok(moreTrendingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("featured/latest/gallery"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetTabLatestGallery()
        {
            IEnumerable<dynamic> tabLatestGallery = await homeBLL.GetTabLatestGallery();

            if (tabLatestGallery != null)
            {
                return Ok(tabLatestGallery);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("featured/latest/videos"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetTabLatestVideos()
        {
            IEnumerable<dynamic> tabLatestVideos = await homeBLL.GetTabLatestVideos();

            if (tabLatestVideos != null)
            {
                return Ok(tabLatestVideos);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("featured/news/more"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetTabMoreNews()
        {
            IEnumerable<dynamic> tabMoreNews = await homeBLL.GetTabNews("TAB_MORE_NEWS");

            if (tabMoreNews != null)
            {
                return Ok(tabMoreNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("featured/mostread"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetTabMostRead()
        {
            IEnumerable<dynamic> tabMostRead = await homeBLL.GetTabNews("TAB_MOST_READ");

            if (tabMostRead != null)
            {
                return Ok(tabMostRead);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("entertainment/news"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetEntertainmentNews()
        {
            IEnumerable<dynamic> entertainmentNews = await homeBLL.GetEntertainmentNews();

            if (entertainmentNews != null)
            {
                return Ok(entertainmentNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("marketwatch"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetMarketWatch()
        {
            IEnumerable<dynamic> marketWatch = await homeBLL.GetMarketWatchDetails();

            if (marketWatch != null)
            {
                return Ok(marketWatch);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("jokeoftheday"), ResponseType(typeof(JokesTable))]
        public async Task<IHttpActionResult> GetJokeOfTheDay()
        {
            JokesTable jokeOfTheDay = await homeBLL.GetJokeOfTheDay();

            if (jokeOfTheDay != null)
            {
                return Ok(jokeOfTheDay);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("gallery/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetPhotoGallery()
        {
            IEnumerable<dynamic> photoGallery = await homeBLL.GetPhotoGallery();

            if (photoGallery != null)
            {
                return Ok(photoGallery);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("latest/videos"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestVideosAsync()
        {
            IEnumerable<dynamic> latestVideos = await homeBLL.GetLatestVideosAsync();

            if (latestVideos != null)
            {
                return Ok(latestVideos);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("telugu/headlines"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetTeluguHeadlinesAsync()
        {
            IEnumerable<dynamic> teluguHeadlines = await homeBLL.GetTeluguHeadlinesAsync();

            if (teluguHeadlines != null)
            {
                return Ok(teluguHeadlines);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}