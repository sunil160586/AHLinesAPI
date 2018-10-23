using AHLines.BusinessLogic;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/news")]
    public class NewsController : ApiController
    {
        private NewsBLL newsBLL = new NewsBLL();

        [Route("special/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetSpecialBreakingNewsAsync()
        {
            dynamic specialBreakingNews = await newsBLL.GetSpecialBreakingNewsAsync();

            if (specialBreakingNews != null)
            {
                return Ok(specialBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("special/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestSpecialNewsAsync()
        {
            IEnumerable<dynamic> latestSpecialNews = await newsBLL.GetLatestSpecialNewsAsync();

            if (latestSpecialNews != null)
            {
                return Ok(latestSpecialNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("special"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetSpecialNewsAsync()
        {
            IEnumerable<dynamic> specialNews = await newsBLL.GetSpecialNewsAsync();

            if (specialNews != null)
            {
                return Ok(specialNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("seemandhra/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetSeemandhraBreakingNewsAsync()
        {
            dynamic seemandhraBreakingNews = await newsBLL.GetSeemandhraBreakingNewsAsync();

            if (seemandhraBreakingNews != null)
            {
                return Ok(seemandhraBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("seemandhra/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestSeemandhraNewsAsync()
        {
            IEnumerable<dynamic> latestSeemandhraNews = await newsBLL.GetLatestSeemandhraNewsAsync();

            if (latestSeemandhraNews != null)
            {
                return Ok(latestSeemandhraNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("seemandhra"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetSeemandhraNewsAsync()
        {
            IEnumerable<dynamic> seemandhraNews = await newsBLL.GetSeemandhraNewsAsync();

            if (seemandhraNews != null)
            {
                return Ok(seemandhraNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("telangana/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetTelanganaBreakingNewsAsync()
        {
            dynamic telanganaBreakingNews = await newsBLL.GetTelanganaBreakingNewsAsync();

            if (telanganaBreakingNews != null)
            {
                return Ok(telanganaBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("telangana/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestTelanganaNewsAsync()
        {
            IEnumerable<dynamic> latestTelanganaNews = await newsBLL.GetLatestTelanganaNewsAsync();

            if (latestTelanganaNews != null)
            {
                return Ok(latestTelanganaNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("telangana"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetTelanganaNewsAsync()
        {
            IEnumerable<dynamic> telanganaNews = await newsBLL.GetTelanganaNewsAsync();

            if (telanganaNews != null)
            {
                return Ok(telanganaNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("sports/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetSportsBreakingNewsAsync()
        {
            dynamic sportsBreakingNews = await newsBLL.GetSportsBreakingNewsAsync();

            if (sportsBreakingNews != null)
            {
                return Ok(sportsBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("sports/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestSportsNewsAsync()
        {
            IEnumerable<dynamic> latestSportsNews = await newsBLL.GetLatestSportsNewsAsync();

            if (latestSportsNews != null)
            {
                return Ok(latestSportsNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("sports"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetSportsNewsAsync()
        {
            IEnumerable<dynamic> sportsNews = await newsBLL.GetSportsNewsAsync();

            if (sportsNews != null)
            {
                return Ok(sportsNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("national/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetNationalBreakingNewsAsync()
        {
            dynamic nationalBreakingNews = await newsBLL.GetNationalBreakingNewsAsync();

            if (nationalBreakingNews != null)
            {
                return Ok(nationalBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("national/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestNationalNewsAsync()
        {
            IEnumerable<dynamic> latestNationalNews = await newsBLL.GetLatestNationalNewsAsync();

            if (latestNationalNews != null)
            {
                return Ok(latestNationalNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("national"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetNationalNewsAsync()
        {
            IEnumerable<dynamic> nationalNews = await newsBLL.GetNationalNewsAsync();

            if (nationalNews != null)
            {
                return Ok(nationalNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("world/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetWorldBreakingNewsAsync()
        {
            dynamic worldBreakingNews = await newsBLL.GetWorldBreakingNewsAsync();

            if (worldBreakingNews != null)
            {
                return Ok(worldBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("world/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestWorldNewsAsync()
        {
            IEnumerable<dynamic> latestWorldNews = await newsBLL.GetLatestWorldNewsAsync();

            if (latestWorldNews != null)
            {
                return Ok(latestWorldNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("world"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetWorldNewsAsync()
        {
            IEnumerable<dynamic> worldNews = await newsBLL.GetWorldNewsAsync();

            if (worldNews != null)
            {
                return Ok(worldNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("nri/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetNRIBreakingNewsAsync()
        {
            dynamic nriBreakingNews = await newsBLL.GetNRIBreakingNewsAsync();

            if (nriBreakingNews != null)
            {
                return Ok(nriBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("nri/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestNRINewsAsync()
        {
            IEnumerable<dynamic> latestNRINews = await newsBLL.GetLatestNRINewsAsync();

            if (latestNRINews != null)
            {
                return Ok(latestNRINews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("nri"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetNRINewsAsync()
        {
            IEnumerable<dynamic> nriNews = await newsBLL.GetNRINewsAsync();

            if (nriNews != null)
            {
                return Ok(nriNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("crimewatch/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetCrimeWatchBreakingNewsAsync()
        {
            dynamic crimeWatchBreakingNews = await newsBLL.GetCrimeWatchBreakingNewsAsync();

            if (crimeWatchBreakingNews != null)
            {
                return Ok(crimeWatchBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("crimewatch/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestCrimeWatchNewsAsync()
        {
            IEnumerable<dynamic> latestCrimeWatchNews = await newsBLL.GetLatestCrimeWatchNewsAsync();

            if (latestCrimeWatchNews != null)
            {
                return Ok(latestCrimeWatchNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("crimewatch"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetCrimeWatchNewsAsync()
        {
            IEnumerable<dynamic> crimeWatchNews = await newsBLL.GetCrimeWatchNewsAsync();

            if (crimeWatchNews != null)
            {
                return Ok(crimeWatchNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("business/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetBusinessBreakingNewsAsync()
        {
            dynamic businessBreakingNews = await newsBLL.GetBusinessBreakingNewsAsync();

            if (businessBreakingNews != null)
            {
                return Ok(businessBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("business/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestBusinessNewsAsync()
        {
            IEnumerable<dynamic> latestBusinessNews = await newsBLL.GetLatestBusinessNewsAsync();

            if (latestBusinessNews != null)
            {
                return Ok(latestBusinessNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("business"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetBusinessNewsAsync()
        {
            IEnumerable<dynamic> businessNews = await newsBLL.GetBusinessNewsAsync();

            if (businessNews != null)
            {
                return Ok(businessNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("fashionandlifestyle/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetFashionAndLifeStyleBreakingNewsAsync()
        {
            dynamic fashionAndLifeStyleBreakingNews = await newsBLL.GetFashionAndLifeStyleBreakingNewsAsync();

            if (fashionAndLifeStyleBreakingNews != null)
            {
                return Ok(fashionAndLifeStyleBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("fashionandlifestyle/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestFashionAndLifeStyleNewsAsync()
        {
            IEnumerable<dynamic> latestFashionAndLifeStyleNews = await newsBLL.GetLatestFashionAndLifeStyleNewsAsync();

            if (latestFashionAndLifeStyleNews != null)
            {
                return Ok(latestFashionAndLifeStyleNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("fashionandlifestyle"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetFashionAndLifeStyleNewsAsync()
        {
            IEnumerable<dynamic> fashionAndLifeStyleNews = await newsBLL.GetFashionAndLifeStyleNewsAsync();

            if (fashionAndLifeStyleNews != null)
            {
                return Ok(fashionAndLifeStyleNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("scienceandtechnology/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetScienceAndTechnologyBreakingNewsAsync()
        {
            dynamic scienceAndTechnologyBreakingNews = await newsBLL.GetScienceAndTechnologyBreakingNewsAsync();

            if (scienceAndTechnologyBreakingNews != null)
            {
                return Ok(scienceAndTechnologyBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("scienceandtechnology/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestScienceAndTechnologyNewsAsync()
        {
            IEnumerable<dynamic> latestScienceAndTechnologyNews = await newsBLL.GetLatestScienceAndTechnologyNewsAsync();

            if (latestScienceAndTechnologyNews != null)
            {
                return Ok(latestScienceAndTechnologyNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("scienceandtechnology"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetScienceAndTechnologyNewsAsync()
        {
            IEnumerable<dynamic> scienceAndTechnologyNews = await newsBLL.GetScienceAndTechnologyNewsAsync();

            if (scienceAndTechnologyNews != null)
            {
                return Ok(scienceAndTechnologyNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("healthandliving/breaking"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetHealthAndLivingBreakingNewsAsync()
        {
            dynamic healthAndLivingBreakingNews = await newsBLL.GetHealthAndLivingBreakingNewsAsync();

            if (healthAndLivingBreakingNews != null)
            {
                return Ok(healthAndLivingBreakingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("healthandliving/latest"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetLatestHealthAndLivingNewsAsync()
        {
            IEnumerable<dynamic> latestHealthAndLivingNews = await newsBLL.GetLatestHealthAndLivingNewsAsync();

            if (latestHealthAndLivingNews != null)
            {
                return Ok(latestHealthAndLivingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("healthandliving"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetHealthAndLivingNewsAsync()
        {
            IEnumerable<dynamic> healthAndLivingNews = await newsBLL.GetHealthAndLivingNewsAsync();

            if (healthAndLivingNews != null)
            {
                return Ok(healthAndLivingNews);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("headlines"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetNewsHeadlinesAsync()
        {
            IEnumerable<dynamic> newsHeadlines = await newsBLL.GetNewsHeadlinesAsync();

            if (newsHeadlines != null)
            {
                return Ok(newsHeadlines);
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("{articleId:int}"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetNewsArticleAsync(int articleId)
        {
            dynamic articleDetails = await newsBLL.GetNewsArticleAsync(articleId);

            if (articleDetails != null)
            {
                return Ok(articleDetails);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}