using AHLines.DataAccess;
using AHLines.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class NewsBLL
    {
        private NewsDAL newsDAL = new NewsDAL();

        public async Task<dynamic> GetSpecialBreakingNewsAsync()
        {
            return await newsDAL.GetSpecialBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestSpecialNewsAsync()
        {
            return await newsDAL.GetLatestSpecialNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetSpecialNewsAsync()
        {
            return await newsDAL.GetSpecialNewsAsync();
        }

        public async Task<dynamic> GetSeemandhraBreakingNewsAsync()
        {
            return await newsDAL.GetSeemandhraBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestSeemandhraNewsAsync()
        {
            return await newsDAL.GetLatestSeemandhraNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetSeemandhraNewsAsync()
        {
            return await newsDAL.GetSeemandhraNewsAsync();
        }

        public async Task<dynamic> GetTelanganaBreakingNewsAsync()
        {
            return await newsDAL.GetTelanganaBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestTelanganaNewsAsync()
        {
            return await newsDAL.GetLatestTelanganaNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetTelanganaNewsAsync()
        {
            return await newsDAL.GetTelanganaNewsAsync();
        }

        public async Task<dynamic> GetSportsBreakingNewsAsync()
        {
            return await newsDAL.GetSportsBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestSportsNewsAsync()
        {
            return await newsDAL.GetLatestSportsNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetSportsNewsAsync()
        {
            return await newsDAL.GetSportsNewsAsync();
        }

        public async Task<dynamic> GetNationalBreakingNewsAsync()
        {
            return await newsDAL.GetNationalBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestNationalNewsAsync()
        {
            return await newsDAL.GetLatestNationalNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetNationalNewsAsync()
        {
            return await newsDAL.GetNationalNewsAsync();
        }

        public async Task<dynamic> GetWorldBreakingNewsAsync()
        {
            return await newsDAL.GetWorldBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestWorldNewsAsync()
        {
            return await newsDAL.GetLatestWorldNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetWorldNewsAsync()
        {
            return await newsDAL.GetWorldNewsAsync();
        }

        public async Task<dynamic> GetNRIBreakingNewsAsync()
        {
            return await newsDAL.GetNRIBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestNRINewsAsync()
        {
            return await newsDAL.GetLatestNRINewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetNRINewsAsync()
        {
            return await newsDAL.GetNRINewsAsync();
        }

        public async Task<dynamic> GetCrimeWatchBreakingNewsAsync()
        {
            return await newsDAL.GetCrimeWatchBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestCrimeWatchNewsAsync()
        {
            return await newsDAL.GetLatestCrimeWatchNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetCrimeWatchNewsAsync()
        {
            return await newsDAL.GetCrimeWatchNewsAsync();
        }

        public async Task<dynamic> GetBusinessBreakingNewsAsync()
        {
            return await newsDAL.GetBusinessBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestBusinessNewsAsync()
        {
            return await newsDAL.GetLatestBusinessNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetBusinessNewsAsync()
        {
            return await newsDAL.GetBusinessNewsAsync();
        }

        public async Task<dynamic> GetFashionAndLifeStyleBreakingNewsAsync()
        {
            return await newsDAL.GetFashionAndLifeStyleBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestFashionAndLifeStyleNewsAsync()
        {
            return await newsDAL.GetLatestFashionAndLifeStyleNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetFashionAndLifeStyleNewsAsync()
        {
            return await newsDAL.GetFashionAndLifeStyleNewsAsync();
        }

        public async Task<dynamic> GetScienceAndTechnologyBreakingNewsAsync()
        {
            return await newsDAL.GetScienceAndTechnologyBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestScienceAndTechnologyNewsAsync()
        {
            return await newsDAL.GetLatestScienceAndTechnologyNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetScienceAndTechnologyNewsAsync()
        {
            return await newsDAL.GetScienceAndTechnologyNewsAsync();
        }

        public async Task<dynamic> GetHealthAndLivingBreakingNewsAsync()
        {
            return await newsDAL.GetHealthAndLivingBreakingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetLatestHealthAndLivingNewsAsync()
        {
            return await newsDAL.GetLatestHealthAndLivingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetHealthAndLivingNewsAsync()
        {
            return await newsDAL.GetHealthAndLivingNewsAsync();
        }

        public async Task<IEnumerable<dynamic>> GetNewsHeadlinesAsync()
        {
            return await newsDAL.GetNewsHeadlinesAsync();
        }

        public async Task<dynamic> GetNewsArticleAsync(int articleId)
        {
            return await newsDAL.GetNewsArticleAsync(articleId);
        }
    }
}