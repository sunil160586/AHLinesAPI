namespace AHLines.DataAccess
{
    public class StoredProcedures
    {
        #region News Related Procedures
        public const string HomeEditorsPick = "[dbo].[usp_WebAPI_GetHomeEditorsPick]";
        public const string HomeEntertainmentNews = "[dbo].[usp_WebAPI_GetHomeEntertainmentNews]";
        public const string HomeLatestVideos = "[dbo].[usp_webapi_Get_Home_Latest_Videos]";
        public const string HomeTabMoreNews = "[dbo].[usp_webapi_Get_Home_Tab_More_News]";
        public const string HomeTabMostRead = "[dbo].[usp_webapi_Get_Home_Tab_Most_Read]";
        public const string HomePhotoGallery = "[dbo].[usp_webapi_Get_Home_Photo_Gallery]";
        public const string SpecialNews = "[dbo].[usp_WebAPI_GetSpecialNews]";
        public const string SeemandhraNews = "[dbo].[usp_WebAPI_GetSeemandhraNews]";
        public const string TelanganaNews = "[dbo].[usp_WebAPI_GetTelanganaNews]";
        public const string SportsNews = "[dbo].[usp_WebAPI_GetSportsNews]";
        public const string NationalNews = "[dbo].[usp_WebAPI_GetNationalNews]";
        public const string WorldNews = "[dbo].[usp_WebAPI_GetWorldNews]";
        public const string NRINews = "[dbo].[usp_WebAPI_GetNRINews]";
        public const string CrimeWatchNews = "[dbo].[usp_WebAPI_GetCrimeWatchNews]";
        public const string BusinessNews = "[dbo].[usp_WebAPI_GetBusinessNews]";
        public const string FashionLifeStyleNews = "[dbo].[usp_WebAPI_GetFashionLifeStyleNews]";
        public const string ScienceAndTechnologyNews = "[dbo].[usp_WebAPI_GetScienceAndTechnologyNews]";
        public const string HealthAndLivingNews = "[dbo].[usp_WebAPI_HealthAndLivingNews]";
        #endregion

        #region Movies Related Procedures
        public const string MoviesReviewsList = "[dbo].[usp_WebAPI_GetMoviesReviewsList]";
        public const string MoviesReviewsDetails = "[dbo].[usp_WebAPI_GetMoviesReviewsDetails]";
        #endregion

        #region Jokes Related Procedures
        public const string JokesList = "[dbo].[usp_WebAPI_GetJokesList]";
        public const string JokeDetails = "[dbo].[usp_WebAPI_GetJokeDetails]";
        #endregion

        #region Guess Related Procedures
        public const string PreviousGuessList = "[dbo].[usp_WebAPI_GetPreviousGuessList]";
        public const string PreviousGuessDetails = "[dbo].[usp_WebAPI_GetPreviousGuessDetails]";
        public const string CurrentGuessDetails = "[dbo].[usp_WebAPI_GetCurrentGuessDetails]";
        #endregion

        #region Gallery Related Procedures
        public const string HomePageLatestGallery = "[dbo].[usp_WebAPI_HomePageLatestGallery]";
        public const string SectionWiseLatestGallery = "[dbo].[usp_WebAPI_SectionWiseLatestGallery]";
        public const string SectionWiseList = "[dbo].[usp_WebAPI_SectionWiseList]";
        public const string SectionWiseStills = "[dbo].[usp_WebAPI_SectionWiseStills]";
        public const string SectionWiseDetails = "[dbo].[usp_WebAPI_SectionWiseDetails]";
        #endregion
    }
}