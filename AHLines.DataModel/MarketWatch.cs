using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Market_Watch")]
    public class MarketWatch
    {
        public MarketWatch()
        {

        }

        [Key, Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("Type_Name", TypeName = "nvarchar"), MaxLength(50)]
        public string TypeName { get; set; }

        [Column("Type_Value", TypeName = "nvarchar"), MaxLength(50)]
        public string TypeValue { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string ModifiedBy { get; set; }
    }
}