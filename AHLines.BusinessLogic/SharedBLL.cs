using AHLines.DataAccess;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class SharedBLL
    {
        SharedDAL sharedDAL = new SharedDAL();

        public async Task<dynamic> GetLatestGuessAsync()
        {
            return await sharedDAL.GetLatestGuessAsync();
        }
    }
}