using AHLines.DataAccess;
using AHLines.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class HomeBLL
    {
        HomeDAL homeDAL = new HomeDAL();

        public async Task<IEnumerable<dynamic>> GetBannerPhotosAsync()
        {
            return await homeDAL.GetBannerPhotosAsync();
        }

        public async Task<dynamic> GetLatestBreakingNewsAsync()
        {
            return await homeDAL.GetLatestBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestNewsAsync()
        {
            return await homeDAL.GetLatestNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetMoreLatestNewsAsync()
        {
            return await homeDAL.GetMoreLatestNewsAsync();
        }

        public async Task<dynamic> GetFashionAndLifeStyleBreakingNews()
        {
            return await homeDAL.GetFashionAndLifeStyleBreakingNews();
        }

        public async Task<IEnumerable<dynamic>> GetFashionAndLifeStyleLatestNews()
        {
            return await homeDAL.GetFashionAndLifeStyleLatestNews();
        }

        public async Task<dynamic> GetTrendingBreakingNews()
        {
            return await homeDAL.GetTrendingBreakingNews();
        }

        public async Task<IEnumerable<dynamic>> GetLatestTrendingNews()
        {
            return await homeDAL.GetLatestTrendingNews();
        }

        public async Task<IEnumerable<dynamic>> GetMoreTrendingNews()
        {
            return await homeDAL.GetMoreTrendingNews();
        }

        public async Task<IEnumerable<dynamic>> GetTabLatestGallery()
        {
            return await homeDAL.GetTabLatestGallery();
        }

        public async Task<IEnumerable<dynamic>> GetTabLatestVideos()
        {
            return await homeDAL.GetTabLatestVideos();
        }

        public async Task<IEnumerable<dynamic>> GetTabNews(string section)
        {
            return await homeDAL.GetTabNews(section);
        }

        public async Task<IEnumerable<dynamic>> GetEntertainmentNews()
        {
            return await homeDAL.GetEntertainmentNews();
        }

        public async Task<IEnumerable<dynamic>> GetMarketWatchDetails()
        {
            return await homeDAL.GetMarketWatchDetails();
        }

        public async Task<JokesTable> GetJokeOfTheDay()
        {
            return await homeDAL.GetJokeOfTheDay();
        }

        public async Task<IEnumerable<dynamic>> GetPhotoGallery()
        {
            return await homeDAL.GetPhotoGallery();
        }

        public async Task<IEnumerable<dynamic>> GetLatestVideosAsync()
        {
            return await homeDAL.GetLatestVideosAsync();
        }

        public async Task<IEnumerable<dynamic>> GetTeluguHeadlinesAsync()
        {
            return await homeDAL.GetTeluguHeadlinesAsync();
        }
    }
}