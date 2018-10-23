using AHLines.BusinessLogic;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/guess")]
    public class GuessController : ApiController
    {
        GuessBLL guessBLL = new GuessBLL();

        [Route(""), ResponseType(typeof(IEnumerable<dynamic>))]
        public async Task<IHttpActionResult> GetGuessListAsync()
        {
            IEnumerable<dynamic> guessList = await guessBLL.GetGuessListAsync();

            if (guessBLL != null)
            {
                return Ok(guessList);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}