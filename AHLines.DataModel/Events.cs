using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Events")]
    public class Events
    {
        public Events()
        {

        }

        [Key, Column("EventId", TypeName = "int")]
        public int EventId { get; set; }

        [Column("EventFolder", TypeName = "nvarchar"), MaxLength(50)]
        public string EventFolder { get; set; }

        [Column("EventName", TypeName = "nvarchar"), MaxLength(100)]
        public string EventName { get; set; }

        [Column("EventTitle", TypeName = "nvarchar"), MaxLength(50)]
        public string EventTitle { get; set; }

        [Column("EventCategoryId", TypeName = "int")]
        public int? EventCategoryId { get; set; }

        [Column("EventStatus", TypeName = "nvarchar"), MaxLength(1)]
        public string EventStatus { get; set; }

        [Column("ImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string ImageUrl { get; set; }

        [Column("EventType", TypeName = "nvarchar"), MaxLength(10)]
        public string EventType { get; set; }

        [Column("EventColor", TypeName = "nvarchar"), MaxLength(50)]
        public string EventColor { get; set; }

        [Column("EventAbstract", TypeName = "nvarchar"), MaxLength(100)]
        public string EventAbstract { get; set; }

        [Column("EventComments", TypeName = "nvarchar"), MaxLength(1000)]
        public string EventComments { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}