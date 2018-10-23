using AHLines.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class NewsDAL
    {
        public async Task<dynamic> GetSpecialBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle specialBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_SPECIAL_BREAKING"));

                    return new
                    {
                        ArticleId = specialBreakingNews.ArticleId,
                        Title = specialBreakingNews.Title,
                        Abstract = specialBreakingNews.Abstract,
                        ImageUrl = specialBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(specialBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestSpecialNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestSpecialNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_SPECIAL_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestSpecialNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetSpecialNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var specialNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("SPECIAL_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return specialNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetSeemandhraBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle seemandhraBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_ANDHRA_BREAKING"));

                    return new
                    {
                        ArticleId = seemandhraBreakingNews.ArticleId,
                        Title = seemandhraBreakingNews.Title,
                        Abstract = seemandhraBreakingNews.Abstract,
                        ImageUrl = seemandhraBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(seemandhraBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestSeemandhraNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestSeemandhraNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_ANDHRA_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestSeemandhraNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetSeemandhraNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var seemandhraNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("ANDHRA_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return seemandhraNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetTelanganaBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle telanganaBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_TELANGANA_BREAKING"));

                    return new
                    {
                        ArticleId = telanganaBreakingNews.ArticleId,
                        Title = telanganaBreakingNews.Title,
                        Abstract = telanganaBreakingNews.Abstract,
                        ImageUrl = telanganaBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(telanganaBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestTelanganaNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestTelanganaNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_TELANGANA_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestTelanganaNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetTelanganaNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var telanganaNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("TELANGANA_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return telanganaNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetSportsBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle sportsBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_SPORTS_BREAKING"));

                    return new
                    {
                        ArticleId = sportsBreakingNews.ArticleId,
                        Title = sportsBreakingNews.Title,
                        Abstract = sportsBreakingNews.Abstract,
                        ImageUrl = sportsBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(sportsBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestSportsNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestSportsNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_SPORTS_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestSportsNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetSportsNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var sportsNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("SPORTS_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return sportsNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetNationalBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle nationalBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_INDIA_BREAKING"));

                    return new
                    {
                        ArticleId = nationalBreakingNews.ArticleId,
                        Title = nationalBreakingNews.Title,
                        Abstract = nationalBreakingNews.Abstract,
                        ImageUrl = nationalBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(nationalBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestNationalNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestNationalNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_INDIA_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestNationalNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetNationalNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var nationalNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("INDIA_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return nationalNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetWorldBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle worldBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_WORLD_BREAKING"));

                    return new
                    {
                        ArticleId = worldBreakingNews.ArticleId,
                        Title = worldBreakingNews.Title,
                        Abstract = worldBreakingNews.Abstract,
                        ImageUrl = worldBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(worldBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestWorldNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestWorldNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_WORLD_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestWorldNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetWorldNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var worldNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("WORLD_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return worldNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetNRIBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle nriBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_NRI_BREAKING"));

                    return new
                    {
                        ArticleId = nriBreakingNews.ArticleId,
                        Title = nriBreakingNews.Title,
                        Abstract = nriBreakingNews.Abstract,
                        ImageUrl = nriBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(nriBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestNRINewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestNRINews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_NRI_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestNRINews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetNRINewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var nriNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("NRI_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return nriNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetCrimeWatchBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle crimeWatchBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_CRIME_WATCH_BREAKING"));

                    return new
                    {
                        ArticleId = crimeWatchBreakingNews.ArticleId,
                        Title = crimeWatchBreakingNews.Title,
                        Abstract = crimeWatchBreakingNews.Abstract,
                        ImageUrl = crimeWatchBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(crimeWatchBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestCrimeWatchNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestCrimeWatchNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_CRIME_WATCH_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestCrimeWatchNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetCrimeWatchNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var crimeWatchNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("CRIME_WATCH_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return crimeWatchNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetBusinessBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle businessBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_BUSINESS_BREAKING"));

                    return new
                    {
                        ArticleId = businessBreakingNews.ArticleId,
                        Title = businessBreakingNews.Title,
                        Abstract = businessBreakingNews.Abstract,
                        ImageUrl = businessBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(businessBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestBusinessNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestBusinessNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_BUSINESS_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestBusinessNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetBusinessNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var businessNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("BUSINESS_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return businessNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetFashionAndLifeStyleBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle fashionAndLifeStyleBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_FASH_LIFE_BREAKING"));

                    return new
                    {
                        ArticleId = fashionAndLifeStyleBreakingNews.ArticleId,
                        Title = fashionAndLifeStyleBreakingNews.Title,
                        Abstract = fashionAndLifeStyleBreakingNews.Abstract,
                        ImageUrl = fashionAndLifeStyleBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(fashionAndLifeStyleBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestFashionAndLifeStyleNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestFashionAndLifeStyleNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_FASH_LIFE_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestFashionAndLifeStyleNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetFashionAndLifeStyleNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var fashionAndLifeStyleNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("FASH_LIFE_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return fashionAndLifeStyleNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetScienceAndTechnologyBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle scienceAndTechnologyBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_SCI_TECH_BREAKING"));

                    return new
                    {
                        ArticleId = scienceAndTechnologyBreakingNews.ArticleId,
                        Title = scienceAndTechnologyBreakingNews.Title,
                        Abstract = scienceAndTechnologyBreakingNews.Abstract,
                        ImageUrl = scienceAndTechnologyBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(scienceAndTechnologyBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestScienceAndTechnologyNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestScienceAndTechnologyNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_SCI_TECH_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestScienceAndTechnologyNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetScienceAndTechnologyNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var scienceAndTechnologyNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("SCI_TECH_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return scienceAndTechnologyNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetHealthAndLivingBreakingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    SectionArticle healthAndLivingBreakingNews = await ahLinesContext.SectionArticle
                        .FirstOrDefaultAsync(s => s.Section.Equals("NEWS_HEALTH_LIVE_BREAKING"));

                    return new
                    {
                        ArticleId = healthAndLivingBreakingNews.ArticleId,
                        Title = healthAndLivingBreakingNews.Title,
                        Abstract = healthAndLivingBreakingNews.Abstract,
                        ImageUrl = healthAndLivingBreakingNews.ImageUrl,
                        Posted = Common.PostedAgo(healthAndLivingBreakingNews.PostedAgo)
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestHealthAndLivingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var latestHealthAndLivingNews = await ahLinesContext.SectionArticle
                        .Where(l => l.Section.Equals("NEWS_HEALTH_LIVE_LATEST"))
                        .Select(l => new
                        {
                            l.ArticleId,
                            l.Title,
                            l.ImageSmallUrl,
                            l.PostedAgo
                        })
                        .OrderByDescending(l => l.ArticleId)
                        .ToListAsync();

                    return latestHealthAndLivingNews.Select(l => new
                    {
                        ArticleId = l.ArticleId,
                        Title = l.Title,
                        ImageUrl = l.ImageSmallUrl,
                        Posted = Common.PostedAgo(l.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetHealthAndLivingNewsAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var healthAndLivingNews = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("HEALTH_LIVE_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.PostedAgo
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return healthAndLivingNews.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ImageUrl = s.ImageUrl,
                        Posted = Common.PostedAgo(s.PostedAgo)
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetNewsHeadlinesAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var newsHeadlines = await ahLinesContext.SectionArticle
                        .Where(s => s.Section.Equals("SECTION_LATEST"))
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.CategoryId,
                            s.Title
                        })
                        .OrderByDescending(s => s.ArticleId)
                        .ToListAsync();

                    return newsHeadlines.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        Title = s.Title,
                        PrefixUrl = Common.GetPrefixUrl(Convert.ToString(s.CategoryId))
                    })
                    .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetNewsArticleAsync(int articleId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    int viewCount = await Common.UpdateArticleViewCount(articleId);

                    var newsArticle = await ahLinesContext.Article
                        .Join(ahLinesContext.ArticleBody,
                        a => a.ArticleId,
                        b => b.ArticleId,
                        (a, b) => new { a, b })
                        .Join(ahLinesContext.Category,
                        a => a.a.CategoryId,
                        c => c.CategoryId,
                        (a, c) => new { a, c })
                        .FirstOrDefaultAsync(a => a.a.a.ArticleId.Equals(articleId));

                    return new
                    {
                        ArticleId = newsArticle.a.a.ArticleId,
                        Title = newsArticle.a.a.Title,
                        ImageUrl = ConfigurationManager.AppSettings["ImagePrefixUrl"].ToString() + newsArticle.a.a.ImageUrl,
                        Body = newsArticle.a.b.Body,
                        TagLine = newsArticle.a.a.TagLine
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}