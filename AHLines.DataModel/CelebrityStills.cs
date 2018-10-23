using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Celebrities_Stills")]
    public class CelebrityStills
    {
        public CelebrityStills()
        {

        }

        [Key, Column("StillId", TypeName = "int")]
        public int StillId { get; set; }

        [Column("CelebrityId", TypeName = "int")]
        public int? CelebrityId { get; set; }

        [Column("CelebrityStillId", TypeName = "int")]
        public int? CelebrityStillId { get; set; }

        [Column("DisplayStatus", TypeName = "nvarchar"), MaxLength(50)]
        public string DisplayStatus { get; set; }

        [Column("DisplayPage", TypeName = "int")]
        public int? DisplayPage { get; set; }

        [Column("ThumbImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string ThumbImageUrl { get; set; }

        [Column("SmallImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string SmallImageUrl { get; set; }

        [Column("LargeImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string LargeImageUrl { get; set; }

        [Column("ViewCount", TypeName = "int")]
        public int? ViewCount { get; set; }

        [Column("LastViewed", TypeName = "datetime")]
        public DateTime? LastViewed { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }

        [Column("OldCelebrityId", TypeName = "int")]
        public int? OldCelebrityId { get; set; }
    }
}