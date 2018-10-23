using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class HeaderDAL
    {
        public async Task<IEnumerable<dynamic>> GetScrollingNewsAsync()
        {
            try
            {
                using (THLinesContext thLinesContext = new THLinesContext())
                {
                    var scrollingNews = await thLinesContext.News
                        .Where(s => s.Scrolling.Value.Equals(true) && s.Approved.Value.Equals(true) && s.Deleted.Value.Equals(false))
                        .Select(s => new
                        {
                            s.NewsId,
                            s.Title,
                            s.Category
                        })
                        .OrderByDescending(s => s.NewsId)
                        .ToListAsync();

                    return scrollingNews.Select(s => new
                    {
                        Id = s.NewsId,
                        Title = s.Title,
                        PrefixUrl = Common.GetTeluguPrefixUrl(s.Category)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}