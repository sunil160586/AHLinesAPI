using AHLines.DataModel;
using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class GalleryDAL
    {
        readonly string imagePrefixUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]);

        public async Task<IEnumerable<dynamic>> GetCelebritiesGalleryAsync(string celebrityType)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var celebrities = await ahLinesContext.Celebrities
                        .Select(c => new
                        {
                            c.CelebrityId,
                            c.CelebrityName,
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
                        .Where(cg => cg.c.DisplayStatus == "V" && cg.c.CelebrityType.ToLower() == celebrityType)
                        .Select(cg => new
                        {
                            Id = cg.c.CelebrityId,
                            Name = cg.c.CelebrityName,
                            ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["BannerImagePrefixUrl"]) + cg.c.CelebrityImageUrl,
                            PrefixUrl = cg.c.CelebrityType == "Actress" ? "/photos/actress/" : "/photos/actors/",
                            Updated = cg.cs.Updated
                        })
                        .OrderByDescending(cg => cg.Updated)
                        .Take(20).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoviesGalleryAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var movies = await ahLinesContext.Movie
                        .Select(m => new
                        {
                            m.MovieId,
                            m.MovieName,
                            m.ImageUrl,
                            m.MovieStatus
                        }).ToListAsync();

                    var movieStills = await ahLinesContext.MovieStills
                        .GroupBy(ms => ms.MovieId)
                        .Select(ms => new
                        {
                            MovieId = ms.Key,
                            Updated = ms.Max(u => u.Updated)
                        }).ToListAsync();

                    return movies.Join(movieStills.DefaultIfEmpty(),
                        m => m.MovieId,
                        ms => ms.MovieId,
                        (m, ms) => new { m, ms })
                        .Where(mg => mg.m.MovieStatus == "V")
                        .OrderByDescending(mg => mg.ms.Updated)
                        .Select(mg => new
                        {
                            Id = mg.m.MovieId,
                            Name = mg.m.MovieName,
                            ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["BannerImagePrefixUrl"]) + mg.m.ImageUrl,
                            PrefixUrl = "/photos/movies/"
                        })
                        .Take(20).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetEventsGalleryAsync()
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
                        .Where(eg => eg.e.EventStatus == "V" && eg.e.EventCategoryId != 9 && eg.e.EventId != 179)
                        .Select(eg => new
                        {
                            Id = eg.e.EventId,
                            Name = eg.e.EventName,
                            ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["BannerImagePrefixUrl"]) + eg.e.ImageUrl,
                            PrefixUrl = "/photos/events/",
                            Updated = eg.es.Updated
                        })
                        .OrderByDescending(eg => eg.Updated)
                        .Take(20).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetWallPapersGalleryAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var wallPapersView = await ahLinesContext.WallPapers
                        .GroupJoin(ahLinesContext.Celebrities,
                        w => w.CelebrityId,
                        c => c.CelebrityId,
                        (w, c) => new { w, c })
                        .SelectMany(w => w.c.DefaultIfEmpty(), (w, c) => new { w.w, c })
                        .GroupJoin(ahLinesContext.Movie,
                        wc => wc.w.MovieId,
                        m => m.MovieId,
                        (wc, m) => new { wc, m })
                        .SelectMany(wcm => wcm.m.DefaultIfEmpty(), (wcm, m) => new { wcm.wc, m })
                        .GroupJoin(ahLinesContext.Events,
                        wcm => wcm.wc.w.EventId,
                        e => e.EventId,
                        (wcm, e) => new { wcm, e })
                        .SelectMany(wcme => wcme.e.DefaultIfEmpty(), (wcme, e) => new
                        {
                            Id = wcme.wcm.wc.w.CelebrityId != null ? wcme.wcm.wc.w.CelebrityId : wcme.wcm.wc.w.MovieId != null ? wcme.wcm.wc.w.MovieId : wcme.wcm.wc.w.EventId != null ? wcme.wcm.wc.w.EventId : null,
                            WallPaperId = wcme.wcm.wc.w.WallpaperId,
                            WallPaperName = wcme.wcm.wc.w.CelebrityId != null ? wcme.wcm.wc.c.CelebrityName : wcme.wcm.wc.w.MovieId != null ? wcme.wcm.m.MovieName : wcme.wcm.wc.w.EventId != null ? e.EventName : string.Empty,
                            ImageUrl = wcme.wcm.wc.w.ThumbImageUrl,
                            Updated = wcme.wcm.wc.w.Updated
                        }).ToListAsync();

                    var a = wallPapersView.Select(wpv => new
                    {
                        wpv.Id,
                        wpv.WallPaperId,
                        wpv.WallPaperName,
                        wpv.ImageUrl,
                        wpv.Updated
                    }).ToList();

                    var b = wallPapersView.GroupBy(wpv => wpv.Id)
                        .Select(wpv => new
                        {
                            Id = wpv.Key,
                            WallPaperId = wpv.Max(w => w.WallPaperId)
                        }).ToList();

                    return a.Join(b,
                        x => new { x.Id, x.WallPaperId },
                        y => new { y.Id, y.WallPaperId },
                        (x, y) => new { x, y })
                        .Where(wg => !string.IsNullOrEmpty(wg.x.WallPaperName))
                        .Select(wg => new
                        {
                            Id = wg.x.Id,
                            Name = wg.x.WallPaperName,
                            ImageUrl = Convert.ToString(ConfigurationManager.AppSettings["BannerImagePrefixUrl"]) + wg.x.ImageUrl,
                            PrefixUrl = "/photos/wallpapers/",
                            Updated = wg.x.Updated
                        })
                        .OrderByDescending(wg => wg.Updated)
                        .Take(40)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetActressGalleryListAsync(int actressId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    await UpdateCelebrityGalleryViewCountAsync(actressId);

                    return await ahLinesContext.Celebrities
                        .Join(ahLinesContext.CelebrityStills,
                        c => c.CelebrityId,
                        cs => cs.CelebrityId,
                        (c, cs) => new { c, cs })
                        .Where(cg => cg.cs.CelebrityId == actressId)
                        .Select(cg => new
                        {
                            GalleryId = cg.cs.CelebrityStillId,
                            Id = cg.cs.CelebrityId,
                            Name = cg.c.CelebrityName,
                            SmallImageUrl = imagePrefixUrl + cg.cs.SmallImageUrl,
                            LargeImageUrl = imagePrefixUrl + cg.cs.LargeImageUrl
                        })
                        .OrderByDescending(cg => cg.GalleryId)
                        .ToListAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetActorGalleryListAsync(int actorId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    await UpdateCelebrityGalleryViewCountAsync(actorId);

                    return await ahLinesContext.Celebrities
                        .Join(ahLinesContext.CelebrityStills,
                        c => c.CelebrityId,
                        cs => cs.CelebrityId,
                        (c, cs) => new { c, cs })
                        .Where(cg => cg.cs.CelebrityId == actorId && cg.cs.DisplayStatus == "V")
                        .Select(cg => new
                        {
                            GalleryId = cg.cs.CelebrityStillId,
                            Id = cg.cs.CelebrityId,
                            Name = cg.c.CelebrityName,
                            SmallImageUrl = imagePrefixUrl + cg.cs.SmallImageUrl,
                            LargeImageUrl = imagePrefixUrl + cg.cs.LargeImageUrl
                        })
                        .OrderByDescending(cg => cg.GalleryId)
                        .ToListAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMovieGalleryListAsync(int movieId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    await UpdateMovieGalleryViewCountAsync(movieId);

                    return await ahLinesContext.MovieStills
                        .Join(ahLinesContext.Movie,
                        ms => ms.MovieId,
                        m => m.MovieId,
                        (ms, m) => new { ms, m })
                        .Where(mg => mg.ms.MovieId == movieId)
                        .Select(mg => new
                        {
                            GalleryId = mg.ms.MovieStillId,
                            Id = mg.ms.MovieId,
                            Name = mg.m.MovieName,
                            SmallImageUrl = imagePrefixUrl + mg.ms.SmallImageUrl,
                            LargeImageUrl = imagePrefixUrl + mg.ms.LargeImageUrl
                        })
                        .OrderByDescending(mg => mg.GalleryId)
                        .ToListAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetEventGalleryListAsync(int eventId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    await UpdateEventGalleryViewCountAsync(eventId);

                    return await ahLinesContext.EventStills
                        .Join(ahLinesContext.Events,
                        es => es.EventId,
                        e => e.EventId,
                        (es, e) => new { es, e })
                        .Where(eg => eg.es.EventId == eventId)
                        .Select(eg => new
                        {
                            GalleryId = eg.es.EventStillId,
                            Id = eg.es.EventId,
                            Name = eg.e.EventName,
                            SmallImageUrl = imagePrefixUrl + eg.es.SmallImageUrl,
                            LargeImageUrl = imagePrefixUrl + eg.es.LargeImageUrl
                        })
                        .OrderBy(eg => eg.GalleryId)
                        .ToListAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetWallPaperGalleryListAsync(int wallPaperId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var wallPapersView = await ahLinesContext.WallPapers
                        .GroupJoin(ahLinesContext.Celebrities,
                        w => w.CelebrityId,
                        c => c.CelebrityId,
                        (w, c) => new { w, c })
                        .SelectMany(w => w.c.DefaultIfEmpty(), (w, c) => new { w.w, c })
                        .GroupJoin(ahLinesContext.Movie,
                        wc => wc.w.MovieId,
                        m => m.MovieId,
                        (wc, m) => new { wc, m })
                        .SelectMany(wcm => wcm.m.DefaultIfEmpty(), (wcm, m) => new { wcm.wc, m })
                        .GroupJoin(ahLinesContext.Events,
                        wcm => wcm.wc.w.EventId,
                        e => e.EventId,
                        (wcm, e) => new { wcm, e })
                        .SelectMany(wcme => wcme.e.DefaultIfEmpty(), (wcme, e) => new
                        {
                            Id = wcme.wcm.wc.w.CelebrityId != null ? wcme.wcm.wc.w.CelebrityId : wcme.wcm.wc.w.MovieId != null ? wcme.wcm.wc.w.MovieId : wcme.wcm.wc.w.EventId != null ? wcme.wcm.wc.w.EventId : null,
                            WallPaperId = wcme.wcm.wc.w.WallpaperId,
                            WallPaperName = wcme.wcm.wc.w.CelebrityId != null ? wcme.wcm.wc.c.CelebrityName : wcme.wcm.wc.w.MovieId != null ? wcme.wcm.m.MovieName : wcme.wcm.wc.w.EventId != null ? e.EventName : string.Empty,
                            ImageUrl = wcme.wcm.wc.w.ThumbImageUrl,
                            Image1024x768Url = wcme.wcm.wc.w.Image1024x768Url,
                            Updated = wcme.wcm.wc.w.Updated
                        }).ToListAsync();

                    return wallPapersView.Where(wg => wg.Id == wallPaperId && !string.IsNullOrEmpty(wg.Image1024x768Url))
                        .Select(wg => new
                        {
                            GalleryId = wg.WallPaperId,
                            Id = wg.Id,
                            Name = wg.WallPaperName,
                            SmallImageUrl = Convert.ToString(ConfigurationManager.AppSettings["BannerImagePrefixUrl"]) + wg.ImageUrl,
                            LargeImageUrl = Convert.ToString(ConfigurationManager.AppSettings["BannerImagePrefixUrl"]) + wg.Image1024x768Url,
                            Updated = wg.Updated
                        })
                        .OrderByDescending(wg => wg.GalleryId)
                        .OrderByDescending(wg => wg.Updated)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetCelebritiesTitleNamesAsync(string celebrityType)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var celebrities = await ahLinesContext.Celebrities
                        .Select(c => new
                        {
                            c.CelebrityId,
                            c.CelebrityName,
                            c.DisplayStatus,
                            c.CelebrityType
                        }).ToListAsync();

                    var celebrityStills = await ahLinesContext.CelebrityStills
                        .GroupBy(cs => cs.CelebrityId)
                        .Select(cs => new
                        {
                            CelebrityId = cs.Key
                        }).ToListAsync();

                    return celebrities.GroupJoin(celebrityStills,
                        c => c.CelebrityId,
                        cs => cs.CelebrityId,
                        (c, cs) => new { c, cs })
                        .SelectMany(t => t.cs.DefaultIfEmpty(), (cg, cs) => new
                        {
                            Name = cg.c.CelebrityName,
                            Type = cg.c.CelebrityType,
                            DisplayStatus = cg.c.DisplayStatus
                        })
                        .Where(t => t.DisplayStatus == "V" && t.Type.ToLower() == celebrityType)
                        .ToList()
                        .GroupBy(t => t.Name.Substring(0, 1).ToUpper())
                        .Select(t => new
                        {
                            Title = t.Key
                        })
                        .OrderBy(t => t.Title)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoviesTitleNamesAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var movies = await ahLinesContext.Movie
                        .Select(m => new
                        {
                            m.MovieId,
                            m.MovieName,
                            m.MovieStatus
                        })
                        .ToListAsync();

                    var movieStills = await ahLinesContext.MovieStills
                        .GroupBy(ms => ms.MovieId)
                        .Select(ms => new
                        {
                            MovieId = ms.Key
                        })
                        .ToListAsync();

                    return movies.GroupJoin(movieStills,
                        m => m.MovieId,
                        ms => ms.MovieId,
                        (m, ms) => new { m, ms })
                        .SelectMany(t => t.ms.DefaultIfEmpty(), (mg, ms) => new
                        {
                            Name = mg.m.MovieName,
                            MovieStatus = mg.m.MovieStatus
                        })
                        .Where(t => t.MovieStatus == "V")
                        .ToList()
                        .GroupBy(t => t.Name.Substring(0, 1).ToUpper())
                        .Select(t => new
                        {
                            Title = t.Key
                        })
                        .OrderBy(t => t.Title)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetEventsTitleNamesAsync()
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
                            e.e.EventStatus
                        }).ToListAsync();

                    var eventStills = await ahLinesContext.EventStills
                        .GroupBy(es => es.EventId)
                        .Select(es => new
                        {
                            EventId = es.Key,
                            EventStillId = es.Max(e => e.EventStillId)
                        }).ToListAsync();

                    return events.GroupJoin(eventStills,
                        e => e.EventId,
                        es => es.EventId,
                        (e, es) => new { e, es })
                        .SelectMany(t => t.es.DefaultIfEmpty(), (eg, es) => new
                        {
                            Name = eg.e.EventName,
                            EventStatus = eg.e.EventStatus,
                            EventStillId = eg.es.Select(esi => esi.EventStillId)
                        })
                        .Where(t => t.EventStatus == "V" && t.EventStillId != null)
                        .ToList()
                        .GroupBy(t => t.Name.Substring(0, 1).ToUpper())
                        .Select(t => new
                        {
                            Title = t.Key
                        })
                        .OrderBy(t => t.Title).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetCelebritiesListBasedOnTitleAsync(string celebrityType, string title)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var celebrities = await ahLinesContext.Celebrities
                        .Select(c => new
                        {
                            c.CelebrityId,
                            c.CelebrityName,
                            c.DisplayStatus,
                            c.CelebrityType
                        }).ToListAsync();

                    var celebrityStills = await ahLinesContext.CelebrityStills
                        .GroupBy(cs => cs.CelebrityId)
                        .Select(cs => new
                        {
                            CelebrityId = cs.Key
                        }).ToListAsync();

                    return celebrities.GroupJoin(celebrityStills,
                        c => c.CelebrityId,
                        cs => cs.CelebrityId,
                        (c, cs) => new { c, cs })
                        .SelectMany(cg => cg.cs.DefaultIfEmpty(), (cg, cs) => new
                        {
                            Id = cg.c.CelebrityId,
                            Name = cg.c.CelebrityName,
                            Type = cg.c.CelebrityType,
                            PrefixUrl = cg.c.CelebrityType == "Actress" ? "/photos/actress/" : "/photos/actors/",
                            DisplayStatus = cg.c.DisplayStatus
                        })
                        .Where(cn => cn.DisplayStatus == "V" && cn.Type.ToLower() == celebrityType && cn.Name.Substring(0, 1).ToUpper() == title)
                        .ToList()
                        .Select(cn => new
                        {
                            Id = cn.Id,
                            Name = cn.Name,
                            PrefixUrl = cn.PrefixUrl
                        })
                        .OrderBy(cn => cn.Name)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoviesListBasedOnTitleAsync(string title)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var movies = await ahLinesContext.Movie
                        .Select(m => new
                        {
                            m.MovieId,
                            m.MovieName,
                            m.MovieStatus
                        })
                        .ToListAsync();

                    var movieStills = await ahLinesContext.MovieStills
                        .GroupBy(ms => ms.MovieId)
                        .Select(ms => new
                        {
                            MovieId = ms.Key
                        })
                        .ToListAsync();

                    return movies.GroupJoin(movieStills,
                        m => m.MovieId,
                        ms => ms.MovieId,
                        (m, ms) => new { m, ms })
                        .SelectMany(t => t.ms.DefaultIfEmpty(), (mg, ms) => new
                        {
                            Id = mg.m.MovieId,
                            Name = mg.m.MovieName,
                            PrefixUrl = "/photos/movies/",
                            MovieStatus = mg.m.MovieStatus
                        })
                        .Where(mn => mn.MovieStatus == "V" && mn.Name.Substring(0, 1).ToUpper() == title)
                        .ToList()
                        .Select(mn => new
                        {
                            Id = mn.Id,
                            Name = mn.Name,
                            PrefixUrl = mn.PrefixUrl
                        })
                        .OrderBy(mn => mn.Name)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetEventsListBasedOnTitleAsync(string title)
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
                            e.e.EventStatus
                        }).ToListAsync();

                    var eventStills = await ahLinesContext.EventStills
                        .GroupBy(es => es.EventId)
                        .Select(es => new
                        {
                            EventId = es.Key,
                            EventStillId = es.Max(e => e.EventStillId)
                        }).ToListAsync();

                    return events.GroupJoin(eventStills,
                        e => e.EventId,
                        es => es.EventId,
                        (e, es) => new { e, es })
                        .SelectMany(t => t.es.DefaultIfEmpty(), (eg, es) => new
                        {
                            Id = eg.e.EventId,
                            Name = eg.e.EventName,
                            EventStatus = eg.e.EventStatus,
                            EventStillId = eg.es.Select(esi => esi.EventStillId),
                            PrefixUrl = "/photos/events/"
                        })
                        .Where(t => t.EventStatus == "V" && t.EventStillId != null && t.Name.Substring(0, 1).ToUpper() == title)
                        .ToList()
                        .Select(en => new
                        {
                            Id = en.Id,
                            Name = en.Name,
                            PrefixUrl = en.PrefixUrl
                        })
                        .OrderBy(en => en.Name).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        async Task UpdateCelebrityGalleryViewCountAsync(int celebrityId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    await ahLinesContext.CelebrityStills
                        .Where(cs => cs.CelebrityId == celebrityId)
                        .UpdateAsync(cs => new CelebrityStills
                        {
                            ViewCount = cs.ViewCount == null ? 1 : cs.ViewCount + 1
                        });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        async Task UpdateMovieGalleryViewCountAsync(int movieId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    await ahLinesContext.MovieStills
                        .Where(ms => ms.MovieId == movieId)
                        .UpdateAsync(ms => new MovieStills
                        {
                            ViewCount = ms.ViewCount == null ? 1 : ms.ViewCount + 1
                        });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        async Task UpdateEventGalleryViewCountAsync(int eventId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    await ahLinesContext.EventStills
                        .Where(es => es.EventId == eventId)
                        .UpdateAsync(es => new EventStill
                        {
                            ViewCount = es.ViewCount == null ? 1 : es.ViewCount + 1
                        });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}