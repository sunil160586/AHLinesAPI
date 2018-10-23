using AHLines.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class HomeDAL
    {
        public async Task<IEnumerable<dynamic>> GetBannerPhotosAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var bannerDetails = await ahLinesContext.BannerDetails
                        .Where(bd => bd.BannerId == 1)
                        .Select(bd => new
                        {
                            bd.ImageUrl,
                            bd.CategoryId,
                            bd.LinkUrl,
                            bd.DisplayOrder
                        })
                        .OrderBy(bd => bd.DisplayOrder)
                        .ToListAsync();

                    return bannerDetails.Select(bd => new
                    {
                        BannerId = Common.ExtractIdFromUrl(bd.LinkUrl),
                        ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["BannerImagePrefixUrl"]) + bd.ImageUrl,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(bd.CategoryId)),
                        LinkUrl = bd.LinkUrl
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetLatestBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestBreakingNews = await ahLinesContext.HomeArticle
                        .Where(l => l.Section.Equals("EDITOR_PICKS"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.CategoryId,
                            l.ImageUrl,
                            l.Title,
                            l.Abstract,
                            l.PostedAgo,
                            l.ReleaseDate
                        }).OrderByDescending(l => l.ReleaseDate)
                        .FirstAsync();

                    return new
                    {
                        ArticleId = latestBreakingNews.ArticleId,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(latestBreakingNews.CategoryId)),
                        ImageUrl = latestBreakingNews.ImageUrl,
                        Title = latestBreakingNews.Title,
                        Abstract = latestBreakingNews.Abstract,
                        Posted = Common.PostedAgo(latestBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestNews = await ahLinesContext.HomeArticle
                        .Where(ha => ha.Section == "EDITOR_PICKS")
                        .Select(ha => new
                        {
                            ha.ArticleId,
                            ha.CategoryId,
                            ha.ImageSmallUrl,
                            ha.Title,
                            ha.PostedAgo,
                            ha.ReleaseDate
                        })
                        .OrderByDescending(ha => ha.ReleaseDate)
                        .Take(11)
                        .Skip(1)
                        .ToListAsync();

                    return latestNews.Select(ln => new
                    {
                        ArticleId = ln.ArticleId,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(ln.CategoryId)),
                        ImageSmallUrl = ln.ImageSmallUrl,
                        Title = ln.Title,
                        Posted = Common.PostedAgo(ln.PostedAgo)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoreLatestNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestNews = await ahLinesContext.HomeArticle
                        .Where(l => l.Section == "EDITOR_PICKS")
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.CategoryId,
                            l.ImageUrl,
                            l.Title,
                            l.Abstract,
                            l.PostedAgo,
                            l.ReleaseDate
                        })
                        .OrderByDescending(l => l.ReleaseDate)
                        .ToListAsync();

                    return latestNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(l.CategoryId)),
                        ImageUrl = l.ImageUrl,
                        Title = l.Title,
                        Abstract = l.Abstract,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetFashionAndLifeStyleBreakingNews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle fashionAndLifeStyleBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(n => n.Section.Equals("NEWS_FASH_LIFE_BREAKING"));

                    return new
                    {
                        ArticleId = fashionAndLifeStyleBreakingNews.ArticleId,
                        ImageUrl = Common.GetValidImageUrl(fashionAndLifeStyleBreakingNews.ImageUrl).Replace("/me/", "/la/"),
                        Title = fashionAndLifeStyleBreakingNews.Title,
                        Abstract = fashionAndLifeStyleBreakingNews.Abstract,
                        Posted = Common.PostedAgo(fashionAndLifeStyleBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetFashionAndLifeStyleLatestNews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var fashionAndLifeStyleLatestNews = await ahLinesContext.SectionArticle
                        .Where(f => f.Section.Equals("NEWS_FASH_LIFE_LATEST"))
                        .Select(f => new
                        {
                            f.ArticleId,
                            f.ImageSmallUrl,
                            f.Title,
                            f.PostedAgo
                        })
                        .OrderByDescending(f => f.ArticleId)
                        .Take(5)
                        .ToListAsync();

                    return fashionAndLifeStyleLatestNews.Select(f => new
                    {
                        ArticleId = f.ArticleId,
                        ImageSmallUrl = f.ImageSmallUrl,
                        Title = f.Title,
                        Posted = Common.PostedAgo(f.PostedAgo)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetTrendingBreakingNews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    HomeArticle trendingBreakingNews = await ahLinesContext.HomeArticle
                        .Where(ha => ha.Section == "SECTION1_BREAKING")
                        .OrderByDescending(ha => ha.ReleaseDate).FirstOrDefaultAsync();

                    return new
                    {
                        ArticleId = trendingBreakingNews.ArticleId,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(trendingBreakingNews.CategoryId)),
                        ImageUrl = trendingBreakingNews.ImageUrl.Replace("/me/", "/la/"),
                        Title = trendingBreakingNews.Title,
                        Abstract = trendingBreakingNews.Abstract,
                        Posted = Common.PostedAgo(trendingBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestTrendingNews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestTrendingNews = await ahLinesContext.HomeArticle
                        .Where(ha => ha.Section == "SECTION1_LATEST")
                        .Select(ha => new
                        {
                            ha.ArticleId,
                            ha.CategoryId,
                            ha.ImageSmallUrl,
                            ha.Title,
                            ha.PostedAgo,
                            ha.ReleaseDate
                        })
                        .OrderByDescending(ha => ha.ReleaseDate)
                        .Take(5).ToListAsync();

                    return latestTrendingNews.Select(ltn => new
                    {
                        ArticleId = ltn.ArticleId,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(ltn.CategoryId)),
                        ImageSmallUrl = ltn.ImageSmallUrl,
                        Title = ltn.Title,
                        Posted = Common.PostedAgo(ltn.PostedAgo)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoreTrendingNews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var moreTrendingNews = await ahLinesContext.HomeArticle
                        .Where(ha => ha.Section == "SECTION1_LATEST")
                        .Select(ha => new
                        {
                            ha.ArticleId,
                            ha.CategoryId,
                            ha.ImageSmallUrl,
                            ha.Title,
                            ha.Abstract,
                            ha.ReleaseDate
                        })
                        .OrderByDescending(ha => ha.ReleaseDate).ToListAsync();

                    return moreTrendingNews.Select(mtn => new
                    {
                        ArticleId = mtn.ArticleId,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(mtn.CategoryId)),
                        ImageSmallUrl = mtn.ImageSmallUrl,
                        Title = mtn.Title,
                        Abstract = mtn.Abstract,
                        ReleaseDate = mtn.ReleaseDate
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetTabLatestGallery()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var tabNews = await ahLinesContext.HomeArticle
                        .Where(ha => ha.Section.Equals("PHOTOS_GALLERY"))
                        .Select(ha => new
                        {
                            ha.ArticleId,
                            ha.Category,
                            ha.Title,
                            ha.ReleaseDate
                        })
                        .OrderByDescending(ha => ha.ReleaseDate)
                        .Take(12)
                        .ToListAsync();

                    return tabNews.Select(tn => new
                    {
                        ArticleId = tn.ArticleId,
                        PrefixUrl = Common.GetPrefixUrl(tn.Category),
                        Title = tn.Title
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetTabLatestVideos()
        {
            try
            {
                IEnumerable<dynamic> videosList = await Views.ViewQueryForVideosAsync();
                IEnumerable<dynamic> videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A")
                    .Join(videosSummary,
                    vl => vl.VideoClipId,
                    vs => vs.VideoClipId,
                    (vl, vs) => new { vl, vs })
                    .Select(lv => new
                    {
                        Id = lv.vl.VideoClipId,
                        Title = lv.vl.VideoClipTitle,
                        Created = lv.vs.Created
                    })
                    .OrderByDescending(lv => lv.Created)
                    .Take(24).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetTabNews(string section)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var tabNews = await ahLinesContext.HomeArticle
                        .Where(ha => ha.Section.Equals(section))
                        .Select(ha => new
                        {
                            ha.ArticleId,
                            ha.CategoryId,
                            ha.Title,
                            ha.ReleaseDate
                        })
                        .OrderByDescending(ha => ha.ReleaseDate)
                        .ToListAsync();

                    return tabNews.Select(n => new
                    {
                        ArticleId = n.ArticleId,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(n.CategoryId)),
                        Title = n.Title
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetEntertainmentNews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    List<HomeArticle> entertainmentNews = await ahLinesContext.HomeArticle
                        .Where(h => h.Section == "ENTERTAINMENT")
                        .OrderByDescending(h => h.ReleaseDate)
                        .Take(6).ToListAsync();

                    return entertainmentNews.Select(e => new
                    {
                        ArticleId = e.ArticleId,
                        Abstract = e.Abstract,
                        ImageUrl = string.IsNullOrEmpty(e.ImageUrl) ? e.ImageSmallUrl.Replace("sm", "la") : e.ImageUrl,
                        ImageSmallUrl = e.ImageSmallUrl,
                        Posted = Common.PostedAgo(e.PostedAgo),
                        Title = e.Title
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMarketWatchDetails()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    return await ahLinesContext.MarketWatch
                        .Select(m => new
                        {
                            TypeName = m.TypeName,
                            TypeValue = m.TypeValue
                        }).ToListAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<JokesTable> GetJokeOfTheDay()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    return await ahLinesContext.JokesTable
                        .Where(j => j.JokeStatus == true)
                        .OrderByDescending(j => j.JokeId).FirstAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetPhotoGallery()
        {
            try
            {
                List<dynamic> photoGallery = new List<dynamic>();
                photoGallery.AddRange(await GetCelebrityGalleryExceptSpicyAsync());
                photoGallery.AddRange(await GetCelebrityGalleryIncludeSpicyAsync());
                photoGallery.AddRange(await GetMovieGalleryAsync());
                photoGallery.AddRange(await GetEventGalleryAsync());
                return photoGallery
                    .OrderByDescending(pg => pg.GetType().GetProperty("Updated").GetValue(pg))
                    .Take(8);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestVideosAsync()
        {
            try
            {
                IEnumerable<dynamic> videosList = await Views.ViewQueryForVideosAsync();
                IEnumerable<dynamic> videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A")
                    .Join(videosSummary,
                    vl => vl.VideoClipId,
                    vs => vs.VideoClipId,
                    (vl, vs) => new { vl, vs })
                    .Select(lv => new
                    {
                        Id = lv.vl.VideoClipId,
                        Title = lv.vl.VideoClipTitle,
                        ImageUrl = lv.vl.ThumbImageUrl,
                        Created = lv.vs.Created
                    })
                    .OrderByDescending(lv => lv.Created)
                    .Take(4).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetTeluguHeadlinesAsync()
        {
            try
            {
                using (THLinesContext thLinesContext = new THLinesContext())
                {
                    short[] categoryIds = new short[] { 1, 2, 3, 4, 14 };

                    var teluguHeadlines = await thLinesContext.News
                        .Where(t => t.Approved.Value.Equals(true) && t.Deleted.Value.Equals(false) && categoryIds.Contains((short)t.Category))
                        .Select(t => new
                        {
                            t.NewsId,
                            t.Title,
                            t.Category,
                            t.AddedDate
                        })
                        .OrderByDescending(t => t.AddedDate)
                        .Take(10)
                        .ToListAsync();

                    return teluguHeadlines.Select(t => new
                    {
                        Id = t.NewsId,
                        Title = t.Title,
                        PrefixUrl = Common.GetTeluguPrefixUrl(t.Category)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async Task<IEnumerable<dynamic>> GetCelebrityGalleryExceptSpicyAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    string[] celebrityTypes = new string[] { "Actress", "Actor" };

                    var celebrities = await ahLinesContext.Celebrities
                        .Select(c => new
                        {
                            c.CelebrityId,
                            c.DisplayTitle,
                            c.DisplayStatus,
                            c.CelebrityImageUrl,
                            c.CelebrityType
                        }).ToListAsync();

                    var celebrityStills = await ahLinesContext.CelebrityStills
                        .GroupBy(cs => cs.CelebrityId)
                        .Select(cs => new
                        {
                            CelebrityId = cs.Key,
                            Updated = cs.Max(u => u.Updated)
                        }).ToListAsync();

                    return celebrities.Join(celebrityStills.DefaultIfEmpty(),
                        c => c.CelebrityId,
                        cs => cs.CelebrityId,
                        (c, cs) => new { c, cs })
                        .Where(pg => pg.c.DisplayStatus == "V" && celebrityTypes.Contains(pg.c.CelebrityType) && pg.c.CelebrityId != 69)
                        .Select(pg => new
                        {
                            GalleryId = pg.c.CelebrityId,
                            Title = pg.c.DisplayTitle,
                            ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]) + pg.c.CelebrityImageUrl,
                            PrefixUrl = pg.c.CelebrityType == "Actress" ? "/photos/actress/" : "/photos/actors/",
                            Updated = pg.cs.Updated
                        })
                        .OrderByDescending(pg => pg.Updated)
                        .Take(16).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<IEnumerable<dynamic>> GetCelebrityGalleryIncludeSpicyAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    string[] celebrityTypes = new string[] { "Actress", "Actor" };

                    var celebrities = await ahLinesContext.Celebrities
                        .Select(c => new
                        {
                            c.CelebrityId,
                            c.DisplayTitle,
                            c.DisplayStatus,
                            c.CelebrityImageUrl,
                            c.CelebrityType
                        }).ToListAsync();

                    var celebrityStills = await ahLinesContext.CelebrityStills
                        .GroupBy(cs => cs.CelebrityId)
                        .Select(cs => new
                        {
                            CelebrityId = cs.Key,
                            Updated = cs.Max(u => u.Updated)
                        }).ToListAsync();

                    return celebrities.Join(celebrityStills.DefaultIfEmpty(),
                        c => c.CelebrityId,
                        cs => cs.CelebrityId,
                        (c, cs) => new { c, cs })
                        .Where(pg => pg.c.DisplayStatus == "V" && celebrityTypes.Contains(pg.c.CelebrityType) && pg.c.CelebrityId == 69)
                        .Select(pg => new
                        {
                            GalleryId = pg.c.CelebrityId,
                            Title = pg.c.DisplayTitle,
                            ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]) + pg.c.CelebrityImageUrl,
                            PrefixUrl = pg.c.CelebrityType == "Actress" ? "/photos/actress/" : "/photos/actors/",
                            Updated = pg.cs.Updated
                        })
                        .OrderByDescending(pg => pg.Updated)
                        .Take(16).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<IEnumerable<dynamic>> GetMovieGalleryAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    int[] movieIds = new int[] { 69, 70, 71, 72, 74, 85, 86, 87, 88, 89, 90, 94, 95, 101, 103, 104 };

                    var movies = await ahLinesContext.Movie
                        .Select(m => new
                        {
                            m.MovieId,
                            m.MovieTitle,
                            m.ImageUrl,
                            m.MovieStatus,
                            m.Updated
                        }).ToListAsync();

                    var movieStills = await ahLinesContext.MovieStills
                        .GroupBy(ms => ms.MovieId)
                        .Select(ms => new
                        {
                            MovieId = ms.Key,
                            ImageUrl = ms.Max(i => i.SmallImageUrl.Replace("~", string.Empty)),
                            Updated = ms.Max(u => u.Updated)
                        }).ToListAsync();

                    return movies.Join(movieStills.DefaultIfEmpty(),
                        m => m.MovieId,
                        ms => ms.MovieId,
                        (m, ms) => new { m, ms })
                        .Where(mg => mg.m.MovieStatus == "V" && !movieIds.Contains(mg.m.MovieId) && !string.IsNullOrEmpty(mg.ms.ImageUrl))
                        .OrderByDescending(mg => mg.m.Updated)
                        .Select(mg => new
                        {
                            GalleryId = mg.m.MovieId,
                            Title = mg.m.MovieTitle,
                            ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]) + mg.m.ImageUrl,
                            PrefixUrl = "/photos/movies/",
                            Updated = mg.ms.Updated
                        })
                        .Take(16).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<IEnumerable<dynamic>> GetEventGalleryAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var events = await ahLinesContext.Events
                        .Join(ahLinesContext.EventCategories,
                        e => e.EventCategoryId,
                        ec => ec.EventCategoryId,
                        (e, ec) => new { e, ec })
                        .Select(e => new
                        {
                            e.e.EventId,
                            e.e.EventName,
                            e.e.ImageUrl,
                            e.e.EventCategoryId,
                            e.e.EventStatus
                        }).ToListAsync();

                    var eventStills = await ahLinesContext.EventStills
                        .GroupBy(es => es.EventId)
                        .Select(es => new
                        {
                            EventId = es.Key,
                            Updated = es.Max(u => u.Updated)
                        }).ToListAsync();

                    return events.Join(eventStills.DefaultIfEmpty(),
                        e => e.EventId,
                        es => es.EventId,
                        (e, es) => new { e, es })
                        .Where(eg => eg.e.EventStatus == "V")
                        .Select(eg => new
                        {
                            GalleryId = eg.e.EventId,
                            Title = eg.e.EventName,
                            ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]) + eg.e.ImageUrl,
                            PrefixUrl = eg.e.EventCategoryId == 6 ? "/photos/events/" : eg.e.EventCategoryId == 9 ? "/news/special/" : "/photos/events/",
                            Updated = eg.es.Updated
                        })
                        .OrderByDescending(eg => eg.Updated)
                        .Take(16).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}