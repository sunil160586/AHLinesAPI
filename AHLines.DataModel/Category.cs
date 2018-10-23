using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Category")]
    public class Category
    {
        public Category()
        {

        }

        [Key, Column("CategoryID", TypeName = "int")]
        public int CategoryId { get; set; }

        [Column("Title", TypeName = "nvarchar"), MaxLength(50)]
        public string Title { get; set; }

        [Column("AddedDate", TypeName = "datetime")]
        public DateTime AddedDate { get; set; }

        [Column("AddedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string AddedBy { get; set; }

        [Column("Description", TypeName = "nvarchar"), MaxLength(200)]
        public string Description { get; set; }

        [Column("Visible", TypeName = "bit")]
        public bool? IsVisible { get; set; }

        [Column("Url", TypeName = "nvarchar"), MaxLength(50)]
        public string Url { get; set; }

        [Column("CreatedBy", TypeName = "varchar"), MaxLength(10)]
        public string CreatedBy { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [Column("UpdatedBy", TypeName = "varchar"), MaxLength(10)]
        public string UpdatedBy { get; set; }

        [Column("UpdatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}