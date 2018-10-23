using System;

namespace AHLines.DataModel
{
    public enum SectionWiseLatestGalleries
    {
        Actor,
        Actress,
        Event,
        LatestWallpapers,
        Movie,
        Special
    }

    public enum SectionWiseList
    {
        Celebrities,
        Events,
        Movies,
        Special
    }

    public enum SectionWiseStills
    {
        Actor,
        Actress,
        Event,
        Movie
    }

    public enum SectionWiseDetails
    {
        Actor,
        Actress,
        Event,
        Movie
    }

    public class HomePageLatestGallery
    {
        public int? SId { get; set; }
        public int? GalleryId { get; set; }
        public string GalleryName { get; set; }
        public string DisplayTitle { get; set; }
        public string SmallImageUrl { get; set; }
        public string LinkUrl { get; set; }
        public string Category { get; set; }
        public int? DisplayPage { get; set; }
        public int? PageIndex { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public class SectionWiseLatestGallery : HomePageLatestGallery
    {      
        public int? StillId { get; set; }
        public string Section { get; set; }
    }

    public class SectionWiseGallery : HomePageLatestGallery
    {
        public string GalleryFolder { get; set; }
        public string GalleryTitle { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbImageUrl { get; set; }
        public string GalleryType { get; set; }
        public int? TabIndex { get; set; }
        public char GalleryFirstChar { get; set; }
        public string GalleryCategory { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public char GalleryStatus { get; set; }
        public int? EventCategoryId { get; set; }
    }

    public class SectionWiseStillsDTO
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int? Idx { get; set; }
        public string Category { get; set; }
        public int? GalleryId { get; set; }
        public int? CelebrityStillId { get; set; }
        public int? MovieStillId { get; set; }
        public int? StillId { get; set; }
        public string DisplayStatus { get; set; }
        public int? DisplayPage { get; set; }
        public string StatusDescription { get; set; }
        public string ThumbImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public string LargeImageUrl { get; set; }
        public string LinkUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class SectionWiseDetailsDTO
    {
        public int? Id { get; set; }
        public string Folder { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string StatusDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public string Abstract { get; set; }
        public string Comments { get; set; }
        public int? CategoryId { get; set; }
        public string Category { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}