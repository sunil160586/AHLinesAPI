using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Movies_Reviews")]
    public class MovieReview
    {
        public MovieReview()
        {

        }

        [Key, Column("ReviewId", TypeName = "int")]
        public int ReviewId { get; set; }

        [Column("MovieId", TypeName = "int")]
        public int? MovieId { get; set; }

        [Column("ImageUrl", TypeName = "nvarchar"), MaxLength(150)]
        public string ImageUrl { get; set; }

        [Column("Abstract", TypeName = "nvarchar"), MaxLength(200)]
        public string Abstract { get; set; }

        [Column("Rating", TypeName = "nvarchar"), MaxLength(50)]
        public string Rating { get; set; }

        [Column("Casting", TypeName = "nvarchar"), MaxLength(250)]
        public string Casting { get; set; }

        [Column("Banner", TypeName = "nvarchar"), MaxLength(150)]
        public string Banner { get; set; }

        [Column("Producers", TypeName = "nvarchar"), MaxLength(150)]
        public string Producers { get; set; }

        [Column("Director", TypeName = "nvarchar"), MaxLength(150)]
        public string Director { get; set; }

        [Column("Music", TypeName = "nvarchar"), MaxLength(150)]
        public string Music { get; set; }

        [Column("Lyrics", TypeName = "nvarchar"), MaxLength(150)]
        public string Lyrics { get; set; }

        [Column("Story", TypeName = "nvarchar"), MaxLength(150)]
        public string Story { get; set; }

        [Column("Dailogues", TypeName = "nvarchar"), MaxLength(150)]
        public string Dialogues { get; set; }

        [Column("Art", TypeName = "nvarchar"), MaxLength(150)]
        public string Art { get; set; }

        [Column("Editing", TypeName = "nvarchar"), MaxLength(150)]
        public string Editing { get; set; }

        [Column("Camera", TypeName = "nvarchar"), MaxLength(150)]
        public string Camera { get; set; }

        [Column("Choreography", TypeName = "nvarchar"), MaxLength(150)]
        public string Choreography { get; set; }

        [Column("Screenplay", TypeName = "nvarchar"), MaxLength(150)]
        public string Screenplay { get; set; }

        [Column("ReleaseDate", TypeName = "smalldatetime")]
        public DateTime? ReleaseDate { get; set; }

        [Column("ExpireDate", TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }

        [Column("ApprovedDate", TypeName = "smalldatetime")]
        public DateTime? ApprovedDate { get; set; }

        [Column("ApprovedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string ApprovedBy { get; set; }

        [Column("Approved", TypeName = "bit")]
        public bool? IsApproved { get; set; }

        [Column("Status", TypeName = "bit")]
        public bool? Status { get; set; }

        [Column("StoryBody", TypeName = "nvarchar"), MaxLength(4000)]
        public string StoryBody { get; set; }

        [Column("StoryImageUrl", TypeName = "nvarchar"), MaxLength(150)]
        public string StoryImageUrl { get; set; }

        [Column("PerformanceBody", TypeName = "nvarchar"), MaxLength(4000)]
        public string PerformanceBody { get; set; }

        [Column("PerformanceImageUrl", TypeName = "nvarchar"), MaxLength(150)]
        public string PerformanceImageUrl { get; set; }

        [Column("MusicBody", TypeName = "nvarchar"), MaxLength(4000)]
        public string MusicBody { get; set; }

        [Column("MusicImageUrl", TypeName = "nvarchar"), MaxLength(150)]
        public string MusicImageUrl { get; set; }

        [Column("AnalysisBody", TypeName = "nvarchar"), MaxLength(4000)]
        public string AnalysisBody { get; set; }

        [Column("AnalysisImageUrl", TypeName = "nvarchar"), MaxLength(150)]
        public string AnalysisImageUrl { get; set; }

        [Column("GoodBody", TypeName = "nvarchar"), MaxLength(4000)]
        public string GoodBody { get; set; }

        [Column("BadBody", TypeName = "nvarchar"), MaxLength(4000)]
        public string BadBody { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}