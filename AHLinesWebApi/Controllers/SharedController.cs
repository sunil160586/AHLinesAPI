using AHLines.BusinessLogic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/shared")]
    public class SharedController : ApiController
    {
        SharedBLL sharedBLL = new SharedBLL();

        [Route("latest/guess"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetLatestGuessAsync()
        {
            dynamic latestGuess = await sharedBLL.GetLatestGuessAsync();

            if (latestGuess != null)
            {
                return Ok(latestGuess);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}