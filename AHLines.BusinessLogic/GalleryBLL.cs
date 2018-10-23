using AHLines.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AHLines.BusinessLogic
{
    public class GalleryBLL
    {
        GalleryDAL galleryDAL = new GalleryDAL();

        public async Task<IEnumerable<dynamic>> GetCelebritiesGalleryAsync(string celebrityType)
        {
            return await galleryDAL.GetCelebritiesGalleryAsync(celebrityType);
        }

        public async Task<IEnumerable<dynamic>> GetMoviesGalleryAsync()
        {
            return await galleryDAL.GetMoviesGalleryAsync();
        }

        public async Task<IEnumerable<dynamic>> GetEventsGalleryAsync()
        {
            return await galleryDAL.GetEventsGalleryAsync();
        }

        public async Task<IEnumerable<dynamic>> GetWallPapersGalleryAsync()
        {
            return await galleryDAL.GetWallPapersGalleryAsync();
        }

        public async Task<IEnumerable<dynamic>> GetActressGalleryListAsync(int actressId)
        {
            return await galleryDAL.GetActressGalleryListAsync(actressId);
        }

        public async Task<IEnumerable<dynamic>> GetActorsGalleryListAsync(int actorId)
        {
            return await galleryDAL.GetActorGalleryListAsync(actorId);
        }

        public async Task<IEnumerable<dynamic>> GetMovieGalleryListAsync(int movieId)
        {
            return await galleryDAL.GetMovieGalleryListAsync(movieId);
        }

        public async Task<IEnumerable<dynamic>> GetEventGalleryListAsync(int eventId)
        {
            return await galleryDAL.GetEventGalleryListAsync(eventId);
        }

        public async Task<IEnumerable<dynamic>> GetWallPaperGalleryListAsync(int wallPaperId)
        {
            return await galleryDAL.GetWallPaperGalleryListAsync(wallPaperId);
        }

        public async Task<IEnumerable<dynamic>> GetCelebritiesTitleNamesAsync(string celebrityType)
        {
            return await galleryDAL.GetCelebritiesTitleNamesAsync(celebrityType);
        }

        public async Task<IEnumerable<dynamic>> GetMoviesTitleNamesAsync()
        {
            return await galleryDAL.GetMoviesTitleNamesAsync();
        }

        public async Task<IEnumerable<dynamic>> GetEventsTitleNamesAsync()
        {
            return await galleryDAL.GetEventsTitleNamesAsync();
        }

        public async Task<IEnumerable<dynamic>> GetCelebritiesListBasedOnTitleAsync(string celebrityType, string title)
        {
            return await galleryDAL.GetCelebritiesListBasedOnTitleAsync(celebrityType, title);
        }

        public async Task<IEnumerable<dynamic>> GetMoviesListBasedOnTitleAsync(string title)
        {
            return await galleryDAL.GetMoviesListBasedOnTitleAsync(title);
        }

        public async Task<IEnumerable<dynamic>> GetEventsListBasedOnTitleAsync(string title)
        {
            return await galleryDAL.GetEventsListBasedOnTitleAsync(title);
        }
    }
}