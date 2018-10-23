using AHLines.BusinessLogic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api/metakeys")]
    public class MetaKeysController : ApiController
    {
        MetaKeysBLL metaKeysBLL = new MetaKeysBLL();

        [Route("pagename/{pageName}"), ResponseType(typeof(object))]
        public async Task<IHttpActionResult> GetMetaKeysAsync(string pageName)
        {
            dynamic metaKeys = await metaKeysBLL.GetMetaKeysAsync(pageName);

            if (metaKeys != null)
            {
                return Ok(metaKeys);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}