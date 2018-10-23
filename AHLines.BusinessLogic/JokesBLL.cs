using AHLines.DataAccess;
using AHLines.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class JokesBLL
    {
        JokesDAL jokesDAL = new JokesDAL();

        public async Task<ICollection<Joke>> GetJokes()
        {
            return await Task.Run(() => jokesDAL.GetJokes());
        }

        public async Task<Joke> GetJokeDetails(int? jokeId)
        {
            return await Task.Run(() => jokesDAL.GetJokeDetails(jokeId));
        }
    }
}