using AHLines.DataModel;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class MetaKeysDAL
    {
        public async Task<dynamic> GetMetaKeysAsync(string pageName)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    MetaKeys metaKeys = await ahLinesContext.MetaKeys
                        .Where(mk => mk.PageName == pageName)
                        .SingleOrDefaultAsync();

                    if (metaKeys != null)
                    {
                        return new
                        {
                            Title = metaKeys.PageTitle + " " + metaKeys.PageTemporaryTitle,
                            MetaDescription = metaKeys.MetaDescription + " " + metaKeys.MetaTemporaryDescription,
                            MetaKeywords = metaKeys.MetaKeywords + " " + metaKeys.MetaTemporaryKeywords
                        };
                    }
                    else
                    {
                        return new object();
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}