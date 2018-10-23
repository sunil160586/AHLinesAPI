using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("utbl_Home_Articles")]
    public class HomeArticle
    {
        public HomeArticle()
        {

        }

        [Key, Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("ArticleId", TypeName = "int")]
        public int? ArticleId { get; set; }

        [Column("CategoryId", TypeName = "int")]
        public int? CategoryId { get; set; }

        [Column("Title", TypeName = "varchar"), MaxLength(500)]
        public string Title { get; set; }

        [Column("ArticleTitle", TypeName = "varchar"), MaxLength(500)]
        public string ArticleTitle { get; set; }

        [Column("Abstract", TypeName = "varchar"), MaxLength(500)]
        public string Abstract { get; set; }

        [Column("LinkUrl", TypeName = "varchar"), MaxLength(500)]
        public string LinkUrl { get; set; }

        [Column("ImageSmallUrl", TypeName = "varchar"), MaxLength(500)]
        public string ImageSmallUrl { get; set; }

        [Column("ImageUrl", TypeName = "varchar"), MaxLength(500)]
        public string ImageUrl { get; set; }

        [Column("Section", TypeName = "varchar"), MaxLength(20)]
        public string Section { get; set; }

        [Column("Category", TypeName = "varchar"), MaxLength(10)]
        public string Category { get; set; }

        [Column("DisplayPage", TypeName = "int")]
        public int? DisplayPage { get; set; }

        [Column("PageIndex", TypeName = "int")]
        public int? PageIndex { get; set; }

        [Column("ReleaseDate", TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }

        [Column("AddedDate", TypeName = "datetime")]
        public DateTime? AddedDate { get; set; }

        [Column("PostedAgo", TypeName = "int")]
        public int? PostedAgo { get; set; }

        [NotMapped]
        public string Posted { get; set; }
    }
}