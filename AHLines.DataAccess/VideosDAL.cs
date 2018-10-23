using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class VideosDAL
    {
        public async Task<IEnumerable<dynamic>> GetLatestVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

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
                    .Take(24).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetPoliticalVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 5)
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
                    .Take(24).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoviesVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 1)
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
                    .Take(24).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetSportsVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 3)
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
                    .Take(24).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetOtherVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 1 && vl.TypeId != 1)
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
                    .Take(24).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetLatestVideoDetailsBasedOnIdAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.VideoClipId == videoId)
                    .Join(videosSummary,
                    vl => vl.VideoClipId,
                    vs => vs.VideoClipId,
                    (vl, vs) => new { vl, vs })
                    .Select(lv => new
                    {
                        Id = lv.vl.VideoClipId,
                        Title = lv.vl.VideoClipTitle,
                        VideoUrl = Common.GetVideoUrl(lv.vl.FormatId, lv.vl.VideoUrl)
                    }).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetRemainingLatestVideosAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.VideoClipId != videoId)
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
                    .Take(21).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetPoliticalVideoDetailsBasedOnIdAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 5 && vl.VideoClipId == videoId)
                    .Join(videosSummary,
                    vl => vl.VideoClipId,
                    vs => vs.VideoClipId,
                    (vl, vs) => new { vl, vs })
                    .Select(lv => new
                    {
                        Id = lv.vl.VideoClipId,
                        Title = lv.vl.VideoClipTitle,
                        VideoUrl = Common.GetVideoUrl(lv.vl.FormatId, lv.vl.VideoUrl)
                    }).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetRemainingPoliticalVideosAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 5 && vl.VideoClipId != videoId)
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
                    .Take(21).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetMovieVideoDetailsBasedOnIdAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 1 && vl.VideoClipId == videoId)
                    .Join(videosSummary,
                    vl => vl.VideoClipId,
                    vs => vs.VideoClipId,
                    (vl, vs) => new { vl, vs })
                    .Select(lv => new
                    {
                        Id = lv.vl.VideoClipId,
                        Title = lv.vl.VideoClipTitle,
                        VideoUrl = Common.GetVideoUrl(lv.vl.FormatId, lv.vl.VideoUrl)
                    }).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetRemainingMoviesVideosAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 1 && vl.VideoClipId != videoId)
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
                    .Take(21).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetSportsVideoDetailsBasedOnIdAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 3 && vl.VideoClipId == videoId)
                    .Join(videosSummary,
                    vl => vl.VideoClipId,
                    vs => vs.VideoClipId,
                    (vl, vs) => new { vl, vs })
                    .Select(lv => new
                    {
                        Id = lv.vl.VideoClipId,
                        Title = lv.vl.VideoClipTitle,
                        VideoUrl = Common.GetVideoUrl(lv.vl.FormatId, lv.vl.VideoUrl)
                    }).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetRemainingSportsVideosAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 3 && vl.VideoClipId != videoId)
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
                    .Take(21).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<dynamic> GetOtherVideoDetailsBasedOnIdAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 1 && vl.TypeId != 1 && vl.VideoClipId == videoId)
                    .Join(videosSummary,
                    vl => vl.VideoClipId,
                    vs => vs.VideoClipId,
                    (vl, vs) => new { vl, vs })
                    .Select(lv => new
                    {
                        Id = lv.vl.VideoClipId,
                        Title = lv.vl.VideoClipTitle,
                        VideoUrl = Common.GetVideoUrl(lv.vl.FormatId, lv.vl.VideoUrl)
                    }).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetRemainingOtherVideosAsync(int videoId)
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                return videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 1 && vl.TypeId != 1 && vl.VideoClipId != videoId)
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
                    .Take(21).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoreSportsVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                var moreSportsVideos = videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 3)
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
                    .Take(54).ToList();

                moreSportsVideos.RemoveRange(0, 24);
                return moreSportsVideos;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMorePoliticalVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                var morePoliticalVideos = videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 5)
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
                    .Take(54).ToList();

                morePoliticalVideos.RemoveRange(0, 24);
                return morePoliticalVideos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMoreMoviesVideosAsync()
        {
            try
            {
                var videosList = await Views.ViewQueryForVideosAsync();
                var videosSummary = await Views.ViewQueryForVideosSummaryAsync();

                var moreMoviesVideos = videosList.Where(vl => vl.Status == "A" && vl.CategoryId == 1)
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
                    .Take(54).ToList();

                moreMoviesVideos.RemoveRange(0, 24);
                return moreMoviesVideos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}