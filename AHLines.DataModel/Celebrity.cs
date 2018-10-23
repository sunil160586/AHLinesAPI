using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Celebrities")]
    public class Celebrity
    {
        public Celebrity()
        {

        }

        [Key, Column("CelebrityId", TypeName = "int")]
        public int CelebrityId { get; set; }

        [Column("CelebFolder", TypeName = "nvarchar"), MaxLength(50)]
        public string CelebrityFolder { get; set; }

        [Column("CelebrityName", TypeName = "nvarchar"), MaxLength(100)]
        public string CelebrityName { get; set; }

        [Column("DisplayTitle", TypeName = "nvarchar"), MaxLength(100)]
        public string DisplayTitle { get; set; }

        [Column("CelebImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string CelebrityImageUrl { get; set; }

        [Column("CelebThumbImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string CelebrityThumbImageUrl { get; set; }

        [Column("CelebSmallImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string CelebritySmallImageUrl { get; set; }

        [Column("CelebrityType", TypeName = "nvarchar"), MaxLength(50)]
        public string CelebrityType { get; set; }

        [Column("DisplayStatus", TypeName = "nvarchar"), MaxLength(1)]
        public string DisplayStatus { get; set; }

        [Column("Category", TypeName = "nvarchar"), MaxLength(50)]
        public string Category { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}