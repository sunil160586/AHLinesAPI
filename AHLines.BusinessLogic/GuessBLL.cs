using AHLines.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class GuessBLL
    {
        GuessDAL guessDAL = new GuessDAL();

        public async Task<IEnumerable<dynamic>> GetGuessListAsync()
        {
            return await guessDAL.GetGuessListAsync();
        }
    }
}