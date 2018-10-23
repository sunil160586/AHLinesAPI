using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Articles")]
    public class Article
    {
        public Article()
        {

        }

        [Key, Column("ArticleID", TypeName = "int")]
        public int ArticleId { get; set; }

        [Column("CategoryID", TypeName = "int")]
        public int? CategoryId { get; set; }

        [Column("RelatedCategory", TypeName = "int")]
        public int? RelatedCategory { get; set; }

        [Column("Title", TypeName = "nvarchar"), MaxLength(255)]
        public string Title { get; set; }

        [Column("ArticleTitle", TypeName = "nvarchar"), MaxLength(256)]
        public string ArticleTitle { get; set; }

        [Column("SmallAbstract", TypeName = "nvarchar"), MaxLength(165)]
        public string SmallAbstract { get; set; }

        [Column("Abstract", TypeName = "nvarchar"), MaxLength(1000)]
        public string Abstract { get; set; }

        [Column("TagLine", TypeName = "nvarchar"), MaxLength(1000)]
        public string TagLine { get; set; }

        [Column("Developing", TypeName = "bit"), DefaultValue(true), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsDeveloping { get; set; }

        [Column("EditorsChoice", TypeName = "bit"), DefaultValue(true), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsEditorsChoice { get; set; }

        [Column("Breaking", TypeName = "bit"), DefaultValue(true), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsBreaking { get; set; }

        [Column("Latest", TypeName = "bit"), DefaultValue(true), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsLatest { get; set; }

        [Column("ReleaseDate", TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }

        [Column("Approved", TypeName = "bit"), DefaultValue(true), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsApproved { get; set; }

        [Column("DevelopingImageUrl", TypeName = "nvarchar"), MaxLength(200)]
        public string DevelopingImageUrl { get; set; }

        [Column("ImageSmallUrl", TypeName = "nvarchar"), MaxLength(200)]
        public string ImageSmallUrl { get; set; }

        [Column("ImageMediumUrl", TypeName = "nvarchar"), MaxLength(200)]
        public string ImageMediumUrl { get; set; }

        [Column("ImageUrl", TypeName = "nvarchar"), MaxLength(500)]
        public string ImageUrl { get; set; }

        [Column("ImageVisible", TypeName = "bit"), DefaultValue(true), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsImageVisible { get; set; }

        [Column("NavigateURL", TypeName = "nvarchar"), MaxLength(200)]
        public string NavigateUrl { get; set; }

        [Column("ImagesUpdated", TypeName = "bit"), DefaultValue(true), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsImageUpdated { get; set; }

        [Column("ImagesUpdatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string ImagesUpdatedBy { get; set; }

        [Column("ImagesUpdatedDate", TypeName = "datetime")]
        public DateTime? ImagesUpdatedDate { get; set; }

        [Column("ViewCount", TypeName = "int"), DefaultValue(10), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? ViewCount { get; set; }

        [Column("Listed", TypeName = "bit"), DefaultValue(true), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsListed { get; set; }

        [Column("Type", TypeName = "char"), MaxLength(1)]
        public char? Type { get; set; }

        [Column("ExpireDate", TypeName = "datetime")]
        public DateTime? ExpireDate { get; set; }

        [Column("State", TypeName = "nvarchar"), MaxLength(10)]
        public string State { get; set; }

        [Column("Region", TypeName = "nvarchar"), MaxLength(20)]
        public string Region { get; set; }

        [Column("Country", TypeName = "nvarchar"), MaxLength(256)]
        public string Country { get; set; }

        [Column("Lang", TypeName = "char"), MaxLength(2)]
        public char? Language { get; set; }

        [Column("Source", TypeName = "nvarchar"), MaxLength(50)]
        public string Source { get; set; }

        [Column("AddedDate", TypeName = "datetime")]
        public DateTime? AddedDate { get; set; }

        [Column("AddedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string AddedBy { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar")]
        public string CreatedBy { get; set; }

        [Column("UpdatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }

        [Column("UpdatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}