using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_WallPapers")]
    public class WallPaper
    {
        public WallPaper()
        {

        }

        [Key, Column("WallPaperId", TypeName = "int")]
        public int WallpaperId { get; set; }

        [Column("CelebrityId", TypeName = "int")]
        public int? CelebrityId { get; set; }

        [Column("MovieId", TypeName = "int")]
        public int? MovieId { get; set; }

        [Column("EventId", TypeName = "int")]
        public int? EventId { get; set; }

        [Column("WallPaperFolder", TypeName = "nvarchar"), MaxLength(50)]
        public string WallPaperFolder { get; set; }

        [Column("DisplayTitle", TypeName = "nvarchar"), MaxLength(150)]
        public string DisplayTitle { get; set; }

        [Column("ThumbImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string ThumbImageUrl { get; set; }

        [Column("Image800600Url", TypeName = "nvarchar"), MaxLength(100)]
        public string Image800x600Url { get; set; }

        [Column("Image1024768Url", TypeName = "nvarchar"), MaxLength(100)]
        public string Image1024x768Url { get; set; }

        [Column("AddedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("AddedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("ModifiedBy", TypeName = "varchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }
    }
}