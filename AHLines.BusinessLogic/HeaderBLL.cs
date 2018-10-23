using AHLines.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class HeaderBLL
    {
        HeaderDAL headerDAL = new HeaderDAL();

        public async Task<IEnumerable<dynamic>> GetScrollingNewsAsync()
        {
            return await headerDAL.GetScrollingNewsAsync();
        }
    }
}