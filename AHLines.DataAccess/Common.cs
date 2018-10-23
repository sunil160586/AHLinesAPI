using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public static class Common
    {
        public static string PostedAgo(int? postedAgo)
        {
            if (postedAgo < 60)
            {
                if (postedAgo == 0 || postedAgo == 1)
                {
                    return postedAgo + " min ago";
                }
                else
                {
                    return postedAgo + " mins ago";
                }
            }
            else if (postedAgo >= 61 && postedAgo < 1440)
            {
                if (postedAgo / 60 == 1)
                {
                    return "1 hr ago";
                }
                else
                {
                    return postedAgo / 60 + " hrs ago";
                }
            }
            else
            {
                if (postedAgo / 1440 == 1)
                {
                    return "1 day ago";
                }
                else
                {
                    return postedAgo / 1440 + " days ago";
                }
            }
        }

        public static DateTime? GetPostedDate(DateTime? releaseDate, DateTime? updatedDate)
        {
            if (releaseDate == null)
            {
                return updatedDate;
            }

            if (updatedDate == null)
            {
                return releaseDate;
            }

            if (releaseDate > updatedDate)
            {
                return releaseDate;
            }
            else
            {
                return updatedDate;
            }
        }

        public static DateTime? GetTimeBasedOnTimeZone(DateTime? dateTime)
        {
            return TimeZoneInfo.ConvertTime(dateTime.Value, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time"));
        }

        public static string GetValidImageUrl(string url)
        {
            if (string.IsNullOrEmpty(Path.GetExtension(url)))
            {
                return url + ".JPG";
            }
            else
            {
                return url;
            }
        }

        public static async Task<int> UpdateArticleViewCount(int articleId)
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    DataModel.Article result = await ahLinesContext.Article.SingleOrDefaultAsync(a => a.ArticleId == articleId);

                    if (result != null)
                    {
                        result.ViewCount = result.ViewCount + 1;
                        return await ahLinesContext.SaveChangesAsync();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static string RemoveHtmlTags(string htmlContent, string type)
        {
            char[] array = new char[htmlContent.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < htmlContent.Length; i++)
            {
                char let = htmlContent[i];

                if (let == '<')
                {
                    inside = true;
                    continue;
                }

                if (let == '>')
                {
                    inside = false;
                    continue;
                }

                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }

            string result = new List<string>(new string(array, 0, arrayIndex).Split(new string[] { "\r\n" }, StringSplitOptions.None))
                .Where(b => b.Contains(type))
                .FirstOrDefault();

            return !string.IsNullOrEmpty(result) ? result : string.Empty;
        }

        public static string GetPrefixUrl(string category)
        {
            string url = string.Empty;

            switch (category.ToLower())
            {
                case "1":
                    url = "/news/sports/";
                    break;
                case "2":
                    url = "/news/telangana/";
                    break;
                case "3":
                    url = "/news/national/";
                    break;
                case "4":
                    url = "/news/andhra/";
                    break;
                case "5":
                    url = "/news/world/";
                    break;
                case "6":
                    url = "/movies/news/";
                    break;
                case "7":
                    url = "/news/nri/";
                    break;
                case "8":
                    url = "/news/fashion/";
                    break;
                case "9":
                    url = "/movies/news/";
                    break;
                case "10":
                    url = "/news/science/";
                    break;
                case "11":
                    url = "/news/business/";
                    break;
                case "12":
                    url = "/news/health/";
                    break;
                case "13":
                    url = "/news/special/";
                    break;
                case "14":
                    url = "/news/crime/";
                    break;
                case "15":
                    url = "/news/sports/";
                    break;
                case "16":
                    url = "browse";
                    break;
                case "17":
                    url = "/movies/reviews/";
                    break;
                case "99":
                    url = "/news/sports/";
                    break;
                case "mfa":
                    url = "/photos/actress/";
                    break;
                case "mma":
                    url = "/photos/actors/";
                    break;
                case "mm":
                    url = "/photos/movies/";
                    break;
                case "me":
                    url = "/photos/events/";
                    break;
                case "ps":
                    url = "photoshoot";
                    break;
                case "as":
                    url = "/news/special/";
                    break;
                case "wp":
                    url = "/photos/wallpapers/";
                    break;
            }

            return url;
        }

        public static int? ExtractIdFromUrl(string url)
        {
            try
            {

                if (int.TryParse(Regex.Match(url, @"\d+").Value, out int num))
                {
                    return Regex.Matches(url, @"\d+")
                .Cast<Match>()
                .Select(x => Convert.ToInt32(x.Value))
                .ToList()[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string GetVideoUrl(int formatId, string url)
        {
            string videoUrl = string.Empty;

            switch (formatId)
            {
                case 2:
                    videoUrl = "http://www.youtube.com/v/" + url + "&rel=1&border=1&autoplay=1";
                    break;
            }

            return videoUrl;
        }

        public static string GetTeluguPrefixUrl(Nullable<Int16> category)
        {
            string url = string.Empty;

            switch (category)
            {
                case 1:
                    url = "/news/andhra/";
                    break;
                case 2:
                    url = "/news/national/";
                    break;
                case 3:
                    url = "/news/sports/";
                    break;
                case 4:
                    url = "/movies/news/";
                    break;
                case 5:
                    url = "/movies/reviews/";
                    break;
                case 14:
                    url = "/news/nri/";
                    break;
            }

            return url;
        }
    }
}