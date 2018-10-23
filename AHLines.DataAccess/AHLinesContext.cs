using AHLines.DataModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace AHLines.DataAccess
{
    public class AHLinesContext : DbContext
    {
        public AHLinesContext() : base("name=ahLinesConnectionString")
        {
            Database.SetInitializer<AHLinesContext>(new CreateDatabaseIfNotExists<AHLinesContext>());
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 9999;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        void FixEfProviderServicesProblem()
        {
            var instance = SqlProviderServices.Instance;
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleBody> ArticleBody { get; set; }
        public DbSet<Audio> Audio { get; set; }
        public DbSet<BannerDetail> BannerDetails { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Celebrity> Celebrities { get; set; }
        public DbSet<CelebrityStills> CelebrityStills { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<EventStill> EventStills { get; set; }
        public DbSet<Guess> Guess { get; set; }
        public DbSet<HomeArticle> HomeArticle { get; set; }
        public DbSet<JokesTable> JokesTable { get; set; }
        public DbSet<MarketWatch> MarketWatch { get; set; }
        public DbSet<MetaKeys> MetaKeys { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieStills> MovieStills { get; set; }
        public DbSet<MovieReview> MovieReview { get; set; }
        public DbSet<SectionArticle> SectionArticle { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoCategory> VideoCategories { get; set; }
        public DbSet<VideoFormat> VideoFormats { get; set; }
        public DbSet<VideoType> VideoTypes { get; set; }
        public DbSet<WallPaper> WallPapers { get; set; }
    }
}