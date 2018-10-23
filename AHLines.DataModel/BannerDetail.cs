using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("utbl_Banner_Details")]
    public class BannerDetail
    {
        public BannerDetail()
        {

        }

        [Key, Column("DetailsId", TypeName = "int")]
        public int BannerDetailId { get; set; }

        [Column("BannerId", TypeName = "int")]
        public int? BannerId { get; set; }

        [Column("CategoryId", TypeName = "int")]
        public int? CategoryId { get; set; }

        [Column("ImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string ImageUrl { get; set; }

        [Column("LinkUrl", TypeName = "nvarchar"), MaxLength(500)]
        public string LinkUrl { get; set; }

        [Column("DisplayOrder", TypeName = "int")]
        public int? DisplayOrder { get; set; }

        [Column("DisplayStatus", TypeName = "bit")]
        public bool? DisplayStatus { get; set; }

        [Column("DisplayTitle", TypeName = "nvarchar"), MaxLength(500)]
        public string DisplayTitle { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [Column("Id", TypeName = "int")]
        public int? Id { get; set; }
    }
}