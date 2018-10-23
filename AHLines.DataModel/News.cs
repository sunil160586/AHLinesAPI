using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("News")]
    public class News
    {
        public News()
        {

        }

        [Key, Column("NewsId", TypeName = "int")]
        public Int32 NewsId { get; set; }

        [Column("Title", TypeName = "nvarchar")]
        public String Title { get; set; }

        [Column("Category", TypeName = "smallint")]
        public Nullable<Int16> Category { get; set; }

        [Column("ViewCount", TypeName = "int")]
        public Nullable<Int32> ViewCount { get; set; }

        [Column("Scrolling", TypeName = "bit"), DefaultValue(false), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public Nullable<Boolean> Scrolling { get; set; }

        [Column("AddedDate", TypeName = "datetime")]
        public Nullable<DateTime> AddedDate { get; set; }

        [Column("AddedBy", TypeName = "nvarchar"), MaxLength(50)]
        public String AddedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public Nullable<DateTime> ModifiedDate { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public String ModifiedBy { get; set; }

        [Column("Approved", TypeName = "bit"), DefaultValue(false), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public Nullable<Boolean> Approved { get; set; }

        [Column("ApprovedDate", TypeName = "datetime")]
        public Nullable<DateTime> ApprovedDate { get; set; }

        [Column("ApprovedBy", TypeName = "nvarchar"), MaxLength(50)]
        public String ApprovedBy { get; set; }

        [Column("Deleted", TypeName = "bit"), DefaultValue(false), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public Nullable<Boolean> Deleted { get; set; }

        [Column("DeletedDate", TypeName = "datetime")]

        public Nullable<DateTime> DeletedDate { get; set; }

        [Column("DeletedBy", TypeName = "nvarchar"), MaxLength(50)]
        public String DeletedBy { get; set; }
    }
}