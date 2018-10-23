using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Videos")]
    public class Video
    {
        public Video()
        {
            Status = "I";
            ViewCount = 500;
        }

        [Key, Column("VideoClipId", TypeName = "int")]
        public int VideoClipId { get; set; }

        [Column("VideoId", TypeName = "int")]
        public int? VideoId { get; set; }

        [Column("VideoTitle", TypeName = "nvarchar"), MaxLength(50)]
        public string VideoTitle { get; set; }

        [Column("VideoClipTitle", TypeName = "nvarchar"), MaxLength(150)]
        public string VideoClipTitle { get; set; }

        [Column("VideoFolder", TypeName = "nvarchar"), MaxLength(50)]
        public string VideoFolder { get; set; }

        [Column("ThumbImageUrl", TypeName = "nvarchar"), MaxLength(150)]
        public string ThumbImageUrl { get; set; }

        [Column("SmallImageUrl", TypeName = "nvarchar"), MaxLength(150)]
        public string SmallImageUrl { get; set; }

        [Column("CategoryId", TypeName = "int")]
        public int? CategoryId { get; set; }

        [Column("TypeId", TypeName = "int")]
        public int? TypeId { get; set; }

        [Column("FormatId", TypeName = "int")]
        public int? FormatId { get; set; }

        [Column("Casting", TypeName = "nvarchar"), MaxLength(50)]
        public string Casting { get; set; }

        [Column("ClipLinkUrl", TypeName = "nvarchar"), MaxLength(150)]
        public string ClipLinkUrl { get; set; }

        [Column("ActorId", TypeName = "int")]
        public int? ActorId { get; set; }

        [Column("ActressId", TypeName = "int")]
        public int? ActressId { get; set; }

        [Column("MovieId", TypeName = "int")]
        public int? MovieId { get; set; }

        [Column("EventId", TypeName = "int")]
        public int? EventId { get; set; }

        [Column("Status", TypeName = "nvarchar"), MaxLength(1)]
        public string Status { get; set; }

        [Column("ViewCount", TypeName = "int")]
        public int? ViewCount { get; set; }

        [Column("AddedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("AddedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}