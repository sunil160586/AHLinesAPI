using AHLines.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    class EntertainmentDAL
    {
        public async Task<List<HomeArticle>> GetEntertainmentNews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    List<HomeArticle> homeArticles = new List<HomeArticle>();

                    var entertainmentNews = await ahLinesContext.HomeArticle
                        .Where(h => h.Section == "ENTERTAINMENT")
                        .OrderByDescending(h => h.ReleaseDate)
                        .Take(30).ToListAsync();

                    foreach (HomeArticle homeArticle in entertainmentNews)
                    {
                        homeArticle.Section = homeArticle.Section == "PHOTOS_GALLERY" ? "GALLERY" : "NEWS";
                        homeArticle.ImageUrl = homeArticle.ImageSmallUrl.Replace("sm", "la");
                        homeArticle.Posted = Common.PostedAgo(homeArticle.PostedAgo);
                        homeArticles.Add(homeArticle);
                    }

                    return homeArticles;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}