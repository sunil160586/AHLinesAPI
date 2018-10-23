using AHLines.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class VideosBLL
    {
        VideosDAL videosDAL = new VideosDAL();

        public async Task<IEnumerable<dynamic>> GetLatestVideosAsync()
        {
            return await videosDAL.GetLatestVideosAsync();
        }

        public async Task<IEnumerable<dynamic>> GetPoliticalVideosAsync()
        {
            return await videosDAL.GetPoliticalVideosAsync();
        }

        public async Task<IEnumerable<dynamic>> GetMoviesVideosAsync()
        {
            return await videosDAL.GetMoviesVideosAsync();
        }

        public async Task<IEnumerable<dynamic>> GetSportsVideosAsync()
        {
            return await videosDAL.GetSportsVideosAsync();
        }

        public async Task<IEnumerable<dynamic>> GetOtherVideosAsync()
        {
            return await videosDAL.GetOtherVideosAsync();
        }

        public async Task<dynamic> GetLatestVideoDetailsBasedOnIdAsync(int videoId)
        {
            return await videosDAL.GetLatestVideoDetailsBasedOnIdAsync(videoId);
        }

        public async Task<IEnumerable<dynamic>> GetRemainingLatestVideosAsync(int videoId)
        {
            return await videosDAL.GetRemainingLatestVideosAsync(videoId);
        }

        public async Task<dynamic> GetPoliticalVideoDetailsBasedOnIdAsync(int videoId)
        {
            return await videosDAL.GetPoliticalVideoDetailsBasedOnIdAsync(videoId);
        }

        public async Task<IEnumerable<dynamic>> GetRemainingPoliticalVideosAsync(int videoId)
        {
            return await videosDAL.GetRemainingPoliticalVideosAsync(videoId);
        }

        public async Task<dynamic> GetMovieVideoDetailsBasedOnIdAsync(int videoId)
        {
            return await videosDAL.GetMovieVideoDetailsBasedOnIdAsync(videoId);
        }

        public async Task<IEnumerable<dynamic>> GetRemainingMoviesVideosAsync(int videoId)
        {
            return await videosDAL.GetRemainingMoviesVideosAsync(videoId);
        }

        public async Task<dynamic> GetSportsVideoDetailsBasedOnIdAsync(int videoId)
        {
            return await videosDAL.GetSportsVideoDetailsBasedOnIdAsync(videoId);
        }

        public async Task<IEnumerable<dynamic>> GetRemainingSportsVideosAsync(int videoId)
        {
            return await videosDAL.GetRemainingSportsVideosAsync(videoId);
        }

        public async Task<dynamic> GetOtherVideoDetailsBasedOnIdAsync(int videoId)
        {
            return await videosDAL.GetOtherVideoDetailsBasedOnIdAsync(videoId);
        }

        public async Task<IEnumerable<dynamic>> GetRemainingOtherVideosAsync(int videoId)
        {
            return await videosDAL.GetRemainingOtherVideosAsync(videoId);
        }

        public async Task<IEnumerable<dynamic>> GetMoreSportsVideosAsync()
        {
            return await videosDAL.GetMoreSportsVideosAsync();
        }

        public async Task<IEnumerable<dynamic>> GetMorePoliticalVideosAsync()
        {
            return await videosDAL.GetMorePoliticalVideosAsync();
        }

        public async Task<IEnumerable<dynamic>> GetMoreMoviesVideosAsync()
        {
            return await videosDAL.GetMoreMoviesVideosAsync();
        }
    }
}