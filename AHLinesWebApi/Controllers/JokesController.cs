using AHLines.BusinessLogic;
using AHLines.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AHLinesWebApi.Controllers
{
    [RoutePrefix("api")]
    public class JokesController : ApiController
    {
        JokesBLL jokesBLL = new JokesBLL();

        [Route("jokes")]
        [ResponseType(typeof(ICollection<Joke>))]
        public async Task<IHttpActionResult> GetJokes()
        {
            ICollection<Joke> jokes = await Task.Run(() => jokesBLL.GetJokes());

            if (jokes != null)
            {
                if (jokes.Count > 0)
                {
                    return Ok(jokes);
                }
                else
                {
                    return Ok();
                }
            }
            else
            {
                return InternalServerError();
            }
        }

        [Route("jokes/{jokeId:int?}")]
        [ResponseType(typeof(Joke))]
        public async Task<IHttpActionResult> GetJokeDetails(int? jokeId)
        {
            Joke joke = await Task.Run(() => jokesBLL.GetJokeDetails(jokeId));

            if (joke != null)
            {
                if (joke.JokeId != null)
                {
                    return Ok(joke);
                }
                else
                {
                    return Ok();
                }
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}