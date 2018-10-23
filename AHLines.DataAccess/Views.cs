using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class Views
    {
        readonly static string bannerImagePrefixUrl = Convert.ToString(ConfigurationManager.AppSettings["BannerImagePrefixUrl"]);

        public static async Task<IEnumerable<dynamic>> ViewQueryForVideosAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    return await ahLinesContext.Videos
                        .Join(ahLinesContext.VideoCategories,
                        v => v.CategoryId,
                        vc => vc.CategoryId,
                        (v, vc) => new { v, vc })
                        .Join(ahLinesContext.VideoTypes,
                        v => v.v.TypeId,
                        vt => vt.TypeId,
                        (v, vt) => new { v, vt })
                        .Join(ahLinesContext.VideoFormats,
                        v => v.v.v.FormatId,
                        vf => vf.FormatId,
                        (v, vf) => new { v, vf })
                        .GroupJoin(ahLinesContext.Celebrities,
                        v => v.v.v.v.ActorId,
                        c => c.CelebrityId,
                        (v, c) => new { v, c })
                        .SelectMany(va => va.c.DefaultIfEmpty(), (va, c) => new { va.v, c })
                        .GroupJoin(ahLinesContext.Celebrities,
                        v => v.v.v.v.v.ActorId,
                        c => c.CelebrityId,
                        (v, c) => new { v, c })
                        .SelectMany(va => va.c.DefaultIfEmpty(), (va, c) => new { va.v, c })
                        .GroupJoin(ahLinesContext.Movie,
                        v => v.v.v.v.v.v.MovieId,
                        m => m.MovieId,
                        (v, m) => new { v, m })
                        .SelectMany(vm => vm.m.DefaultIfEmpty(), (vm, m) => new { vm.v, m })
                        .GroupJoin(ahLinesContext.Events,
                        v => v.v.v.v.v.v.v.EventId,
                        e => e.EventId,
                        (v, e) => new { v, e })
                        .SelectMany(ve => ve.e.DefaultIfEmpty(), (ve, e) => new
                        {
                            VideoClipId = ve.v.v.v.v.v.v.v.VideoClipId,
                            VideoId = ve.v.v.v.v.v.v.v.VideoId,
                            VideoClipTitle = ve.v.v.v.v.v.v.v.VideoClipTitle,
                            VideoUrl = ve.v.v.v.v.v.v.v.ClipLinkUrl,
                            ThumbImageUrl = bannerImagePrefixUrl + ve.v.v.v.v.v.v.v.ThumbImageUrl,
                            SmallImageUrl = bannerImagePrefixUrl + ve.v.v.v.v.v.v.v.SmallImageUrl,
                            CategoryId = ve.v.v.v.v.v.v.v.CategoryId,
                            TypeId = ve.v.v.v.v.v.v.v.TypeId,
                            FormatId = ve.v.v.v.v.v.v.v.FormatId,
                            Status = ve.v.v.v.v.v.v.v.Status,
                            Created = ve.v.v.v.v.v.v.v.Created
                        }).ToListAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<IEnumerable<dynamic>> ViewQueryForVideosSummaryAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var videosList = await ViewQueryForVideosAsync();

                    return videosList.GroupBy(vl => new { vl.VideoId, vl.VideoClipTitle })
                        .Select(vl => new
                        {
                            VideoClipId = vl.Max(v => v.VideoClipId),
                            Created = vl.Max(v => v.Created)
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