using System;

namespace AHLines.DataModel
{
    public class ArticleDetails
    {
        public int ArticleId { get; set; }
        public string TagLine { get; set; }
        public DateTime? AddedDate { get; set; }
        public string AddedBy { get; set; }
        public int? CategoryId { get; set; }
        public string ArticleTitle { get; set; }
        public string Abstract { get; set; }
        public string Body { get; set; }
        public string CategoryTitle { get; set; }
        public string ImageSmallUrl { get; set; }
        public string ImageMediumUrl { get; set; }
        public string ImageUrl { get; set; }
        public bool? IsApproved { get; set; }
        public int? ViewCount { get; set; }
        public DateTime? PostedDate { get; set; }
    }
}