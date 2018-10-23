using AHLines.BusinessLogic;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/header")]
    public class HeaderController : ApiController
    {
        HeaderBLL headerBLL = new HeaderBLL();

        [Route("scrollingnews"), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetScrollingNewsAsync()
        {
            IEnumerable<dynamic> scrollingNews = await headerBLL.GetScrollingNewsAsync();

            if (scrollingNews != null)
            {
                return Ok(scrollingNews);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}