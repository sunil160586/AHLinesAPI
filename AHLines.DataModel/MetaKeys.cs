using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("utbl_Meta_Keys")]
    public class MetaKeys
    {
        public MetaKeys()
        {

        }

        [Key, Column("Meta_Id", TypeName = "int")]
        public int MetaId { get; set; }

        [Column("Page_Name", TypeName = "nvarchar"), MaxLength(10)]
        public string PageName { get; set; }

        [Column("Page_Title", TypeName = "nvarchar"), MaxLength(4000)]
        public string PageTitle { get; set; }

        [Column("Meta_Description", TypeName = "nvarchar"), MaxLength(4000)]
        public string MetaDescription { get; set; }

        [Column("Meta_Keywords", TypeName = "nvarchar"), MaxLength(4000)]
        public string MetaKeywords { get; set; }

        [Column("Page_Temp_Title", TypeName = "nvarchar"), MaxLength(1000)]
        public string PageTemporaryTitle { get; set; }

        [Column("Meta_Temp_Description", TypeName = "nvarchar"), MaxLength(1000)]
        public string MetaTemporaryDescription { get; set; }

        [Column("Meta_Temp_Keywords", TypeName = "nvarchar"), MaxLength(1000)]
        public string MetaTemporaryKeywords { get; set; }

        [Column("Modified_By", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }

        [Column("Modified_Date", TypeName = "datetime")]
        public DateTime? Updated { get; set; }
    }
}