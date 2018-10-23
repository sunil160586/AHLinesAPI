using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class MoviesDAL
    {
        public async Task<IEnumerable<dynamic>> GetLatestMovieNewsAndGossips()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var movieNewsAndGossips = await ahLinesContext.Article
                        .Where(m => m.IsApproved == true && new[] { 6, 9 }.Contains((int)m.CategoryId))
                        .Take(6)
                        .OrderByDescending(m => m.ArticleId).ToListAsync();

                    return movieNewsAndGossips.Select(m => new
                    {
                        ArticleId = m.ArticleId,
                        ImageSmallUrl = ConfigurationManager.AppSettings["ImagePrefixUrl"].ToString() + m.ImageSmallUrl,
                        Title = m.Title,
                        ReleaseDate = Common.GetTimeBasedOnTimeZone(m.ReleaseDate)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMovieNewsAndGossips()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var movieNewsAndGossips = await ahLinesContext.SectionArticle
                        .Where(s => s.Section == "MOVIE_NEWS")
                        .Select(s => new
                        {
                            s.ArticleId,
                            s.ImageUrl,
                            s.Title,
                            s.Abstract,
                            s.ReleaseDate
                        }).OrderByDescending(s => s.ArticleId).ToListAsync();

                    return movieNewsAndGossips.Select(s => new
                    {
                        ArticleId = s.ArticleId,
                        ImageUrl = s.ImageUrl,
                        Title = s.Title,
                        Abstract = s.Abstract,
                        ReleaseDate = Common.GetTimeBasedOnTimeZone(s.ReleaseDate)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetMovieArticle(int articleId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    int viewCount = await Common.UpdateArticleViewCount(articleId);
                    string imagePrefixUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]);

                    return await ahLinesContext.Article
                        .Join(ahLinesContext.ArticleBody,
                        a => a.ArticleId,
                        ab => ab.ArticleId,
                        (a, ab) => new { a, ab })
                        .Where(a => a.a.ArticleId == articleId)
                        .Select(a => new
                        {
                            ArticleTitle = a.a.ArticleTitle,
                            ImageUrl = imagePrefixUrl + a.a.ImageUrl,
                            TagLine = a.a.TagLine,
                            Body = a.ab.Body
                        }).FirstOrDefaultAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMovieVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                var movieIds = videosList.Where(vl => vl.Status == "A")
                    .Join(videosSummary,
                    vl => vl.VideoClipId,
                    vs => vs.VideoClipId,
                    (vl, vs) => new { vl, vs })
                    .Select(lv => new
                    {
                        Id = lv.vl.VideoClipId,
                        Created = lv.vs.Created
                    })
                    .OrderByDescending(lv => lv.Created)
                    .Take(6).ToList();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 1 && vl.TypeId == 1 && !movieIds.Select(m => m.Id).ToList().Contains(vl.VideoClipId))
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
                    .Take(6).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestMovieAudios()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    string imagePrefixUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]);

                    return await ahLinesContext.Audio
                        .Join(ahLinesContext.Movie,
                        a => a.MovieId,
                        m => m.MovieId,
                        (a, m) => new { a, m })
                        .Select(am => new
                        {
                            AudioId = am.a.AudioId,
                            MovieName = am.m.MovieName,
                            ImageUrl = imagePrefixUrl + am.m.ImageUrl
                        })
                        .Take(6)
                        .OrderByDescending(am => am.AudioId).ToListAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetLatestMovieReviews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    string imagePrefixUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]);

                    var result = await ahLinesContext.Article
                        .Join(ahLinesContext.ArticleBody,
                        a => a.ArticleId,
                        ab => ab.ArticleId,
                        (a, ab) => new { a, ab })
                        .Where(a => a.a.CategoryId == 17)
                        .Select(a => new
                        {
                            a.a.ArticleId,
                            a.a.Title,
                            a.a.ImageSmallUrl,
                            a.ab.Body,
                            a.a.UpdatedDate
                        })
                        .Take(5)
                        .OrderByDescending(a => a.UpdatedDate).ToListAsync();

                    return result.Select(a => new
                    {
                        MovieId = a.ArticleId,
                        MovieName = a.Title.Replace("Review: ", string.Empty),
                        ImageUrl = imagePrefixUrl + a.ImageSmallUrl,
                        Rating = Common.RemoveHtmlTags(a.Body, "Rating")
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoviesReviews()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    string imagePrefixUrl = Convert.ToString(ConfigurationManager.AppSettings["ImagePrefixUrl"]);

                    return await ahLinesContext.Article
                        .Where(a => a.CategoryId == 17)
                        .Select(a => new MovieReviews
                        {
                            MovieId = a.ArticleId,
                            MovieName = a.Title.Replace("Review: ", string.Empty),
                            Abstract = a.Abstract,
                            Casting = a.TagLine,
                            ImageUrl = imagePrefixUrl + a.ImageSmallUrl,
                            UpdatedDate = a.UpdatedDate
                        }).Union(
                        ahLinesContext.Movie
                        .Join(ahLinesContext.MovieReview,
                        m => m.MovieId,
                        mr => mr.MovieId,
                        (m, mr) => new { m, mr })
                        .Select(m => new MovieReviews
                        {
                            MovieId = m.mr.MovieId,
                            MovieName = m.m.MovieName,
                            Abstract = m.mr.Abstract,
                            Casting = m.mr.Casting,
                            ImageUrl = imagePrefixUrl + m.m.ImageUrl,
                            UpdatedDate = m.mr.ModifiedDate
                        }))
                        .OrderByDescending(m => m.UpdatedDate).ToListAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    class MovieReviews
    {
        public int? MovieId { get; set; }
        public string MovieName { get; set; }
        public string Abstract { get; set; }
        public string Casting { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}