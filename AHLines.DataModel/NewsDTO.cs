namespace AHLines.DataModel
{
    public enum NewsType
    {
        Special,
        Seemandhra,
        Telangana,
        Sports,
        National,
        World,
        NRI,
        CrimeWatch,
        Business,
        FashionLifeStyle,
        ScienceAndTechnology,
        HealthAndLiving
    }

    public enum SpecialNews
    {
        SpecialBreakingNews = 1,
        SpecialLatestNews = 2,
        SpecialLatestSubNews = 3
    }

    public enum SeemandhraNews
    {
        AndhraBreakingNews = 1,
        AndhraLatestNews = 2,
        AndhraLatestSubNews = 3
    }

    public enum TelanganaNews
    {
        TelanganaBreakingNews = 1,
        TelanganaLatestNews = 2,
        TelanganaLatestSubNews = 3
    }

    public enum SportsNews
    {
        SportsBreakingNews = 1,
        SportsLatestNews = 2,
        SportsLatestSubNews = 3
    }

    public enum NationalNews
    {
        IndiaBreakingNews = 1,
        IndiaLatestNews = 2,
        IndiaLatestSubNews = 3
    }

    public enum WorldNews
    {
        WorldBreakingNews = 1,
        WorldLatestNews = 2,
        WorldLatestSubNews = 3
    }

    public enum NRINews
    {
        NRIBreakingNews = 1,
        NRILatestNews = 2,
        NRILatestSubNews = 3
    }

    public enum CrimeWatchNews
    {
        CrimeWatchBreakingNews = 1,
        CrimeWatchLatestNews = 2,
        CrimeWatchLatestSubNews = 3
    }

    public enum BusinessNews
    {
        BusinessBreakingNews = 1,
        BusinessLatestNews = 2,
        BusinessLatestSubNews = 3
    }

    public enum FashionLifeStyleNews
    {
        FashionLifeStyleBreakingNews = 1,
        FashionLifeStyleLatestNews = 2,
        FashionLifeStyleLatestSubNews = 3
    }

    public enum ScienceAndTechnologyNews
    {
        ScienceAndTechnologyBreakingNews = 1,
        ScienceAndTechnologyLatestNews = 2,
        ScienceAndTechnologyLatestSubNews = 3
    }

    public enum HealthAndLivingNews
    {
        HealthAndLivingBreakingNews = 1,
        HealthAndLivingLatestNews = 2,
        HealthAndLivingLatestSubNews = 3
    }

    public class NewsDTO
    {
        public int ArticleId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ArticleTitle { get; set; }
        public string Abstract { get; set; }
        public string LinkUrl { get; set; }
        public string ImageSmallUrl { get; set; }
        public string ImageUrl { get; set; }
        public string PostedAgo { get; set; }
    }
}
