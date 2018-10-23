using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Events_Category")]
    public class EventCategory
    {
        public EventCategory()
        {

        }

        [Key, Column("EventCategoryId", TypeName = "int")]
        public int EventCategoryId { get; set; }

        [Column("EventCategoryName", TypeName = "nvarchar"), MaxLength(50)]
        public string EventCategoryName { get; set; }

        [Column("EventTitle", TypeName = "nvarchar"), MaxLength(50)]
        public string EventTitle { get; set; }

        [Column("EventColor", TypeName = "nvarchar"), MaxLength(50)]
        public string EventColor { get; set; }
    }
}