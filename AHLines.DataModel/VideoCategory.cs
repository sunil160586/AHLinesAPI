using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Videos_Category")]
    public class VideoCategory
    {
        public VideoCategory()
        {

        }

        [Key, Column("CategoryId", TypeName = "int")]
        public int CategoryId { get; set; }

        [Column("CategoryName", TypeName = "nvarchar"), MaxLength(50)]
        public string CategoryName { get; set; }
    }
}