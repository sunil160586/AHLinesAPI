using AHLines.DataAccess;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class MetaKeysBLL
    {
        MetaKeysDAL metaKeysDAL = new MetaKeysDAL();

        public async Task<dynamic> GetMetaKeysAsync(string pageName)
        {
            return await metaKeysDAL.GetMetaKeysAsync(pageName);
        }
    }
}